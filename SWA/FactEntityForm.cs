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
    public partial class FactEntityForm : MetroForm
    {
        public StaffForm sf;
        public int StaffId;
        public string fName = String.Empty;
        Fact fact = new Fact();
        string MesAccept = String.Empty;

        public FactEntityForm()
        {
            InitializeComponent();
        }

        private void PositionEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(fName))
                {
                    this.Text = "Добавление сведенья";
                    MesAccept = "Сведенье успешно добавлен";
                    fact.StaffId = StaffId;
                }
                else
                {
                    this.Text = "Редактирование сведенья";
                    using(ApplicationDbContext context = new ApplicationDbContext())
                    {
                        fact = context.Facts.FirstOrDefault(f => f.StaffId == StaffId && f.FactName == fName);
                        metroTextBoxName.Text = fact.FactName;
                    }
                    MesAccept = "Запись успешно изменена";
                }
            }
            catch(Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void metroTileAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxName.Text))
                {
                    throw new Exception("Введите название сведенья");
                }

                using(ApplicationDbContext context = new ApplicationDbContext())
                {
                    fact.FactName = metroTextBoxName.Text;

                    if(String.IsNullOrEmpty(fName))
                    {
                        context.Facts.Add(fact);
                    }
                    else
                    {
                        context.Entry(fact).State = EntityState.Modified;
                    }

                    await context.SaveChangesAsync();
                    sf.FactsTable(await context.Facts.Where(f =>f.StaffId == StaffId).ToListAsync());
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
