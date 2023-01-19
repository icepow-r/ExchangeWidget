namespace ExchangeWidget.Pages
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            (MainPanel.Parent as ExchangeWidget)!.GoBack();
        }
    }
}
