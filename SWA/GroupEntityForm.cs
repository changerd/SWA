using MetroFramework.Forms;
using SWA.Entities;
using SWA.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SWA
{
    public partial class GroupEntityForm : MetroForm
    {
        public StudentForm sf;
        public int GroupId = 0;
        Group group = new Group();
        string MesAccept = String.Empty;

        public GroupEntityForm()
        {
            InitializeComponent();
        }

        void GetSpecialties()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var query = context.Specialties.ToList();
                var query1 = new List<SpecialtyComboBox>();
                foreach(var item in query)
                {
                    query1.Add(new SpecialtyComboBox()
                    {
                        Id = item.SpecialtyId,
                        Name = item.SpecialtyId + " " + item.SpecialtyName,
                    });
                }
                metroComboBoxSpecialty.DataSource = query1;
                metroComboBoxSpecialty.DisplayMember = "Name";
                metroComboBoxSpecialty.ValueMember = "Id";
            }
        }

        private void GroupEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                GetSpecialties();
                if(GroupId == 0)
                {
                    this.Text = "Добавление группы";
                    MesAccept = "Добавление группы успешно завершено";
                }
                else
                {
                    this.Text = "Редактирование группы";
                    using(ApplicationDbContext context = new ApplicationDbContext())
                    {
                        group = context.Groups.Find(GroupId);
                        metroTextBoxName.Text = group.GroupName;
                        metroComboBoxSpecialty.SelectedValue = group.SpecialtyId;
                        metroTextBoxCourse.Text = group.GroupCourse.ToString();
                        metroTextBoxEndStudy.Text = group.GroupEndStudy.ToString();
                    }
                    MesAccept = "Группа успешно изменена";
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void metroTileAccept_Click(object sender, EventArgs e)
        {
            //try
            //{
                if(String.IsNullOrEmpty(metroTextBoxName.Text))
                {
                    throw new Exception("Введите название группы");
                } 
                else if(String.IsNullOrEmpty(metroTextBoxCourse.Text))
                {
                    throw new Exception("Введите курс группы");
                }
                else if(String.IsNullOrEmpty(metroTextBoxEndStudy.Text))
                {
                    throw new Exception("Введите год выпуска группы");
                }

                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    group.GroupName = metroTextBoxName.Text;
                    group.SpecialtyId = metroComboBoxSpecialty.SelectedValue.ToString();
                    group.GroupCourse = Int32.Parse(metroTextBoxCourse.Text);
                    //group.GroupCount = (GroupId == 0) ? 0 : context.Groups.Find(GroupId).Students.Count;
                    group.GroupEndStudy = Int32.Parse(metroTextBoxEndStudy.Text);

                    if (GroupId == 0)
                    {
                        context.Groups.Add(group);
                    }
                    else
                    {
                        context.Entry(group).State = EntityState.Modified;
                    }

                    await context.SaveChangesAsync();
                    sf.GroupsTable(await context.Groups.Include(s => s.Specialty).ToListAsync());
                }
                MessageBox.Show(MesAccept, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            //}
            //catch (Exception gg)
            //{
            //    MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void metroTextBoxCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
