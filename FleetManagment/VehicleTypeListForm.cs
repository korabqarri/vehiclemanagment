using System;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;

namespace FleetManagment
{
    public partial class VehicleTypeListForm : Form
    {
        private readonly VehicleTypeBLL _vehicleTypeService;
        public VehicleTypeListForm()
        {
            _vehicleTypeService = new VehicleTypeBLL();
            InitializeComponent();
        }

        private void VehicleTypeListForm_Activated(object sender, EventArgs e)
        {
            RefreshVehicleTypeList();
        }

        private void RefreshVehicleTypeList()
        {
            dgvVehicleTypeList.DataSource = _vehicleTypeService.GetAll();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RefreshVehicleTypeList();
        }


        private void dgvVehicleTypeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                VehicleType vehicleType = Get(rowIndex);
                if (vehicleType != null)
                {
                    VehicleTypeForm frm = new VehicleTypeForm(vehicleType);
                    frm.Name = "Edit Vehicle Type";
                    frm.TopLevel = false;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }

        }


        private VehicleType Get(int rowIndex)
        {
            VehicleType VehicleType = new VehicleType();

            VehicleType.ID = (int)GetValue(rowIndex, 0);
            VehicleType.Name = (string)GetValue(rowIndex, 1);
            return VehicleType;
        }

        private Object GetValue(int rowIndex, int cellIndex)
        {
            return dgvVehicleTypeList.Rows[rowIndex].Cells[cellIndex].Value;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvVehicleTypeList.SelectedRows[0].Index;

            VehicleType vehicleType = Get(rowIndex);

            if (vehicleType != null)
            {
                VehicleTypeForm frm = new VehicleTypeForm(vehicleType);
                frm.Text = "Edit Vehicle Type";
                frm.TopLevel = false;
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvVehicleTypeList.SelectedRows[0].Index;
            VehicleType vehicleType = Get(rowIndex);

            if (vehicleType != null)
            {
                if (MessageBox.Show("A je i sigurte", "Jeni duke fshire",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    _vehicleTypeService.Delete(vehicleType.ID);
                    RefreshVehicleTypeList();
                }
            }

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            VehicleTypeForm frm = new VehicleTypeForm();
            frm.Text = "New Vehicle Type";
            frm.TopLevel = false;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
