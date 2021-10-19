using System;
using System.Windows;

using PersonalSV.Models;
using PersonalSV.Controllers;
using PersonalSV.Helpers;
using PersonalSV.Views;
using System.ComponentModel;
using System.Windows.Input;

namespace PersonalSV.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        BackgroundWorker bwLogin;
        private PrivateDefineModel defModel;
        public LoginWindow()
        {
            bwLogin = new BackgroundWorker();
            bwLogin.DoWork += BwLogin_DoWork;
            bwLogin.RunWorkerCompleted += BwLogin_RunWorkerCompleted;
            defModel = new PrivateDefineModel();
            InitializeComponent();
            txtUserName.Focus();
        }

        private void BwLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var accountLogin = e.Result as AccountModel;
            if (accountLogin != null)
            {
                MessageBox.Show(string.Format("{0}{1} !", LanguageHelper.GetStringFromResource("logInWindowMsgWelcome"), accountLogin.FullName), this.Title, MessageBoxButton.OK, MessageBoxImage.Information);

                MainWindow window = new MainWindow(accountLogin);
                this.Hide();
                this.txtPassword.Clear();
                window.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show(string.Format("{0}", LanguageHelper.GetStringFromResource("logInWindowMsgLoginFailed")), this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            this.Cursor = null;
        }

        private void BwLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            var par = e.Argument as object[];
            var username = par[0] as string;
            var password = par[1] as string;

            var accountLogin = new AccountModel();
            accountLogin = AccountController.GetAccountByUP(username, password);
            e.Result = accountLogin;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Password;

            if (bwLogin.IsBusy == false)
            {
                this.Cursor = Cursors.Wait;
                var par = new object[] { userName, password };
                bwLogin.RunWorkerAsync(par);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }

        private void cbLoginBySaoViet_Checked(object sender, RoutedEventArgs e)
        {
            if (defModel.Factory.Equals("SAOVIET"))
            {
                txtUserName.Text = "saoviet";
                txtPassword.Password = "sv123";
            }
            else if (defModel.Factory.Equals("DAILOC"))
            {
                txtUserName.Text = "dailoc";
                txtPassword.Password = "dl123";
            }
            else if (defModel.Factory.Equals("THIENLOC"))
            {
                txtUserName.Text = "thienloc";
                txtPassword.Password = "tl123";
            }
        }

        private void cbLoginBySaoViet_Unchecked(object sender, RoutedEventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Password = "";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                defModel = CommonController.GetDefineProps();
                cbLoginBySaoViet.Content = string.Format("Login By {0}", defModel.Factory);
            }
            catch
            {
            }
        }
    }
}
