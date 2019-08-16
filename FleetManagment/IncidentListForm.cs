using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;

namespace FleetManagment
{
    public partial class IncidentListForm : Form
    {
        private readonly IncidentBLL _incidentService;

        private readonly StationBLL stationBll;
        private readonly VehicleBLL vehicleBLL;


        private readonly IEnumerable<Station> stations;
        private List<Vehicle> vehicles;
        private int requiredVehicles;
        public IncidentListForm()
        {
            _incidentService = new IncidentBLL();
            InitializeComponent();

            stationBll = new StationBLL();
            stations = stationBll.GetAll();

            vehicleBLL = new VehicleBLL();

            cmbStation.DataSource = stations;
            txtFirstname.Text = ApplicationCookie.CurrentUser.Name;
            txtLastname.Text = ApplicationCookie.CurrentUser.Surname;
        }

        private void VehicleTypeListForm_Activated(object sender, EventArgs e)
        {
            RefreshIncidentList();
        }

        private void RefreshIncidentList()
        {
            dgvIncidentList.DataSource = _incidentService.GetAll();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RefreshIncidentList();
        }

        private Object GetValue(int rowIndex, int cellIndex)
        {
            return dgvIncidentList.Rows[rowIndex].Cells[cellIndex].Value;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (vehicles.Count > 0)
            {

                Incident newIncident = new Incident();
                newIncident = fillObject(newIncident);
                newIncident.Vehicles = vehicles.GetRange(0, requiredVehicles - 1);
                if (newIncident != null)
                {
                    var registered = _incidentService.Insert(newIncident);
                    if (registered)
                    {
                        MessageBox.Show("U regjistrua me sukses");
                        Reset();
                        RefreshIncidentList();
                    }
                    else
                        MessageBox.Show("Regjistrimi deshtoi. Ju lutem kontrolloni formen");
                }
            }
            else
            {
                MessageBox.Show("Te gjitha veturat jane te zena");
            }
        }

        private Incident fillObject(Incident incident)
        {
            incident.Time = dtTime.Value;
            incident.Description = txtDescription.Text;
            incident.Address = txtAddress.Text;
            incident.AddressAdditional = txtAddressAdditional.Text;
            incident.StationResponseId = (int)cmbResponseId.SelectedValue;
            incident.ReporterId = ApplicationCookie.UserId;
            incident.Latitude = txtLatitude.Text;
            incident.Longitude = txtLongitude.Text;
            incident.Emergency = chbIsEmergency.Checked;

            return incident;
        }

        private void CmbResponseId_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            StationResponse responseSelected = (StationResponse)comboBox.SelectedItem;

            if (responseSelected != null)
            {
                //Is Emergency service needed
                ResponseBLL responseBll = new ResponseBLL();
                Response response = responseBll.Get(responseSelected.ResponseId);
                chbIsEmergency.Checked = response.Emergency;

                requiredVehicles = responseSelected.NumberOfVehicles;


                //Number of vehicles
                lblComment.Text = requiredVehicles.ToString() + " vehicles required";

            }
        }

        private void Reset()
        {
            txtDescription.Text = "";
            txtAddress.Text = "";
            txtAddressAdditional.Text = "";
            txtLatitude.Text = "";
            txtLongitude.Text = "";
            lblComment.Text = "";
            lblVehicles.Text = "";
        }

        private void CmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            Station stationSelected = (Station)comboBox.SelectedItem;

            cmbResponseId.SelectedIndex = -1;
            lblComment.Text = "";
            lblVehicles.Text = "";

            if (stationSelected != null)
            {
                StationResponseBLL stationResponseBll = new StationResponseBLL();
                cmbResponseId.DataSource = stationResponseBll.GetByStation(stationSelected.ID);

                vehicles = vehicleBLL.GetStationVehicles(stationSelected.ID);
                lblVehicles.Text = vehicles.Count.ToString() + " vehicles available";

            }
        }
    }
}
