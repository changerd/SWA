using MetroFramework.Forms;
using SWA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWA
{
    public partial class StaffDocumentsEntityForm : MetroForm
    {
        public int StaffId = 0;
        public string Id = null;
        public StaffDocumentsForm sdf;
        StaffDocument sd = new StaffDocument();
        string MesAccept = String.Empty;

        public StaffDocumentsEntityForm()
        {
            InitializeComponent();
            dateTimePickerDate.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }

        void GetDocumentTypes()
        {
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                var query = context.DocumentTypes.ToList();
                metroComboBoxType.DataSource = query;
                metroComboBoxType.DisplayMember = "DocumentTypeName";
                metroComboBoxType.ValueMember = "DocumentTypeId";
            }
        }

        private void StaffDocumentsEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                GetDocumentTypes();
                if (String.IsNullOrEmpty(Id))
                {
                    this.Text = "Добавление документа";
                    MesAccept = "Документ успешно добавлен";
                    sd.StaffId = StaffId;
                }
                else
                {
                    metroTextBoxId.Enabled = false;
                    this.Text = "Редактирование документа";
                    using(ApplicationDbContext context = new ApplicationDbContext())
                    {
                        sd = context.StaffDocuments.Find(Id);
                        metroTextBoxId.Text = sd.StaffDocumentId;
                        metroTextBoxName.Text = sd.StaffDocumentName;
                        metroComboBoxType.SelectedValue = sd.DocumentTypeId;
                        metroTextBoxFrom.Text = sd.StaffDoucmentFrom;
                        metroTextBoxTo.Text = sd.StaffDocumentTo;
                        dateTimePickerDate.Value = sd.StaffDocumentDateCreation;
                        richTextBoxDescription.Text = sd.StaffDocumentDescription;
                    }
                    MesAccept = "Документ успешно изменен";
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void metroTileAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(metroTextBoxId.Text))
                {
                    throw new Exception("Введите номер документа");
                }
                else if (String.IsNullOrEmpty(metroTextBoxTo.Text))
                {
                    throw new Exception("Введите для кого предназначен документ");
                }
                else if (String.IsNullOrEmpty(metroTextBoxFrom.Text))
                {
                    throw new Exception("Введите от кого документ");
                } 
                else if (String.IsNullOrEmpty(richTextBoxDescription.Text))
                {
                    throw new Exception("Введите номер документа");
                }
                else if (String.IsNullOrEmpty(metroTextBoxName.Text))
                {
                    throw new Exception("Введите название документа");
                }

                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    sd.StaffDocumentId = metroTextBoxId.Text;
                    sd.StaffDocumentName = metroTextBoxName.Text;
                    sd.DocumentTypeId = Convert.ToInt32(metroComboBoxType.SelectedValue);
                    sd.StaffDocumentTo = metroTextBoxTo.Text;
                    sd.StaffDoucmentFrom = metroTextBoxFrom.Text;
                    sd.StaffDocumentDateCreation = dateTimePickerDate.Value;
                    sd.StaffDocumentDescription = richTextBoxDescription.Text;

                    if (String.IsNullOrEmpty(Id))
                    {
                        context.StaffDocuments.Add(sd);
                    }
                    else
                    {
                        context.Entry(sd).State = EntityState.Modified;
                    }
                    await context.SaveChangesAsync();
                    sdf.metroTabControl1_SelectedIndexChanged(sender, e);
                }
                MessageBox.Show(MesAccept, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

                
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
