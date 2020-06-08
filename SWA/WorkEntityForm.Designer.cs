namespace SWA
{
    partial class WorkEntityForm
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
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.metroTextBoxHours = new MetroFramework.Controls.MetroTextBox();
            this.metroTileAccept = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(195, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Дата:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(212, 38);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Количество отработанных часов:\r\n";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(241, 79);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerDate.TabIndex = 2;
            this.dateTimePickerDate.Value = new System.DateTime(2020, 6, 7, 0, 0, 0, 0);
            // 
            // metroTextBoxHours
            // 
            this.metroTextBoxHours.Location = new System.Drawing.Point(241, 105);
            this.metroTextBoxHours.Name = "metroTextBoxHours";
            this.metroTextBoxHours.Size = new System.Drawing.Size(94, 23);
            this.metroTextBoxHours.TabIndex = 3;
            // 
            // metroTileAccept
            // 
            this.metroTileAccept.Location = new System.Drawing.Point(134, 162);
            this.metroTileAccept.Name = "metroTileAccept";
            this.metroTileAccept.Size = new System.Drawing.Size(101, 23);
            this.metroTileAccept.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileAccept.TabIndex = 4;
            this.metroTileAccept.Text = "Сохранить";
            this.metroTileAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAccept.Click += new System.EventHandler(this.metroTileAccept_Click);
            // 
            // WorkEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 208);
            this.Controls.Add(this.metroTileAccept);
            this.Controls.Add(this.metroTextBoxHours);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(355, 208);
            this.MinimumSize = new System.Drawing.Size(355, 208);
            this.Name = "WorkEntityForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "WorkEntityForm";
            this.Load += new System.EventHandler(this.WorkEntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private MetroFramework.Controls.MetroTextBox metroTextBoxHours;
        private MetroFramework.Controls.MetroTile metroTileAccept;
    }
}