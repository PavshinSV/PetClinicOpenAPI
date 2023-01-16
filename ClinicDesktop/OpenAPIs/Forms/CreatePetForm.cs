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
    public partial class CreatePetForm : Form
    {
        private ClinicDesktopREST myClinic;

        public CreatePetForm(string apiUrl)
        {
            InitializeComponent();
            this.myClinic = new ClinicDesktopREST(apiUrl, new System.Net.Http.HttpClient());
            createPetAllertLabel.Visible= false;
            ICollection<Client> clients = myClinic.GetAllClientsAsync().Result;
            foreach (Client client in clients)
            {
                string[] item = new string[2];
                item[0] = client.SurName + " " + client.FirstName[0] + ". " + client.Patronymic[0] + ".";
                item[1]= client.ClientId.ToString();
                comboBox1.Items.Add(item[0]+"; ClientId:" + item[1]);
            }
        }

        private void createPetButton_Click(object sender, EventArgs e)
        {
            
            if (petNameInputField.Text.Length != 0 && comboBox1.Text.Length != 0) 
            {
                int indexId = comboBox1.Text.IndexOf(':')+1;
                createPetAllertLabel.Visible = false;
                CreatePetRequest request = new CreatePetRequest()
                {
                    Name = petNameInputField.Text,
                    Birthday = dateTimePicker1.Value,
                    ClientId = Int32.Parse(comboBox1.Text.Substring(indexId))
                };
                myClinic.CreatePetAsync(request).Wait();
                this.Close();
            }
            else
            {
                createPetAllertLabel.Visible = true;
            }
        }

        private void cancelCreatePetButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
