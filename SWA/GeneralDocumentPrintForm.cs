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
    public partial class GeneralDocumentPrintForm : MetroForm
    {        

        public GeneralDocumentPrintForm()
        {
            InitializeComponent();
            dateTimePickerFirst.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            dateTimePickerSecond.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
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

        private void GeneralDocumentPrintForm_Load(object sender, EventArgs e)
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
                    worksheet.Cells[1, "D"] = "От кого";
                    worksheet.Cells[1, "E"] = "Кому";
                    worksheet.Cells[1, "F"] = "ДАта";
                    worksheet.Cells[1, "G"] = "Примечание";
                    
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        int row = 1;
                        var documents = context.GeneralDocuments.Include(t => t.DocumentType);                        

                        if(metroComboBoxType.Text != "Все")
                        {
                            documents = documents.Where(s => s.DocumentType.DocumentTypeName == metroComboBoxType.Text);
                        }

                        if(metroCheckBoxDate.Checked)
                        {
                            documents = documents.Where(s => s.GeneralDocumentDateCreation >= dateTimePickerFirst.Value && s.GeneralDocumentDateCreation <= dateTimePickerSecond.Value);
                        }

                        foreach(var item in documents)
                        {
                            row++;
                            worksheet.Cells[row, "A"] = item.GeneralDocumentId.ToString();
                            worksheet.Cells[row, "B"] = item.GeneralDocumentName.ToString();
                            worksheet.Cells[row, "C"] = item.DocumentType.DocumentTypeName.ToString();                            
                            worksheet.Cells[row, "D"] = item.GeneralDoucmentFrom.ToString();
                            worksheet.Cells[row, "E"] = item.GeneralDocumentTo.ToString();
                            worksheet.Cells[row, "F"] = item.GeneralDocumentDateCreation.ToShortDateString();
                            worksheet.Cells[row, "G"] = item.GeneralDocumentDescription.ToString();
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
