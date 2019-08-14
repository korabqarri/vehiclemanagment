using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;
using FleetManagment.Interface;

namespace FleetManagment
{
    public partial class EmployeeForm : Form,IBasicCrudForm<Employee>
    {

        private  readonly EmployeeBLL _service;
        public EmployeeForm()
        {
            _service = new EmployeeBLL();
            InitializeComponent();
        }



        private void btnReset_Click(object sender, EventArgs e)
        {

            ResetForm();
        }



        public void ResetForm()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            var employee = Get();
            if (employee == null)
            {
                MessageBox.Show("Gabim ne model apo parsim te te dhenave");
                return;
            }

            var saved = _service.Insert(employee);

            if (saved)
            {
                MessageBox.Show("U regjistrua me sukses");
            }
            else
            {
                MessageBox.Show("Provoni perseri, regjistrimi deshtoi");
            }


        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public Employee Get()
        {
            try
            {
                Employee employee = new Employee
                {
                    ID = txtID.Text.Trim() != "" ? int.Parse(txtID.Text.Trim()) : 0,
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    Birthdate = DateTime.Now.AddYears(-20),//duhet dinamikisht e harruar
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    PersonalNo = txtPersonalNo.Text,
                    CityId = 2,//int.Parse(cbCity.Text),
                    IsPasiv = chbIsPasiv.Checked,
                    Mobile = txtMobile.Text,
                    Gender = rbFemale.Checked ? 'F' : 'M',
                    InsertBy = 3,
                    InsDate = DateTime.Now,
                    UpdateBy = null,
                    UpdateDate = null
                };
                return employee;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
