using ClinicDesktopNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicDesktop.OpenAPIs.Forms
{
    public partial class CreateClientForm : Form
    {
        private String apiUrl;
        public CreateClientForm(String apiUrl)
        {
            InitializeComponent();
            this.apiUrl = apiUrl;
            alertLabel.Visible = false;
        }

        private void createClientButton_Click(object sender, EventArgs e)
        {
            ClinicDesktopREST myClinic = new ClinicDesktopREST(apiUrl, new System.Net.Http.HttpClient());
            if (firstNameInputField.Text.Length!=0 && secondNameInputField.Text.Length != 0 && patronymicInputField.Text.Length != 0 && documentInputField.Text.Length != 0)
            {
                CreateClientRequest request = new CreateClientRequest();
                request.Birthday= dateTimePickerField.Value;
                request.Document = documentInputField.Text;
                request.SurName = secondNameInputField.Text;
                request.FirstName = firstNameInputField.Text;
                request.Patronymic= patronymicInputField.Text;
                int res = myClinic.CreateClientAsync(request).Result;
                alertLabel.Visible = false;
                this.Close();
            }
            else
            {
                alertLabel.Visible = true;
            }
        }

        private void cancelCreateClientButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
