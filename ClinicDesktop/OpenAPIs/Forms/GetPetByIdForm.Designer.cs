namespace ClinicDesktop.OpenAPIs.Forms
{
    partial class GetPetByIdForm
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
            this.petIdTextBox = new System.Windows.Forms.TextBox();
            this.getData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fioClientLabel = new System.Windows.Forms.Label();
            this.petBirthdayLabel = new System.Windows.Forms.Label();
            this.petNameLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PetId";
            // 
            // petIdTextBox
            // 
            this.petIdTextBox.Location = new System.Drawing.Point(77, 32);
            this.petIdTextBox.Name = "petIdTextBox";
            this.petIdTextBox.Size = new System.Drawing.Size(105, 20);
            this.petIdTextBox.TabIndex = 1;
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(214, 28);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(124, 32);
            this.getData.TabIndex = 2;
            this.getData.Text = "Получить данные";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кличка животного";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата рождения животного";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Фамилия Имя Отчество Владельца";
            // 
            // fioClientLabel
            // 
            this.fioClientLabel.AutoSize = true;
            this.fioClientLabel.Location = new System.Drawing.Point(326, 134);
            this.fioClientLabel.Name = "fioClientLabel";
            this.fioClientLabel.Size = new System.Drawing.Size(0, 13);
            this.fioClientLabel.TabIndex = 8;
            // 
            // petBirthdayLabel
            // 
            this.petBirthdayLabel.AutoSize = true;
            this.petBirthdayLabel.Location = new System.Drawing.Point(159, 134);
            this.petBirthdayLabel.Name = "petBirthdayLabel";
            this.petBirthdayLabel.Size = new System.Drawing.Size(0, 13);
            this.petBirthdayLabel.TabIndex = 7;
            // 
            // petNameLabel
            // 
            this.petNameLabel.AutoSize = true;
            this.petNameLabel.Location = new System.Drawing.Point(39, 134);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(0, 13);
            this.petNameLabel.TabIndex = 6;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(214, 268);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(124, 32);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // GetPetByIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 316);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.fioClientLabel);
            this.Controls.Add(this.petBirthdayLabel);
            this.Controls.Add(this.petNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.petIdTextBox);
            this.Controls.Add(this.label1);
            this.Name = "GetPetByIdForm";
            this.Text = "GetPetByIdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox petIdTextBox;
        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fioClientLabel;
        private System.Windows.Forms.Label petBirthdayLabel;
        private System.Windows.Forms.Label petNameLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}