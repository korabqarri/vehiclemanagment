using System;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;

namespace FleetManagment
{
    public partial class StationListForm : Form
    {
        private readonly StationBLL _stationService;
        public StationListForm()
        {
            _stationService = new StationBLL();
            InitializeComponent();
        }

        private void VehicleTypeListForm_Activated(object sender, EventArgs e)
        {
            RefreshStationList();
        }

        private void RefreshStationList()
        {
            dgvStationList.DataSource = _stationService.GetAll();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RefreshStationList();
        }


        private void dgvStationList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                Station station = Get(rowIndex);
                if (station != null)
                {
                    StationForm frm = new StationForm(station);
                    frm.Name = "Edit Station";
                    frm.TopLevel = false;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }

        }


        private Station Get(int rowIndex)
        {
            Station station = new Station();

            station.ID = (int)GetValue(rowIndex, 0);
            station.Name = (string)GetValue(rowIndex, 1);
            station.Area = (string)GetValue(rowIndex, 2);
            return station;
        }

        private Object GetValue(int rowIndex, int cellIndex)
        {
            return dgvStationList.Rows[rowIndex].Cells[cellIndex].Value;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvStationList.SelectedRows[0].Index;

            Station station = Get(rowIndex);

            if (station != null)
            {
                StationForm frm = new StationForm(station);
                frm.Text = "Edit Station";
                frm.TopLevel = false;
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvStationList.SelectedRows[0].Index;
            Station station = Get(rowIndex);

            if (station != null)
            {
                if (MessageBox.Show("A je i sigurte", "Jeni duke fshire",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    _stationService.Delete(station.ID);
                    RefreshStationList();
                }
            }

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            StationForm frm = new StationForm();
            frm.Text = "New Station";
            frm.TopLevel = false;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
