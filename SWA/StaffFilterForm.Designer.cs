namespace SWA
{
    partial class StaffFilterForm
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
            this.metroComboBoxPosition = new MetroFramework.Controls.MetroComboBox();
            this.metroTileAccept = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Должность:";
            // 
            // metroComboBoxPosition
            // 
            this.metroComboBoxPosition.FormattingEnabled = true;
            this.metroComboBoxPosition.ItemHeight = 23;
            this.metroComboBoxPosition.Location = new System.Drawing.Point(107, 69);
            this.metroComboBoxPosition.Name = "metroComboBoxPosition";
            this.metroComboBoxPosition.Size = new System.Drawing.Size(121, 29);
            this.metroComboBoxPosition.TabIndex = 1;
            // 
            // metroTileAccept
            // 
            this.metroTileAccept.Location = new System.Drawing.Point(90, 125);
            this.metroTileAccept.Name = "metroTileAccept";
            this.metroTileAccept.Size = new System.Drawing.Size(69, 26);
            this.metroTileAccept.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileAccept.TabIndex = 2;
            this.metroTileAccept.Text = "Фильтр";
            this.metroTileAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAccept.Click += new System.EventHandler(this.metroTileAccept_Click);
            // 
            // StaffFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 174);
            this.Controls.Add(this.metroTileAccept);
            this.Controls.Add(this.metroComboBoxPosition);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(265, 174);
            this.MinimumSize = new System.Drawing.Size(265, 174);
            this.Name = "StaffFilterForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Фильтр сотрудников";
            this.Load += new System.EventHandler(this.StaffFilterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBoxPosition;
        private MetroFramework.Controls.MetroTile metroTileAccept;
    }
}