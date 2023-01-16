namespace ClinicDesktop.OpenAPIs.Forms
{
    partial class DeletePetForm
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
            this.cancelDeletePetButton = new System.Windows.Forms.Button();
            this.acceptDeletePetButton = new System.Windows.Forms.Button();
            this.deletingPetBirthdayLabel = new System.Windows.Forms.Label();
            this.deletingPetClientNameLabel = new System.Windows.Forms.Label();
            this.deletingPetNameLabel = new System.Windows.Forms.Label();
            this.deletingPetIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "№";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кличка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ФИО Клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата рождения питомца";
            // 
            // cancelDeletePetButton
            // 
            this.cancelDeletePetButton.Location = new System.Drawing.Point(43, 237);
            this.cancelDeletePetButton.Name = "cancelDeletePetButton";
            this.cancelDeletePetButton.Size = new System.Drawing.Size(112, 49);
            this.cancelDeletePetButton.TabIndex = 4;
            this.cancelDeletePetButton.Text = "Отмена";
            this.cancelDeletePetButton.UseVisualStyleBackColor = true;
            this.cancelDeletePetButton.Click += new System.EventHandler(this.cancelDeletePetButton_Click);
            // 
            // acceptDeletePetButton
            // 
            this.acceptDeletePetButton.Location = new System.Drawing.Point(191, 237);
            this.acceptDeletePetButton.Name = "acceptDeletePetButton";
            this.acceptDeletePetButton.Size = new System.Drawing.Size(112, 49);
            this.acceptDeletePetButton.TabIndex = 5;
            this.acceptDeletePetButton.Text = "Удалить";
            this.acceptDeletePetButton.UseVisualStyleBackColor = true;
            this.acceptDeletePetButton.Click += new System.EventHandler(this.acceptDeletePetButton_Click);
            // 
            // deletingPetBirthdayLabel
            // 
            this.deletingPetBirthdayLabel.AutoSize = true;
            this.deletingPetBirthdayLabel.Location = new System.Drawing.Point(188, 151);
            this.deletingPetBirthdayLabel.Name = "deletingPetBirthdayLabel";
            this.deletingPetBirthdayLabel.Size = new System.Drawing.Size(132, 13);
            this.deletingPetBirthdayLabel.TabIndex = 9;
            this.deletingPetBirthdayLabel.Text = "Дата рождения питомца";
            // 
            // deletingPetClientNameLabel
            // 
            this.deletingPetClientNameLabel.AutoSize = true;
            this.deletingPetClientNameLabel.Location = new System.Drawing.Point(188, 110);
            this.deletingPetClientNameLabel.Name = "deletingPetClientNameLabel";
            this.deletingPetClientNameLabel.Size = new System.Drawing.Size(79, 13);
            this.deletingPetClientNameLabel.TabIndex = 8;
            this.deletingPetClientNameLabel.Text = "ФИО Клиента";
            // 
            // deletingPetNameLabel
            // 
            this.deletingPetNameLabel.AutoSize = true;
            this.deletingPetNameLabel.Location = new System.Drawing.Point(188, 74);
            this.deletingPetNameLabel.Name = "deletingPetNameLabel";
            this.deletingPetNameLabel.Size = new System.Drawing.Size(43, 13);
            this.deletingPetNameLabel.TabIndex = 7;
            this.deletingPetNameLabel.Text = "Кличка";
            // 
            // deletingPetIdLabel
            // 
            this.deletingPetIdLabel.AutoSize = true;
            this.deletingPetIdLabel.Location = new System.Drawing.Point(188, 41);
            this.deletingPetIdLabel.Name = "deletingPetIdLabel";
            this.deletingPetIdLabel.Size = new System.Drawing.Size(18, 13);
            this.deletingPetIdLabel.TabIndex = 6;
            this.deletingPetIdLabel.Text = "№";
            // 
            // DeletePetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 311);
            this.Controls.Add(this.deletingPetBirthdayLabel);
            this.Controls.Add(this.deletingPetClientNameLabel);
            this.Controls.Add(this.deletingPetNameLabel);
            this.Controls.Add(this.deletingPetIdLabel);
            this.Controls.Add(this.acceptDeletePetButton);
            this.Controls.Add(this.cancelDeletePetButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeletePetForm";
            this.Text = "DeletePetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelDeletePetButton;
        private System.Windows.Forms.Button acceptDeletePetButton;
        private System.Windows.Forms.Label deletingPetBirthdayLabel;
        private System.Windows.Forms.Label deletingPetClientNameLabel;
        private System.Windows.Forms.Label deletingPetNameLabel;
        private System.Windows.Forms.Label deletingPetIdLabel;
    }
}