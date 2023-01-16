namespace ClinicDesktop.OpenAPIs.Forms
{
    partial class DeleteConsultationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.consultationIdLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.dateConsultationLabel = new System.Windows.Forms.Label();
            this.petNameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.cancelDeletConsultationButton = new System.Windows.Forms.Button();
            this.acceptDeleteConsultationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "№";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Клиент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Питомец";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата приема";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Описание";
            // 
            // consultationIdLabel
            // 
            this.consultationIdLabel.AutoSize = true;
            this.consultationIdLabel.Location = new System.Drawing.Point(103, 42);
            this.consultationIdLabel.Name = "consultationIdLabel";
            this.consultationIdLabel.Size = new System.Drawing.Size(43, 13);
            this.consultationIdLabel.TabIndex = 5;
            this.consultationIdLabel.Text = "Клиент";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(103, 82);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(43, 13);
            this.clientNameLabel.TabIndex = 6;
            this.clientNameLabel.Text = "Клиент";
            // 
            // dateConsultationLabel
            // 
            this.dateConsultationLabel.AutoSize = true;
            this.dateConsultationLabel.Location = new System.Drawing.Point(103, 157);
            this.dateConsultationLabel.Name = "dateConsultationLabel";
            this.dateConsultationLabel.Size = new System.Drawing.Size(43, 13);
            this.dateConsultationLabel.TabIndex = 8;
            this.dateConsultationLabel.Text = "Клиент";
            // 
            // petNameLabel
            // 
            this.petNameLabel.AutoSize = true;
            this.petNameLabel.Location = new System.Drawing.Point(103, 117);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(43, 13);
            this.petNameLabel.TabIndex = 7;
            this.petNameLabel.Text = "Клиент";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(103, 190);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(43, 13);
            this.descriptionLabel.TabIndex = 9;
            this.descriptionLabel.Text = "Клиент";
            // 
            // cancelDeletConsultationButton
            // 
            this.cancelDeletConsultationButton.Location = new System.Drawing.Point(42, 287);
            this.cancelDeletConsultationButton.Name = "cancelDeletConsultationButton";
            this.cancelDeletConsultationButton.Size = new System.Drawing.Size(87, 39);
            this.cancelDeletConsultationButton.TabIndex = 10;
            this.cancelDeletConsultationButton.Text = "Отмена";
            this.cancelDeletConsultationButton.UseVisualStyleBackColor = true;
            this.cancelDeletConsultationButton.Click += new System.EventHandler(this.cancelDeletConsultationButton_Click);
            // 
            // acceptDeleteConsultationButton
            // 
            this.acceptDeleteConsultationButton.Location = new System.Drawing.Point(170, 287);
            this.acceptDeleteConsultationButton.Name = "acceptDeleteConsultationButton";
            this.acceptDeleteConsultationButton.Size = new System.Drawing.Size(87, 39);
            this.acceptDeleteConsultationButton.TabIndex = 11;
            this.acceptDeleteConsultationButton.Text = "Удалить";
            this.acceptDeleteConsultationButton.UseVisualStyleBackColor = true;
            this.acceptDeleteConsultationButton.Click += new System.EventHandler(this.acceptDeleteConsultationButton_Click);
            // 
            // DeleteConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 352);
            this.Controls.Add(this.acceptDeleteConsultationButton);
            this.Controls.Add(this.cancelDeletConsultationButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.dateConsultationLabel);
            this.Controls.Add(this.petNameLabel);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.consultationIdLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteConsultationForm";
            this.Text = "DeleteConsultationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label consultationIdLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Label dateConsultationLabel;
        private System.Windows.Forms.Label petNameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button cancelDeletConsultationButton;
        private System.Windows.Forms.Button acceptDeleteConsultationButton;
    }
}