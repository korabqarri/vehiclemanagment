using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FleetManagment.BLL;
using FleetManagment.BO;
using FleetManagment.Interface;

namespace FleetManagment
{
    public partial class ResponseForm : Form,IBasicCrudForm<Response>
    {

        private readonly ResponseBLL _responseService;
        private Response response;

        public Response Response
        {
            get { return response; }
            set { response = value; }
        }
        public ResponseForm()
        {
            _responseService = new ResponseBLL();
            InitializeComponent();
        }


        public ResponseForm(Response response)
        {
            _responseService = new ResponseBLL();
            InitializeComponent();
            this.response = response;
            PopulateForm();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        private void PopulateForm()
        {
            if (this.response != null)
            {
                btnReset.Hide();
                txtName.Text = response.Name;
                checkEmergency.Checked = response.Emergency;
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
            if (response == null)
            {
                Response newResponse = new Response();
                newResponse = fillObject(newResponse);
                if (newResponse != null)
                {
                    var registered = _responseService.Insert(newResponse);
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
                response = fillObject(response);
                var updated = _responseService.Update(response);
                if (updated)
                {
                    MessageBox.Show("U editua me sukses");
                    this.Close();
                }
                else
                    MessageBox.Show("Editimi deshtoi. Ju lutem kontrolloni formen");
            }
        }


        private Response fillObject(Response response)
        {
            response.Name = txtName.Text;
            response.Emergency = checkEmergency.Checked;
            return response;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtName.Text = "";
            response = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        Response IBasicCrudForm<Response>.Get()
        {
            Response response = new Response();
            response.Name = txtName.Text;
            return response;
        }

        List<Response> IBasicCrudForm<Response>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
