using BankService;
using ExchangeWidget.Database;
using ExchangeWidget.ServiceModel;
using System.ComponentModel;
using System.Globalization;
using System.Xml;

namespace ExchangeWidget.Pages
{
    public partial class ExchangeForm : Form
    {
        private readonly BindingList<Currency> _currencyList;
        private readonly BindingList<Currency> _favoritesList;
        public ExchangeForm()
        {
            InitializeComponent();

            _currencyList = new BindingList<Currency>();
            _favoritesList = new BindingList<Currency>();
            GetCurrencyList();
            CurrencyDataGridView.DataSource = _currencyList;
            FavoritesDataGridView.DataSource = _favoritesList;
        }

        private void GetCurrencyList()
        {
            _currencyList.Clear();
            var node = new BankService.DailyInfoSoapClient(DailyInfoSoapClient.EndpointConfiguration.DailyInfoSoap);
            var elements = node.GetCursOnDateXML(DateTime.Today);
            foreach (XmlNode currency in elements.ChildNodes)
            {
                _currencyList.Add(new Currency()
                {
                    Name = currency["Vname"]!.InnerText.Trim(),
                    Nominal = int.Parse(currency["Vnom"]!.InnerText.Trim()),
                    Curs = decimal.Parse(currency["Vcurs"]!.InnerText.Trim(), CultureInfo.InvariantCulture),
                    Code = int.Parse(currency["Vcode"]!.InnerText.Trim()),
                    CharCode = currency["VchCode"]!.InnerText.Trim(),
                });
            }
        }

        private void GetFavoritesList()
        {
            GetCurrencyList();
            var favoritesCodeList = new List<int>();
            using var context = new CurrencyContext();
            favoritesCodeList.AddRange(context.Favorites.Select(x => x.Code));

            _favoritesList.Clear();
            foreach (var item in _currencyList
                                            .Where(x => favoritesCodeList
                                            .Any(y => y == x.Code)))
            {
                _favoritesList.Add(item);
            }

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            GetCurrencyList();
        }

        private void CurrencyDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CurrencyDataGridView.SelectedRows.Count > 0)
            {
                AddFavoriteButton.Enabled = true;
            }
        }

        private void AddFavoriteButton_Click(object sender, EventArgs e)
        {
            using var context = new CurrencyContext();

            var item = new Favorite
            {
                Code = (int)CurrencyDataGridView.SelectedRows[0].Cells[3].Value
            };
            context.Favorites.Add(item);
            context.SaveChanges();
        }

        private void CurrencyList_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == "CursPage")
            {
                GetCurrencyList();
            }
            else if (e.TabPage.Name == "FavouritesPage")
            {
                GetFavoritesList();
            }
        }
    }
}
