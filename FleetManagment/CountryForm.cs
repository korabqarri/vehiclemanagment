using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;
using FleetManagment.Interface;

namespace FleetManagment
{
    public partial class CountryForm : Form,IBasicCrudForm<Country>
    {

        private readonly CountryBLL _countryService;
        private Country country;

        public Country Country
        {
            get { return country; }
            set { country = value; }
        }
        public CountryForm()
        {
            _countryService = new CountryBLL();
            InitializeComponent();
        }


        public CountryForm(Country country)
        {
            _countryService = new CountryBLL();
            InitializeComponent();
            this.country = country;
            PopulateForm();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        private void PopulateForm()
        {
            if (this.country != null)
            {
                btnReset.Hide();
                txtName.Text = country.Name;
                txtCode.Text = country.Code;
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
            if (country == null)
            {
                Country newCountry = new Country();
                newCountry = fillObject(newCountry);
                if (newCountry != null)
                {
                    var registered = _countryService.Insert(newCountry);
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
                country = fillObject(country);
                var updated = _countryService.Update(country);
                if (updated)
                {
                    MessageBox.Show("U editua me sukses");
                    this.Close();
                }
                else
                    MessageBox.Show("Editimi deshtoi. Ju lutem kontrolloni formen");
            }
        }


        private Country fillObject(Country country)
        {
            country.Name = txtName.Text;
            country.Code = txtCode.Text;
            return country;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtName.Text = "";
            txtCode.Text = "";
            country = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        Country IBasicCrudForm<Country>.Get()
        {
            Country country = new Country();
            country.Name = txtName.Text;
            country.Code = txtCode.Text;
            return country;
        }

        List<Country> IBasicCrudForm<Country>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
