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
    public partial class CreateConsultattionForm : Form
    {
        ClinicDesktopREST myClinic;
        public CreateConsultattionForm(string apiUrl)
        {
            myClinic = new ClinicDesktopREST(apiUrl, new System.Net.Http.HttpClient());
            InitializeComponent();
            createConsultateionAlert.Visible= false;
            ICollection<Pet> pets = myClinic.GetAllPetsAsync().Result;
            foreach (Pet pet in pets)
            {
                selectPetBox.Items.Add(pet.Name+"; PetId: "+pet.PetId);
            }
        }

        private void cancelCreateConsultationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createConsultationButton_Click(object sender, EventArgs e)
        {
            if (selectPetBox.Text.Length!=0 && descriptionInputField.Text.Length!=0)
            {
                createConsultateionAlert.Visible = false;
                int indexStart = selectPetBox.Text.IndexOf(':')+2;
                int PetId = Int32.Parse(selectPetBox.Text.Substring(indexStart));
                Pet pet = myClinic.GetPetByIdAsync(PetId).Result;
                CreateConsultationRequest request = new CreateConsultationRequest();
                request.PetId = PetId;
                request.Description = descriptionInputField.Text;
                request.ClientId = pet.ClientId;
                request.ConsultationDate= consultationDateTimeField.Value;
                myClinic.CreateConsultationAsync(request).Wait();
                this.Close();
            }
            else
            {
                createConsultateionAlert.Visible = true;
            }
        }
    }
}
