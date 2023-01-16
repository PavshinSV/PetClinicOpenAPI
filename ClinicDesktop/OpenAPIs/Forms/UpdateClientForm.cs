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
    public partial class UpdateClientForm : Form
    {
        ClinicDesktopREST myClinic;
        Client client;
        public UpdateClientForm(string apiUrl, int id)
        {
            myClinic = new ClinicDesktopREST(apiUrl, new System.Net.Http.HttpClient());
            client = myClinic.GetClientByIdAsync(id).Result;
            InitializeComponent();
            currentClientIdLabel.Text = client.ClientId.ToString();
            newSurnameClientTextBox.Text = client.SurName;
            newNameClientTextBox.Text = client.FirstName;
            newPatronymicClientTextBox.Text = client.Patronymic;
            newDocumentTextBox.Text = client.Document;
            newBirthdayClientDatePicker.Text = client.Birthday.ToString();
        }

        private void cancelClientUpdateButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptUpdateClientButton_Click(object sender, EventArgs e)
        {
            UpdateClientRequest request = new UpdateClientRequest();
            request.ClientId = client.ClientId;
            request.SurName = newSurnameClientTextBox.Text;
            request.FirstName = newNameClientTextBox.Text;
            request.Patronymic = newPatronymicClientTextBox.Text;
            request.Document = newDocumentTextBox.Text;
            request.Birthday = newBirthdayClientDatePicker.Value;
            myClinic.UpdateClientAsync(request).Wait();
            this.Close();
        }
    }
}
