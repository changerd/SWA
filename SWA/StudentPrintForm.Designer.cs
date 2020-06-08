namespace SWA
{
    partial class StudentPrintForm
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
            this.metroComboBoxSpecialty = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxGroup = new MetroFramework.Controls.MetroComboBox();
            this.metroTileAccept = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Специальность:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(73, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Группа:";
            // 
            // metroComboBoxSpecialty
            // 
            this.metroComboBoxSpecialty.FormattingEnabled = true;
            this.metroComboBoxSpecialty.ItemHeight = 23;
            this.metroComboBoxSpecialty.Location = new System.Drawing.Point(134, 68);
            this.metroComboBoxSpecialty.Name = "metroComboBoxSpecialty";
            this.metroComboBoxSpecialty.Size = new System.Drawing.Size(159, 29);
            this.metroComboBoxSpecialty.TabIndex = 2;
            this.metroComboBoxSpecialty.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxSpecialty_SelectedIndexChanged);
            // 
            // metroComboBoxGroup
            // 
            this.metroComboBoxGroup.FormattingEnabled = true;
            this.metroComboBoxGroup.ItemHeight = 23;
            this.metroComboBoxGroup.Location = new System.Drawing.Point(134, 107);
            this.metroComboBoxGroup.Name = "metroComboBoxGroup";
            this.metroComboBoxGroup.Size = new System.Drawing.Size(159, 29);
            this.metroComboBoxGroup.TabIndex = 3;
            // 
            // metroTileAccept
            // 
            this.metroTileAccept.Location = new System.Drawing.Point(118, 172);
            this.metroTileAccept.Name = "metroTileAccept";
            this.metroTileAccept.Size = new System.Drawing.Size(76, 23);
            this.metroTileAccept.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileAccept.TabIndex = 4;
            this.metroTileAccept.Text = "Печать";
            this.metroTileAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAccept.Click += new System.EventHandler(this.metroTileAccept_Click);
            // 
            // StudentPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 228);
            this.Controls.Add(this.metroTileAccept);
            this.Controls.Add(this.metroComboBoxGroup);
            this.Controls.Add(this.metroComboBoxSpecialty);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "StudentPrintForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Печать список студентов";
            this.Load += new System.EventHandler(this.StudentPrintForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBoxSpecialty;
        private MetroFramework.Controls.MetroComboBox metroComboBoxGroup;
        private MetroFramework.Controls.MetroTile metroTileAccept;
    }
}