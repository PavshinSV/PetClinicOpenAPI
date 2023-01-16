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
    public partial class GetConsultationByIdForm : Form
    {
        ClinicDesktopREST myClinic;
        public GetConsultationByIdForm(string apiUrl)
        {
            myClinic = new ClinicDesktopREST(apiUrl, new System.Net.Http.HttpClient());
            InitializeComponent();
        }

        private void closeFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getData_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                int id = Int32.Parse(textBox1.Text);
                try
                {
                    Consultation consultation = myClinic.GetConsultationByIdAsync(id).Result;
                    Pet pet = myClinic.GetPetByIdAsync(consultation.PetId).Result;
                    Client client = myClinic.GetClientByIdAsync(consultation.ClientId).Result;
                    fioClient.Text = client.SurName + " " + client.FirstName + " " + client.Patronymic;
                    petName.Text = pet.Name;
                    consultationDate.Text = consultation.ConsultationDate.ToString();
                    description.Text = consultation.Description;

                }
                catch (Exception)
                {
                    AlertForm alert = new AlertForm("Запись с указанным индексом отсутствует");
                    alert.ShowDialog();
                }
            }
        }
    }
}
