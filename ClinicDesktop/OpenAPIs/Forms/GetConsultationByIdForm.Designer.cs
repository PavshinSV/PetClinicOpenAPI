namespace ClinicDesktop.OpenAPIs.Forms
{
    partial class GetConsultationByIdForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.getData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.consultationDate = new System.Windows.Forms.Label();
            this.petName = new System.Windows.Forms.Label();
            this.fioClient = new System.Windows.Forms.Label();
            this.closeFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ConsultationId";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 1;
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(312, 15);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(152, 26);
            this.getData.TabIndex = 2;
            this.getData.Text = "Получить данные";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия Имя Отчество Клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кличка Питомца";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дата консультации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Описание";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(575, 102);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(0, 13);
            this.description.TabIndex = 10;
            // 
            // consultationDate
            // 
            this.consultationDate.AutoSize = true;
            this.consultationDate.Location = new System.Drawing.Point(417, 102);
            this.consultationDate.Name = "consultationDate";
            this.consultationDate.Size = new System.Drawing.Size(0, 13);
            this.consultationDate.TabIndex = 9;
            // 
            // petName
            // 
            this.petName.AutoSize = true;
            this.petName.Location = new System.Drawing.Point(264, 102);
            this.petName.Name = "petName";
            this.petName.Size = new System.Drawing.Size(0, 13);
            this.petName.TabIndex = 8;
            // 
            // fioClient
            // 
            this.fioClient.AutoSize = true;
            this.fioClient.Location = new System.Drawing.Point(39, 102);
            this.fioClient.Name = "fioClient";
            this.fioClient.Size = new System.Drawing.Size(0, 13);
            this.fioClient.TabIndex = 7;
            // 
            // closeFormButton
            // 
            this.closeFormButton.Location = new System.Drawing.Point(329, 176);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(202, 48);
            this.closeFormButton.TabIndex = 11;
            this.closeFormButton.Text = "Закрыть форму";
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.closeFormButton_Click);
            // 
            // GetConsultationByIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 240);
            this.Controls.Add(this.closeFormButton);
            this.Controls.Add(this.description);
            this.Controls.Add(this.consultationDate);
            this.Controls.Add(this.petName);
            this.Controls.Add(this.fioClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "GetConsultationByIdForm";
            this.Text = "GetConsultationByIdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label consultationDate;
        private System.Windows.Forms.Label petName;
        private System.Windows.Forms.Label fioClient;
        private System.Windows.Forms.Button closeFormButton;
    }
}