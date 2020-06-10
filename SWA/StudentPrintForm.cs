using MetroFramework.Forms;
using SWA.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SWA
{
    public partial class StudentPrintForm : MetroForm
    {
        public StudentForm sf;
        public StudentPrintForm()
        {
            InitializeComponent();
        }

        void GetSpecialties()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var query = context.Specialties.ToList();
                var query1 = new List<SpecialtyComboBox>();
                foreach (var item in query)
                {
                    query1.Add(new SpecialtyComboBox()
                    {
                        Id = item.SpecialtyId,
                        Name = item.SpecialtyId + " " + item.SpecialtyName,
                    });
                }
                query1.Insert(0, new SpecialtyComboBox
                {
                    Id = "",
                    Name = "Все"
                });
                metroComboBoxSpecialty.DataSource = query1;
                metroComboBoxSpecialty.DisplayMember = "Name";
                metroComboBoxSpecialty.ValueMember = "Id";
            }
        }

        private void metroComboBoxSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sId = metroComboBoxSpecialty.SelectedValue.ToString();
            using (ApplicationDbContext context = new ApplicationDbContext())
            {                
                
                var query = context.Groups.Where(s => s.SpecialtyId == sId).ToList();
                query.Insert(0, new Entities.Group
                {
                    GroupId = 0,
                    GroupName = "Пусто"
                });
                metroComboBoxGroup.DataSource = query;
                metroComboBoxGroup.DisplayMember = "GroupName";               
                metroComboBoxGroup.ValueMember = "GroupId";               
            }
        }

        private void StudentPrintForm_Load(object sender, EventArgs e)
        {
            GetSpecialties();
        }

        private void metroTileAccept_Click(object sender, EventArgs e)
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
                    worksheet.Cells[1, "A"] = "Код студента";
                    worksheet.Cells[1, "B"] = "Фамилия";
                    worksheet.Cells[1, "C"] = "Имя";
                    worksheet.Cells[1, "D"] = "Отчество";
                    worksheet.Cells[1, "E"] = "Группа";
                    worksheet.Cells[1, "F"] = "Дата рождения";
                    worksheet.Cells[1, "G"] = "Пол";
                    worksheet.Cells[1, "H"] = "Адрес";
                    worksheet.Cells[1, "I"] = "Телефон";
                    worksheet.Cells[1, "J"] = "Дата зачисления";
                    worksheet.Cells[1, "K"] = "Дата отчисления";
                    worksheet.Cells[1, "L"] = "Дата выпуска";

                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        int row = 1;
                        var students = context.Students.Include(g => g.Group);

                        if (metroComboBoxSpecialty.Text != "Все")
                        {
                            students = students.Where(s => s.Group.SpecialtyId == metroComboBoxSpecialty.SelectedValue.ToString());
                        }

                        if (metroComboBoxGroup.Text != "Пусто")
                        {
                            int gId = Convert.ToInt32(metroComboBoxGroup.SelectedValue.ToString());
                            students = students.Where(s => s.GroupId == gId);
                        }

                        foreach (var item in students)
                        {
                            row++;
                            worksheet.Cells[row, "A"] = item.StudentId;
                            worksheet.Cells[row, "B"] = item.StudentSurName;
                            worksheet.Cells[row, "C"] = item.StudentFirstName;
                            worksheet.Cells[row, "D"] = item.StudentSecondName;
                            worksheet.Cells[row, "E"] = item.Group.GroupName;
                            worksheet.Cells[row, "F"] = item.StudentBirthDate.ToShortDateString();
                            worksheet.Cells[row, "G"] = item.StudentGender;
                            worksheet.Cells[row, "H"] = item.StudentAdress;
                            worksheet.Cells[row, "I"] = item.StudentTelephone;
                            worksheet.Cells[row, "J"] = (item.AdmissionDate.HasValue) ? Convert.ToDateTime(item.AdmissionDate.Value).ToShortDateString() : "-";
                            worksheet.Cells[row, "K"] = (item.GetOutDate.HasValue) ? Convert.ToDateTime(item.GetOutDate.Value).ToShortDateString() : "-";
                            worksheet.Cells[row, "L"] = (item.GraduationDate.HasValue) ? Convert.ToDateTime(item.GraduationDate.Value).ToShortDateString() : "-";
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

        
    }
}
