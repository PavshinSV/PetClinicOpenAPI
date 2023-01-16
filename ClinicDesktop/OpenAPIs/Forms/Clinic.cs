using ClinicDesktop.OpenAPIs.Forms;
using ClinicDesktopNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicDesktop
{
    public partial class Clinic : Form
    {
        private String apiUrl;
        private bool clientsActive = false;
        private bool petsActive = false;
        private bool consultationsActive = true;

        public Clinic(String apiUrl)
        {
            InitializeComponent();
            this.apiUrl = apiUrl;
            setActive("consultations");
        }


        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            viewActive();
        }

        private void viewActive()
        {
            if (clientsActive)
            {
                viewAllClients();
            }
            if (petsActive)
            {
                viewAllPets();
            }
            if (consultationsActive)
            {
                viewAllConsultations();
            }
        }

        private void viewAllConsultations()
        {
            ClinicDesktopREST myClinic = new ClinicDesktopREST(apiUrl, new System.Net.Http.HttpClient());
            consultationsViewer.Items.Clear();
            ICollection<Consultation> consultations = myClinic.GetAllConsultationsAsync().Result;
            foreach (Consultation consultation in consultations)
            {
                long clientId = consultation.ClientId;
                long petId = consultation.PetId;
                Client client = myClinic.GetClientByIdAsync((int)clientId).Result;
                Pet pet = myClinic.GetPetByIdAsync((int)petId).Result;
                ListViewItem item = new ListViewItem();
                item.Text = consultation.ConsultationId.ToString();
                item.SubItems.Add(client.SurName + " " + client.FirstName[0] + "." + client.Patronymic[0] + ".");
                item.SubItems.Add(pet.Name);
                item.SubItems.Add(consultation.ConsultationDate.ToString());
                item.SubItems.Add(consultation.Description);
                consultationsViewer.Items.Add(item);
            }
        }

        private void viewAllPets()
        {
            ClinicDesktopREST myClinic = new ClinicDesktopREST(apiUrl, new System.Net.Http.HttpClient());
            PetsViewer.Items.Clear();
            ICollection<Pet> pets = myClinic.GetAllPetsAsync().Result;
            foreach (Pet pet in pets)
            {
                long clientId = pet.ClientId;
                Client client = myClinic.GetClientByIdAsync((int)clientId).Result;
                ListViewItem item = new ListViewItem();
                item.Text = pet.PetId.ToString();
                item.SubItems.Add(pet.Name);
                item.SubItems.Add(client.SurName + " " + client.FirstName[0] + "." + client.Patronymic[0] + ".");
                item.SubItems.Add(pet.Birthday.ToString());
                PetsViewer.Items.Add(item);
            }
        }

        private void viewAllClients()
        {
            ClinicDesktopREST myClinic = new ClinicDesktopREST(apiUrl, new System.Net.Http.HttpClient());
            ClientsViewer.Items.Clear();
            ICollection<Client> clients = myClinic.GetAllClientsAsync().Result;
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();
                item.SubItems.Add(client.Document);
                item.SubItems.Add(client.SurName);
                item.SubItems.Add(client.FirstName);
                item.SubItems.Add(client.Patronymic);
                item.SubItems.Add(client.Birthday.ToString());
                ClientsViewer.Items.Add(item);
            }
        }

        private void setActive(String set)
        {
            switch(set)
            {
                case ("pets"):
                    clientsActive = false;
                    ClientsViewer.Visible = false;
                    
                    consultationsActive = false;
                    consultationsViewer.Visible = false;

                    petsActive = true;
                    PetsViewer.Visible = true;
                    activityLabel.Text = "Питомцы";
                    viewActive();
                    break;

                case ("clients"):
                    clientsActive = true;
                    ClientsViewer.Visible = true;
                    activityLabel.Text = "Клиенты";

                    consultationsActive = false;
                    consultationsViewer.Visible = false;

                    petsActive = false;
                    PetsViewer.Visible = false;
                    viewActive();
                    break;
                case ("consultations"):
                    clientsActive = false;
                    ClientsViewer.Visible = false;

                    consultationsActive = true;
                    consultationsViewer.Visible = true;
                    activityLabel.Text = "Консультации";

                    petsActive = false;
                    PetsViewer.Visible = false;
                    viewActive();
                    break;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (clientsActive)
            {
                updateClient();
            }
            if (petsActive)
            {
                updatePet();
            }
            if (consultationsActive)
            {
                updateConsultation();
            }
        }

        private void updateClient()
        {
            try
            {
                int clientId = getClientId();
                Form updateClientForm = new UpdateClientForm(apiUrl, clientId);
                updateClientForm.ShowDialog();
            }
            catch (Exception ex)
            {
                Form alert = new AlertForm();
                alert.ShowDialog();
            }
            viewActive();
        }

        private void updatePet()
        {
            try
            {
                int petId = getPetId();
                Form updatePetform = new UpdatePetForm(apiUrl, petId);
                updatePetform.ShowDialog();
            }
            catch (Exception ex)
            {
                Form alert = new AlertForm();
                alert.ShowDialog();
            }
            viewActive();
        }

        private void updateConsultation()
        {
            try
            {
                int consultationId = getConsultationId();
                Form updateConsultationForm = new UpdateConsultationForm(apiUrl,consultationId);
                updateConsultationForm.ShowDialog();
            }
            catch(Exception ex)
            {
                Form alert = new AlertForm();
                alert.ShowDialog();
            }
            viewActive();
        }

        private int getConsultationId()
        {
            string d;
            if (consultationsViewer.FocusedItem.Text == null)
            {
                throw new Exception("null");
            }
            else
            {
                d = consultationsViewer.FocusedItem.Text;
                return Int32.Parse(d);
            }
        }

        private int getClientId()
        {
            string d;
            if (ClientsViewer.FocusedItem.Text == null)
            {
                throw new Exception("null");
            }
            else
            {
                d = ClientsViewer.FocusedItem.Text;
                return Int32.Parse(d);
            }
        }

        private int getPetId()
        {
            string d;
            if (PetsViewer.FocusedItem.Text == null)
            {
                throw new Exception("null");
            }
            else
            {
                d = PetsViewer.FocusedItem.Text;
                return Int32.Parse(d);
            }
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            setActive("clients");
        }

        private void buttonPets_Click(object sender, EventArgs e)
        {
            setActive("pets");
        }

        private void buttonConsultations_Click(object sender, EventArgs e)
        {
            setActive("consultations");
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            createActive();
        }

        private void createActive()
        {
            if (clientsActive)
            {
                createClient();
            }
            if (petsActive)
            {
                createPet();
            }
            if (consultationsActive)
            {
                createConsultation();
            }
        }

        private void createConsultation()
        {
            CreateConsultattionForm createConsultationForm = new CreateConsultattionForm(apiUrl);
            createConsultationForm.ShowDialog();
            viewActive();
        }

        private void createPet()
        {
            CreatePetForm createPet = new CreatePetForm(apiUrl);
            createPet.ShowDialog();
            viewActive();
        }

        private void createClient()
        {
            CreateClientForm createClient = new CreateClientForm(apiUrl);
            createClient.ShowDialog();
            viewActive();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (clientsActive)
            {
                deleteClient();
            }
            if (petsActive)
            {
                deletePet();
            }
            if (consultationsActive)
            {
                deleteConsultation();
            }
        }

        private void deleteConsultation()
        {
            try
            {
                int consultationId = getConsultationId();
                Form deleteConsultationForm = new DeleteConsultationForm(apiUrl,consultationId);
                deleteConsultationForm.ShowDialog();
                viewActive();
            } catch
            {
                Form alert = new AlertForm();
                alert.ShowDialog();
            }

        }

        private void deleteClient()
        {
            try
            {
                int clientId = getClientId();
                Form deleteClientForm = new DeleteClientForm(apiUrl, clientId);
                deleteClientForm.ShowDialog();
                viewActive();
            }
            catch
            {
                Form alert = new AlertForm();
                alert.ShowDialog();
            }
        }

        private void deletePet()
        {
            try
            {
                int petId = getPetId();
                Form deletePetForm = new DeletePetForm(apiUrl, petId);
                deletePetForm.ShowDialog();
                viewActive();
            }
            catch
            {
                Form alert = new AlertForm();
                alert.ShowDialog();
            }
        }

        private void buttonGetById_Click(object sender, EventArgs e)
        {
            if (clientsActive)
            {
                getClientById();
            }
            if (petsActive)
            {
                getPetById();
            }
            if (consultationsActive)
            {
                getConsultationById();
            }
        }

        private void getConsultationById()
        {
            Form getConsultationByIdForm = new GetConsultationByIdForm(apiUrl);
            getConsultationByIdForm.ShowDialog();
        }

        private void getPetById()
        {
            Form getPetByIdForm = new GetPetByIdForm(apiUrl);
            getPetByIdForm.ShowDialog();
        }

        private void getClientById()
        {
            Form getClientByIdForm = new GetClientByIdForm(apiUrl);
            getClientByIdForm.ShowDialog();
        }
    }
}
