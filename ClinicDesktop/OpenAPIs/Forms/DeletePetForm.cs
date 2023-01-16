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
    public partial class DeletePetForm : Form
    {
        ClinicDesktopREST myClinic;
        Pet pet;
        public DeletePetForm(string apiUrl, int petId)
        {
            myClinic = new ClinicDesktopREST(apiUrl, new System.Net.Http.HttpClient());
            pet = myClinic.GetPetByIdAsync(petId).Result;
            Client client = myClinic.GetClientByIdAsync(pet.ClientId).Result;
            InitializeComponent();
            deletingPetIdLabel.Text = petId.ToString();
            deletingPetNameLabel.Text = pet.Name;
            deletingPetClientNameLabel.Text = client.SurName + " " + client.FirstName[0] + ". " + client.Patronymic[0] + ".";
            deletingPetBirthdayLabel.Text = pet.Birthday.ToString();
        }

        private void cancelDeletePetButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptDeletePetButton_Click(object sender, EventArgs e)
        {
            ICollection<Consultation> consultations = myClinic.GetAllConsultationsAsync().Result;
            foreach (Consultation consultation in consultations) 
            {
                if (consultation.PetId == pet.PetId)
                {
                    myClinic.DeleteConsultationAsync(consultation.ConsultationId);
                }
            }
            myClinic.DeletePetAsync(pet.PetId).Wait();
            this.Close();
        }
    }
}
