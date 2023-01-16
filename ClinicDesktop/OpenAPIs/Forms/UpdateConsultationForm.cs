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
    public partial class UpdateConsultationForm : Form
    {
        private ClinicDesktopREST myClinic;
        Consultation consultation;
        public UpdateConsultationForm(string apiUrl, int consultationId)
        {
            myClinic = new ClinicDesktopREST(apiUrl, new System.Net.Http.HttpClient());
            InitializeComponent();
            consultation = myClinic.GetConsultationByIdAsync(consultationId).Result;
            Client client= myClinic.GetClientByIdAsync(consultation.ClientId).Result;
            Pet currentPet = myClinic.GetPetByIdAsync(consultation.PetId).Result;
            consultationIdLabel.Text = consultationId.ToString();
            clientIdLabel.Text = client.SurName + " " + client.FirstName + " " + client.Patronymic;
            petNameLabel.Text = currentPet.Name;
            datetimeLabel.Text = consultation.ConsultationDate.ToString();
            discriptionLabel.Text = consultation.Description;
            ICollection<Pet> pets = myClinic.GetAllPetsAsync().Result;
            foreach (Pet pet in pets)
            {
                petComboBox.Items.Add(pet.Name+"; PetId: "+pet.PetId);
            }
            string currentPetString = currentPet.Name + "; PetId: " + currentPet.PetId;
            petComboBox.Text = currentPetString;
            textBox1.Text = consultation.Description;
        }

        private void cancelUpdateConsultationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptUpdateConsultationButton_Click(object sender, EventArgs e)
        {
            int indexStart = petComboBox.Text.IndexOf(":") + 2;
            int newPetId = Int32.Parse(petComboBox.Text.Substring(indexStart));
            Pet newPet = myClinic.GetPetByIdAsync(newPetId).Result;
            Client newClient = myClinic.GetClientByIdAsync(newPet.ClientId).Result;
            UpdateConsultationRequest request = new UpdateConsultationRequest();
            request.ConsultationId = consultation.ConsultationId;
            request.ClientId = newClient.ClientId;
            request.PetId= newPetId;
            request.ConsultationDate = dateTimePicker1.Value;
            request.Description = textBox1.Text;
            myClinic.UpdateConsultationAsync(request).Wait();
            this.Close();
        }
    }
}
