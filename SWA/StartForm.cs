using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWA
{
    public partial class StartForm : MetroForm
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void metroTileStudents_Click(object sender, EventArgs e)
        {
            var Form = new StudentForm();
            Form.Show();
        }
    }
}
