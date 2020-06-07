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
    public partial class StudentEntityForm : MetroForm
    {
        public StudentForm sf;
        public string StudentId = String.Empty;
        Student student = new Student();
        string MesAccept = String.Empty;

        public StudentEntityForm()
        {
            InitializeComponent();
        }

        void GetGroups()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var query = context.Groups.ToList();
                metroComboBoxGroup.DataSource = query;
                metroComboBoxGroup.DisplayMember = "GroupName";
                metroComboBoxGroup.ValueMember = "GroupId";
            }
        }

        private void StudentEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                GetGroups();
                if (String.IsNullOrEmpty(StudentId))
                {
                    this.Text = "Добавление студента";
                    MesAccept = "Студент успешно добавлен";
                }
                else
                {
                    this.Text = "Редактирование студнета";
                    using(ApplicationDbContext context = new ApplicationDbContext())
                    {
                        student = context.Students.Find(StudentId);
                        metroTextBoxId.Text = student.StudentId;
                        metroTextBoxSurname.Text = student.StudentSurName;
                        metroTextBoxFName.Text = student.StudentFirstName;
                        metroTextBoxSName.Text = student.StudentSecondName;
                        dateTimePickerBirth.Value = student.StudentBirthDate;
                        metroComboBoxGroup.SelectedValue = student.GroupId;
                        metroComboBoxGender.Text = student.StudentGender;
                        metroTextBoxAdress.Text = student.StudentAdress;
                        maskedTextBox1.Text = student.StudentTelephone;
                        if(student.AdmissionDate != null)
                        {
                            dateTimePickerDateA.Value = Convert.ToDateTime(student.AdmissionDate);
                            metroCheckBoxDateA.Checked = false;
                        }
                        if (student.GetOutDate != null)
                        {
                            dateTimePickerDateO.Value = Convert.ToDateTime(student.GetOutDate);
                            metroCheckBoxDateO.Checked = false;
                        }
                        if(student.GraduationDate != null)
                        {
                            dateTimePickerDateG.Value = Convert.ToDateTime(student.GraduationDate);
                            metroCheckBoxDateG.Checked = false;
                        }                        
                    }
                    MesAccept = "Студент успешно изменен";
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
                if (String.IsNullOrEmpty(metroTextBoxId.Text))
                {
                    throw new Exception("Введите код студента студента");
                }
                else if (String.IsNullOrEmpty(metroTextBoxSurname.Text))
                {
                    throw new Exception("Введите фамилию студента");
                }
                else if (String.IsNullOrEmpty(metroTextBoxFName.Text))
                {
                    throw new Exception("Введите имя студента");
                }
                else if (String.IsNullOrEmpty(metroTextBoxSName.Text))
                {
                    throw new Exception("Введите отчество студента");
                }
                else if (String.IsNullOrEmpty(metroTextBoxAdress.Text))
                {
                    throw new Exception("Введите адрес студента");
                }
                else if (String.IsNullOrEmpty(maskedTextBox1.Text))
                {
                    throw new Exception("Введите телефон студента");
                }

                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    student.StudentId = metroTextBoxId.Text;
                    student.StudentSurName = metroTextBoxSurname.Text;
                    student.StudentFirstName = metroTextBoxFName.Text;
                    student.StudentSecondName = metroTextBoxSName.Text;
                    student.GroupId = Convert.ToInt32(metroComboBoxGroup.SelectedValue.ToString());
                    student.StudentBirthDate = dateTimePickerBirth.Value;
                    student.StudentGender = metroComboBoxGender.Text;
                    student.StudentAdress = metroTextBoxAdress.Text;
                    student.StudentTelephone = maskedTextBox1.Text;

                    if (!metroCheckBoxDateA.Checked)
                    {
                        student.AdmissionDate = dateTimePickerDateA.Value;
                    }
                    else
                    {
                        student.AdmissionDate = null;
                    }

                    if (!metroCheckBoxDateO.Checked)
                    {
                        student.GetOutDate = dateTimePickerDateO.Value;
                    }
                    else
                    {
                        student.GetOutDate = null;
                    }

                    if (!metroCheckBoxDateG.Checked)
                    {
                        student.GraduationDate = dateTimePickerDateG.Value;
                    }
                    else
                    {
                        student.GraduationDate = null;
                    }

                    if (String.IsNullOrEmpty(StudentId))
                    {
                        context.Students.Add(student);
                    }
                    else
                    {
                        context.Entry(student).State = EntityState.Modified;
                    }
                    await context.SaveChangesAsync();
                    var group = context.Groups.Find(Convert.ToInt32(metroComboBoxGroup.SelectedValue));
                    group.GroupCount = context.Groups.Find(Convert.ToInt32(metroComboBoxGroup.SelectedValue)).Students.Count;
                    await context.SaveChangesAsync();
                    sf.StudentsTable(await context.Students.Include(g => g.Group).ToListAsync());
                }
                MessageBox.Show(MesAccept, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroCheckBoxDateA_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBoxDateA.Checked)
            {
                dateTimePickerDateA.Enabled = false;
            }
            else
            {
                dateTimePickerDateA.Enabled = true;
            }
        }

        private void metroCheckBoxDateO_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBoxDateO.Checked)
            {
                dateTimePickerDateO.Enabled = false;                
            }
            else
            {
                dateTimePickerDateO.Enabled = true;
            }
        }

        private void metroCheckBoxDateG_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBoxDateG.Checked)
            {
                dateTimePickerDateG.Enabled = false;
            }
            else
            {
                dateTimePickerDateG.Enabled = true;
            }
        }
    }
}
