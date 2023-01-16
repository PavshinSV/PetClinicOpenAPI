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
    public partial class GetPetByIdForm : Form
    {
        ClinicDesktopREST myClinic;
        public GetPetByIdForm(string apiUrl)
        {
            myClinic = new ClinicDesktopREST(apiUrl, new System.Net.Http.HttpClient());
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getData_Click(object sender, EventArgs e)
        {
            if (petIdTextBox.Text.Length != 0)
            {
                try
                {
                    Pet pet = myClinic.GetPetByIdAsync(Int32.Parse(petIdTextBox.Text)).Result;
                    Client client = myClinic.GetClientByIdAsync(pet.ClientId).Result;
                    petNameLabel.Text = pet.Name;
                    petBirthdayLabel.Text = pet.Birthday.ToString();
                    fioClientLabel.Text = client.SurName + " " + client.FirstName + " " + client.Patronymic;
                } catch(Exception)
                {
                    string str = "Запись с указанным номером отсутствует";
                    AlertForm alert = new AlertForm(str);
                    alert.ShowDialog();
                }
            }
        }
    }
}
