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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = AuthenticationService.CurrentUser.Name;
            roleLabel.Text = AuthenticationService.CurrentUser.Role;

            if (AuthenticationService.CurrentUser.Role == "Admin")
            {
                button1.Visible = true;
            }
        }

        private void roleLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
