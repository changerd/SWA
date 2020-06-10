using MetroFramework.Forms;
using SWA.Entities;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SWA
{
    public partial class WorkEntityForm : MetroForm
    {
        public int StaffId;
        public DateTime Date;
        public int Hours = 0;
        public StaffForm sf;
        Work work = new Work();
        string MesAccept = String.Empty;

        public WorkEntityForm()
        {
            InitializeComponent();
            dateTimePickerDate.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }

        private void WorkEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (Hours == 0)
                {
                    this.Text = "Добавление работы";
                    MesAccept = "Работа добавлена успешна";
                    work.StaffId = StaffId;

                }
                else
                {
                    this.Text = "Редактирование работы";
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        work = context.Works.FirstOrDefault(w => w.StaffId == StaffId && w.WorkHours == Hours && w.WorkDate == Date);
                        dateTimePickerDate.Value = work.WorkDate;
                        metroTextBoxHours.Text = work.WorkHours.ToString();
                        MesAccept = "Работа изменена успешна";
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
                if (String.IsNullOrEmpty(metroTextBoxHours.Text))
                {
                    throw new Exception("Введите количество часов");
                }

                using(ApplicationDbContext context = new ApplicationDbContext())
                {
                    work.WorkDate = dateTimePickerDate.Value;
                    work.WorkHours = Int32.Parse(metroTextBoxHours.Text);

                    if (Hours == 0)
                    {
                        context.Works.Add(work);
                    }
                    else
                    {
                        context.Entry(work).State = EntityState.Modified;
                    }

                    await context.SaveChangesAsync();
                    sf.WorksTable(await context.Works.Where(f => f.StaffId == StaffId).ToListAsync());
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
