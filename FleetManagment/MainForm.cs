using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace FleetManagment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void ShowLogin()
        {
            this.Hide();
            LoginForm frmLogin = new LoginForm();
            //  frmLogin.Show();
            DialogResult dr = new DialogResult();
            dr = frmLogin.ShowDialog();
            if (dr == DialogResult.OK && ApplicationCookie.CurrentUser != null)
            {
                if(ApplicationCookie.Role == "Admin")
                {
                    administrationToolStripMenuItem.Visible = true;
                    locationToolStripMenuItem.Visible = true;
                    stationToolStripMenuItem1.Visible = true;
                    vehicleToolStripMenuItem.Visible = true;
                    responseToolStripMenuItem.Visible = true;
                }
                this.Show();
            }
            else if (dr == DialogResult.OK && ApplicationCookie.CurrentUser != null)
            {
                MessageBox.Show("Gabim");
                ShowLogin();
            }
            else if (dr == DialogResult.Cancel)
            {
                Application.Exit();
            }
            else
                Application.Exit();

        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAccountForm uaf = new UserAccountForm();
            uaf.MdiParent = this;
            uaf.Show();
        }

        private void userAccountTsmi_Click(object sender, EventArgs e)
        {
            UserListForm ulf = new UserListForm();
            ulf.TopLevel = false;
            ulf.MdiParent = this;
            ulf.Show();
        }

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this,@"C:\Users\naims\Desktop\HELP\help.chm");
            Help.ShowHelp(this,@"C:\Users\naims\Desktop\HELP\help.chm",HelpNavigator.Topic,"Raportimit.htm");
            Process.Start(
                @"D:\Faculty\Assistant\TI-2018\Projeki Teknologjise Internetit\Lirim Kuleta & Besfort Isufi\JS Hiking\index.html");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void VehicleTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleTypeListForm ef = new VehicleTypeListForm();

            ef.MdiParent = this;
            ef.Show();
        }

        private void ResponsesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResponseListForm ef = new ResponseListForm();
            ef.MdiParent = this;
            ef.Show();
        }

        private void StationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StationListForm ef = new StationListForm();
            ef.MdiParent = this;
            ef.Show();
        }

        private void StationResponsesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StationResponseListForm ef = new StationResponseListForm();
            ef.MdiParent = this;
            ef.Show();
        }

        private void CountriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountryListForm ef = new CountryListForm();
            ef.MdiParent = this;
            ef.Show();
        }

        private void CitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityListForm ef = new CityListForm();
            ef.MdiParent = this;
            ef.Show();
        }

        private void CountriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CountryListForm ef = new CountryListForm();
            ef.MdiParent = this;
            ef.Show();
        }

        private void CitiesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CityListForm ef = new CityListForm();
            ef.MdiParent = this;
            ef.Show();
        }

        private void StationsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StationListForm ef = new StationListForm();
            ef.MdiParent = this;
            ef.Show();
        }

        private void StationResponsesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StationResponseListForm ef = new StationResponseListForm();
            ef.MdiParent = this;
            ef.Show();
        }

        private void ResponsesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ResponseListForm ef = new ResponseListForm();
            ef.MdiParent = this;
            ef.Show();
        }

        private void VehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleListForm ef = new VehicleListForm();
            ef.MdiParent = this;
            ef.Show();
        }

        private void IncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncidentListForm ef = new IncidentListForm();
            ef.MdiParent = this;
            //ef.WindowState = FormWindowState.Maximized;
            ef.Show();
        }
    }
}
