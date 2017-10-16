using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UppApplication.Services;

namespace UppApplication.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (AuthenticationService.ValidateUser(tboxUsername.Text, tboxPassword.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Login failed");
                errorLabel.Text = "Login failed";
                errorLabel.Show();
            }
        }
    }
}
