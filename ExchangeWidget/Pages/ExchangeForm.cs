using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankService;
using System.Xml;
using ExchangeWidget.ServiceModel;

namespace ExchangeWidget.Pages
{
    public partial class ExchangeForm : Form
    {
        private BindingList<Currency> currencyList;
        public ExchangeForm()
        {
            InitializeComponent();

            currencyList = new BindingList<Currency>();
            GetCurrencyList();
            CurrencyDataGridView.DataSource = currencyList;
        }

        private void GetCurrencyList()
        {
            currencyList.Clear();
            var node = new BankService.DailyInfoSoapClient(DailyInfoSoapClient.EndpointConfiguration.DailyInfoSoap);
            var elements = node.GetCursOnDateXML(DateTime.Today);
            foreach (XmlNode currency in elements.ChildNodes)
            {
                currencyList.Add(new Currency()
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
