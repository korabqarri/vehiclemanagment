using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;
using FleetManagment.Interface;

namespace FleetManagment
{
    public partial class StationResponseForm : Form,IBasicCrudForm<StationResponse>
    {

        private readonly StationResponseBLL _stationResponseService;
        private readonly ResponseBLL responseBll;
        private readonly StationBLL stationBLL;
        private readonly VehicleTypeBLL vehicleTypeBLL;

        private readonly IEnumerable<Response> responses;
        private readonly IEnumerable<Station> stations;
        private readonly IEnumerable<VehicleType> vehicleTypes;
        private StationResponse stationResponse;



        public StationResponse StationResponse
        {
            get { return stationResponse; }
            set { stationResponse = value; }
        }
        public StationResponseForm()
        {
            _stationResponseService = new StationResponseBLL();
            InitializeComponent();
            responseBll = new ResponseBLL();
            stationBLL = new StationBLL();
            vehicleTypeBLL = new VehicleTypeBLL();

            responses = responseBll.GetAll();
            stations = stationBLL.GetAll();
            vehicleTypes = vehicleTypeBLL.GetAll();

            cmbResponseId.DataSource = responses;
            cmbStationId.DataSource = stations;
            cmbVehicleTypeId.DataSource = vehicleTypes;
        }


        public StationResponseForm(StationResponse stationResponse)
        {
            _stationResponseService = new StationResponseBLL();
            InitializeComponent();

            responseBll = new ResponseBLL();
            stationBLL = new StationBLL();
            vehicleTypeBLL = new VehicleTypeBLL();

            responses = responseBll.GetAll();
            stations = stationBLL.GetAll();
            vehicleTypes = vehicleTypeBLL.GetAll();

            cmbResponseId.DataSource = responses;
            cmbStationId.DataSource = stations;
            cmbVehicleTypeId.DataSource = vehicleTypes;

            this.stationResponse = stationResponse;

            PopulateForm();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        private void PopulateForm()
        {
            if (this.stationResponse != null)
            {
                btnReset.Hide();
                cmbResponseId.SelectedValue = stationResponse.ResponseId;
                cmbStationId.SelectedValue = stationResponse.StationId;
                nudNumberOfVehicles.Value = stationResponse.NumberOfVehicles;
                cmbVehicleTypeId.SelectedValue = stationResponse.VehicleTypeId;
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
            if (stationResponse == null)
            {
                StationResponse newStationResponse = new StationResponse();
                newStationResponse = fillObject(newStationResponse);
                if (newStationResponse != null)
                {
                    var registered = _stationResponseService.Insert(newStationResponse);
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
                stationResponse = fillObject(stationResponse);
                var updated = _stationResponseService.Update(stationResponse);
                if (updated)
                {
                    MessageBox.Show("U editua me sukses");
                    this.Close();
                }
                else
                    MessageBox.Show("Editimi deshtoi. Ju lutem kontrolloni formen");
            }
        }


        private StationResponse fillObject(StationResponse stationResponse)
        {
            stationResponse.ResponseId = (int)cmbResponseId.SelectedValue;
            stationResponse.StationId = (int)cmbStationId.SelectedValue;
            stationResponse.NumberOfVehicles = (int)nudNumberOfVehicles.Value;
            stationResponse.VehicleTypeId = (int)cmbVehicleTypeId.SelectedValue;
            return stationResponse;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            cmbResponseId.SelectedIndex = -1;
            cmbStationId.SelectedIndex = -1;
            nudNumberOfVehicles.Value = 0;
            cmbVehicleTypeId.SelectedIndex = -1;
            stationResponse = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        StationResponse IBasicCrudForm<StationResponse>.Get()
        {
            StationResponse stationResponse = new StationResponse();
            stationResponse.ResponseId = (int)cmbResponseId.SelectedValue;
            stationResponse.StationId = (int)cmbResponseId.SelectedValue;
            stationResponse.NumberOfVehicles = (int)nudNumberOfVehicles.Value;
            stationResponse.VehicleTypeId = (int)cmbVehicleTypeId.SelectedValue;
            return stationResponse;
        }

        List<StationResponse> IBasicCrudForm<StationResponse>.GetAll()
        {
            throw new NotImplementedException();
        }

        private void CmbVehicleTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
