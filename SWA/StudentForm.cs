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

        public void StudentForm_Load(object sender, EventArgs e)
        {
            metroTabControl1_SelectedIndexChanged(sender, e);
        }

        public async void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {


                    if (metroTabControl1.SelectedIndex == 0)
                    {

                    }
                    else if (metroTabControl1.SelectedIndex == 1)
                    {
                        StudyFormsTable(await context.StudyForms.ToListAsync());
                    }
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void StudyFormsTable(List<StudyForm> query)
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
                        StudyFormsTable(await context.StudyForms.ToListAsync());
                    }
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
