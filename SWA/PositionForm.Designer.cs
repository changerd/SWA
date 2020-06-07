namespace SWA
{
    partial class PositionForm
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
            this.buttonPositionAdd = new System.Windows.Forms.Button();
            this.buttonPositionEdit = new System.Windows.Forms.Button();
            this.buttonPositionDelete = new System.Windows.Forms.Button();
            this.dataGridViewPosition = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPositionAdd
            // 
            this.buttonPositionAdd.Image = global::SWA.Properties.Resources.plus_sign;
            this.buttonPositionAdd.Location = new System.Drawing.Point(23, 63);
            this.buttonPositionAdd.Name = "buttonPositionAdd";
            this.buttonPositionAdd.Size = new System.Drawing.Size(32, 26);
            this.buttonPositionAdd.TabIndex = 0;
            this.buttonPositionAdd.UseVisualStyleBackColor = true;
            this.buttonPositionAdd.Click += new System.EventHandler(this.buttonPositionAdd_Click);
            // 
            // buttonPositionEdit
            // 
            this.buttonPositionEdit.Image = global::SWA.Properties.Resources.edit;
            this.buttonPositionEdit.Location = new System.Drawing.Point(61, 63);
            this.buttonPositionEdit.Name = "buttonPositionEdit";
            this.buttonPositionEdit.Size = new System.Drawing.Size(31, 26);
            this.buttonPositionEdit.TabIndex = 1;
            this.buttonPositionEdit.UseVisualStyleBackColor = true;
            this.buttonPositionEdit.Click += new System.EventHandler(this.buttonPositionEdit_Click);
            // 
            // buttonPositionDelete
            // 
            this.buttonPositionDelete.Image = global::SWA.Properties.Resources.garbage_container;
            this.buttonPositionDelete.Location = new System.Drawing.Point(98, 63);
            this.buttonPositionDelete.Name = "buttonPositionDelete";
            this.buttonPositionDelete.Size = new System.Drawing.Size(31, 26);
            this.buttonPositionDelete.TabIndex = 2;
            this.buttonPositionDelete.UseVisualStyleBackColor = true;
            this.buttonPositionDelete.Click += new System.EventHandler(this.buttonPositionDelete_Click);
            // 
            // dataGridViewPosition
            // 
            this.dataGridViewPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosition.Location = new System.Drawing.Point(23, 95);
            this.dataGridViewPosition.Name = "dataGridViewPosition";
            this.dataGridViewPosition.Size = new System.Drawing.Size(247, 270);
            this.dataGridViewPosition.TabIndex = 3;
            // 
            // PositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 388);
            this.Controls.Add(this.dataGridViewPosition);
            this.Controls.Add(this.buttonPositionDelete);
            this.Controls.Add(this.buttonPositionEdit);
            this.Controls.Add(this.buttonPositionAdd);
            this.Name = "PositionForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Должности";
            this.Load += new System.EventHandler(this.PositionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPositionAdd;
        private System.Windows.Forms.Button buttonPositionEdit;
        private System.Windows.Forms.Button buttonPositionDelete;
        private System.Windows.Forms.DataGridView dataGridViewPosition;
    }
}