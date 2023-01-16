namespace ClinicDesktop.OpenAPIs.Forms
{
    partial class CreateClientForm
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
            this.secondNameInputField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameInputField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patronymicInputField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.documentInputField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerField = new System.Windows.Forms.DateTimePicker();
            this.createClientButton = new System.Windows.Forms.Button();
            this.alertLabel = new System.Windows.Forms.Label();
            this.cancelCreateClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secondNameInputField
            // 
            this.secondNameInputField.Location = new System.Drawing.Point(122, 67);
            this.secondNameInputField.Name = "secondNameInputField";
            this.secondNameInputField.Size = new System.Drawing.Size(161, 20);
            this.secondNameInputField.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // firstNameInputField
            // 
            this.firstNameInputField.Location = new System.Drawing.Point(122, 108);
            this.firstNameInputField.Name = "firstNameInputField";
            this.firstNameInputField.Size = new System.Drawing.Size(161, 20);
            this.firstNameInputField.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(46, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // patronymicInputField
            // 
            this.patronymicInputField.Location = new System.Drawing.Point(122, 152);
            this.patronymicInputField.Name = "patronymicInputField";
            this.patronymicInputField.Size = new System.Drawing.Size(161, 20);
            this.patronymicInputField.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(45, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Документ";
            // 
            // documentInputField
            // 
            this.documentInputField.Location = new System.Drawing.Point(122, 196);
            this.documentInputField.Name = "documentInputField";
            this.documentInputField.Size = new System.Drawing.Size(161, 20);
            this.documentInputField.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата рождения";
            // 
            // dateTimePickerField
            // 
            this.dateTimePickerField.Location = new System.Drawing.Point(122, 240);
            this.dateTimePickerField.Name = "dateTimePickerField";
            this.dateTimePickerField.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerField.TabIndex = 10;
            // 
            // createClientButton
            // 
            this.createClientButton.Location = new System.Drawing.Point(191, 346);
            this.createClientButton.Name = "createClientButton";
            this.createClientButton.Size = new System.Drawing.Size(76, 53);
            this.createClientButton.TabIndex = 11;
            this.createClientButton.Text = "Создать";
            this.createClientButton.UseVisualStyleBackColor = true;
            this.createClientButton.Click += new System.EventHandler(this.createClientButton_Click);
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.ForeColor = System.Drawing.Color.Red;
            this.alertLabel.Location = new System.Drawing.Point(108, 297);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(121, 13);
            this.alertLabel.TabIndex = 12;
            this.alertLabel.Text = "Заполните ВСЕ поля!!!";
            // 
            // cancelCreateClientButton
            // 
            this.cancelCreateClientButton.Location = new System.Drawing.Point(86, 346);
            this.cancelCreateClientButton.Name = "cancelCreateClientButton";
            this.cancelCreateClientButton.Size = new System.Drawing.Size(76, 53);
            this.cancelCreateClientButton.TabIndex = 13;
            this.cancelCreateClientButton.Text = "Отмена";
            this.cancelCreateClientButton.UseVisualStyleBackColor = true;
            this.cancelCreateClientButton.Click += new System.EventHandler(this.cancelCreateClientButton_Click);
            // 
            // CreateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.cancelCreateClientButton);
            this.Controls.Add(this.alertLabel);
            this.Controls.Add(this.createClientButton);
            this.Controls.Add(this.dateTimePickerField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.documentInputField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patronymicInputField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameInputField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondNameInputField);
            this.MaximumSize = new System.Drawing.Size(350, 450);
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "CreateClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание нового клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox secondNameInputField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameInputField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox patronymicInputField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox documentInputField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerField;
        private System.Windows.Forms.Button createClientButton;
        private System.Windows.Forms.Label alertLabel;
        private System.Windows.Forms.Button cancelCreateClientButton;
    }
}