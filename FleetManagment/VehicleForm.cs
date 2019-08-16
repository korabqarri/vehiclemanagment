using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;
using FleetManagment.Interface;

namespace FleetManagment
{
    public partial class VehicleForm : Form,IBasicCrudForm<Vehicle>
    {

        private readonly VehicleBLL _vehicleService;
        private readonly VehicleTypeBLL vehicleTypeBll;
        private readonly StationBLL stationBll;

        private readonly IEnumerable<VehicleType> vehicleTypes;
        private readonly IEnumerable<Station> stations;
        private Vehicle vehicle;

        public Vehicle Vehicle
        {
            get { return vehicle; }
            set { vehicle = value; }
        }
        public VehicleForm()
        {
            _vehicleService = new VehicleBLL();
            InitializeComponent();
            vehicleTypeBll = new VehicleTypeBLL();
            stationBll = new StationBLL();

            vehicleTypes = vehicleTypeBll.GetAll();
            stations = stationBll.GetAll();

            cmbVehicleTypeId.DataSource = vehicleTypes;
            cmbStationId.DataSource = stations;
        }


        public VehicleForm(Vehicle vehicle)
        {
            _vehicleService = new VehicleBLL();
            InitializeComponent();

            vehicleTypeBll = new VehicleTypeBLL();
            stationBll = new StationBLL();

            vehicleTypes = vehicleTypeBll.GetAll();
            stations = stationBll.GetAll();

            cmbVehicleTypeId.DataSource = vehicleTypes;
            cmbStationId.DataSource = stations;

            this.vehicle = vehicle;

            PopulateForm();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        private void PopulateForm()
        {
            if (this.vehicle != null)
            {
                btnReset.Hide();
                txtLicensePlate.Text = vehicle.LicensePlate;
                cmbVehicleTypeId.SelectedValue = vehicle.VehicleTypeId;
                cmbStationId.SelectedValue = vehicle.StationId;
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
            if (vehicle == null)
            {
                Vehicle newVehicle = new Vehicle();
                newVehicle = fillObject(newVehicle);
                if (newVehicle != null)
                {
                    var registered = _vehicleService.Insert(newVehicle);
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
                vehicle = fillObject(vehicle);
                var updated = _vehicleService.Update(vehicle);
                if (updated)
                {
                    MessageBox.Show("U editua me sukses");
                    this.Close();
                }
                else
                    MessageBox.Show("Editimi deshtoi. Ju lutem kontrolloni formen");
            }
        }


        private Vehicle fillObject(Vehicle vehicle)
        {
            vehicle.LicensePlate = (string)txtLicensePlate.Text;
            vehicle.VehicleTypeId = (int)cmbVehicleTypeId.SelectedValue;
            vehicle.StationId = (int)cmbStationId.SelectedValue;
            vehicle.IsAvailable = (bool)checkAvailable.Checked;
            return vehicle;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            cmbVehicleTypeId.SelectedIndex = -1;
            txtLicensePlate.Text = "";
            checkAvailable.Checked = false;
            vehicle = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        Vehicle IBasicCrudForm<Vehicle>.Get()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.LicensePlate = (string)txtLicensePlate.Text;
            vehicle.VehicleTypeId = (int)cmbVehicleTypeId.SelectedValue;
            vehicle.StationId = (int)cmbStationId.SelectedValue;
            vehicle.IsAvailable = (bool)checkAvailable.Checked;

            return vehicle;
        }

        List<Vehicle> IBasicCrudForm<Vehicle>.GetAll()
        {
            throw new NotImplementedException();
        }

        private void CmbVehicleTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
