using MetroFramework.Forms;
using SWA.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SWA
{
    public partial class StudentFilterForm : MetroForm
    {
        public StudentForm sf;
        public StudentFilterForm()
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

        private void StudentFilterForm_Load(object sender, EventArgs e)
        {
            GetSpecialties();
        }

        private async void metroTileAccept_Click(object sender, EventArgs e)
        {
            try
            {
                using(ApplicationDbContext context = new ApplicationDbContext())
                {
                    var students = context.Students.Include(g => g.Group);
                    students = students.Where(g => g.Group.SpecialtyId == metroComboBoxSpecialty.SelectedValue.ToString());
                    if(metroComboBoxGroup.SelectedValue.ToString() != "0")
                    {
                        int gId = Int32.Parse(metroComboBoxGroup.SelectedValue.ToString());
                        students = students.Where(g => g.GroupId == gId);
                    }
                    sf.StudentsTable(await students.ToListAsync());
                }
                sf.filter();
                this.Close();                
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
