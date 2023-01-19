using ExchangeWidget.Pages;
using System.Security.Cryptography;
using System.Text;

namespace ExchangeWidget
{
    public partial class ExchangeWidget : Form
    {
        private Panel? _currentPanel;
        public ExchangeWidget()
        {
            InitializeComponent();
            ChangeForm(new LoginForm().MainPanel);
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            ChangeForm(new AboutForm().MainPanel);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ChangeForm(Panel panel)
        {
            if (_currentPanel != null) _currentPanel.Dispose();
            panel.Parent = this;
            _currentPanel = panel;
        }
    }
}