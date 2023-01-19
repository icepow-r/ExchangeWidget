using ExchangeWidget.Pages;

namespace ExchangeWidget
{
    public partial class ExchangeWidget : Form
    {
        private Stack<Panel> _navigator = new();
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
            if (_navigator.Count > 0)
            {
                _navigator.Peek().Parent = null;
            }
            panel.Parent = this;
            _navigator.Push(panel);
        }

        public void GoBack()
        {
            var panel = _navigator.Pop();
            panel.Dispose();
            _navigator.Peek().Parent = this;
        }
    }
}