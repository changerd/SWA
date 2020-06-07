namespace SWA
{
    partial class StaffEntityForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxSurname = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxFName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSName = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBoxPosition = new MetroFramework.Controls.MetroComboBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.metroComboBoxGender = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxAdress = new MetroFramework.Controls.MetroTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.metroTileAccept = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(86, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ФИО:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(51, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Должность:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 128);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Дата рождения:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(93, 163);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Пол:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(80, 192);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Адрес:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(46, 218);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Телефон:";
            // 
            // metroTextBoxSurname
            // 
            this.metroTextBoxSurname.Location = new System.Drawing.Point(143, 63);
            this.metroTextBoxSurname.Name = "metroTextBoxSurname";
            this.metroTextBoxSurname.Size = new System.Drawing.Size(95, 23);
            this.metroTextBoxSurname.TabIndex = 5;
            // 
            // metroTextBoxFName
            // 
            this.metroTextBoxFName.Location = new System.Drawing.Point(244, 63);
            this.metroTextBoxFName.Name = "metroTextBoxFName";
            this.metroTextBoxFName.Size = new System.Drawing.Size(95, 23);
            this.metroTextBoxFName.TabIndex = 6;
            // 
            // metroTextBoxSName
            // 
            this.metroTextBoxSName.Location = new System.Drawing.Point(345, 63);
            this.metroTextBoxSName.Name = "metroTextBoxSName";
            this.metroTextBoxSName.Size = new System.Drawing.Size(95, 23);
            this.metroTextBoxSName.TabIndex = 7;
            // 
            // metroComboBoxPosition
            // 
            this.metroComboBoxPosition.FormattingEnabled = true;
            this.metroComboBoxPosition.ItemHeight = 23;
            this.metroComboBoxPosition.Location = new System.Drawing.Point(143, 92);
            this.metroComboBoxPosition.Name = "metroComboBoxPosition";
            this.metroComboBoxPosition.Size = new System.Drawing.Size(121, 29);
            this.metroComboBoxPosition.TabIndex = 8;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirth.Location = new System.Drawing.Point(143, 127);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerBirth.TabIndex = 9;
            this.dateTimePickerBirth.Value = new System.DateTime(2020, 6, 7, 0, 0, 0, 0);
            // 
            // metroComboBoxGender
            // 
            this.metroComboBoxGender.FormattingEnabled = true;
            this.metroComboBoxGender.ItemHeight = 23;
            this.metroComboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.metroComboBoxGender.Location = new System.Drawing.Point(143, 153);
            this.metroComboBoxGender.Name = "metroComboBoxGender";
            this.metroComboBoxGender.Size = new System.Drawing.Size(121, 29);
            this.metroComboBoxGender.TabIndex = 10;
            // 
            // metroTextBoxAdress
            // 
            this.metroTextBoxAdress.Location = new System.Drawing.Point(143, 188);
            this.metroTextBoxAdress.Name = "metroTextBoxAdress";
            this.metroTextBoxAdress.Size = new System.Drawing.Size(121, 23);
            this.metroTextBoxAdress.TabIndex = 11;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(143, 217);
            this.maskedTextBox1.Mask = "+375(99)000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // metroTileAccept
            // 
            this.metroTileAccept.Location = new System.Drawing.Point(185, 267);
            this.metroTileAccept.Name = "metroTileAccept";
            this.metroTileAccept.Size = new System.Drawing.Size(106, 23);
            this.metroTileAccept.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileAccept.TabIndex = 13;
            this.metroTileAccept.Text = "Сохранить";
            this.metroTileAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAccept.Click += new System.EventHandler(this.metroTileAccept_Click);
            // 
            // StaffEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 313);
            this.Controls.Add(this.metroTileAccept);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.metroTextBoxAdress);
            this.Controls.Add(this.metroComboBoxGender);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.metroComboBoxPosition);
            this.Controls.Add(this.metroTextBoxSName);
            this.Controls.Add(this.metroTextBoxFName);
            this.Controls.Add(this.metroTextBoxSurname);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "StaffEntityForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "StaffEntityForm";
            this.Load += new System.EventHandler(this.StaffEntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSurname;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSName;
        private MetroFramework.Controls.MetroComboBox metroComboBoxPosition;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private MetroFramework.Controls.MetroComboBox metroComboBoxGender;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAdress;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private MetroFramework.Controls.MetroTile metroTileAccept;
    }
}