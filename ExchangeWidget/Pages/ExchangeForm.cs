using BankService;
using ExchangeWidget.Database;
using ExchangeWidget.ServiceModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Xml;

namespace ExchangeWidget.Pages
{
    public partial class ExchangeForm : Form
    {
        private readonly BindingList<Currency> _currencyList;
        private readonly BindingList<Currency> _favoritesList;
        private int _counter;
        private DateTime _date;
        public ExchangeForm()
        {
            InitializeComponent();

            _currencyList = new BindingList<Currency>();
            _favoritesList = new BindingList<Currency>();
            GetCurrencyList();
            GetFavoritesList();
            CurrencyDataGridView.DataSource = _currencyList;
            FavoritesDataGridView.DataSource = _favoritesList;

            SetInitialTabPage();
            RefreshStatusAndButtons();
        }

        private void GetCurrencyList()
        {
            _currencyList.Clear();
            var node = new BankService.DailyInfoSoapClient(DailyInfoSoapClient.EndpointConfiguration.DailyInfoSoap);
            _date = node.GetLatestDateTime();
            var elements = node.GetCursOnDateXML(_date);
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

            _counter = elements.ChildNodes.Count;
        }

        private void GetFavoritesList()
        {
            _favoritesList.Clear();
            var favoritesCodeList = new List<int>();
            using var context = new CurrencyContext();
            favoritesCodeList.AddRange(context.Favorites.Select(x => x.Code));

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
            GetFavoritesList();
            RefreshStatusAndButtons();
        }

        private void CurrencyDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CurrencyDataGridView.SelectedRows.Count > 0 &&
                !_favoritesList.Contains((Currency)CurrencyDataGridView.SelectedRows[0].DataBoundItem))
            {
                AddFavoriteButton.Enabled = true;
                DeleteFavoriteButton.Enabled = false;
            }
            else
            {
                AddFavoriteButton.Enabled = false;
                DeleteFavoriteButton.Enabled = true;
            }
        }

        private void AddFavoriteButton_Click(object sender, EventArgs e)
        {
            using var context = new CurrencyContext();
            var item = new Favorite
            {
                Code = (int)CurrencyDataGridView.SelectedRows[0].Cells[3].Value
            };

            if (context.Favorites.Find(item.Code) != null)
                return;

            context.Favorites.Add(item);
            context.SaveChanges();

            _favoritesList.Add((Currency)CurrencyDataGridView.SelectedRows[0].DataBoundItem);
        }

        private void DeleteFavoriteButton_Click(object sender, EventArgs e)
        {
            using var context = new CurrencyContext();
            var item = new Favorite();

            var currentTab = CurrencyList.SelectedTab;

            if (currentTab.Name == "CursPage")
            {
                item.Code = (int)CurrencyDataGridView.SelectedRows[0].Cells[3].Value;
            }
            else if (currentTab.Name == "FavouritesPage")
            {
                item.Code = (int)FavoritesDataGridView.SelectedRows[0].Cells[3].Value;
            }

            context.Favorites.Remove(item);
            context.SaveChanges();

            var removedItem = _favoritesList.First(x => x.Code == item.Code);
            _favoritesList.Remove(removedItem);
        }

        private void CurrencyList_Selected(object sender, TabControlEventArgs e)
        {
            RefreshStatusAndButtons();
        }

        private void RefreshStatusAndButtons()
        {
            var currentTab = CurrencyList.SelectedTab;

            if (currentTab.Name == "CursPage")
            {
                StatusLabel.Text = $"Данные выгружены на {_date.ToString("dd.MM.yyyy")}. Количество выгруженных курсов валют: {_counter}";
                CurrencyDataGridView_SelectionChanged(null!, null!);
            }
            else if (currentTab.Name == "FavouritesPage")
            {
                StatusLabel.Text = $"Количество курсов валют в избранном: {_favoritesList.Count}";
                AddFavoriteButton.Enabled = false;
                DeleteFavoriteButton.Enabled = true;
            }
        }

        private void SetInitialTabPage()
        {
            if (_favoritesList.Count > 0)
            {
                CurrencyList.SelectedTab = FavouritesPage;
            }
        }
    }
}
