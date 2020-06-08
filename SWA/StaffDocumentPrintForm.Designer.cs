namespace SWA
{
    partial class StaffDocumentPrintForm
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxType = new MetroFramework.Controls.MetroComboBox();
            this.metroCheckBoxDate = new MetroFramework.Controls.MetroCheckBox();
            this.dateTimePickerFirst = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSecond = new System.Windows.Forms.DateTimePicker();
            this.metroTilePrint = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Тип документа:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(104, 129);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(21, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "С:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(230, 129);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(29, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "По:";
            // 
            // metroComboBoxType
            // 
            this.metroComboBoxType.FormattingEnabled = true;
            this.metroComboBoxType.ItemHeight = 23;
            this.metroComboBoxType.Location = new System.Drawing.Point(131, 72);
            this.metroComboBoxType.Name = "metroComboBoxType";
            this.metroComboBoxType.Size = new System.Drawing.Size(121, 29);
            this.metroComboBoxType.TabIndex = 4;
            // 
            // metroCheckBoxDate
            // 
            this.metroCheckBoxDate.AutoSize = true;
            this.metroCheckBoxDate.Location = new System.Drawing.Point(131, 107);
            this.metroCheckBoxDate.Name = "metroCheckBoxDate";
            this.metroCheckBoxDate.Size = new System.Drawing.Size(65, 15);
            this.metroCheckBoxDate.TabIndex = 5;
            this.metroCheckBoxDate.Text = "По дате";
            this.metroCheckBoxDate.UseVisualStyleBackColor = true;
            this.metroCheckBoxDate.CheckedChanged += new System.EventHandler(this.metroCheckBoxDate_CheckedChanged);
            // 
            // dateTimePickerFirst
            // 
            this.dateTimePickerFirst.Enabled = false;
            this.dateTimePickerFirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFirst.Location = new System.Drawing.Point(131, 128);
            this.dateTimePickerFirst.Name = "dateTimePickerFirst";
            this.dateTimePickerFirst.Size = new System.Drawing.Size(93, 20);
            this.dateTimePickerFirst.TabIndex = 6;
            this.dateTimePickerFirst.Value = new System.DateTime(2020, 6, 8, 0, 0, 0, 0);
            // 
            // dateTimePickerSecond
            // 
            this.dateTimePickerSecond.Enabled = false;
            this.dateTimePickerSecond.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSecond.Location = new System.Drawing.Point(265, 129);
            this.dateTimePickerSecond.Name = "dateTimePickerSecond";
            this.dateTimePickerSecond.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerSecond.TabIndex = 7;
            this.dateTimePickerSecond.Value = new System.DateTime(2020, 6, 8, 0, 0, 0, 0);
            // 
            // metroTilePrint
            // 
            this.metroTilePrint.Location = new System.Drawing.Point(149, 170);
            this.metroTilePrint.Name = "metroTilePrint";
            this.metroTilePrint.Size = new System.Drawing.Size(75, 23);
            this.metroTilePrint.TabIndex = 8;
            this.metroTilePrint.Text = "Печать";
            this.metroTilePrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTilePrint.Click += new System.EventHandler(this.metroTilePrint_Click);
            // 
            // StaffDocumentPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 226);
            this.Controls.Add(this.metroTilePrint);
            this.Controls.Add(this.dateTimePickerSecond);
            this.Controls.Add(this.dateTimePickerFirst);
            this.Controls.Add(this.metroCheckBoxDate);
            this.Controls.Add(this.metroComboBoxType);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(384, 226);
            this.MinimumSize = new System.Drawing.Size(384, 226);
            this.Name = "StaffDocumentPrintForm";
            this.Text = "Печать документа";
            this.Load += new System.EventHandler(this.StaffDocumentPrintForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox metroComboBoxType;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirst;
        private System.Windows.Forms.DateTimePicker dateTimePickerSecond;
        private MetroFramework.Controls.MetroTile metroTilePrint;
    }
}