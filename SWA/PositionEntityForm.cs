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
    public partial class PositionEntityForm : MetroForm
    {
        public PositionForm pf;
        public int PositionId = 0;
        Position position = new Position();
        string MesAccept = String.Empty;

        public PositionEntityForm()
        {
            InitializeComponent();
        }

        private void PositionEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (PositionId == 0)
                {
                    this.Text = "Добавление должности";
                    MesAccept = "Должность умпешно добавлена";
                }
                else
                {
                    this.Text = "Редактирование должности";
                    using(ApplicationDbContext context = new ApplicationDbContext())
                    {
                        position = context.Positions.Find(PositionId);
                        metroTextBoxName.Text = position.PositionName;
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
                    throw new Exception("Введите название должности");
                }

                using(ApplicationDbContext context = new ApplicationDbContext())
                {
                    position.PositionName = metroTextBoxName.Text;

                    if(PositionId == 0)
                    {
                        context.Positions.Add(position);
                    }
                    else
                    {
                        context.Entry(position).State = EntityState.Modified;
                    }

                    await context.SaveChangesAsync();
                    pf.PositionsTable();
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
