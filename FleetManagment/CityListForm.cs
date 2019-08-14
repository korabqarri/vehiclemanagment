using System;
using System.Reflection;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;

namespace FleetManagment
{
    public partial class CityListForm : Form
    {
        private readonly CityBLL _cityService;
        public CityListForm()
        {
            _cityService = new CityBLL();
            InitializeComponent();
        }

        private void VehicleTypeListForm_Activated(object sender, EventArgs e)
        {
            RefreshCityList();
        }

        private void RefreshCityList()
        {
            dgvCityList.DataSource = _cityService.GetAll();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RefreshCityList();
        }


        private void dgvCityList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                City city = Get(rowIndex);
                if (city != null)
                {
                    CityForm frm = new CityForm(city);
                    frm.Name = "Edit City";
                    frm.TopLevel = false;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }

        }


        private City Get(int rowIndex)
        {
            City city = new City();

            city.ID = (int)GetValue(rowIndex, 0);
            city.Name = (string)GetValue(rowIndex, 1);
            city.CountryId = (int)GetValue(rowIndex, 3);
            return city;
        }

        private Object GetValue(int rowIndex, int cellIndex)
        {
            return dgvCityList.Rows[rowIndex].Cells[cellIndex].Value;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvCityList.SelectedRows[0].Index;

            City city = Get(rowIndex);

            if (city != null)
            {
                CityForm frm = new CityForm(city);
                frm.Text = "Edit City";
                frm.TopLevel = false;
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvCityList.SelectedRows[0].Index;
            City city = Get(rowIndex);

            if (city != null)
            {
                if (MessageBox.Show("A je i sigurte", "Jeni duke fshire",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    _cityService.Delete(city.ID);
                    RefreshCityList();
                }
            }

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            CityForm frm = new CityForm();
            frm.Text = "New City";
            frm.TopLevel = false;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
