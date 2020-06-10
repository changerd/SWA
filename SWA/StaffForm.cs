using MetroFramework.Forms;
using SWA.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SWA
{
    public partial class StaffForm : MetroForm
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        public void StaffTable(List<Staff> query)
        {
            DataTable sTable = new DataTable();
            DataColumn sIdC = new DataColumn("Код", typeof(int));
            DataColumn sSurnameC = new DataColumn("Фамилия", typeof(string));
            DataColumn sFNameC = new DataColumn("Имя", typeof(string));
            DataColumn sSecNameC = new DataColumn("Отчество", typeof(string));
            DataColumn sPosC = new DataColumn("Должность", typeof(string));
            DataColumn sBirthC = new DataColumn("Дата рождения", typeof(string));
            DataColumn sGenderC = new DataColumn("Пол", typeof(string));
            DataColumn sAdressC = new DataColumn("Адрес", typeof(string));
            DataColumn sTelephone = new DataColumn("Телефон", typeof(string));
            sTable.Columns.AddRange(new DataColumn[]
            {
                sIdC,
                sSurnameC,
                sFNameC,
                sSecNameC,
                sPosC,
                sBirthC,
                sGenderC,
                sAdressC,
                sTelephone,
            });
            foreach(var item in query)
            {
                DataRow newRow = sTable.NewRow();
                newRow[0] = item.StaffId;
                newRow[1] = item.StafftSurName;
                newRow[2] = item.StaffFirstName;
                newRow[3] = item.StaffSecondName;
                newRow[4] = item.Position.PositionName;
                newRow[5] = item.StaffBirthDate.ToShortDateString();
                newRow[6] = item.StaffGender;
                newRow[7] = item.StaffAdress;
                newRow[8] = item.StaffTelephone;
                sTable.Rows.Add(newRow);
            }
            dataGridViewStaff.DataSource = sTable;
        }

        public void WorksTable(List<Work> query)
        {
            DataTable wTable = new DataTable();
            DataColumn wDateC = new DataColumn("Дата", typeof(string));
            DataColumn wHoursC = new DataColumn("Количество часов", typeof(int));
            wTable.Columns.AddRange(new DataColumn[]
            {
                wDateC,
                wHoursC,
            });
            foreach(var item in query)
            {
                DataRow newRow = wTable.NewRow();
                newRow[0] = item.WorkDate.ToShortDateString();
                newRow[1] = item.WorkHours.ToString();
                wTable.Rows.Add(newRow);
            }
            dataGridViewWork.DataSource = wTable;
        }

        public void FactsTable(List<Fact> query)
        {
            DataTable fTable = new DataTable();
            DataColumn fNameC = new DataColumn("Сведенье", typeof(string));
            fTable.Columns.Add(fNameC);
            foreach(var item in query)
            {
                DataRow newRow = fTable.NewRow();
                newRow[0] = item.FactName;
                fTable.Rows.Add(newRow);
            }
            dataGridViewFact.DataSource = fTable;
        }

        private async void StaffForm_Load(object sender, EventArgs e)
        {
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                StaffTable(await context.Staffs.Include(p => p.Position).ToListAsync());
            }
        }

        private void buttonStaffAdd_Click(object sender, EventArgs e)
        {
            var Form = new StaffEntityForm();
            Form.sf = this;
            Form.Show();
        }

        private void buttonStaffEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var sSId = dataGridViewStaff.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(sSId))
                {
                    throw new Exception("Не выбран сотрудник");
                }

                var Form = new StaffEntityForm();
                Form.StaffId = Int32.Parse(dataGridViewStaff.SelectedCells[0].Value.ToString());
                Form.sf = this;
                Form.Show();

            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonStaffDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var sSId = dataGridViewStaff.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(sSId))
                {
                    throw new Exception("Не выбран сотрудник");
                }

                DialogResult dialog = MessageBox.Show(String.Format("Удалить сотрудника: {0} {1} {2}?", dataGridViewStaff.SelectedCells[1].Value.ToString(), dataGridViewStaff.SelectedCells[2].Value.ToString(), dataGridViewStaff.SelectedCells[3].Value.ToString()), "SWA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        var s = await context.Staffs.FindAsync(Int32.Parse(sSId));
                        context.Entry(s).State = EntityState.Deleted;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Удаление успешно завершено", "SWA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StaffTable(await context.Staffs.Include(f => f.Position).ToListAsync());
                    }
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWorkAdd_Click(object sender, EventArgs e)
        {
            var Form = new WorkEntityForm();
            Form.sf = this;
            Form.StaffId = Int32.Parse(dataGridViewStaff.SelectedCells[0].Value.ToString());
            Form.Show();
        }

        private void buttonWorkEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var wDate = dataGridViewWork.SelectedCells[0].Value.ToString();
                var wHours = dataGridViewWork.SelectedCells[1].Value.ToString();
                if (String.IsNullOrEmpty(wDate) && String.IsNullOrEmpty(wHours))
                {
                    throw new Exception("Не выбрана работа");
                }

                var Form = new WorkEntityForm();
                Form.StaffId = Int32.Parse(dataGridViewStaff.SelectedCells[0].Value.ToString());
                Form.Date = Convert.ToDateTime(wDate);
                Form.Hours = Convert.ToInt32(wHours);
                Form.sf = this;
                Form.Show();

            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonWorkDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var wDate = dataGridViewWork.SelectedCells[0].Value.ToString();
                var wHours = dataGridViewWork.SelectedCells[1].Value.ToString();
                DateTime Date = Convert.ToDateTime(wDate);
                if (String.IsNullOrEmpty(wDate) && String.IsNullOrEmpty(wHours))
                {
                    throw new Exception("Не выбрана работа");
                }

                DialogResult dialog = MessageBox.Show("Удалить работу за " + dataGridViewWork.SelectedCells[0].Value.ToString(), "SWA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        var w = await context.Works.FirstOrDefaultAsync(s => s.WorkDate == Date && s.WorkHours == Convert.ToInt32(wHours) && s.StaffId == Convert.ToInt32(dataGridViewStaff.SelectedCells[0].Value.ToString()));
                        context.Entry(w).State = EntityState.Deleted;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Удаление успешно завершено", "SWA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        WorksTable(await context.Works.Where(s => s.StaffId == Convert.ToInt32(dataGridViewStaff.SelectedCells[0].Value.ToString())).ToListAsync());
                    }
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFactAdd_Click(object sender, EventArgs e)
        {
            var Form = new FactEntityForm();
            Form.sf = this;
            Form.StaffId = Int32.Parse(dataGridViewStaff.SelectedCells[0].Value.ToString());
            Form.Show();
        }

        private void buttonFactEdit_Click(object sender, EventArgs e)
        {
            try
            {                
                var Name = dataGridViewFact.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(Name))
                {
                    throw new Exception("Не выбрано сведенье");
                }

                var Form = new FactEntityForm();
                Form.StaffId = Int32.Parse(dataGridViewStaff.SelectedCells[0].Value.ToString());
                Form.Name = Name;                
                Form.sf = this;
                Form.Show();

            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonFactDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var Name = dataGridViewFact.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(Name))
                {
                    throw new Exception("Не выбрано сведенье");
                }

                DialogResult dialog = MessageBox.Show("Удалить сведенье^ " + dataGridViewFact.SelectedCells[0].ToString(), "SWA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        var f = await context.Facts.FirstOrDefaultAsync(s => s.StaffId == Convert.ToInt32(dataGridViewStaff.SelectedCells[0].Value.ToString()) && s.FactName == Name);
                        context.Entry(f).State = EntityState.Deleted;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Удаление успешно завершено", "SWA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FactsTable(await context.Facts.Where(s => s.StaffId == Convert.ToInt32(dataGridViewStaff.SelectedCells[0].Value.ToString())).ToListAsync());
                    }
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPosition_Click(object sender, EventArgs e)
        {
            var Form = new PositionForm();
            Form.Show();
        }

        private async void dataGridViewStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(dataGridViewStaff.SelectedCells[0].Value.ToString()))
                {
                    throw new Exception("Ошибка выбора");
                }

                if(dataGridViewStaff.SelectedCells == null)
                {
                    throw new Exception("Ошибка выбора");
                }

                int Id = Convert.ToInt32(dataGridViewStaff.SelectedCells[0].Value.ToString());
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    FactsTable(await context.Facts.Where(s => s.StaffId == Id).ToListAsync());
                    WorksTable(await context.Works.Where(s => s.StaffId == Id).ToListAsync());
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void dataGridViewStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var sId = dataGridViewStaff.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(sId))
                {
                    throw new Exception("Не выбран студент");
                }

                var Form = new StaffDocumentsForm();
                Form.StaffId = Int32.Parse(sId);
                Form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDocuments_Click(object sender, EventArgs e)
        {
            var Form = new StaffDocumentsForm();
            Form.Show();
        }

        public void filter()
        {
            buttonStaffFilter.Visible = false;
            buttonReloadFilter.Visible = true;
        }

        private async void buttonReloadFilter_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                StaffTable(await context.Staffs.Include(s => s.Position).ToListAsync());
            }
            buttonStaffFilter.Visible = true;
            buttonReloadFilter.Visible = false;

        }

        private void buttonStaffFilter_Click(object sender, EventArgs e)
        {
            var Form = new StaffFilterForm();
            Form.sf = this;
            Form.Show();
        }

        private void metroTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager cManager = dataGridViewStaff.BindingContext[dataGridViewStaff.DataSource, dataGridViewStaff.DataMember] as CurrencyManager;
                cManager.SuspendBinding();
                cManager.ResumeBinding();
                for (int i = 0; i < dataGridViewStaff.RowCount; i++)
                {
                    dataGridViewStaff.Rows[i].Selected = false;
                }
                if (metroTextBoxSearch.Text == "")
                    for (int i = 0; i < dataGridViewStaff.RowCount; i++)
                    {
                        dataGridViewStaff.Rows[i].Selected = false;
                        dataGridViewStaff.Rows[i].Visible = true;
                    }
                else
                {
                    for (int i = 0; i < dataGridViewStaff.RowCount; i++)
                    {
                        dataGridViewStaff.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridViewStaff.ColumnCount; j++)
                            if (dataGridViewStaff.Rows[i].Cells[j].Value != null)

                                if (dataGridViewStaff.Rows[i].Cells[j].Value.ToString().Contains(metroTextBoxSearch.Text))
                                {
                                    dataGridViewStaff.Rows[i].Selected = true;
                                    dataGridViewStaff.Rows[i].Visible = true;
                                    break;
                                }
                                else
                                {
                                    dataGridViewStaff.Rows[i].Selected = false;
                                    dataGridViewStaff.Rows[i].Visible = false;
                                }
                    }
                }
            }

            catch
            {
                MessageBox.Show("При поиске произошла ошибка, для исправления выберите другую строку");
            }
        }
    }
}
