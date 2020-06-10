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
    public partial class StaffDocumentsForm : MetroForm
    {
        public int StaffId = 0;
        DateTime? Date = null;
        public StaffDocumentsForm()
        {
            InitializeComponent();
            dateTimePickerDateFilter.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }

        public DataTable StaffDocumentsTable(List<StaffDocument> query)
        {
            DataTable sdTable = new DataTable();
            DataColumn sdIdC = new DataColumn("Номер документа", typeof(string));
            DataColumn sdNameC = new DataColumn("Название документа", typeof(string));
            DataColumn sdFromC = new DataColumn("От кого", typeof(string));
            DataColumn sdToC = new DataColumn("Кому", typeof(string));
            DataColumn sdDateC = new DataColumn("Дата", typeof(string));
            sdTable.Columns.AddRange(new DataColumn[]
            {
                sdIdC,
                sdNameC,
                sdFromC,
                sdToC,
                sdDateC,
            });
            foreach(var item in query)
            {
                DataRow newRow = sdTable.NewRow();
                newRow[0] = item.StaffDocumentId;
                newRow[1] = item.StaffDocumentName;
                newRow[2] = item.StaffDoucmentFrom;
                newRow[3] = item.StaffDocumentTo;
                newRow[4] = item.StaffDocumentDateCreation.ToShortDateString();
                sdTable.Rows.Add(newRow);
            }
            return sdTable;
        }

        private void StaffDocumentsForm_Load(object sender, EventArgs e)
        {
            buttonReload_Click(sender, e);
            metroTabControl1_SelectedIndexChanged(sender, e);
        }

        public async void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using(ApplicationDbContext context = new ApplicationDbContext())
                {
                    var documents = context.StaffDocuments.Include(d => d.DocumentType);
                    if (StaffId != 0)
                    {
                        documents = documents.Where(d => d.StaffId == StaffId);
                        metroTileDocumentAdd.Enabled = true;
                    }

                    if(Date != null)
                    {
                        documents = documents.Where(d => d.StaffDocumentDateCreation == Date);
                    }

                    if (metroTabControl1.SelectedIndex == 0)
                    {
                        dataGridViewInput.DataSource = StaffDocumentsTable(await documents.Where(d => d.DocumentType.DocumentTypeName == "Входящий").ToListAsync());
                    }
                    else if (metroTabControl1.SelectedIndex == 1)
                    {
                        dataGridViewOutput.DataSource = StaffDocumentsTable(await documents.Where(d => d.DocumentType.DocumentTypeName == "Исходящий").ToListAsync());
                    }
                    else if (metroTabControl1.SelectedIndex == 2)
                    {
                        dataGridViewInside.DataSource = StaffDocumentsTable(await documents.Where(d => d.DocumentType.DocumentTypeName == "Внутренний").ToListAsync());
                    }
                }
               
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTileDocumentAdd_Click(object sender, EventArgs e)
        {
            var Form = new StaffDocumentsEntityForm();
            Form.StaffId = StaffId;
            Form.sdf = this;
            Form.Show();
        }

        private void buttonInputEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var dId = dataGridViewInput.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(dId))
                {
                    throw new Exception("Не выбран документ");
                }

                var Form = new StaffDocumentsEntityForm();
                Form.Id = dataGridViewInput.SelectedCells[0].Value.ToString();
                Form.sdf = this;
                Form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonInputDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var dId = dataGridViewInput.SelectedCells[0].Value.ToString();                
                if (String.IsNullOrEmpty(dId))
                {
                    throw new Exception("Не выбран документ");
                }

                DialogResult dialog = MessageBox.Show("Удалить документ: " + dataGridViewInput.SelectedCells[0].Value.ToString(), "SWA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        var d = await context.StaffDocuments.FindAsync(dId);
                        context.Entry(d).State = EntityState.Deleted;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Удаление успешно завершено", "SWA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroTabControl1_SelectedIndexChanged(sender, e);
                    }
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOutputEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var dId = dataGridViewOutput.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(dId))
                {
                    throw new Exception("Не выбран документ");
                }

                var Form = new StaffDocumentsEntityForm();
                Form.Id = dataGridViewOutput.SelectedCells[0].Value.ToString();
                Form.sdf = this;
                Form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonOutputDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var dId = dataGridViewOutput.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(dId))
                {
                    throw new Exception("Не выбран документ");
                }

                DialogResult dialog = MessageBox.Show("Удалить документ: " + dataGridViewOutput.SelectedCells[0].Value.ToString(), "SWA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        var d = await context.StaffDocuments.FindAsync(dId);
                        context.Entry(d).State = EntityState.Deleted;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Удаление успешно завершено", "SWA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroTabControl1_SelectedIndexChanged(sender, e);
                    }
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInsideEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var dId = dataGridViewInside.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(dId))
                {
                    throw new Exception("Не выбран документ");
                }

                var Form = new StaffDocumentsEntityForm();
                Form.Id = dataGridViewInside.SelectedCells[0].Value.ToString();
                Form.sdf = this;
                Form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonInsideDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var dId = dataGridViewInside.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(dId))
                {
                    throw new Exception("Не выбран документ");
                }

                DialogResult dialog = MessageBox.Show("Удалить документ: " + dataGridViewInside.SelectedCells[0].Value.ToString(), "SWA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        var d = await context.StaffDocuments.FindAsync(dId);
                        context.Entry(d).State = EntityState.Deleted;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Удаление успешно завершено", "SWA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroTabControl1_SelectedIndexChanged(sender, e);
                    }
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewInput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dId = dataGridViewInput.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(dId))
                {
                    throw new Exception("Не выбран документ");
                }

                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    richTextBoxDescription.Text = context.StaffDocuments.Find(dId).StaffDocumentDescription;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void dataGridViewOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dId = dataGridViewOutput.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(dId))
                {
                    throw new Exception("Не выбран документ");
                }

                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    richTextBoxDescription.Text = context.StaffDocuments.Find(dId).StaffDocumentDescription;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewInside_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dId = dataGridViewInside.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(dId))
                {
                    throw new Exception("Не выбран документ");
                }

                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    richTextBoxDescription.Text = context.StaffDocuments.Find(dId).StaffDocumentDescription;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerDateFilter_ValueChanged(object sender, EventArgs e)
        {
            Date = dateTimePickerDateFilter.Value;
            metroTabControl1_SelectedIndexChanged(sender, e);
            buttonReload.Visible = true;
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            Date = null;
            metroTabControl1_SelectedIndexChanged(sender, e);
            buttonReload.Visible = false;
        }

        private void metroTextBoxSearchInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager cManager = dataGridViewInput.BindingContext[dataGridViewInput.DataSource, dataGridViewInput.DataMember] as CurrencyManager;
                cManager.SuspendBinding();
                cManager.ResumeBinding();
                for (int i = 0; i < dataGridViewInput.RowCount; i++)
                {
                    dataGridViewInput.Rows[i].Selected = false;
                }
                if (metroTextBoxSearchInput.Text == "")
                    for (int i = 0; i < dataGridViewInput.RowCount; i++)
                    {
                        dataGridViewInput.Rows[i].Selected = false;
                        dataGridViewInput.Rows[i].Visible = true;
                    }
                else
                {
                    for (int i = 0; i < dataGridViewInput.RowCount; i++)
                    {
                        dataGridViewInput.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridViewInput.ColumnCount; j++)
                            if (dataGridViewInput.Rows[i].Cells[j].Value != null)

                                if (dataGridViewInput.Rows[i].Cells[j].Value.ToString().Contains(metroTextBoxSearchInput.Text))
                                {
                                    dataGridViewInput.Rows[i].Selected = true;
                                    dataGridViewInput.Rows[i].Visible = true;
                                    break;
                                }
                                else
                                {
                                    dataGridViewInput.Rows[i].Selected = false;
                                    dataGridViewInput.Rows[i].Visible = false;
                                }
                    }
                }
            }

            catch
            {
                MessageBox.Show("При поиске произошла ошибка, для исправления выберите другую строку");
            }
        }

        private void metroTextBoxSearchOutput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager cManager = dataGridViewOutput.BindingContext[dataGridViewOutput.DataSource, dataGridViewOutput.DataMember] as CurrencyManager;
                cManager.SuspendBinding();
                cManager.ResumeBinding();
                for (int i = 0; i < dataGridViewOutput.RowCount; i++)
                {
                    dataGridViewOutput.Rows[i].Selected = false;
                }
                if (metroTextBoxSearchOutput.Text == "")
                    for (int i = 0; i < dataGridViewOutput.RowCount; i++)
                    {
                        dataGridViewOutput.Rows[i].Selected = false;
                        dataGridViewOutput.Rows[i].Visible = true;
                    }
                else
                {
                    for (int i = 0; i < dataGridViewOutput.RowCount; i++)
                    {
                        dataGridViewOutput.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridViewOutput.ColumnCount; j++)
                            if (dataGridViewOutput.Rows[i].Cells[j].Value != null)

                                if (dataGridViewOutput.Rows[i].Cells[j].Value.ToString().Contains(metroTextBoxSearchOutput.Text))
                                {
                                    dataGridViewOutput.Rows[i].Selected = true;
                                    dataGridViewOutput.Rows[i].Visible = true;
                                    break;
                                }
                                else
                                {
                                    dataGridViewOutput.Rows[i].Selected = false;
                                    dataGridViewOutput.Rows[i].Visible = false;
                                }
                    }
                }
            }

            catch
            {
                MessageBox.Show("При поиске произошла ошибка, для исправления выберите другую строку");
            }
        }

        private void metroTextBoxSearchInside_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager cManager = dataGridViewInside.BindingContext[dataGridViewInside.DataSource, dataGridViewInside.DataMember] as CurrencyManager;
                cManager.SuspendBinding();
                cManager.ResumeBinding();
                for (int i = 0; i < dataGridViewInside.RowCount; i++)
                {
                    dataGridViewInside.Rows[i].Selected = false;
                }
                if (metroTextBoxSearchInput.Text == "")
                    for (int i = 0; i < dataGridViewInside.RowCount; i++)
                    {
                        dataGridViewInside.Rows[i].Selected = false;
                        dataGridViewInside.Rows[i].Visible = true;
                    }
                else
                {
                    for (int i = 0; i < dataGridViewInside.RowCount; i++)
                    {
                        dataGridViewInside.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridViewInside.ColumnCount; j++)
                            if (dataGridViewInside.Rows[i].Cells[j].Value != null)

                                if (dataGridViewInside.Rows[i].Cells[j].Value.ToString().Contains(metroTextBoxSearchInput.Text))
                                {
                                    dataGridViewInside.Rows[i].Selected = true;
                                    dataGridViewInside.Rows[i].Visible = true;
                                    break;
                                }
                                else
                                {
                                    dataGridViewInside.Rows[i].Selected = false;
                                    dataGridViewInside.Rows[i].Visible = false;
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
            var Form = new StaffDocumentPrintForm();
            Form.StaffId = StaffId;
            Form.Show();
        }
    }
}
