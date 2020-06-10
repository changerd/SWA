using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.Entity;
using System.Windows.Forms;

namespace SWA
{
    public partial class PositionForm : MetroForm
    {
        public PositionForm()
        {
            InitializeComponent();
        }

        public async void PositionsTable()
        {
            DataTable pTable = new DataTable();
            DataColumn pIdC = new DataColumn("Код", typeof(int));
            DataColumn pNameC = new DataColumn("Название", typeof(string));
            pTable.Columns.AddRange(new DataColumn[]
            {
                    pIdC,
                    pNameC,
            });
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                foreach(var item in await context.Positions.ToListAsync())
                {
                    DataRow newRow = pTable.NewRow();
                    newRow[0] = item.PositionId;
                    newRow[1] = item.PositionName;
                    pTable.Rows.Add(newRow);                    
                }
            }
            dataGridViewPosition.DataSource = pTable;
        }

        private void buttonPositionAdd_Click(object sender, EventArgs e)
        {
            var Form = new PositionEntityForm();
            Form.pf = this;
            Form.Show();
        }

        private void buttonPositionEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var sPId = dataGridViewPosition.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(sPId))
                {
                    throw new Exception("Не выбрана должность");
                }

                var Form = new PositionEntityForm();
                Form.PositionId = Int32.Parse(sPId);
                Form.pf = this;
                Form.Show();

            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonPositionDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var sPId = dataGridViewPosition.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(sPId))
                {
                    throw new Exception("Не выбрана должность");
                }

                DialogResult dialog = MessageBox.Show("Удалить должность: " + dataGridViewPosition.SelectedCells[1].Value.ToString(), "SWA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        var p = await context.Positions.FindAsync(Int32.Parse(sPId));
                        context.Entry(p).State = EntityState.Deleted;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Удаление успешно завершено", "SWA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PositionsTable();
                    }
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PositionForm_Load(object sender, EventArgs e)
        {
            PositionsTable();
        }
    }
}
