using System;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;

namespace FleetManagment
{
    public partial class CountryListForm : Form
    {
        private readonly CountryBLL _countryService;
        public CountryListForm()
        {
            _countryService = new CountryBLL();
            InitializeComponent();
        }

        private void VehicleTypeListForm_Activated(object sender, EventArgs e)
        {
            RefreshCountryList();
        }

        private void RefreshCountryList()
        {
            dgvCountryList.DataSource = _countryService.GetAll();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RefreshCountryList();
        }


        private void dgvCountryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                Country country = Get(rowIndex);
                if (country != null)
                {
                    CountryForm frm = new CountryForm(country);
                    frm.Name = "Edit Country";
                    frm.TopLevel = false;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }

        }


        private Country Get(int rowIndex)
        {
            Country country = new Country();

            country.ID = (int)GetValue(rowIndex, 0);
            country.Name = (string)GetValue(rowIndex, 1);
            country.Code = (string)GetValue(rowIndex, 2);
            return country;
        }

        private Object GetValue(int rowIndex, int cellIndex)
        {
            return dgvCountryList.Rows[rowIndex].Cells[cellIndex].Value;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvCountryList.SelectedRows[0].Index;

            Country country = Get(rowIndex);

            if (country != null)
            {
                CountryForm frm = new CountryForm(country);
                frm.Text = "Edit Country";
                frm.TopLevel = false;
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvCountryList.SelectedRows[0].Index;
            Country country = Get(rowIndex);

            if (country != null)
            {
                if (MessageBox.Show("A je i sigurte", "Jeni duke fshire",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    _countryService.Delete(country.ID);
                    RefreshCountryList();
                }
            }

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            CountryForm frm = new CountryForm();
            frm.Text = "New Country";
            frm.TopLevel = false;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
