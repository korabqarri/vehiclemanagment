using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleetManagment
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm ef = new EmployeeForm();
            ef.MdiParent = this;
            ef.Show();
        }
    }
}
