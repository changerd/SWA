using MetroFramework.Forms;
using SWA.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SWA
{
    public partial class StudentDocumentsEntityForm : MetroForm
    {
        public string StudentId = null;
        public string Id = null;
        public StudentDocumentsForm sdf;
        StudentDocument sd = new StudentDocument();
        string MesAccept = String.Empty;

        public StudentDocumentsEntityForm()
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

        private void StudentDocumentsEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                GetDocumentTypes();
                if (String.IsNullOrEmpty(Id))
                {
                    this.Text = "Добавление документа";
                    MesAccept = "Документ успешно добавлен";
                    sd.StudentId = StudentId;
                }
                else
                {
                    metroTextBoxId.Enabled = false;
                    this.Text = "Редактирование документа";
                    using(ApplicationDbContext context = new ApplicationDbContext())
                    {
                        sd = context.StudentDocuments.Find(Id);
                        metroTextBoxId.Text = sd.StudentDocumentId;
                        metroTextBoxName.Text = sd.StudentDocumentName;
                        metroComboBoxType.SelectedValue = sd.DocumentTypeId;
                        metroTextBoxFrom.Text = sd.StudentDoucmentFrom;
                        metroTextBoxTo.Text = sd.StudentDocumentTo;
                        dateTimePickerDate.Value = sd.StudentDocumentDateCreation;
                        richTextBoxDescription.Text = sd.StudentDocumentDescription;
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
                    sd.StudentDocumentId = metroTextBoxId.Text;
                    sd.StudentDocumentName = metroTextBoxName.Text;
                    sd.DocumentTypeId = Convert.ToInt32(metroComboBoxType.SelectedValue);
                    sd.StudentDocumentTo = metroTextBoxTo.Text;
                    sd.StudentDoucmentFrom = metroTextBoxFrom.Text;
                    sd.StudentDocumentDateCreation = dateTimePickerDate.Value;
                    sd.StudentDocumentDescription = richTextBoxDescription.Text;

                    if (String.IsNullOrEmpty(Id))
                    {
                        context.StudentDocuments.Add(sd);
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
