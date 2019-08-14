using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FleetManagment.BLL;

namespace FleetManagment
{
    public partial class LoginForm : Form
    {
        private readonly UserAccountBLL userBLL;
        public LoginForm()
        {
            userBLL = new UserAccountBLL();
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           Login();
        }

        private void Login()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username.Trim() == "" || password == "")
            {
                MessageBox.Show("Please check username or password");
                return;
            }

            var user = userBLL.Login(username, password);
            if (user != null)
            {
                ApplicationCookie.CurrentUser = user;
                ApplicationCookie.UserId = user.ID;
                ApplicationCookie.Role = user.RoleName;
                //MainForm mf = new MainForm();
                //this.Hide();
                //mf.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password gabim");
            }
        }
        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk.PerformClick();
            }
        }

        private void rbAlb_CheckedChanged(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("sq");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }

        private void rbEng_CheckedChanged(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }
    }
}
