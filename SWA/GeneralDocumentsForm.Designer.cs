namespace SWA
{
    partial class GeneralDocumentsForm
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
            this.buttonInputDelete = new System.Windows.Forms.Button();
            this.buttonInputEdit = new System.Windows.Forms.Button();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridViewOutput = new System.Windows.Forms.DataGridView();
            this.buttonOutputDelete = new System.Windows.Forms.Button();
            this.buttonOutputEdit = new System.Windows.Forms.Button();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.buttonInsideDelete = new System.Windows.Forms.Button();
            this.buttonInsideEdit = new System.Windows.Forms.Button();
            this.dataGridViewInside = new System.Windows.Forms.DataGridView();
            this.metroTileDocumentAdd = new MetroFramework.Controls.MetroTile();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
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
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 92);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1154, 349);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.buttonInputDelete);
            this.metroTabPage1.Controls.Add(this.buttonInputEdit);
            this.metroTabPage1.Controls.Add(this.dataGridViewInput);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1146, 310);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Входящие";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
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
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.Location = new System.Drawing.Point(3, 35);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.Size = new System.Drawing.Size(1140, 272);
            this.dataGridViewInput.TabIndex = 5;
            this.dataGridViewInput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInput_CellClick);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.dataGridViewOutput);
            this.metroTabPage2.Controls.Add(this.buttonOutputDelete);
            this.metroTabPage2.Controls.Add(this.buttonOutputEdit);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1146, 310);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Исходящие";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // dataGridViewOutput
            // 
            this.dataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput.Location = new System.Drawing.Point(3, 35);
            this.dataGridViewOutput.Name = "dataGridViewOutput";
            this.dataGridViewOutput.Size = new System.Drawing.Size(1140, 272);
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
            this.metroTabPage3.Controls.Add(this.buttonInsideDelete);
            this.metroTabPage3.Controls.Add(this.buttonInsideEdit);
            this.metroTabPage3.Controls.Add(this.dataGridViewInside);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1146, 310);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Внутренние";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
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
            this.dataGridViewInside.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInside.Location = new System.Drawing.Point(3, 35);
            this.dataGridViewInside.Name = "dataGridViewInside";
            this.dataGridViewInside.Size = new System.Drawing.Size(1140, 272);
            this.dataGridViewInside.TabIndex = 9;
            this.dataGridViewInside.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInside_CellClick);
            // 
            // metroTileDocumentAdd
            // 
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
            this.richTextBoxDescription.Size = new System.Drawing.Size(1140, 130);
            this.richTextBoxDescription.TabIndex = 2;
            this.richTextBoxDescription.Text = "";
            // 
            // GeneralDocumentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.metroTileDocumentAdd);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "GeneralDocumentsForm";
            this.Text = "Общие документы";
            this.Load += new System.EventHandler(this.GeneralDocumentsForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
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
    }
}