namespace ClinicDesktop.OpenAPIs.Forms
{
    partial class CreatePetForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cancelCreatePetButton = new System.Windows.Forms.Button();
            this.createPetButton = new System.Windows.Forms.Button();
            this.createPetAllertLabel = new System.Windows.Forms.Label();
            this.petNameInputField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кличка";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(109, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Владелец";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата рождения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // cancelCreatePetButton
            // 
            this.cancelCreatePetButton.Location = new System.Drawing.Point(61, 322);
            this.cancelCreatePetButton.Name = "cancelCreatePetButton";
            this.cancelCreatePetButton.Size = new System.Drawing.Size(76, 53);
            this.cancelCreatePetButton.TabIndex = 7;
            this.cancelCreatePetButton.Text = "Отмена";
            this.cancelCreatePetButton.UseVisualStyleBackColor = true;
            this.cancelCreatePetButton.Click += new System.EventHandler(this.cancelCreatePetButton_Click);
            // 
            // createPetButton
            // 
            this.createPetButton.Location = new System.Drawing.Point(171, 322);
            this.createPetButton.Name = "createPetButton";
            this.createPetButton.Size = new System.Drawing.Size(76, 53);
            this.createPetButton.TabIndex = 8;
            this.createPetButton.Text = "Создать";
            this.createPetButton.UseVisualStyleBackColor = true;
            this.createPetButton.Click += new System.EventHandler(this.createPetButton_Click);
            // 
            // createPetAllertLabel
            // 
            this.createPetAllertLabel.AutoSize = true;
            this.createPetAllertLabel.ForeColor = System.Drawing.Color.Red;
            this.createPetAllertLabel.Location = new System.Drawing.Point(81, 235);
            this.createPetAllertLabel.Name = "createPetAllertLabel";
            this.createPetAllertLabel.Size = new System.Drawing.Size(109, 13);
            this.createPetAllertLabel.TabIndex = 9;
            this.createPetAllertLabel.Text = "Введите ВСЕ поля!!!";
            // 
            // petNameInputField
            // 
            this.petNameInputField.Location = new System.Drawing.Point(109, 62);
            this.petNameInputField.Name = "petNameInputField";
            this.petNameInputField.Size = new System.Drawing.Size(182, 20);
            this.petNameInputField.TabIndex = 10;
            // 
            // CreatePetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.petNameInputField);
            this.Controls.Add(this.createPetAllertLabel);
            this.Controls.Add(this.createPetButton);
            this.Controls.Add(this.cancelCreatePetButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(350, 450);
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "CreatePetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание питомца";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button cancelCreatePetButton;
        private System.Windows.Forms.Button createPetButton;
        private System.Windows.Forms.Label createPetAllertLabel;
        private System.Windows.Forms.TextBox petNameInputField;
    }
}