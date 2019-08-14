using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;
using UA=FleetManagment.BO.UserAccount;


namespace FleetManagment
{
    public partial class UserAccountForm : Form
    {
        private readonly UserAccountBLL userBll;
        private readonly RoleBLL roleBll;
        private readonly IEnumerable<Role> roles;
        private UserAccount user;
        private bool update = false;

        public UserAccountForm()
        {
            InitializeComponent();
            userBll = new UserAccountBLL();
            roleBll = new RoleBLL();
            roles = roleBll.GetAll();
            cbRole.DataSource = roles;
            update = false;
        }

        public UserAccountForm(UserAccount user)
        {
            InitializeComponent();
            userBll = new UserAccountBLL();
            roleBll = new RoleBLL();
            roles = roleBll.GetAll();
            cbRole.DataSource = roles;
            this.user = user;
            update = this.user != null;
            populateForm(this.user);
        }

        private void populateForm(UserAccount user)
        {
            txtName.Text = user.Name;
            txtID.Text = user.ID.ToString();
            txtSurname.Text = user.Surname;
            txtUsername.Text = user.Username;
            txtPassword.Text = "";
            cbRole.SelectedItem = roles.FirstOrDefault(r=>r.ID==user.RoleId);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            UserAccount ua = new UserAccount();
            ua.ID = int.Parse(txtID.Text);
            ua.Name = txtName.Text;
            ua.Surname = txtSurname.Text;
            ua.Username = txtUsername.Text;
            ua.Password = txtPassword.Text;
            ua.RoleId = (int) cbRole.SelectedValue;
            ua.InsDate = DateTime.Now;
            ua.InsertBy = ApplicationCookie.CurrentUser.ID;
            if (!update)
            {
                bool isRegistered = userBll.Add(ua);

                if (isRegistered)
                {
                    MessageBox.Show("U regjistrua me sukses");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Regjistrimi deshtoi, provoni perseri");
                }
            }
            else
            {
                MessageBox.Show("Updated...");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var col = e.ColumnIndex;
            var row = e.RowIndex;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            user = null;
            update = false;
            txtName.Text = txtSurname.Text = txtPassword.Text = txtID.Text = txtUsername.Text = "";
            cbRole.SelectedIndex = -1;
        }
    }
}
