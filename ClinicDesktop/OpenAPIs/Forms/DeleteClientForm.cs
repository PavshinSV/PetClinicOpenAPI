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
    public partial class DeleteClientForm : Form
    {
        ClinicDesktopREST myClinic;
        Client client;
        public DeleteClientForm(string apiUrl,int clientId)
        {
            myClinic = new ClinicDesktopREST(apiUrl, new System.Net.Http.HttpClient());
            client = myClinic.GetClientByIdAsync(clientId).Result;
            InitializeComponent();
            deletingClientId.Text = client.ClientId.ToString();
            deletingSurname.Text = client.SurName;
            deletingFirstname.Text = client.FirstName;
            deletingPatronymic.Text = client.Patronymic;
            deletingDocument.Text = client.Document;
            deletingData.Text = client.Birthday.ToString();
        }

        private void cancelDeleteClientButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myClinic.DeleteClientAsync(client.ClientId);
            this.Close();
        }
    }
}
