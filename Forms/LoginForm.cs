using BLL.Services;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingCompany.BLL;
using Unity.Resolution;

namespace Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthenticationService _authenticationService;
        private readonly UserService _userService;
        public LoginForm(AuthenticationService authenticationService, UserService userService)
        {
            _authenticationService = authenticationService;
            _userService = userService;

            InitializeComponent();
            SetUpForm();
        }

        private void SetUpForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button_create_account_Click(object sender, EventArgs e)
        {
            var form = DependencyInjectorBLL.Resolve<RegistrationForm>();
            form.Show();
        }

        private void button_sign_in_Click(object sender, EventArgs e)
        {
            CredentialsDTO credentials = new CredentialsDTO()
            {
                Login = textbox_login.Text,
                Password = textbox_password.Text
            };

            if (_authenticationService.UserExist(textbox_login.Text))
            {
                if (_authenticationService.CheckCredentials(credentials))
                {
                    MenuForm menu = DependencyInjectorBLL.Resolve<MenuForm>(
                        new ParameterOverride("user", _userService.GetByLogin(credentials.Login)));
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                       "Wrong password!",
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                   "There is no such user!",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       




        ///---
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
