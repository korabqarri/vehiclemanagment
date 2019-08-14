using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;
using FleetManagment.Interface;

namespace FleetManagment
{
    public partial class VehicleTypeForm : Form,IBasicCrudForm<VehicleType>
    {

        private readonly VehicleTypeBLL _vehicleTypeService;
        private VehicleType vehicleType;

        public VehicleType VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }
        public VehicleTypeForm()
        {
            _vehicleTypeService = new VehicleTypeBLL();
            InitializeComponent();
        }


        public VehicleTypeForm(VehicleType vehicleType)
        {
            _vehicleTypeService = new VehicleTypeBLL();
            InitializeComponent();
            this.vehicleType = vehicleType;
            PopulateForm();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        private void PopulateForm()
        {
            if (this.vehicleType != null)
            {
                btnReset.Hide();
                txtName.Text = vehicleType.Name;
            }
        }


        public void ResetForm()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (vehicleType == null)
            {
                VehicleType newVehicleType = new VehicleType();
                newVehicleType = fillObject(newVehicleType);
                if (newVehicleType != null)
                {
                    var registered = _vehicleTypeService.Insert(newVehicleType);
                    if (registered)
                    {
                        MessageBox.Show("U regjistrua me sukses");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Regjistrimi deshtoi. Ju lutem kontrolloni formen");
                }
            }
            else
            {
                vehicleType = fillObject(vehicleType);
                var updated = _vehicleTypeService.Update(vehicleType);
                if (updated)
                {
                    MessageBox.Show("U editua me sukses");
                    this.Close();
                }
                else
                    MessageBox.Show("Editimi deshtoi. Ju lutem kontrolloni formen");
            }
        }


        private VehicleType fillObject(VehicleType type)
        {
            type.Name = txtName.Text;
            return type;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtName.Text = "";
            vehicleType = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        VehicleType IBasicCrudForm<VehicleType>.Get()
        {
            VehicleType vehicleType = new VehicleType();
            vehicleType.Name = txtName.Text;
            return vehicleType;
        }

        List<VehicleType> IBasicCrudForm<VehicleType>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
