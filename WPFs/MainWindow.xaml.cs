using BLL.Services;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TradingCompany.BLL;
using Unity.Resolution;

namespace WPFs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AuthenticationService _authenticationService;
        private readonly UserService _userService;

        public MainWindow(AuthenticationService authenticationService, UserService userService)
        {
            _authenticationService = authenticationService;
            _userService = userService;

            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            CredentialsDTO credentials = new CredentialsDTO()
            {
                Login = login.Text,
                Password = pwd.Password
                };

            if (credentials.Login != "" && credentials.Password != "")
            {
                if (_authenticationService.UserExist(login.Text))
                {
                    if (_authenticationService.CheckCredentials(credentials))
                    {
                        ItemsMenu menu = DependencyInjectorBLL.Resolve<ItemsMenu>(
                            new ParameterOverride("user", _userService.GetByLogin(credentials.Login)));
                        menu.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                           "Wrong password!",
                           "Error",
                           MessageBoxButton.OK,
                           MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                       "There is no such user!",
                       "Error",
                       MessageBoxButton.OK,
                       MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "Empty Data!",
                    "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }
        }
    }
}
