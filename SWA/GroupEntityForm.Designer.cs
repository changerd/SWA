namespace SWA
{
    partial class GroupEntityForm
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
            this.metroTextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBoxSpecialty = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxCourse = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxEndStudy = new MetroFramework.Controls.MetroTextBox();
            this.metroTileAccept = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Название группы:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Специальность:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(103, 139);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Курс:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(56, 168);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Год выпуска:";
            // 
            // metroTextBoxName
            // 
            this.metroTextBoxName.Location = new System.Drawing.Point(148, 71);
            this.metroTextBoxName.Name = "metroTextBoxName";
            this.metroTextBoxName.Size = new System.Drawing.Size(146, 23);
            this.metroTextBoxName.TabIndex = 5;
            // 
            // metroComboBoxSpecialty
            // 
            this.metroComboBoxSpecialty.FormattingEnabled = true;
            this.metroComboBoxSpecialty.ItemHeight = 23;
            this.metroComboBoxSpecialty.Location = new System.Drawing.Point(148, 100);
            this.metroComboBoxSpecialty.Name = "metroComboBoxSpecialty";
            this.metroComboBoxSpecialty.Size = new System.Drawing.Size(146, 29);
            this.metroComboBoxSpecialty.TabIndex = 6;
            // 
            // metroTextBoxCourse
            // 
            this.metroTextBoxCourse.Location = new System.Drawing.Point(148, 135);
            this.metroTextBoxCourse.Name = "metroTextBoxCourse";
            this.metroTextBoxCourse.Size = new System.Drawing.Size(146, 23);
            this.metroTextBoxCourse.TabIndex = 7;
            // 
            // metroTextBoxEndStudy
            // 
            this.metroTextBoxEndStudy.Location = new System.Drawing.Point(148, 164);
            this.metroTextBoxEndStudy.Name = "metroTextBoxEndStudy";
            this.metroTextBoxEndStudy.Size = new System.Drawing.Size(146, 23);
            this.metroTextBoxEndStudy.TabIndex = 8;
            // 
            // metroTileAccept
            // 
            this.metroTileAccept.Location = new System.Drawing.Point(112, 209);
            this.metroTileAccept.Name = "metroTileAccept";
            this.metroTileAccept.Size = new System.Drawing.Size(104, 23);
            this.metroTileAccept.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileAccept.TabIndex = 9;
            this.metroTileAccept.Text = "Сохранить";
            this.metroTileAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAccept.Click += new System.EventHandler(this.metroTileAccept_Click);
            // 
            // GroupEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 255);
            this.Controls.Add(this.metroTileAccept);
            this.Controls.Add(this.metroTextBoxEndStudy);
            this.Controls.Add(this.metroTextBoxCourse);
            this.Controls.Add(this.metroComboBoxSpecialty);
            this.Controls.Add(this.metroTextBoxName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "GroupEntityForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "GroupEntityForm";
            this.Load += new System.EventHandler(this.GroupEntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBoxName;
        private MetroFramework.Controls.MetroComboBox metroComboBoxSpecialty;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCourse;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEndStudy;
        private MetroFramework.Controls.MetroTile metroTileAccept;
    }
}