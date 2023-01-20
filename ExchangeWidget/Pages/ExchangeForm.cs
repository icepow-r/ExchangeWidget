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
        private BindingList<Currency> _currencyList;
        private BindingList<Currency> _favoritesList;
        private DateTime _date;

        public ExchangeForm()
        {
            InitializeComponent();
            RefreshButton.PerformClick();
            CurrencyList.SelectedTab = _favoritesList!.Count > 0 ? FavoritesPage : CursPage;
            RefreshStatus();
        }

        #region Service Integration

        private static DateTime GetLatestCursDate()
        {
            var node = new DailyInfoSoapClient(DailyInfoSoapClient.EndpointConfiguration.DailyInfoSoap);
            return node.GetLatestDateTime();
        }

        private static List<Currency> GetCurrencyList(DateTime cursDate)
        {
            var currencyList = new List<Currency>();
            var node = new DailyInfoSoapClient(DailyInfoSoapClient.EndpointConfiguration.DailyInfoSoap);
            var elements = node.GetCursOnDateXML(cursDate);
            foreach (XmlNode currency in elements.ChildNodes)
            {
                currencyList.Add(new Currency()
                {
                    Name = currency["Vname"]!.InnerText.Trim(),
                    Nominal = int.Parse(currency["Vnom"]!.InnerText.Trim()),
                    Curs = decimal.Parse(currency["Vcurs"]!.InnerText.Trim(), CultureInfo.InvariantCulture),
                    Code = int.Parse(currency["Vcode"]!.InnerText.Trim()),
                    CharCode = currency["VchCode"]!.InnerText.Trim(),
                });
            }
            return currencyList;
        }

        #endregion

        #region Database Integration

        private List<Currency> GetFavoritesCurrencyList()
        {
            var currencyList = new List<Currency>();
            using var context = new CurrencyContext();
            var codes = context.Favorites.Select(x => x.Code);
            currencyList.AddRange(_currencyList.Where(x => codes.Contains(x.Code)));
            return currencyList;
        }

        private static void AddToFavorites(Favorite favorite)
        {
            using var context = new CurrencyContext();
            if (context.Favorites.Find(favorite.Code) != null)
                return;

            context.Favorites.Add(favorite);
            context.SaveChanges();
        }

        private static void RemoveFromFavorites(Favorite favorite)
        {
            using var context = new CurrencyContext();
            context.Favorites.Remove(favorite);
            context.SaveChanges();
        }

        #endregion

        #region Buttons

        private void AddFavoriteButton_Click(object sender, EventArgs e)
        {
            var selectedCurrency = (Currency)CurrencyDataGridView.SelectedRows[0].DataBoundItem;
            var item = new Favorite(selectedCurrency.Code);
            AddToFavorites(item);
            _favoritesList.Add(selectedCurrency);
            ToggleButtons(CurrencyDataGridView);
        }

        private void DeleteFavoriteButton_Click(object sender, EventArgs e)
        {
            var selectedCurrency = CurrencyList.SelectedIndex switch
            {
                0 => (Currency)CurrencyDataGridView.SelectedRows[0].DataBoundItem,
                1 => (Currency)FavoritesDataGridView.SelectedRows[0].DataBoundItem
            };
            var item = new Favorite(selectedCurrency.Code);
            RemoveFromFavorites(item);
            _favoritesList.Remove(selectedCurrency);
            RefreshStatus();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            _date = GetLatestCursDate();
            _currencyList = new BindingList<Currency>(GetCurrencyList(_date));
            _favoritesList = new BindingList<Currency>(GetFavoritesCurrencyList());
            CurrencyDataGridView.DataSource = _currencyList;
            FavoritesDataGridView.DataSource = _favoritesList;
            RefreshStatus();
        }

        #endregion

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ToggleButtons((DataGridView)sender);
        }

        private void CurrencyList_Selected(object sender, TabControlEventArgs e)
        {
            var dataGridView = e.TabPageIndex switch
            {
                0 => CurrencyDataGridView,
                1 => FavoritesDataGridView
            };
            ToggleButtons(dataGridView);
            RefreshStatus();
        }

        private void ToggleButtons(DataGridView sender)
        {
            if (sender.SelectedRows.Count > 0)
            {
                if (sender.Name == "FavoritesDataGridView")
                {
                    AddFavoriteButton.Enabled = false;
                    DeleteFavoriteButton.Enabled = true;
                    return;
                }

                var selectedCurrency = (Currency)sender.SelectedRows[0].DataBoundItem;
                if (_favoritesList.Contains(selectedCurrency))
                {
                    AddFavoriteButton.Enabled = false;
                    DeleteFavoriteButton.Enabled = true;
                    
                }
                else
                {
                    AddFavoriteButton.Enabled = true;
                    DeleteFavoriteButton.Enabled = false;
                }
            }
            else
            {
                AddFavoriteButton.Enabled = false;
                DeleteFavoriteButton.Enabled = false;
            }
        }

        private void RefreshStatus()
        {
            StatusLabel.Text = CurrencyList.SelectedIndex switch
            {
                0 => $"Данные выгружены на {_date:dd.MM.yyyy}. " +
                     $"Количество выгруженных курсов валют: {_currencyList.Count}",
                1 => $"Количество курсов валют в избранном: {_favoritesList.Count}",
            };
        }
    }
}
