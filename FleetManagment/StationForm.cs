using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;
using FleetManagment.Interface;

namespace FleetManagment
{
    public partial class StationForm : Form,IBasicCrudForm<Station>
    {

        private readonly StationBLL _stationService;
        private Station station;

        public Station Station
        {
            get { return station; }
            set { station = value; }
        }
        public StationForm()
        {
            _stationService = new StationBLL();
            InitializeComponent();
        }


        public StationForm(Station station)
        {
            _stationService = new StationBLL();
            InitializeComponent();
            this.station = station;
            PopulateForm();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        private void PopulateForm()
        {
            if (this.station != null)
            {
                btnReset.Hide();
                txtName.Text = station.Name;
                txtArea.Text = station.Area;
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
            if (station == null)
            {
                Station newStation = new Station();
                newStation = fillObject(newStation);
                if (newStation != null)
                {
                    var registered = _stationService.Insert(newStation);
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
                station = fillObject(station);
                var updated = _stationService.Update(station);
                if (updated)
                {
                    MessageBox.Show("U editua me sukses");
                    this.Close();
                }
                else
                    MessageBox.Show("Editimi deshtoi. Ju lutem kontrolloni formen");
            }
        }


        private Station fillObject(Station station)
        {
            station.Name = txtName.Text;
            station.Area = txtArea.Text;
            return station;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtName.Text = "";
            txtArea.Text = "";
            station = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        Station IBasicCrudForm<Station>.Get()
        {
            Station station = new Station();
            station.Name = txtName.Text;
            station.Area = txtArea.Text;
            return station;
        }

        List<Station> IBasicCrudForm<Station>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
