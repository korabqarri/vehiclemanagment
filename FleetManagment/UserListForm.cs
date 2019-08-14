using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;

namespace FleetManagment
{
    public partial class UserListForm : Form
    {
        private readonly UserAccountBLL _userService;
        public UserListForm()
        {
            _userService = new UserAccountBLL();
            InitializeComponent();
            dgvUserAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    
        }

        private void UserListForm_Activated(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            dgvUserAccount.DataSource = _userService.GetAll();
        }

        private void tsbAddUser_Click(object sender, EventArgs e)
        {
            UserAccountForm uaf = new UserAccountForm();
            uaf.TopLevel = false;
            uaf.MdiParent = this.MdiParent;
            uaf.Show();
        }


        public UserAccount GetUser(DataGridViewRow userRow)
        {
            try
            {
                UserAccount user = new UserAccount();
                user.ID = (int)userRow.Cells[0].Value;
                user.Username = (string)userRow.Cells[1].Value;
                user.Password = "";
                user.Name = (string)userRow.Cells[3].Value;
                user.Surname = (string)userRow.Cells[4].Value;
                user.RoleId = (int) userRow.Cells[5].Value;
                //            user.InsertBy = (int) userRow.Cells[5].Value;
                //            user.InsDate = (DateTime) userRow.Cells[6].Value;
                //            user.UpdateBy = (int) userRow.Cells[7].Value;
                //            user.UpdateDate = (DateTime)userRow.Cells[8].Value;
                //            user.UpdateNo = (int) userRow.Cells[9].Value;

                return user;

            }
            catch (Exception e)
            {
                return null;
            }
           
        }

        private void dgvUserAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            UserAccount user;
            if (rowIndex >= 0)
            {
                user = GetUser(dgvUserAccount.Rows[rowIndex]);
                if (user != null)
                {
                    UserAccountForm uaf = new UserAccountForm(user);
                    uaf.TopLevel = false;
                    uaf.MdiParent = this.MdiParent;
                    uaf.Show();
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUserAccount.SelectedRows.Count>0)
            {


                var row = dgvUserAccount.SelectedRows[0].Index;

                if (row >= 0)
                {
                    var user = GetUser(dgvUserAccount.Rows[row]);
                    if (user != null)
                    {
                        UserAccountForm uaf = new UserAccountForm(user);
                        uaf.TopLevel = false;
                        uaf.MdiParent = this.MdiParent;
                        uaf.Show();
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUserAccount.SelectedRows.Count > 0)
            {


                var row = dgvUserAccount.SelectedRows[0].Index;

                if (row >= 0)
                {
                    var user = GetUser(dgvUserAccount.Rows[row]);
                    if (user != null)
                    {
                        if (user.ID == ApplicationCookie.CurrentUser.ID)
                        {
                            MessageBox.Show("Nuk mund ta fshini vetveten :)");
                            return;
                        }
                        var deleted = _userService.Delete(user.ID );
                        if (deleted)
                        {
                            MessageBox.Show("U fshi perderouesi");
                            RefreshList();
                            
                        }
                        else
                        {
                            MessageBox.Show("Provoni perseri");

                        }
                    }
                }
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
