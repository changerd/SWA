using MetroFramework.Forms;
using SWA.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SWA
{
    public partial class SpecialtyEntityForm : MetroForm
    {
        public StudentForm sf;
        public string SpecialtyId = String.Empty;
        Specialty specialty = new Specialty();
        string MesAccept = String.Empty;

        public SpecialtyEntityForm()
        {
            InitializeComponent();
        }

        void GetStudyForms()
        {
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                var query = context.StudyForms.ToList();
                metroComboBoxFormStudy.DataSource = query;
                metroComboBoxFormStudy.DisplayMember = "StudyFormName";
                metroComboBoxFormStudy.ValueMember = "StudyFormId";
            }
        }

        private void SpecialtyEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                GetStudyForms();
                if (String.IsNullOrEmpty(SpecialtyId))
                {
                    this.Text = "Добавление специальности";
                    MesAccept = "Специальность успешно добавлена";
                    metroTextBoxSpecialtyId.Enabled = true;
                }
                else
                {
                    this.Text = "Редактирование специальности";
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        specialty = context.Specialties.Find(SpecialtyId);
                        metroTextBoxSpecialtyId.Text = specialty.SpecialtyId;
                        metroTextBoxSpecialtyName.Text = specialty.SpecialtyName;
                        metroTextBoxSpecialtyTime.Text = specialty.SpecialityTime;
                        metroComboBoxFormStudy.SelectedValue = specialty.StudyFormId;
                        MesAccept = "Специальность успешно изменена";
                        metroTextBoxSpecialtyId.Enabled = false;
                    }
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
                if(String.IsNullOrEmpty(metroTextBoxSpecialtyId.Text))
                {
                    throw new Exception("Введите код специальности");
                } else if (String.IsNullOrEmpty(metroTextBoxSpecialtyName.Text))
                {
                    throw new Exception("Введите название специальности");
                }
                else if (String.IsNullOrEmpty(metroTextBoxSpecialtyTime.Text))
                {
                    throw new Exception("Введите срок обучения специальности");
                }

                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    specialty.SpecialtyId = metroTextBoxSpecialtyId.Text;
                    specialty.SpecialtyName = metroTextBoxSpecialtyName.Text;
                    specialty.SpecialityTime = metroTextBoxSpecialtyTime.Text;
                    specialty.StudyFormId = Convert.ToInt32(metroComboBoxFormStudy.SelectedValue);
                    
                    if (String.IsNullOrEmpty(SpecialtyId))
                    {                        
                        context.Specialties.Add(specialty);
                    }
                    else
                    {
                        context.Entry(specialty).State = EntityState.Modified;
                    }

                    await context.SaveChangesAsync();
                    sf.SpecialitiesTable(await context.Specialties.Include(s => s.StudyForm).ToListAsync());
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
