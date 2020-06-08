namespace SWA
{
    partial class PositionEntityForm
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
            this.metroTextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.metroTileAccept = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Название:";
            // 
            // metroTextBoxName
            // 
            this.metroTextBoxName.Location = new System.Drawing.Point(100, 63);
            this.metroTextBoxName.Name = "metroTextBoxName";
            this.metroTextBoxName.Size = new System.Drawing.Size(147, 23);
            this.metroTextBoxName.TabIndex = 1;
            // 
            // metroTileAccept
            // 
            this.metroTileAccept.Location = new System.Drawing.Point(82, 118);
            this.metroTileAccept.Name = "metroTileAccept";
            this.metroTileAccept.Size = new System.Drawing.Size(110, 23);
            this.metroTileAccept.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileAccept.TabIndex = 2;
            this.metroTileAccept.Text = "Сохранить";
            this.metroTileAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAccept.Click += new System.EventHandler(this.metroTileAccept_Click);
            // 
            // PositionEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 164);
            this.Controls.Add(this.metroTileAccept);
            this.Controls.Add(this.metroTextBoxName);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 164);
            this.MinimumSize = new System.Drawing.Size(280, 164);
            this.Name = "PositionEntityForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "PositionEntityForm";
            this.Load += new System.EventHandler(this.PositionEntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxName;
        private MetroFramework.Controls.MetroTile metroTileAccept;
    }
}