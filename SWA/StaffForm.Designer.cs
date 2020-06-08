namespace SWA
{
    partial class StaffForm
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
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.dataGridViewWork = new System.Windows.Forms.DataGridView();
            this.dataGridViewFact = new System.Windows.Forms.DataGridView();
            this.metroTextBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.buttonReloadFilter = new System.Windows.Forms.Button();
            this.buttonStaffFilter = new System.Windows.Forms.Button();
            this.buttonDocuments = new System.Windows.Forms.Button();
            this.buttonPosition = new System.Windows.Forms.Button();
            this.buttonFactDelete = new System.Windows.Forms.Button();
            this.buttonFactEdit = new System.Windows.Forms.Button();
            this.buttonFactAdd = new System.Windows.Forms.Button();
            this.buttonWorkDelete = new System.Windows.Forms.Button();
            this.buttonWorkEdit = new System.Windows.Forms.Button();
            this.buttonWorkAdd = new System.Windows.Forms.Button();
            this.buttonStaffDelete = new System.Windows.Forms.Button();
            this.buttonStaffEdit = new System.Windows.Forms.Button();
            this.buttonStaffAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFact)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(23, 92);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.Size = new System.Drawing.Size(1154, 259);
            this.dataGridViewStaff.TabIndex = 3;
            this.dataGridViewStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaff_CellClick);
            this.dataGridViewStaff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaff_CellDoubleClick);
            // 
            // dataGridViewWork
            // 
            this.dataGridViewWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWork.Location = new System.Drawing.Point(23, 386);
            this.dataGridViewWork.Name = "dataGridViewWork";
            this.dataGridViewWork.Size = new System.Drawing.Size(574, 191);
            this.dataGridViewWork.TabIndex = 7;
            // 
            // dataGridViewFact
            // 
            this.dataGridViewFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFact.Location = new System.Drawing.Point(603, 386);
            this.dataGridViewFact.Name = "dataGridViewFact";
            this.dataGridViewFact.Size = new System.Drawing.Size(574, 191);
            this.dataGridViewFact.TabIndex = 11;
            // 
            // metroTextBoxSearch
            // 
            this.metroTextBoxSearch.Location = new System.Drawing.Point(980, 59);
            this.metroTextBoxSearch.Name = "metroTextBoxSearch";
            this.metroTextBoxSearch.Size = new System.Drawing.Size(197, 23);
            this.metroTextBoxSearch.TabIndex = 12;
            this.metroTextBoxSearch.TextChanged += new System.EventHandler(this.metroTextBoxSearch_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(924, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Поиск:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 361);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Работа";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(603, 361);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Сведенья";
            // 
            // buttonReloadFilter
            // 
            this.buttonReloadFilter.Image = global::SWA.Properties.Resources.close;
            this.buttonReloadFilter.Location = new System.Drawing.Point(134, 63);
            this.buttonReloadFilter.Name = "buttonReloadFilter";
            this.buttonReloadFilter.Size = new System.Drawing.Size(31, 26);
            this.buttonReloadFilter.TabIndex = 19;
            this.buttonReloadFilter.UseVisualStyleBackColor = true;
            this.buttonReloadFilter.Visible = false;
            this.buttonReloadFilter.Click += new System.EventHandler(this.buttonReloadFilter_Click);
            // 
            // buttonStaffFilter
            // 
            this.buttonStaffFilter.Image = global::SWA.Properties.Resources.filter;
            this.buttonStaffFilter.Location = new System.Drawing.Point(134, 63);
            this.buttonStaffFilter.Name = "buttonStaffFilter";
            this.buttonStaffFilter.Size = new System.Drawing.Size(31, 26);
            this.buttonStaffFilter.TabIndex = 18;
            this.buttonStaffFilter.UseVisualStyleBackColor = true;
            this.buttonStaffFilter.Click += new System.EventHandler(this.buttonStaffFilter_Click);
            // 
            // buttonDocuments
            // 
            this.buttonDocuments.Image = global::SWA.Properties.Resources.portable_document_format;
            this.buttonDocuments.Location = new System.Drawing.Point(171, 63);
            this.buttonDocuments.Name = "buttonDocuments";
            this.buttonDocuments.Size = new System.Drawing.Size(31, 26);
            this.buttonDocuments.TabIndex = 17;
            this.buttonDocuments.UseVisualStyleBackColor = true;
            this.buttonDocuments.Click += new System.EventHandler(this.buttonDocuments_Click);
            // 
            // buttonPosition
            // 
            this.buttonPosition.Image = global::SWA.Properties.Resources.work;
            this.buttonPosition.Location = new System.Drawing.Point(1146, 27);
            this.buttonPosition.Name = "buttonPosition";
            this.buttonPosition.Size = new System.Drawing.Size(31, 26);
            this.buttonPosition.TabIndex = 16;
            this.buttonPosition.UseVisualStyleBackColor = true;
            this.buttonPosition.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // buttonFactDelete
            // 
            this.buttonFactDelete.Image = global::SWA.Properties.Resources.garbage_container;
            this.buttonFactDelete.Location = new System.Drawing.Point(1146, 357);
            this.buttonFactDelete.Name = "buttonFactDelete";
            this.buttonFactDelete.Size = new System.Drawing.Size(31, 26);
            this.buttonFactDelete.TabIndex = 10;
            this.buttonFactDelete.UseVisualStyleBackColor = true;
            this.buttonFactDelete.Click += new System.EventHandler(this.buttonFactDelete_Click);
            // 
            // buttonFactEdit
            // 
            this.buttonFactEdit.Image = global::SWA.Properties.Resources.edit;
            this.buttonFactEdit.Location = new System.Drawing.Point(1109, 357);
            this.buttonFactEdit.Name = "buttonFactEdit";
            this.buttonFactEdit.Size = new System.Drawing.Size(31, 26);
            this.buttonFactEdit.TabIndex = 9;
            this.buttonFactEdit.UseVisualStyleBackColor = true;
            this.buttonFactEdit.Click += new System.EventHandler(this.buttonFactEdit_Click);
            // 
            // buttonFactAdd
            // 
            this.buttonFactAdd.Image = global::SWA.Properties.Resources.plus_sign;
            this.buttonFactAdd.Location = new System.Drawing.Point(1072, 357);
            this.buttonFactAdd.Name = "buttonFactAdd";
            this.buttonFactAdd.Size = new System.Drawing.Size(31, 26);
            this.buttonFactAdd.TabIndex = 8;
            this.buttonFactAdd.UseVisualStyleBackColor = true;
            this.buttonFactAdd.Click += new System.EventHandler(this.buttonFactAdd_Click);
            // 
            // buttonWorkDelete
            // 
            this.buttonWorkDelete.Image = global::SWA.Properties.Resources.garbage_container;
            this.buttonWorkDelete.Location = new System.Drawing.Point(566, 357);
            this.buttonWorkDelete.Name = "buttonWorkDelete";
            this.buttonWorkDelete.Size = new System.Drawing.Size(31, 26);
            this.buttonWorkDelete.TabIndex = 6;
            this.buttonWorkDelete.UseVisualStyleBackColor = true;
            this.buttonWorkDelete.Click += new System.EventHandler(this.buttonWorkDelete_Click);
            // 
            // buttonWorkEdit
            // 
            this.buttonWorkEdit.Image = global::SWA.Properties.Resources.edit;
            this.buttonWorkEdit.Location = new System.Drawing.Point(529, 357);
            this.buttonWorkEdit.Name = "buttonWorkEdit";
            this.buttonWorkEdit.Size = new System.Drawing.Size(31, 26);
            this.buttonWorkEdit.TabIndex = 5;
            this.buttonWorkEdit.UseVisualStyleBackColor = true;
            this.buttonWorkEdit.Click += new System.EventHandler(this.buttonWorkEdit_Click);
            // 
            // buttonWorkAdd
            // 
            this.buttonWorkAdd.Image = global::SWA.Properties.Resources.plus_sign;
            this.buttonWorkAdd.Location = new System.Drawing.Point(492, 357);
            this.buttonWorkAdd.Name = "buttonWorkAdd";
            this.buttonWorkAdd.Size = new System.Drawing.Size(31, 26);
            this.buttonWorkAdd.TabIndex = 4;
            this.buttonWorkAdd.UseVisualStyleBackColor = true;
            this.buttonWorkAdd.Click += new System.EventHandler(this.buttonWorkAdd_Click);
            // 
            // buttonStaffDelete
            // 
            this.buttonStaffDelete.Image = global::SWA.Properties.Resources.garbage_container;
            this.buttonStaffDelete.Location = new System.Drawing.Point(97, 63);
            this.buttonStaffDelete.Name = "buttonStaffDelete";
            this.buttonStaffDelete.Size = new System.Drawing.Size(31, 26);
            this.buttonStaffDelete.TabIndex = 2;
            this.buttonStaffDelete.UseVisualStyleBackColor = true;
            this.buttonStaffDelete.Click += new System.EventHandler(this.buttonStaffDelete_Click);
            // 
            // buttonStaffEdit
            // 
            this.buttonStaffEdit.Image = global::SWA.Properties.Resources.edit;
            this.buttonStaffEdit.Location = new System.Drawing.Point(60, 63);
            this.buttonStaffEdit.Name = "buttonStaffEdit";
            this.buttonStaffEdit.Size = new System.Drawing.Size(31, 26);
            this.buttonStaffEdit.TabIndex = 1;
            this.buttonStaffEdit.UseVisualStyleBackColor = true;
            this.buttonStaffEdit.Click += new System.EventHandler(this.buttonStaffEdit_Click);
            // 
            // buttonStaffAdd
            // 
            this.buttonStaffAdd.Image = global::SWA.Properties.Resources.plus_sign;
            this.buttonStaffAdd.Location = new System.Drawing.Point(23, 63);
            this.buttonStaffAdd.Name = "buttonStaffAdd";
            this.buttonStaffAdd.Size = new System.Drawing.Size(31, 26);
            this.buttonStaffAdd.TabIndex = 0;
            this.buttonStaffAdd.UseVisualStyleBackColor = true;
            this.buttonStaffAdd.Click += new System.EventHandler(this.buttonStaffAdd_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.buttonReloadFilter);
            this.Controls.Add(this.buttonStaffFilter);
            this.Controls.Add(this.buttonDocuments);
            this.Controls.Add(this.buttonPosition);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxSearch);
            this.Controls.Add(this.dataGridViewFact);
            this.Controls.Add(this.buttonFactDelete);
            this.Controls.Add(this.buttonFactEdit);
            this.Controls.Add(this.buttonFactAdd);
            this.Controls.Add(this.dataGridViewWork);
            this.Controls.Add(this.buttonWorkDelete);
            this.Controls.Add(this.buttonWorkEdit);
            this.Controls.Add(this.buttonWorkAdd);
            this.Controls.Add(this.dataGridViewStaff);
            this.Controls.Add(this.buttonStaffDelete);
            this.Controls.Add(this.buttonStaffEdit);
            this.Controls.Add(this.buttonStaffAdd);
            this.Name = "StaffForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStaffAdd;
        private System.Windows.Forms.Button buttonStaffEdit;
        private System.Windows.Forms.Button buttonStaffDelete;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.Button buttonWorkAdd;
        private System.Windows.Forms.Button buttonWorkEdit;
        private System.Windows.Forms.Button buttonWorkDelete;
        private System.Windows.Forms.DataGridView dataGridViewWork;
        private System.Windows.Forms.Button buttonFactAdd;
        private System.Windows.Forms.Button buttonFactEdit;
        private System.Windows.Forms.Button buttonFactDelete;
        private System.Windows.Forms.DataGridView dataGridViewFact;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button buttonPosition;
        private System.Windows.Forms.Button buttonDocuments;
        private System.Windows.Forms.Button buttonReloadFilter;
        private System.Windows.Forms.Button buttonStaffFilter;
    }
}