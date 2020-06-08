namespace SWA
{
    partial class SpecialtyEntityForm
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
            this.metroTextBoxSpecialtyId = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSpecialtyName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSpecialtyTime = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBoxFormStudy = new MetroFramework.Controls.MetroComboBox();
            this.metroTileAccept = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Код специальности:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(82, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Название:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(47, 132);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Срок обучения:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(36, 167);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Форма обучения:";
            // 
            // metroTextBoxSpecialtyId
            // 
            this.metroTextBoxSpecialtyId.Location = new System.Drawing.Point(159, 70);
            this.metroTextBoxSpecialtyId.Name = "metroTextBoxSpecialtyId";
            this.metroTextBoxSpecialtyId.Size = new System.Drawing.Size(181, 23);
            this.metroTextBoxSpecialtyId.TabIndex = 4;
            // 
            // metroTextBoxSpecialtyName
            // 
            this.metroTextBoxSpecialtyName.Location = new System.Drawing.Point(159, 99);
            this.metroTextBoxSpecialtyName.Name = "metroTextBoxSpecialtyName";
            this.metroTextBoxSpecialtyName.Size = new System.Drawing.Size(181, 23);
            this.metroTextBoxSpecialtyName.TabIndex = 5;
            // 
            // metroTextBoxSpecialtyTime
            // 
            this.metroTextBoxSpecialtyTime.Location = new System.Drawing.Point(159, 128);
            this.metroTextBoxSpecialtyTime.Name = "metroTextBoxSpecialtyTime";
            this.metroTextBoxSpecialtyTime.Size = new System.Drawing.Size(181, 23);
            this.metroTextBoxSpecialtyTime.TabIndex = 6;
            // 
            // metroComboBoxFormStudy
            // 
            this.metroComboBoxFormStudy.FormattingEnabled = true;
            this.metroComboBoxFormStudy.ItemHeight = 23;
            this.metroComboBoxFormStudy.Location = new System.Drawing.Point(159, 157);
            this.metroComboBoxFormStudy.Name = "metroComboBoxFormStudy";
            this.metroComboBoxFormStudy.Size = new System.Drawing.Size(181, 29);
            this.metroComboBoxFormStudy.TabIndex = 7;
            // 
            // metroTileAccept
            // 
            this.metroTileAccept.Location = new System.Drawing.Point(132, 216);
            this.metroTileAccept.Name = "metroTileAccept";
            this.metroTileAccept.Size = new System.Drawing.Size(105, 23);
            this.metroTileAccept.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileAccept.TabIndex = 8;
            this.metroTileAccept.Text = "Сохранить";
            this.metroTileAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAccept.Click += new System.EventHandler(this.metroTileAccept_Click);
            // 
            // SpecialtyEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 282);
            this.Controls.Add(this.metroTileAccept);
            this.Controls.Add(this.metroComboBoxFormStudy);
            this.Controls.Add(this.metroTextBoxSpecialtyTime);
            this.Controls.Add(this.metroTextBoxSpecialtyName);
            this.Controls.Add(this.metroTextBoxSpecialtyId);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 282);
            this.MinimumSize = new System.Drawing.Size(370, 282);
            this.Name = "SpecialtyEntityForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "SpecialtyEntityForm";
            this.Load += new System.EventHandler(this.SpecialtyEntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSpecialtyId;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSpecialtyName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSpecialtyTime;
        private MetroFramework.Controls.MetroComboBox metroComboBoxFormStudy;
        private MetroFramework.Controls.MetroTile metroTileAccept;
    }
}