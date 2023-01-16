using ClinicDesktopNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicDesktop.OpenAPIs.Forms
{
    public partial class GetClientByIdForm : Form
    {
        ClinicDesktopREST myClinic;
        public GetClientByIdForm(string apiUrl)
        {
            myClinic = new ClinicDesktopREST(apiUrl, new System.Net.Http.HttpClient());
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            if (clientIdBox.Text.Length != 0)
            {
                try
                {
                    int id = int.Parse(clientIdBox.Text);
                    Client client = myClinic.GetClientByIdAsync(id).Result;
                    surNameLabel.Text = client.SurName;
                    firstNameLabel.Text = client.FirstName;
                    patronymicLabel.Text = client.Patronymic;
                    documentLabel.Text = client.Document;
                    birthdayLabel.Text = client.Birthday.ToString();

                }catch(Exception) 
                {
                    string str = "Запись с таким номером отсутствует!";
                    AlertForm alert = new AlertForm(str);
                    alert.ShowDialog();
                }
            }
        }
    }
}
