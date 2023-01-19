using BankService;
using ExchangeWidget.ServiceModel;
using System.ComponentModel;
using System.Xml;

namespace ExchangeWidget.Pages
{
    public partial class ExchangeForm : Form
    {
        private readonly BindingList<Currency> _currencyList;
        public ExchangeForm()
        {
            InitializeComponent();

            _currencyList = new BindingList<Currency>();
            GetCurrencyList();
            CurrencyDataGridView.DataSource = _currencyList;
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
                    Curs = decimal.Parse(currency["Vcurs"]!.InnerText.Trim()),
                    Code = int.Parse(currency["Vcode"]!.InnerText.Trim()),
                    CharCode = currency["VchCode"]!.InnerText.Trim(),
                });
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
                AddFavouriteButton.Enabled = true;
            }
        }
    }
}
