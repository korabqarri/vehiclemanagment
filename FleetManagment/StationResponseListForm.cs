using System;
using System.Reflection;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;

namespace FleetManagment
{
    public partial class StationResponseListForm : Form
    {
        private readonly StationResponseBLL _stationResponseService;
        public StationResponseListForm()
        {
            _stationResponseService = new StationResponseBLL();
            InitializeComponent();
        }

        private void VehicleTypeListForm_Activated(object sender, EventArgs e)
        {
            RefreshStationResponseList();
        }

        private void RefreshStationResponseList()
        {
            dgvStationResponseList.DataSource = _stationResponseService.GetAll();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RefreshStationResponseList();
        }


        private void dgvStationResponseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                StationResponse stationResponse = Get(rowIndex);
                if (stationResponse != null)
                {
                    StationResponseForm frm = new StationResponseForm(stationResponse);
                    frm.Name = "Edit StationResponse";
                    frm.TopLevel = false;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }

        }


        private StationResponse Get(int rowIndex)
        {
            StationResponse stationResponse = new StationResponse();

            stationResponse.ID = (int)GetValue(rowIndex, 0);
            stationResponse.ResponseId = (int)GetValue(rowIndex, 1);
            stationResponse.StationId = (int)GetValue(rowIndex, 2);
            stationResponse.NumberOfVehicles = (int)GetValue(rowIndex, 3);
            stationResponse.VehicleTypeId = (int)GetValue(rowIndex, 4);
            return stationResponse;
        }

        private Object GetValue(int rowIndex, int cellIndex)
        {
            return dgvStationResponseList.Rows[rowIndex].Cells[cellIndex].Value;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvStationResponseList.SelectedRows[0].Index;

            StationResponse stationResponse = Get(rowIndex);

            if (stationResponse != null)
            {
                StationResponseForm frm = new StationResponseForm(stationResponse);
                frm.Text = "Edit StationResponse";
                frm.TopLevel = false;
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvStationResponseList.SelectedRows[0].Index;
            StationResponse stationResponse = Get(rowIndex);

            if (stationResponse != null)
            {
                if (MessageBox.Show("A je i sigurte", "Jeni duke fshire",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    _stationResponseService.Delete(stationResponse.ID);
                    RefreshStationResponseList();
                }
            }

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            StationResponseForm frm = new StationResponseForm();
            frm.Text = "New StationResponse";
            frm.TopLevel = false;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
