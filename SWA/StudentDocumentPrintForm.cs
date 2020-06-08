using MetroFramework.Forms;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace SWA
{
    public partial class StudentDocumentPrintForm : MetroForm
    {
        public string StudentId = null;

        public StudentDocumentPrintForm()
        {
            InitializeComponent();
        }

        void GetDocumentTypes()
        {
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                var query = context.DocumentTypes.ToList();
                query.Insert(0, new Entities.DocumentType
                {
                    DocumentTypeId = 0,
                    DocumentTypeName = "Все",
                });
                metroComboBoxType.DataSource = query;
                metroComboBoxType.DisplayMember = "DocumentTypeName";
                metroComboBoxType.ValueMember = "DocumentTypeId";
            }
        }

        private void StudentDocumentPrintForm_Load(object sender, EventArgs e)
        {
            GetDocumentTypes();
        }

        private void metroTilePrint_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Сохранение xlsx файла";
                saveFileDialog1.Filter = "xlsx файлы (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Workbooks.Add();
                    Excel._Worksheet worksheet = excelApp.ActiveSheet;
                    worksheet.Cells[1, "A"] = "Номер документа";
                    worksheet.Cells[1, "B"] = "Название документа";
                    worksheet.Cells[1, "C"] = "Тип документа";
                    worksheet.Cells[1, "D"] = "Студент";
                    worksheet.Cells[1, "E"] = "От кого";
                    worksheet.Cells[1, "F"] = "Кому";
                    worksheet.Cells[1, "G"] = "Дата";
                    worksheet.Cells[1, "H"] = "Примечание";
                    
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        int row = 1;
                        var documents = context.StudentDocuments.Include(t => t.DocumentType).Include(s => s.Student);

                        if (!String.IsNullOrEmpty(StudentId))
                        {
                            documents = documents.Where(s => s.StudentId == StudentId);
                        }

                        if(metroComboBoxType.Text != "Все")
                        {
                            documents = documents.Where(s => s.DocumentType.DocumentTypeName == metroComboBoxType.Text);
                        }

                        if(metroCheckBoxDate.Checked)
                        {
                            documents = documents.Where(s => s.StudentDocumentDateCreation >= dateTimePickerFirst.Value && s.StudentDocumentDateCreation <= dateTimePickerSecond.Value);
                        }

                        foreach(var item in documents)
                        {
                            row++;
                            worksheet.Cells[row, "A"] = item.StudentDocumentId.ToString();
                            worksheet.Cells[row, "B"] = item.StudentDocumentName.ToString();
                            worksheet.Cells[row, "C"] = item.DocumentType.DocumentTypeName.ToString();
                            worksheet.Cells[row, "D"] = String.Format("{0} {1} {2}", item.Student.StudentSurName.ToString(), item.Student.StudentFirstName.ToString(), item.Student.StudentSecondName.ToString());
                            worksheet.Cells[row, "E"] = item.StudentDoucmentFrom.ToString();
                            worksheet.Cells[row, "F"] = item.StudentDocumentTo.ToString();
                            worksheet.Cells[row, "G"] = item.StudentDocumentDateCreation.ToShortDateString();
                            worksheet.Cells[row, "H"] = item.StudentDocumentDescription.ToString();
                        }
                    }
                    worksheet.Range["A1"].AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic1);                    
                    worksheet.SaveAs(string.Format(saveFileDialog1.FileName));
                    excelApp.Quit();
                    MessageBox.Show("Сохранение завершено", "SWA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroCheckBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBoxDate.Checked)
            {
                dateTimePickerFirst.Enabled = true;
                dateTimePickerSecond.Enabled = true;
            }
            else
            {
                dateTimePickerFirst.Enabled = false;
                dateTimePickerSecond.Enabled = false;
            }    
        }
    }
}
