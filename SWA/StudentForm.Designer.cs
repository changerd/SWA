namespace SWA
{
    partial class StudentForm
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageStudents = new MetroFramework.Controls.MetroTabPage();
            this.buttonReloadFilter = new System.Windows.Forms.Button();
            this.buttonStudentDocuments = new System.Windows.Forms.Button();
            this.metroTextBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.buttonStudentDelete = new System.Windows.Forms.Button();
            this.buttonStudentFilter = new System.Windows.Forms.Button();
            this.buttonStudentEdit = new System.Windows.Forms.Button();
            this.buttonStudentAdd = new System.Windows.Forms.Button();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.metroTabPageService = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewGroup = new System.Windows.Forms.DataGridView();
            this.dataGridViewSpecialty = new System.Windows.Forms.DataGridView();
            this.dataGridViewStudyForm = new System.Windows.Forms.DataGridView();
            this.buttonGroupDelete = new System.Windows.Forms.Button();
            this.buttonGroupEdit = new System.Windows.Forms.Button();
            this.buttonGroupAdd = new System.Windows.Forms.Button();
            this.buttonSpecialtyDelete = new System.Windows.Forms.Button();
            this.buttonSpecialtyEdit = new System.Windows.Forms.Button();
            this.buttonSpecialtyAdd = new System.Windows.Forms.Button();
            this.buttonStudyFormDelete = new System.Windows.Forms.Button();
            this.buttonStudyFormEdit = new System.Windows.Forms.Button();
            this.buttonStudyFormAdd = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.metroTabPageService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecialty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudyForm)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPageStudents);
            this.metroTabControl1.Controls.Add(this.metroTabPageService);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1154, 514);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPageStudents
            // 
            this.metroTabPageStudents.Controls.Add(this.buttonReloadFilter);
            this.metroTabPageStudents.Controls.Add(this.buttonStudentDocuments);
            this.metroTabPageStudents.Controls.Add(this.metroTextBoxSearch);
            this.metroTabPageStudents.Controls.Add(this.metroLabel4);
            this.metroTabPageStudents.Controls.Add(this.buttonStudentDelete);
            this.metroTabPageStudents.Controls.Add(this.buttonStudentFilter);
            this.metroTabPageStudents.Controls.Add(this.buttonStudentEdit);
            this.metroTabPageStudents.Controls.Add(this.buttonStudentAdd);
            this.metroTabPageStudents.Controls.Add(this.dataGridViewStudent);
            this.metroTabPageStudents.HorizontalScrollbarBarColor = true;
            this.metroTabPageStudents.Location = new System.Drawing.Point(4, 35);
            this.metroTabPageStudents.Name = "metroTabPageStudents";
            this.metroTabPageStudents.Size = new System.Drawing.Size(1146, 475);
            this.metroTabPageStudents.TabIndex = 0;
            this.metroTabPageStudents.Text = "Студенты";
            this.metroTabPageStudents.VerticalScrollbarBarColor = true;
            // 
            // buttonReloadFilter
            // 
            this.buttonReloadFilter.Image = global::SWA.Properties.Resources.close;
            this.buttonReloadFilter.Location = new System.Drawing.Point(114, 3);
            this.buttonReloadFilter.Name = "buttonReloadFilter";
            this.buttonReloadFilter.Size = new System.Drawing.Size(31, 26);
            this.buttonReloadFilter.TabIndex = 10;
            this.buttonReloadFilter.UseVisualStyleBackColor = true;
            this.buttonReloadFilter.Visible = false;
            this.buttonReloadFilter.Click += new System.EventHandler(this.buttonReloadFilter_Click);
            // 
            // buttonStudentDocuments
            // 
            this.buttonStudentDocuments.Image = global::SWA.Properties.Resources.portable_document_format;
            this.buttonStudentDocuments.Location = new System.Drawing.Point(151, 3);
            this.buttonStudentDocuments.Name = "buttonStudentDocuments";
            this.buttonStudentDocuments.Size = new System.Drawing.Size(31, 26);
            this.buttonStudentDocuments.TabIndex = 9;
            this.buttonStudentDocuments.UseVisualStyleBackColor = true;
            this.buttonStudentDocuments.Click += new System.EventHandler(this.buttonStudentDocuments_Click);
            // 
            // metroTextBoxSearch
            // 
            this.metroTextBoxSearch.Location = new System.Drawing.Point(965, 6);
            this.metroTextBoxSearch.Name = "metroTextBoxSearch";
            this.metroTextBoxSearch.Size = new System.Drawing.Size(178, 23);
            this.metroTextBoxSearch.TabIndex = 8;
            this.metroTextBoxSearch.TextChanged += new System.EventHandler(this.metroTextBoxSearch_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(909, 10);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Поиск:";
            // 
            // buttonStudentDelete
            // 
            this.buttonStudentDelete.Image = global::SWA.Properties.Resources.garbage_container;
            this.buttonStudentDelete.Location = new System.Drawing.Point(77, 3);
            this.buttonStudentDelete.Name = "buttonStudentDelete";
            this.buttonStudentDelete.Size = new System.Drawing.Size(31, 26);
            this.buttonStudentDelete.TabIndex = 5;
            this.buttonStudentDelete.UseVisualStyleBackColor = true;
            this.buttonStudentDelete.Click += new System.EventHandler(this.buttonStudentDelete_Click);
            // 
            // buttonStudentFilter
            // 
            this.buttonStudentFilter.Image = global::SWA.Properties.Resources.filter;
            this.buttonStudentFilter.Location = new System.Drawing.Point(114, 3);
            this.buttonStudentFilter.Name = "buttonStudentFilter";
            this.buttonStudentFilter.Size = new System.Drawing.Size(31, 26);
            this.buttonStudentFilter.TabIndex = 6;
            this.buttonStudentFilter.UseVisualStyleBackColor = true;
            this.buttonStudentFilter.Click += new System.EventHandler(this.buttonStudentFilter_Click);
            // 
            // buttonStudentEdit
            // 
            this.buttonStudentEdit.Image = global::SWA.Properties.Resources.edit;
            this.buttonStudentEdit.Location = new System.Drawing.Point(40, 3);
            this.buttonStudentEdit.Name = "buttonStudentEdit";
            this.buttonStudentEdit.Size = new System.Drawing.Size(31, 26);
            this.buttonStudentEdit.TabIndex = 4;
            this.buttonStudentEdit.UseVisualStyleBackColor = true;
            this.buttonStudentEdit.Click += new System.EventHandler(this.buttonStudentEdit_Click);
            // 
            // buttonStudentAdd
            // 
            this.buttonStudentAdd.Image = global::SWA.Properties.Resources.plus_sign;
            this.buttonStudentAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonStudentAdd.Name = "buttonStudentAdd";
            this.buttonStudentAdd.Size = new System.Drawing.Size(31, 26);
            this.buttonStudentAdd.TabIndex = 3;
            this.buttonStudentAdd.UseVisualStyleBackColor = true;
            this.buttonStudentAdd.Click += new System.EventHandler(this.buttonStudentAdd_Click);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(3, 35);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.Size = new System.Drawing.Size(1140, 437);
            this.dataGridViewStudent.TabIndex = 2;
            this.dataGridViewStudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellDoubleClick);
            // 
            // metroTabPageService
            // 
            this.metroTabPageService.Controls.Add(this.metroLabel3);
            this.metroTabPageService.Controls.Add(this.metroLabel2);
            this.metroTabPageService.Controls.Add(this.metroLabel1);
            this.metroTabPageService.Controls.Add(this.dataGridViewGroup);
            this.metroTabPageService.Controls.Add(this.dataGridViewSpecialty);
            this.metroTabPageService.Controls.Add(this.dataGridViewStudyForm);
            this.metroTabPageService.Controls.Add(this.buttonGroupDelete);
            this.metroTabPageService.Controls.Add(this.buttonGroupEdit);
            this.metroTabPageService.Controls.Add(this.buttonGroupAdd);
            this.metroTabPageService.Controls.Add(this.buttonSpecialtyDelete);
            this.metroTabPageService.Controls.Add(this.buttonSpecialtyEdit);
            this.metroTabPageService.Controls.Add(this.buttonSpecialtyAdd);
            this.metroTabPageService.Controls.Add(this.buttonStudyFormDelete);
            this.metroTabPageService.Controls.Add(this.buttonStudyFormEdit);
            this.metroTabPageService.Controls.Add(this.buttonStudyFormAdd);
            this.metroTabPageService.HorizontalScrollbarBarColor = true;
            this.metroTabPageService.Location = new System.Drawing.Point(4, 35);
            this.metroTabPageService.Name = "metroTabPageService";
            this.metroTabPageService.Size = new System.Drawing.Size(1146, 475);
            this.metroTabPageService.TabIndex = 1;
            this.metroTabPageService.Text = "Служебная инофрмация";
            this.metroTabPageService.VerticalScrollbarBarColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(767, 3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 25);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Группы";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(385, 3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 25);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Специальности";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(148, 25);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Формы обучения";
            // 
            // dataGridViewGroup
            // 
            this.dataGridViewGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroup.Location = new System.Drawing.Point(767, 35);
            this.dataGridViewGroup.Name = "dataGridViewGroup";
            this.dataGridViewGroup.Size = new System.Drawing.Size(376, 437);
            this.dataGridViewGroup.TabIndex = 13;
            // 
            // dataGridViewSpecialty
            // 
            this.dataGridViewSpecialty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecialty.Location = new System.Drawing.Point(385, 35);
            this.dataGridViewSpecialty.Name = "dataGridViewSpecialty";
            this.dataGridViewSpecialty.Size = new System.Drawing.Size(376, 437);
            this.dataGridViewSpecialty.TabIndex = 9;
            // 
            // dataGridViewStudyForm
            // 
            this.dataGridViewStudyForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudyForm.Location = new System.Drawing.Point(3, 35);
            this.dataGridViewStudyForm.Name = "dataGridViewStudyForm";
            this.dataGridViewStudyForm.Size = new System.Drawing.Size(376, 437);
            this.dataGridViewStudyForm.TabIndex = 5;
            // 
            // buttonGroupDelete
            // 
            this.buttonGroupDelete.Image = global::SWA.Properties.Resources.garbage_container;
            this.buttonGroupDelete.Location = new System.Drawing.Point(1112, 3);
            this.buttonGroupDelete.Name = "buttonGroupDelete";
            this.buttonGroupDelete.Size = new System.Drawing.Size(31, 26);
            this.buttonGroupDelete.TabIndex = 12;
            this.buttonGroupDelete.UseVisualStyleBackColor = true;
            this.buttonGroupDelete.Click += new System.EventHandler(this.buttonGroupDelete_Click);
            // 
            // buttonGroupEdit
            // 
            this.buttonGroupEdit.Image = global::SWA.Properties.Resources.edit;
            this.buttonGroupEdit.Location = new System.Drawing.Point(1075, 3);
            this.buttonGroupEdit.Name = "buttonGroupEdit";
            this.buttonGroupEdit.Size = new System.Drawing.Size(31, 26);
            this.buttonGroupEdit.TabIndex = 11;
            this.buttonGroupEdit.UseVisualStyleBackColor = true;
            this.buttonGroupEdit.Click += new System.EventHandler(this.buttonGroupEdit_Click);
            // 
            // buttonGroupAdd
            // 
            this.buttonGroupAdd.Image = global::SWA.Properties.Resources.plus_sign;
            this.buttonGroupAdd.Location = new System.Drawing.Point(1038, 3);
            this.buttonGroupAdd.Name = "buttonGroupAdd";
            this.buttonGroupAdd.Size = new System.Drawing.Size(31, 26);
            this.buttonGroupAdd.TabIndex = 10;
            this.buttonGroupAdd.UseVisualStyleBackColor = true;
            this.buttonGroupAdd.Click += new System.EventHandler(this.buttonGroupAdd_Click);
            // 
            // buttonSpecialtyDelete
            // 
            this.buttonSpecialtyDelete.Image = global::SWA.Properties.Resources.garbage_container;
            this.buttonSpecialtyDelete.Location = new System.Drawing.Point(730, 3);
            this.buttonSpecialtyDelete.Name = "buttonSpecialtyDelete";
            this.buttonSpecialtyDelete.Size = new System.Drawing.Size(31, 26);
            this.buttonSpecialtyDelete.TabIndex = 8;
            this.buttonSpecialtyDelete.UseVisualStyleBackColor = true;
            this.buttonSpecialtyDelete.Click += new System.EventHandler(this.buttonSpecialtyDelete_Click);
            // 
            // buttonSpecialtyEdit
            // 
            this.buttonSpecialtyEdit.Image = global::SWA.Properties.Resources.edit;
            this.buttonSpecialtyEdit.Location = new System.Drawing.Point(693, 3);
            this.buttonSpecialtyEdit.Name = "buttonSpecialtyEdit";
            this.buttonSpecialtyEdit.Size = new System.Drawing.Size(31, 26);
            this.buttonSpecialtyEdit.TabIndex = 7;
            this.buttonSpecialtyEdit.UseVisualStyleBackColor = true;
            this.buttonSpecialtyEdit.Click += new System.EventHandler(this.buttonSpecialtyEdit_Click);
            // 
            // buttonSpecialtyAdd
            // 
            this.buttonSpecialtyAdd.Image = global::SWA.Properties.Resources.plus_sign;
            this.buttonSpecialtyAdd.Location = new System.Drawing.Point(656, 3);
            this.buttonSpecialtyAdd.Name = "buttonSpecialtyAdd";
            this.buttonSpecialtyAdd.Size = new System.Drawing.Size(31, 26);
            this.buttonSpecialtyAdd.TabIndex = 6;
            this.buttonSpecialtyAdd.UseVisualStyleBackColor = true;
            this.buttonSpecialtyAdd.Click += new System.EventHandler(this.buttonSpecialtyAdd_Click);
            // 
            // buttonStudyFormDelete
            // 
            this.buttonStudyFormDelete.Image = global::SWA.Properties.Resources.garbage_container;
            this.buttonStudyFormDelete.Location = new System.Drawing.Point(348, 3);
            this.buttonStudyFormDelete.Name = "buttonStudyFormDelete";
            this.buttonStudyFormDelete.Size = new System.Drawing.Size(31, 26);
            this.buttonStudyFormDelete.TabIndex = 4;
            this.buttonStudyFormDelete.UseVisualStyleBackColor = true;
            this.buttonStudyFormDelete.Click += new System.EventHandler(this.buttonStudyFormDelete_Click);
            // 
            // buttonStudyFormEdit
            // 
            this.buttonStudyFormEdit.Image = global::SWA.Properties.Resources.edit;
            this.buttonStudyFormEdit.Location = new System.Drawing.Point(311, 3);
            this.buttonStudyFormEdit.Name = "buttonStudyFormEdit";
            this.buttonStudyFormEdit.Size = new System.Drawing.Size(31, 26);
            this.buttonStudyFormEdit.TabIndex = 3;
            this.buttonStudyFormEdit.UseVisualStyleBackColor = true;
            this.buttonStudyFormEdit.Click += new System.EventHandler(this.buttonStudyFormEdit_Click);
            // 
            // buttonStudyFormAdd
            // 
            this.buttonStudyFormAdd.Image = global::SWA.Properties.Resources.plus_sign;
            this.buttonStudyFormAdd.Location = new System.Drawing.Point(274, 3);
            this.buttonStudyFormAdd.Name = "buttonStudyFormAdd";
            this.buttonStudyFormAdd.Size = new System.Drawing.Size(31, 26);
            this.buttonStudyFormAdd.TabIndex = 2;
            this.buttonStudyFormAdd.UseVisualStyleBackColor = true;
            this.buttonStudyFormAdd.Click += new System.EventHandler(this.buttonStudyFormAdd_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "StudentForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Студенты";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPageStudents.ResumeLayout(false);
            this.metroTabPageStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.metroTabPageService.ResumeLayout(false);
            this.metroTabPageService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecialty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudyForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPageStudents;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private MetroFramework.Controls.MetroTabPage metroTabPageService;
        private System.Windows.Forms.Button buttonStudentAdd;
        private System.Windows.Forms.Button buttonStudentFilter;
        private System.Windows.Forms.Button buttonStudentDelete;
        private System.Windows.Forms.Button buttonStudentEdit;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGridViewGroup;
        private System.Windows.Forms.Button buttonGroupDelete;
        private System.Windows.Forms.Button buttonGroupEdit;
        private System.Windows.Forms.Button buttonGroupAdd;
        private System.Windows.Forms.DataGridView dataGridViewSpecialty;
        private System.Windows.Forms.Button buttonSpecialtyDelete;
        private System.Windows.Forms.Button buttonSpecialtyEdit;
        private System.Windows.Forms.Button buttonSpecialtyAdd;
        private System.Windows.Forms.DataGridView dataGridViewStudyForm;
        private System.Windows.Forms.Button buttonStudyFormDelete;
        private System.Windows.Forms.Button buttonStudyFormEdit;
        private System.Windows.Forms.Button buttonStudyFormAdd;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearch;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Button buttonStudentDocuments;
        private System.Windows.Forms.Button buttonReloadFilter;
    }
}