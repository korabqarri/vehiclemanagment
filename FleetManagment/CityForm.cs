using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;
using FleetManagment.Interface;

namespace FleetManagment
{
    public partial class CityForm : Form,IBasicCrudForm<City>
    {

        private readonly CityBLL _cityService;
        private readonly CountryBLL countryBll;

        private readonly IEnumerable<Country> countries;
        private City city;

        public City City
        {
            get { return city; }
            set { city = value; }
        }
        public CityForm()
        {
            _cityService = new CityBLL();
            InitializeComponent();
            countryBll = new CountryBLL();

            countries = countryBll.GetAll();

            cmbCountryId.DataSource = countries;
        }


        public CityForm(City city)
        {
            _cityService = new CityBLL();
            InitializeComponent();

            countryBll = new CountryBLL();

            countries = countryBll.GetAll();

            cmbCountryId.DataSource = countries;

            this.city = city;

            PopulateForm();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        private void PopulateForm()
        {
            if (this.city != null)
            {
                btnReset.Hide();
                cmbCountryId.SelectedValue = city.CountryId;
                txtName.Text = city.Name;
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
            if (city == null)
            {
                City newCity = new City();
                newCity = fillObject(newCity);
                if (newCity != null)
                {
                    var registered = _cityService.Insert(newCity);
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
                city = fillObject(city);
                var updated = _cityService.Update(city);
                if (updated)
                {
                    MessageBox.Show("U editua me sukses");
                    this.Close();
                }
                else
                    MessageBox.Show("Editimi deshtoi. Ju lutem kontrolloni formen");
            }
        }


        private City fillObject(City city)
        {
            city.CountryId = (int)cmbCountryId.SelectedValue;
            city.Name = (string)txtName.Text;
            return city;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            cmbCountryId.SelectedIndex = -1;
            txtName.Text = "";
            city = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        City IBasicCrudForm<City>.Get()
        {
            City city = new City();
            city.CountryId = (int)cmbCountryId.SelectedValue;
            city.Name = (string)txtName.Text;

            return city;
        }

        List<City> IBasicCrudForm<City>.GetAll()
        {
            throw new NotImplementedException();
        }

        private void CmbVehicleTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
