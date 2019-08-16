using System;
using System.Reflection;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;

namespace FleetManagment
{
    public partial class VehicleListForm : Form
    {
        private readonly VehicleBLL _vehicleService;
        public VehicleListForm()
        {
            _vehicleService = new VehicleBLL();
            InitializeComponent();
        }

        private void VehicleTypeListForm_Activated(object sender, EventArgs e)
        {
            RefreshVehicleList();
        }

        private void RefreshVehicleList()
        {
            dgvVehicleList.DataSource = _vehicleService.GetAll();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RefreshVehicleList();
        }


        private void dgvVehicleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                Vehicle vehicle = Get(rowIndex);
                if (vehicle != null)
                {
                    VehicleForm frm = new VehicleForm(vehicle);
                    frm.Name = "Edit Vehicle";
                    frm.TopLevel = false;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }

        }


        private Vehicle Get(int rowIndex)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.ID = (int)GetValue(rowIndex, 0);
            vehicle.LicensePlate = (string)GetValue(rowIndex, 1);
            vehicle.VehicleTypeName = (string)GetValue(rowIndex, 2);
            vehicle.IsAvailable = (bool)GetValue(rowIndex, 3);
            vehicle.StationName = (string)GetValue(rowIndex, 4);
            vehicle.VehicleTypeId = (int)GetValue(rowIndex, 5);
            vehicle.StationId = (int)GetValue(rowIndex, 6);
            return vehicle;
        }

        private Object GetValue(int rowIndex, int cellIndex)
        {
            return dgvVehicleList.Rows[rowIndex].Cells[cellIndex].Value;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvVehicleList.SelectedRows[0].Index;

            Vehicle vehicle = Get(rowIndex);

            if (vehicle != null)
            {
                VehicleForm frm = new VehicleForm(vehicle);
                frm.Text = "Edit Vehicle";
                frm.TopLevel = false;
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvVehicleList.SelectedRows[0].Index;
            Vehicle vehicle = Get(rowIndex);

            if (vehicle != null)
            {
                if (MessageBox.Show("A je i sigurte", "Jeni duke fshire",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    _vehicleService.Delete(vehicle.ID);
                    RefreshVehicleList();
                }
            }

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            VehicleForm frm = new VehicleForm();
            frm.Text = "New Vehicle";
            frm.TopLevel = false;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
