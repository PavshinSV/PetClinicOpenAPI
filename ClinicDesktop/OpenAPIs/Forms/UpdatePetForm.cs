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
    public partial class UpdatePetForm : Form
    {
        ClinicDesktopREST myClinic;
        int petId;
        public UpdatePetForm(string apiUrl, int id)
        {
            myClinic = new ClinicDesktopREST(apiUrl, new System.Net.Http.HttpClient());
            Pet pet = myClinic.GetPetByIdAsync(id).Result;
            InitializeComponent();
            currentPetId.Text = petId.ToString();
            ICollection<Client> clients = myClinic.GetAllClientsAsync().Result;
            Client currentClient = null;
            foreach (Client client in clients)
            {
                if (client.ClientId==pet.ClientId)
                {
                    currentClient = client;
                }
                newClientBox.Items.Add(client.SurName+" "+client.FirstName+" "+client.Patronymic+"; ClientId: "+client.ClientId);
            }
            currentClientName.Text = currentClient.SurName + " "+currentClient.FirstName+" "+currentClient.Patronymic+"; ClientId: " + currentClient.ClientId;
            newClientBox.Text = currentClientName.Text;
            currentPetName.Text = pet.Name;
            newPetNameBox.Text = currentPetName.Text;
            currentPetBirthday.Text=pet.Birthday.ToString();
            newDatetimePicker.Text=currentPetBirthday.Text;
        }

        private void cancelUpdatePetButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptUpdatePetButton_Click(object sender, EventArgs e)
        {
            UpdatePetRequest request= new UpdatePetRequest();
            request.PetId = petId;
            request.Name = newPetNameBox.Text;
            request.Birthday = newDatetimePicker.Value;
            string clientString = newClientBox.Text;
            int indexStart = clientString.IndexOf(":") + 2;
            request.ClientId = Int32.Parse(clientString.Substring(indexStart));
            myClinic.UpdatePetAsync(request).Wait();
            this.Close();
        }
    }
}
