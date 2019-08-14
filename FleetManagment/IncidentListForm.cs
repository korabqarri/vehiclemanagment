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

        private readonly StationResponseBLL stationResponseBll;

        private readonly IEnumerable<StationResponse> stationResponses;
        public IncidentListForm()
        {
            _incidentService = new IncidentBLL();
            InitializeComponent();

            stationResponseBll = new StationResponseBLL();
            stationResponses = stationResponseBll.GetAll();

            cmbResponseId.DataSource = stationResponses;
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
            Incident newIncident = new Incident();
            newIncident = fillObject(newIncident);
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


                //Number of vehicles
                lblComment.Text = responseSelected.NumberOfVehicles.ToString() + " vehicles required";

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
        }
    }
}
