using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWA
{
    public partial class StaffFilterForm : MetroForm
    {
        public StaffForm sf;
        public StaffFilterForm()
        {
            InitializeComponent();
        }

        void GetPositions()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                metroComboBoxPosition.DataSource = context.Positions.ToList();
                metroComboBoxPosition.DisplayMember = "PositionName";
                metroComboBoxPosition.ValueMember = "PositionId";
            }
        }

        private void StaffFilterForm_Load(object sender, EventArgs e)
        {
            GetPositions();
        }

        private async void metroTileAccept_Click(object sender, EventArgs e)
        {
            try
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    int pId = Int32.Parse(metroComboBoxPosition.SelectedValue.ToString());
                    sf.StaffTable(await context.Staffs.Include(p => p.Position).Where(p => p.PositionId == pId).ToListAsync());
                    sf.filter();
                    this.Close();
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "SWA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
