using BLL.Services;
using BLL.Views;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class RegistrationForm : Form
    {
        private readonly AuthenticationService _authenticationService;
        private readonly UserService _userService;
        public RegistrationForm(AuthenticationService authenticationService, UserService userService)
        {
            _userService = userService;
            _authenticationService = authenticationService;

            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            //User user = new User();
            //if (textbox_pwd.Text == textbox_pwd2.Text)
            //{
            //    user.Hashe = textbox_pwd2.Text;
            //}
            //else
            //{
            //    MessageBox.Show(
            //        "Passwords are not match!",
            //        "Error",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //    return;
            //}
            //user.Name = textbox_name.Text;
            //user.Login = textbox_login.Text;
            //user.Age = Convert.ToInt32(textbox_age.Text);
            //_userService.CreateUser(user);
        }

        //---
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
