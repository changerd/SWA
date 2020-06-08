namespace SWA
{
    partial class StudentDocumentsForm
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
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBoxSearchInput = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.buttonInputDelete = new System.Windows.Forms.Button();
            this.buttonInputEdit = new System.Windows.Forms.Button();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBoxSearchOutput = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewOutput = new System.Windows.Forms.DataGridView();
            this.buttonOutputDelete = new System.Windows.Forms.Button();
            this.buttonOutputEdit = new System.Windows.Forms.Button();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBoxSearchInside = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.buttonInsideDelete = new System.Windows.Forms.Button();
            this.buttonInsideEdit = new System.Windows.Forms.Button();
            this.dataGridViewInside = new System.Windows.Forms.DataGridView();
            this.metroTileDocumentAdd = new MetroFramework.Controls.MetroTile();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerDateFilter = new System.Windows.Forms.DateTimePicker();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInside)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 92);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(606, 349);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroTextBoxSearchInput);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.buttonInputDelete);
            this.metroTabPage1.Controls.Add(this.buttonInputEdit);
            this.metroTabPage1.Controls.Add(this.dataGridViewInput);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(598, 310);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Входящие";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTextBoxSearchInput
            // 
            this.metroTextBoxSearchInput.Location = new System.Drawing.Point(406, 6);
            this.metroTextBoxSearchInput.Name = "metroTextBoxSearchInput";
            this.metroTextBoxSearchInput.Size = new System.Drawing.Size(187, 23);
            this.metroTextBoxSearchInput.TabIndex = 9;
            this.metroTextBoxSearchInput.TextChanged += new System.EventHandler(this.metroTextBoxSearchInput_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(350, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Поиск:";
            // 
            // buttonInputDelete
            // 
            this.buttonInputDelete.Image = global::SWA.Properties.Resources.garbage_container;
            this.buttonInputDelete.Location = new System.Drawing.Point(40, 3);
            this.buttonInputDelete.Name = "buttonInputDelete";
            this.buttonInputDelete.Size = new System.Drawing.Size(31, 26);
            this.buttonInputDelete.TabIndex = 7;
            this.buttonInputDelete.UseVisualStyleBackColor = true;
            this.buttonInputDelete.Click += new System.EventHandler(this.buttonInputDelete_Click);
            // 
            // buttonInputEdit
            // 
            this.buttonInputEdit.Image = global::SWA.Properties.Resources.edit;
            this.buttonInputEdit.Location = new System.Drawing.Point(3, 3);
            this.buttonInputEdit.Name = "buttonInputEdit";
            this.buttonInputEdit.Size = new System.Drawing.Size(31, 26);
            this.buttonInputEdit.TabIndex = 6;
            this.buttonInputEdit.UseVisualStyleBackColor = true;
            this.buttonInputEdit.Click += new System.EventHandler(this.buttonInputEdit_Click);
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.Location = new System.Drawing.Point(3, 35);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.Size = new System.Drawing.Size(590, 272);
            this.dataGridViewInput.TabIndex = 5;
            this.dataGridViewInput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInput_CellClick);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroTextBoxSearchOutput);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.dataGridViewOutput);
            this.metroTabPage2.Controls.Add(this.buttonOutputDelete);
            this.metroTabPage2.Controls.Add(this.buttonOutputEdit);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(598, 310);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Исходящие";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroTextBoxSearchOutput
            // 
            this.metroTextBoxSearchOutput.Location = new System.Drawing.Point(406, 6);
            this.metroTextBoxSearchOutput.Name = "metroTextBoxSearchOutput";
            this.metroTextBoxSearchOutput.Size = new System.Drawing.Size(187, 23);
            this.metroTextBoxSearchOutput.TabIndex = 13;
            this.metroTextBoxSearchOutput.TextChanged += new System.EventHandler(this.metroTextBoxSearchOutput_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(350, 10);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Поиск:";
            // 
            // dataGridViewOutput
            // 
            this.dataGridViewOutput.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput.Location = new System.Drawing.Point(3, 35);
            this.dataGridViewOutput.Name = "dataGridViewOutput";
            this.dataGridViewOutput.Size = new System.Drawing.Size(590, 272);
            this.dataGridViewOutput.TabIndex = 9;
            this.dataGridViewOutput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOutput_CellClick);
            // 
            // buttonOutputDelete
            // 
            this.buttonOutputDelete.Image = global::SWA.Properties.Resources.garbage_container;
            this.buttonOutputDelete.Location = new System.Drawing.Point(40, 3);
            this.buttonOutputDelete.Name = "buttonOutputDelete";
            this.buttonOutputDelete.Size = new System.Drawing.Size(31, 26);
            this.buttonOutputDelete.TabIndex = 11;
            this.buttonOutputDelete.UseVisualStyleBackColor = true;
            this.buttonOutputDelete.Click += new System.EventHandler(this.buttonOutputDelete_Click);
            // 
            // buttonOutputEdit
            // 
            this.buttonOutputEdit.Image = global::SWA.Properties.Resources.edit;
            this.buttonOutputEdit.Location = new System.Drawing.Point(3, 3);
            this.buttonOutputEdit.Name = "buttonOutputEdit";
            this.buttonOutputEdit.Size = new System.Drawing.Size(31, 26);
            this.buttonOutputEdit.TabIndex = 10;
            this.buttonOutputEdit.UseVisualStyleBackColor = true;
            this.buttonOutputEdit.Click += new System.EventHandler(this.buttonOutputEdit_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroTextBoxSearchInside);
            this.metroTabPage3.Controls.Add(this.metroLabel2);
            this.metroTabPage3.Controls.Add(this.buttonInsideDelete);
            this.metroTabPage3.Controls.Add(this.buttonInsideEdit);
            this.metroTabPage3.Controls.Add(this.dataGridViewInside);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(598, 310);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Внутренние";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // metroTextBoxSearchInside
            // 
            this.metroTextBoxSearchInside.Location = new System.Drawing.Point(406, 6);
            this.metroTextBoxSearchInside.Name = "metroTextBoxSearchInside";
            this.metroTextBoxSearchInside.Size = new System.Drawing.Size(187, 23);
            this.metroTextBoxSearchInside.TabIndex = 13;
            this.metroTextBoxSearchInside.TextChanged += new System.EventHandler(this.metroTextBoxSearchInside_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(350, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Поиск:";
            // 
            // buttonInsideDelete
            // 
            this.buttonInsideDelete.Image = global::SWA.Properties.Resources.garbage_container;
            this.buttonInsideDelete.Location = new System.Drawing.Point(40, 3);
            this.buttonInsideDelete.Name = "buttonInsideDelete";
            this.buttonInsideDelete.Size = new System.Drawing.Size(31, 26);
            this.buttonInsideDelete.TabIndex = 11;
            this.buttonInsideDelete.UseVisualStyleBackColor = true;
            this.buttonInsideDelete.Click += new System.EventHandler(this.buttonInsideDelete_Click);
            // 
            // buttonInsideEdit
            // 
            this.buttonInsideEdit.Image = global::SWA.Properties.Resources.edit;
            this.buttonInsideEdit.Location = new System.Drawing.Point(3, 3);
            this.buttonInsideEdit.Name = "buttonInsideEdit";
            this.buttonInsideEdit.Size = new System.Drawing.Size(31, 26);
            this.buttonInsideEdit.TabIndex = 10;
            this.buttonInsideEdit.UseVisualStyleBackColor = true;
            this.buttonInsideEdit.Click += new System.EventHandler(this.buttonInsideEdit_Click);
            // 
            // dataGridViewInside
            // 
            this.dataGridViewInside.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewInside.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInside.Location = new System.Drawing.Point(3, 35);
            this.dataGridViewInside.Name = "dataGridViewInside";
            this.dataGridViewInside.Size = new System.Drawing.Size(590, 272);
            this.dataGridViewInside.TabIndex = 9;
            this.dataGridViewInside.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInside_CellClick);
            // 
            // metroTileDocumentAdd
            // 
            this.metroTileDocumentAdd.Enabled = false;
            this.metroTileDocumentAdd.Location = new System.Drawing.Point(23, 63);
            this.metroTileDocumentAdd.Name = "metroTileDocumentAdd";
            this.metroTileDocumentAdd.Size = new System.Drawing.Size(149, 23);
            this.metroTileDocumentAdd.TabIndex = 1;
            this.metroTileDocumentAdd.Text = "Добавить документ";
            this.metroTileDocumentAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDocumentAdd.Click += new System.EventHandler(this.metroTileDocumentAdd_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(30, 447);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(590, 130);
            this.richTextBoxDescription.TabIndex = 2;
            this.richTextBoxDescription.Text = "";
            // 
            // dateTimePickerDateFilter
            // 
            this.dateTimePickerDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateFilter.Location = new System.Drawing.Point(178, 66);
            this.dateTimePickerDateFilter.Name = "dateTimePickerDateFilter";
            this.dateTimePickerDateFilter.Size = new System.Drawing.Size(93, 20);
            this.dateTimePickerDateFilter.TabIndex = 3;
            this.dateTimePickerDateFilter.Value = new System.DateTime(2020, 6, 8, 0, 0, 0, 0);
            this.dateTimePickerDateFilter.ValueChanged += new System.EventHandler(this.dateTimePickerDateFilter_ValueChanged);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(277, 63);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(75, 23);
            this.buttonReload.TabIndex = 4;
            this.buttonReload.Text = "Сбросить";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Visible = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Image = global::SWA.Properties.Resources.print;
            this.buttonPrint.Location = new System.Drawing.Point(589, 65);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(31, 26);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // StudentDocumentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 600);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.dateTimePickerDateFilter);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.metroTileDocumentAdd);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(633, 600);
            this.MinimumSize = new System.Drawing.Size(633, 600);
            this.Name = "StudentDocumentsForm";
            this.Text = "Документы студентов";
            this.Load += new System.EventHandler(this.StudentDocumentsForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInside)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Button buttonInputDelete;
        private System.Windows.Forms.Button buttonInputEdit;
        private System.Windows.Forms.DataGridView dataGridViewInput;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button buttonOutputDelete;
        private System.Windows.Forms.Button buttonOutputEdit;
        private System.Windows.Forms.DataGridView dataGridViewOutput;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.Button buttonInsideDelete;
        private System.Windows.Forms.Button buttonInsideEdit;
        private System.Windows.Forms.DataGridView dataGridViewInside;
        private MetroFramework.Controls.MetroTile metroTileDocumentAdd;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearchInput;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFilter;
        private System.Windows.Forms.Button buttonReload;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearchInside;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearchOutput;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button buttonPrint;
    }
}