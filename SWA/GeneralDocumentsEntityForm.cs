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
    public partial class GeneralDocumentsEntityForm : MetroForm
    {        
        public string Id = null;
        public GeneralDocumentsForm sdf;
        GeneralDocument sd = new GeneralDocument();
        string MesAccept = String.Empty;

        public GeneralDocumentsEntityForm()
        {
            InitializeComponent();
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

        private void GeneralDocumentsEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                GetDocumentTypes();
                if (String.IsNullOrEmpty(Id))
                {
                    this.Text = "Добавление документа";
                    MesAccept = "Документ успешно добавлен";                   
                }
                else
                {
                    metroTextBoxId.Enabled = false;
                    this.Text = "Редактирование документа";
                    using(ApplicationDbContext context = new ApplicationDbContext())
                    {
                        sd = context.GeneralDocuments.Find(Id);
                        metroTextBoxId.Text = sd.GeneralDocumentId;
                        metroTextBoxName.Text = sd.GeneralDocumentName;
                        metroComboBoxType.SelectedValue = sd.DocumentTypeId;
                        metroTextBoxFrom.Text = sd.GeneralDoucmentFrom;
                        metroTextBoxTo.Text = sd.GeneralDocumentTo;
                        dateTimePickerDate.Value = sd.GeneralDocumentDateCreation;
                        richTextBoxDescription.Text = sd.GeneralDocumentDescription;
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
                    sd.GeneralDocumentId = metroTextBoxId.Text;
                    sd.GeneralDocumentName = metroTextBoxName.Text;
                    sd.DocumentTypeId = Convert.ToInt32(metroComboBoxType.SelectedValue);
                    sd.GeneralDocumentTo = metroTextBoxTo.Text;
                    sd.GeneralDoucmentFrom = metroTextBoxFrom.Text;
                    sd.GeneralDocumentDateCreation = dateTimePickerDate.Value;
                    sd.GeneralDocumentDescription = richTextBoxDescription.Text;

                    if (String.IsNullOrEmpty(Id))
                    {
                        context.GeneralDocuments.Add(sd);
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
