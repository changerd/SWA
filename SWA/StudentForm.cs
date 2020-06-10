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
    public partial class StudentForm : MetroForm
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            metroTabControl1_SelectedIndexChanged(sender, e);
        }

        private async void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {


                    if (metroTabControl1.SelectedIndex == 0)
                    {
                        StudentsTable(await context.Students.Include(g => g.Group).ToListAsync());
                    }
                    else if (metroTabControl1.SelectedIndex == 1)
                    {
                        StudyFormsTable(await context.StudyForms.ToListAsync());
                        SpecialitiesTable(await context.Specialties.Include(s => s.StudyForm).ToListAsync());
                        GroupsTable(await context.Groups.Include(s => s.Specialty).ToListAsync());
                    }
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void StudyFormsTable(List<StudyForm> query)
        {
            DataTable sfTable = new DataTable();
            DataColumn sfIdC = new DataColumn("Код", typeof(int));
            DataColumn sfNameC = new DataColumn("Название", typeof(string));
            sfTable.Columns.AddRange(new DataColumn[]
            {
                sfIdC,
                sfNameC,
            });
            int i = 0;
            foreach (var item in query)
            {
                DataRow newRow = sfTable.NewRow();
                newRow[0] = item.StudyFormId;
                newRow[1] = item.StudyFormName;
                sfTable.Rows.Add(newRow);
                i++;
            }
            dataGridViewStudyForm.DataSource = sfTable;
        }

        public void SpecialitiesTable(List<Specialty> query)
        {
            DataTable sTable = new DataTable();
            DataColumn sIdC = new DataColumn("Код", typeof(string));
            DataColumn sNameC = new DataColumn("Название", typeof(string));
            DataColumn sSTC = new DataColumn("Срок обучения", typeof(string));
            DataColumn sSFC = new DataColumn("Форма обучения", typeof(string));
            sTable.Columns.AddRange(new DataColumn[]
            {
                sIdC,
                sNameC,
                sSTC,
                sSFC
            });
            int i = 0;
            foreach (var item in query)
            {
                DataRow newRow = sTable.NewRow();
                newRow[0] = item.SpecialtyId;
                newRow[1] = item.SpecialtyName;
                newRow[2] = item.SpecialityTime;
                newRow[3] = item.StudyForm.StudyFormName;
                sTable.Rows.Add(newRow);
                i++;
            }
            dataGridViewSpecialty.DataSource = sTable;
        }

        public void GroupsTable(List<Group> query)
        {
            DataTable gTable = new DataTable();
            DataColumn gIdC = new DataColumn("Код", typeof(int));
            DataColumn gNameC = new DataColumn("Название", typeof(string));
            DataColumn gCourceC = new DataColumn("Курс", typeof(int));
            DataColumn gCountC = new DataColumn("Количество учащихся", typeof(int));
            DataColumn gESC = new DataColumn("Год выпуска", typeof(int));
            DataColumn gSpecialty = new DataColumn("Специальность", typeof(string));
            gTable.Columns.AddRange(new DataColumn[]
            {
                gIdC,
                gNameC,
                gCourceC,
                gCountC,
                gESC,
                gSpecialty
            });
            int i = 0;
            foreach (var item in query)
            {
                DataRow newRow = gTable.NewRow();
                newRow[0] = item.GroupId;
                newRow[1] = item.GroupName;
                newRow[2] = item.GroupCourse;
                newRow[3] = item.GroupCount;
                newRow[4] = item.GroupEndStudy;
                newRow[5] = String.Format("{0} {1}", item.Specialty.SpecialtyId, item.Specialty.SpecialtyName);
                gTable.Rows.Add(newRow);
                i++;
            }
            dataGridViewGroup.DataSource = gTable;
        }

        public void StudentsTable(List<Student> query)
        {
            DataTable sTable = new DataTable();
            DataColumn sIdC = new DataColumn("Код", typeof(string));
            DataColumn sSNameC = new DataColumn("Фамилия", typeof(string));
            DataColumn sFNameC = new DataColumn("Имя", typeof(string));
            DataColumn sSecNameC = new DataColumn("Отчество", typeof(string));
            DataColumn sGroupC = new DataColumn("Группа", typeof(string));
            DataColumn sBDateC = new DataColumn("Дата рождения", typeof(string));
            DataColumn sGenderC = new DataColumn("Пол", typeof(string));
            DataColumn sAdressC = new DataColumn("Адрес", typeof(string));
            DataColumn sTelephoneC = new DataColumn("Телефон", typeof(string));
            DataColumn sADateC = new DataColumn("Дата зачисления", typeof(string));
            DataColumn sGODateC = new DataColumn("Дата отчисления", typeof(string));
            DataColumn sGDateC = new DataColumn("Дата выпуска", typeof(string));

            sTable.Columns.AddRange(new DataColumn[]
            {
                sIdC,
                sSNameC,
                sFNameC,
                sSecNameC,
                sGroupC,
                sBDateC,
                sGenderC,
                sAdressC,
                sTelephoneC,
                sADateC,
                sGODateC,
                sGDateC
            });
            int i = 0;
            foreach (var item in query)
            {
                DataRow newRow = sTable.NewRow();
                newRow[0] = item.StudentId;
                newRow[1] = item.StudentSurName;
                newRow[2] = item.StudentFirstName;
                newRow[3] = item.StudentSecondName;
                newRow[4] = item.Group.GroupName;
                newRow[5] = item.StudentBirthDate.ToShortDateString();
                newRow[6] = item.StudentGender;
                newRow[7] = item.StudentAdress;
                newRow[8] = item.StudentTelephone;
                newRow[9] = (item.AdmissionDate.HasValue) ? Convert.ToDateTime(item.AdmissionDate.Value).ToShortDateString() : "-";
                newRow[10] = (item.GetOutDate.HasValue) ? Convert.ToDateTime(item.GetOutDate.Value).ToShortDateString() : "-";
                newRow[11] = (item.GraduationDate.HasValue) ? Convert.ToDateTime(item.GraduationDate.Value).ToShortDateString() : "-";
                sTable.Rows.Add(newRow);
                i++;
            }
            dataGridViewStudent.DataSource = sTable;
        }


        private void buttonStudyFormAdd_Click(object sender, EventArgs e)
        {
            var Form = new StudyFormEntityForm();
            Form.sf = this;
            Form.Show();
        }

        private void buttonStudyFormEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var sSFId = dataGridViewStudyForm.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(sSFId))
                {
                    throw new Exception("Не выбрана форма обучения");
                }

                var Form = new StudyFormEntityForm();
                Form.StudyFormId = Int32.Parse(dataGridViewStudyForm.SelectedCells[0].Value.ToString());
                Form.sf = this;
                Form.Show();

            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonStudyFormDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var sSFId = dataGridViewStudyForm.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(sSFId))
                {
                    throw new Exception("Не выбрана форма обучения");
                }

                DialogResult dialog = MessageBox.Show("Удалить форму обучения: " + dataGridViewStudyForm.SelectedCells[1].Value.ToString(), "SWA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        var sf = await context.StudyForms.FindAsync(Int32.Parse(sSFId));
                        context.Entry(sf).State = EntityState.Deleted;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Удаление успешно завершено", "SWA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    metroTabControl1_SelectedIndexChanged(sender, e);
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpecialtyAdd_Click(object sender, EventArgs e)
        {
            var Form = new SpecialtyEntityForm();
            Form.sf = this;
            Form.Show();
        }

        private void buttonSpecialtyEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var sSFId = dataGridViewSpecialty.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(sSFId))
                {
                    throw new Exception("Не выбрана специальность");
                }

                var Form = new SpecialtyEntityForm();
                Form.SpecialtyId = dataGridViewSpecialty.SelectedCells[0].Value.ToString();
                Form.sf = this;
                Form.Show();

            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonSpecialtyDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var sId = dataGridViewSpecialty.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(sId))
                {
                    throw new Exception("Не выбрана специальность");
                }

                DialogResult dialog = MessageBox.Show("Удалить специальность: " + dataGridViewSpecialty.SelectedCells[0].Value.ToString() + " " + dataGridViewSpecialty.SelectedCells[1].Value.ToString(), "SWA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        var specialty = await context.Specialties.FindAsync(sId);
                        context.Entry(specialty).State = EntityState.Deleted;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Удаление успешно завершено", "SWA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    metroTabControl1_SelectedIndexChanged(sender, e);
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGroupAdd_Click(object sender, EventArgs e)
        {
            var Form = new GroupEntityForm();
            Form.sf = this;
            Form.Show();
        }

        private void buttonGroupEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var sgId = dataGridViewGroup.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(sgId))
                {
                    throw new Exception("Не выбрана группа");
                }

                var Form = new GroupEntityForm();
                Form.GroupId = Int32.Parse(sgId);
                Form.sf = this;
                Form.Show();

            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonGroupDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var gId = dataGridViewGroup.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(gId))
                {
                    throw new Exception("Не выбрана группа");
                }

                DialogResult dialog = MessageBox.Show("Удалить группу: " + dataGridViewGroup.SelectedCells[1].Value.ToString(), "SWA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        var group = await context.Groups.FindAsync(Int32.Parse(gId));
                        context.Entry(group).State = EntityState.Deleted;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Удаление успешно завершено", "SWA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    metroTabControl1_SelectedIndexChanged(sender, e);
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStudentAdd_Click(object sender, EventArgs e)
        {
            var Form = new StudentEntityForm();
            Form.sf = this;
            Form.Show();
        }

        private void buttonStudentEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var sId = dataGridViewStudent.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(sId))
                {
                    throw new Exception("Не выбран студент");
                }

                var Form = new StudentEntityForm();
                Form.StudentId = sId;
                Form.sf = this;
                Form.Show();

            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonStudentDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var sId = dataGridViewStudent.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(sId))
                {
                    throw new Exception("Не выбран студент");
                }

                DialogResult dialog = MessageBox.Show(String.Format("Удалить студента: {0} {1} {2}?", dataGridViewStudent.SelectedCells[1].Value.ToString(), dataGridViewStudent.SelectedCells[2].Value.ToString(), dataGridViewStudent.SelectedCells[3].Value.ToString()), "SWA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        string gname = dataGridViewStudent.SelectedCells[4].Value.ToString();
                        var student = await context.Students.FindAsync(sId);
                        var group = await context.Groups.FirstOrDefaultAsync(g => g.GroupName == gname);
                        var sdocuments = context.StudentDocuments.Where(s => s.StudentId == sId);
                        context.StudentDocuments.RemoveRange(sdocuments);
                        await context.SaveChangesAsync();
                        context.Entry(student).State = EntityState.Deleted;
                        await context.SaveChangesAsync();
                        group.GroupCount = context.Groups.FirstOrDefault(g => g.GroupName == gname).Students.Count;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Удаление успешно завершено", "SWA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StudentsTable(await context.Students.Include(g => g.Group).ToListAsync());
                    }
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var sId = dataGridViewStudent.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(sId))
                {
                    throw new Exception("Не выбран студент");
                }

                var Form = new StudentDocumentsForm();
                Form.StudentId = sId;
                Form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStudentDocuments_Click(object sender, EventArgs e)
        {
            var Form = new StudentDocumentsForm();
            Form.Show();
        }

        public void filter()
        {
            buttonStudentFilter.Visible = false;
            buttonReloadFilter.Visible = true;
        }

        private async void buttonReloadFilter_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                StudentsTable(await context.Students.Include(g => g.Group).ToListAsync());
            }
            buttonStudentFilter.Visible = true;
            buttonReloadFilter.Visible = false;
            
        }

        private void buttonStudentFilter_Click(object sender, EventArgs e)
        {
            var Form = new StudentFilterForm();
            Form.sf = this;
            Form.Show();
        }

        private void metroTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager cManager = dataGridViewStudent.BindingContext[dataGridViewStudent.DataSource, dataGridViewStudent.DataMember] as CurrencyManager;
                cManager.SuspendBinding();
                cManager.ResumeBinding();
                for (int i = 0; i < dataGridViewStudent.RowCount; i++)
                {
                    dataGridViewStudent.Rows[i].Selected = false;
                }
                if (metroTextBoxSearch.Text == "")
                    for (int i = 0; i < dataGridViewStudent.RowCount; i++)
                    {
                        dataGridViewStudent.Rows[i].Selected = false;
                        dataGridViewStudent.Rows[i].Visible = true;
                    }
                else
                {
                    for (int i = 0; i < dataGridViewStudent.RowCount; i++)
                    {
                        dataGridViewStudent.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridViewStudent.ColumnCount; j++)
                            if (dataGridViewStudent.Rows[i].Cells[j].Value != null)

                                if (dataGridViewStudent.Rows[i].Cells[j].Value.ToString().Contains(metroTextBoxSearch.Text))
                                {
                                    dataGridViewStudent.Rows[i].Selected = true;
                                    dataGridViewStudent.Rows[i].Visible = true;
                                    break;
                                }
                                else
                                {
                                    dataGridViewStudent.Rows[i].Selected = false;
                                    dataGridViewStudent.Rows[i].Visible = false;
                                }
                    }
                }
            }

            catch
            {
                MessageBox.Show("При поиске произошла ошибка, для исправления выберите другую строку");
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            var Form = new StudentPrintForm();
            Form.Show();
        }
    }
}
