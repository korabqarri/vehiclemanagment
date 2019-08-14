using System;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;

namespace FleetManagment
{
    public partial class ResponseListForm : Form
    {
        private readonly ResponseBLL _responseService;
        public ResponseListForm()
        {
            _responseService = new ResponseBLL();
            InitializeComponent();
        }

        private void VehicleTypeListForm_Activated(object sender, EventArgs e)
        {
            RefreshResponseList();
        }

        private void RefreshResponseList()
        {
            dgvResponseList.DataSource = _responseService.GetAll();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RefreshResponseList();
        }


        private void dgvResponseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                Response response = Get(rowIndex);
                if (response != null)
                {
                    ResponseForm frm = new ResponseForm(response);
                    frm.Name = "Edit Response";
                    frm.TopLevel = false;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }

        }


        private Response Get(int rowIndex)
        {
            Response response = new Response();

            response.ID = (int)GetValue(rowIndex, 0);
            response.Name = (string)GetValue(rowIndex, 1);
            response.Emergency = (bool)GetValue(rowIndex, 2);
            return response;
        }

        private Object GetValue(int rowIndex, int cellIndex)
        {
            return dgvResponseList.Rows[rowIndex].Cells[cellIndex].Value;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvResponseList.SelectedRows[0].Index;

            Response response = Get(rowIndex);

            if (response != null)
            {
                ResponseForm frm = new ResponseForm(response);
                frm.Text = "Edit Response";
                frm.TopLevel = false;
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvResponseList.SelectedRows[0].Index;
            Response response = Get(rowIndex);

            if (response != null)
            {
                if (MessageBox.Show("A je i sigurte", "Jeni duke fshire",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    _responseService.Delete(response.ID);
                    RefreshResponseList();
                }
            }

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            ResponseForm frm = new ResponseForm();
            frm.Text = "New Response";
            frm.TopLevel = false;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
