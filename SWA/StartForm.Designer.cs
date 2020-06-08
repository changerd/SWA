namespace SWA
{
    partial class StartForm
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
            this.metroTileStudents = new MetroFramework.Controls.MetroTile();
            this.metroTileStaff = new MetroFramework.Controls.MetroTile();
            this.metroTileGeneralDoc = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileStudents
            // 
            this.metroTileStudents.Location = new System.Drawing.Point(40, 92);
            this.metroTileStudents.Name = "metroTileStudents";
            this.metroTileStudents.Size = new System.Drawing.Size(166, 41);
            this.metroTileStudents.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTileStudents.TabIndex = 0;
            this.metroTileStudents.Text = "Студенты";
            this.metroTileStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileStudents.Click += new System.EventHandler(this.metroTileStudents_Click);
            // 
            // metroTileStaff
            // 
            this.metroTileStaff.Location = new System.Drawing.Point(40, 139);
            this.metroTileStaff.Name = "metroTileStaff";
            this.metroTileStaff.Size = new System.Drawing.Size(166, 41);
            this.metroTileStaff.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTileStaff.TabIndex = 1;
            this.metroTileStaff.Text = "Персонал";
            this.metroTileStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileStaff.Click += new System.EventHandler(this.metroTileStaff_Click);
            // 
            // metroTileGeneralDoc
            // 
            this.metroTileGeneralDoc.Location = new System.Drawing.Point(40, 186);
            this.metroTileGeneralDoc.Name = "metroTileGeneralDoc";
            this.metroTileGeneralDoc.Size = new System.Drawing.Size(166, 41);
            this.metroTileGeneralDoc.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTileGeneralDoc.TabIndex = 2;
            this.metroTileGeneralDoc.Text = "Общие документы";
            this.metroTileGeneralDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileGeneralDoc.Click += new System.EventHandler(this.metroTileGeneralDoc_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 268);
            this.Controls.Add(this.metroTileGeneralDoc);
            this.Controls.Add(this.metroTileStaff);
            this.Controls.Add(this.metroTileStudents);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(252, 268);
            this.MinimumSize = new System.Drawing.Size(252, 268);
            this.Name = "StartForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "АРМ Секретаря";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileStudents;
        private MetroFramework.Controls.MetroTile metroTileStaff;
        private MetroFramework.Controls.MetroTile metroTileGeneralDoc;
    }
}

