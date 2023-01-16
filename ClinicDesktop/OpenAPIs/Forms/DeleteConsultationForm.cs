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
    public partial class DeleteConsultationForm : Form
    {
        int consultationId;
        ClinicDesktopREST myClinic;

        public DeleteConsultationForm(string apiUrl, int id)
        {
            consultationId = id;
            myClinic = new ClinicDesktopREST(apiUrl, new System.Net.Http.HttpClient());
            InitializeComponent();
            Consultation consultation= myClinic.GetConsultationByIdAsync(consultationId).Result;
            Client client = myClinic.GetClientByIdAsync(consultation.ClientId).Result;
            Pet pet = myClinic.GetPetByIdAsync(consultation.PetId).Result;
            consultationIdLabel.Text = consultation.ConsultationId.ToString();
            clientNameLabel.Text = client.SurName + " " + client.FirstName + " " + client.Patronymic;
            petNameLabel.Text = pet.Name;
            dateConsultationLabel.Text = consultation.ConsultationDate.ToString(); ;
            descriptionLabel.Text = consultation.Description;
        }

        private void cancelDeletConsultationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptDeleteConsultationButton_Click(object sender, EventArgs e)
        {
            myClinic.DeleteConsultationAsync(consultationId);
            this.Close();
        }
    }
}
