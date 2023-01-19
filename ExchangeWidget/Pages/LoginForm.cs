using System.Security.Cryptography;
using System.Text;
// ReSharper disable LocalizableElement

namespace ExchangeWidget.Pages
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //private static void CreateSaltedHash(string password)
        //{
        //    var saltBytes = RandomNumberGenerator.GetBytes(32);
        //    var salt = Convert.ToBase64String(saltBytes);
        //    var result = password + salt;
        //    var hash = MD5.HashData(Encoding.Default.GetBytes(result));
        //    var hashString = Convert.ToBase64String(hash);
        //}

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var bytes = Encoding.Default.GetBytes(PasswordTextBox.Text + Properties.Resources.Salt);
            var hash = MD5.HashData(bytes);
            var password = Convert.ToBase64String(hash);

            if (LoginTextBox.Text == Properties.Resources.Login &&
                password == Properties.Resources.Password)
            {
                (MainPanel.Parent as ExchangeWidget)!.ChangeForm(new ExchangeForm().MainPanel);
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
