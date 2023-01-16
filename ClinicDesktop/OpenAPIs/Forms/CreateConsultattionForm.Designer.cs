namespace ClinicDesktop.OpenAPIs.Forms
{
    partial class CreateConsultattionForm
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
            this.cancelCreateConsultationButton = new System.Windows.Forms.Button();
            this.createConsultationButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.consultationDateTimeField = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionInputField = new System.Windows.Forms.TextBox();
            this.createConsultateionAlert = new System.Windows.Forms.Label();
            this.selectPetBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelCreateConsultationButton
            // 
            this.cancelCreateConsultationButton.Location = new System.Drawing.Point(72, 322);
            this.cancelCreateConsultationButton.Name = "cancelCreateConsultationButton";
            this.cancelCreateConsultationButton.Size = new System.Drawing.Size(76, 53);
            this.cancelCreateConsultationButton.TabIndex = 0;
            this.cancelCreateConsultationButton.Text = "Отмена";
            this.cancelCreateConsultationButton.UseVisualStyleBackColor = true;
            this.cancelCreateConsultationButton.Click += new System.EventHandler(this.cancelCreateConsultationButton_Click);
            // 
            // createConsultationButton
            // 
            this.createConsultationButton.Location = new System.Drawing.Point(179, 322);
            this.createConsultationButton.Name = "createConsultationButton";
            this.createConsultationButton.Size = new System.Drawing.Size(76, 53);
            this.createConsultationButton.TabIndex = 0;
            this.createConsultationButton.Text = "Создать";
            this.createConsultationButton.UseVisualStyleBackColor = true;
            this.createConsultationButton.Click += new System.EventHandler(this.createConsultationButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Питомец";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата посещения";
            // 
            // consultationDateTimeField
            // 
            this.consultationDateTimeField.Location = new System.Drawing.Point(149, 89);
            this.consultationDateTimeField.Name = "consultationDateTimeField";
            this.consultationDateTimeField.Size = new System.Drawing.Size(125, 20);
            this.consultationDateTimeField.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Причина посещения, симптомы";
            // 
            // descriptionInputField
            // 
            this.descriptionInputField.Location = new System.Drawing.Point(49, 160);
            this.descriptionInputField.Multiline = true;
            this.descriptionInputField.Name = "descriptionInputField";
            this.descriptionInputField.Size = new System.Drawing.Size(225, 124);
            this.descriptionInputField.TabIndex = 10;
            // 
            // createConsultateionAlert
            // 
            this.createConsultateionAlert.AutoSize = true;
            this.createConsultateionAlert.ForeColor = System.Drawing.Color.Red;
            this.createConsultateionAlert.Location = new System.Drawing.Point(86, 295);
            this.createConsultateionAlert.Name = "createConsultateionAlert";
            this.createConsultateionAlert.Size = new System.Drawing.Size(109, 13);
            this.createConsultateionAlert.TabIndex = 11;
            this.createConsultateionAlert.Text = "Введите ВСЕ поля!!!";
            // 
            // selectPetBox
            // 
            this.selectPetBox.FormattingEnabled = true;
            this.selectPetBox.Location = new System.Drawing.Point(108, 55);
            this.selectPetBox.Name = "selectPetBox";
            this.selectPetBox.Size = new System.Drawing.Size(166, 21);
            this.selectPetBox.TabIndex = 13;
            // 
            // CreateConsultattionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.selectPetBox);
            this.Controls.Add(this.createConsultateionAlert);
            this.Controls.Add(this.descriptionInputField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.consultationDateTimeField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createConsultationButton);
            this.Controls.Add(this.cancelCreateConsultationButton);
            this.MaximumSize = new System.Drawing.Size(350, 450);
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "CreateConsultattionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateConsultattionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelCreateConsultationButton;
        private System.Windows.Forms.Button createConsultationButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker consultationDateTimeField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionInputField;
        private System.Windows.Forms.Label createConsultateionAlert;
        private System.Windows.Forms.ComboBox selectPetBox;
    }
}