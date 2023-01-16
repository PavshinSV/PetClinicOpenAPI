namespace ClinicDesktop
{
    partial class Clinic
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGetById = new System.Windows.Forms.Button();
            this.buttonGetAll = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonConsultations = new System.Windows.Forms.Button();
            this.buttonPets = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.ClientsViewer = new System.Windows.Forms.ListView();
            this.clientId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.document = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patronymic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.activityLabel = new System.Windows.Forms.Label();
            this.PetsViewer = new System.Windows.Forms.ListView();
            this.petId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.petName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.petBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.consultationsViewer = new System.Windows.Forms.ListView();
            this.consultationId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.consultationClientNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.consultationPetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.consultationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.consultationDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.buttonGetById);
            this.panel1.Controls.Add(this.buttonGetAll);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 105);
            this.panel1.TabIndex = 0;
            // 
            // buttonGetById
            // 
            this.buttonGetById.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonGetById.Location = new System.Drawing.Point(650, 30);
            this.buttonGetById.Name = "buttonGetById";
            this.buttonGetById.Size = new System.Drawing.Size(100, 46);
            this.buttonGetById.TabIndex = 7;
            this.buttonGetById.Text = "ПОЛУЧИТЬ ПО Id";
            this.buttonGetById.UseVisualStyleBackColor = false;
            // 
            // buttonGetAll
            // 
            this.buttonGetAll.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonGetAll.Location = new System.Drawing.Point(500, 30);
            this.buttonGetAll.Name = "buttonGetAll";
            this.buttonGetAll.Size = new System.Drawing.Size(100, 46);
            this.buttonGetAll.TabIndex = 6;
            this.buttonGetAll.Text = "ОБНОВИТЬ СПИСОК";
            this.buttonGetAll.UseVisualStyleBackColor = false;
            this.buttonGetAll.Click += new System.EventHandler(this.buttonGetAll_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDelete.Location = new System.Drawing.Point(350, 30);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 46);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "УДАЛИТЬ";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonUpdate.Location = new System.Drawing.Point(200, 30);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 46);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "ИЗМЕНИТЬ ЗАПИСЬ";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCreate.Location = new System.Drawing.Point(50, 30);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 46);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "СОЗДАТЬ";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.buttonConsultations);
            this.panel2.Controls.Add(this.buttonPets);
            this.panel2.Controls.Add(this.buttonClients);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 456);
            this.panel2.TabIndex = 1;
            // 
            // buttonConsultations
            // 
            this.buttonConsultations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConsultations.Location = new System.Drawing.Point(26, 170);
            this.buttonConsultations.Name = "buttonConsultations";
            this.buttonConsultations.Size = new System.Drawing.Size(90, 45);
            this.buttonConsultations.TabIndex = 2;
            this.buttonConsultations.Text = "Консультации";
            this.buttonConsultations.UseVisualStyleBackColor = true;
            this.buttonConsultations.Click += new System.EventHandler(this.buttonConsultations_Click);
            // 
            // buttonPets
            // 
            this.buttonPets.Location = new System.Drawing.Point(26, 100);
            this.buttonPets.Name = "buttonPets";
            this.buttonPets.Size = new System.Drawing.Size(90, 45);
            this.buttonPets.TabIndex = 1;
            this.buttonPets.Text = "Животные";
            this.buttonPets.UseVisualStyleBackColor = true;
            this.buttonPets.Click += new System.EventHandler(this.buttonPets_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Location = new System.Drawing.Point(26, 30);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(90, 45);
            this.buttonClients.TabIndex = 0;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // ClientsViewer
            // 
            this.ClientsViewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clientId,
            this.document,
            this.surName,
            this.firstName,
            this.patronymic,
            this.birthday});
            this.ClientsViewer.FullRowSelect = true;
            this.ClientsViewer.GridLines = true;
            this.ClientsViewer.HideSelection = false;
            this.ClientsViewer.Location = new System.Drawing.Point(138, 36);
            this.ClientsViewer.MultiSelect = false;
            this.ClientsViewer.Name = "ClientsViewer";
            this.ClientsViewer.Size = new System.Drawing.Size(646, 420);
            this.ClientsViewer.TabIndex = 2;
            this.ClientsViewer.UseCompatibleStateImageBehavior = false;
            this.ClientsViewer.View = System.Windows.Forms.View.Details;
            // 
            // clientId
            // 
            this.clientId.Text = "№";
            this.clientId.Width = 33;
            // 
            // document
            // 
            this.document.Text = "Документ";
            this.document.Width = 126;
            // 
            // surName
            // 
            this.surName.Text = "Фамилия";
            this.surName.Width = 128;
            // 
            // firstName
            // 
            this.firstName.Text = "Имя";
            this.firstName.Width = 114;
            // 
            // patronymic
            // 
            this.patronymic.Text = "Отчество";
            this.patronymic.Width = 141;
            // 
            // birthday
            // 
            this.birthday.Text = "Дата рождения";
            this.birthday.Width = 99;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.activityLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(138, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 39);
            this.panel3.TabIndex = 3;
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activityLabel.Location = new System.Drawing.Point(278, 9);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(60, 24);
            this.activityLabel.TabIndex = 0;
            this.activityLabel.Text = "label1";
            this.activityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PetsViewer
            // 
            this.PetsViewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.petId,
            this.petName,
            this.clientNames,
            this.petBirthday});
            this.PetsViewer.FullRowSelect = true;
            this.PetsViewer.GridLines = true;
            this.PetsViewer.HideSelection = false;
            this.PetsViewer.Location = new System.Drawing.Point(138, 36);
            this.PetsViewer.MultiSelect = false;
            this.PetsViewer.Name = "PetsViewer";
            this.PetsViewer.Size = new System.Drawing.Size(646, 420);
            this.PetsViewer.TabIndex = 4;
            this.PetsViewer.UseCompatibleStateImageBehavior = false;
            this.PetsViewer.View = System.Windows.Forms.View.Details;
            // 
            // petId
            // 
            this.petId.Text = "№";
            this.petId.Width = 47;
            // 
            // petName
            // 
            this.petName.Text = "Кличка";
            this.petName.Width = 149;
            // 
            // clientNames
            // 
            this.clientNames.Text = "ФИО Владельца";
            this.clientNames.Width = 194;
            // 
            // petBirthday
            // 
            this.petBirthday.Text = "Дата рождения питомца";
            this.petBirthday.Width = 251;
            // 
            // consultationsViewer
            // 
            this.consultationsViewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.consultationId,
            this.consultationClientNames,
            this.consultationPetName,
            this.consultationDate,
            this.consultationDescription});
            this.consultationsViewer.FullRowSelect = true;
            this.consultationsViewer.GridLines = true;
            this.consultationsViewer.HideSelection = false;
            this.consultationsViewer.Location = new System.Drawing.Point(138, 38);
            this.consultationsViewer.MultiSelect = false;
            this.consultationsViewer.Name = "consultationsViewer";
            this.consultationsViewer.Size = new System.Drawing.Size(646, 418);
            this.consultationsViewer.TabIndex = 5;
            this.consultationsViewer.UseCompatibleStateImageBehavior = false;
            this.consultationsViewer.View = System.Windows.Forms.View.Details;
            // 
            // consultationId
            // 
            this.consultationId.Text = "№";
            this.consultationId.Width = 41;
            // 
            // consultationClientNames
            // 
            this.consultationClientNames.Text = "ФИО Клиента";
            this.consultationClientNames.Width = 165;
            // 
            // consultationPetName
            // 
            this.consultationPetName.Text = "Кличка";
            this.consultationPetName.Width = 112;
            // 
            // consultationDate
            // 
            this.consultationDate.Text = "Дата консультации";
            this.consultationDate.Width = 119;
            // 
            // consultationDescription
            // 
            this.consultationDescription.Text = "Описание";
            this.consultationDescription.Width = 203;
            // 
            // Clinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.consultationsViewer);
            this.Controls.Add(this.PetsViewer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ClientsViewer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Clinic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clinic";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonConsultations;
        private System.Windows.Forms.Button buttonPets;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonGetById;
        private System.Windows.Forms.Button buttonGetAll;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListView ClientsViewer;
        private System.Windows.Forms.ColumnHeader clientId;
        private System.Windows.Forms.ColumnHeader document;
        private System.Windows.Forms.ColumnHeader surName;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader patronymic;
        private System.Windows.Forms.ColumnHeader birthday;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label activityLabel;
        private System.Windows.Forms.ListView PetsViewer;
        private System.Windows.Forms.ColumnHeader petId;
        private System.Windows.Forms.ColumnHeader petName;
        private System.Windows.Forms.ColumnHeader clientNames;
        private System.Windows.Forms.ColumnHeader petBirthday;
        private System.Windows.Forms.ListView consultationsViewer;
        private System.Windows.Forms.ColumnHeader consultationId;
        private System.Windows.Forms.ColumnHeader consultationClientNames;
        private System.Windows.Forms.ColumnHeader consultationPetName;
        private System.Windows.Forms.ColumnHeader consultationDate;
        private System.Windows.Forms.ColumnHeader consultationDescription;
    }
}

