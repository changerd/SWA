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
    public partial class StaffEntityForm : MetroForm
    {
        public StaffForm sf;
        public int StaffId = 0;
        Staff staff = new Staff();
        string MesAccept = String.Empty;

        public StaffEntityForm()
        {
            InitializeComponent();
            dateTimePickerBirth.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
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

        private void StaffEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                GetPositions();
                if(StaffId == 0)
                {
                    this.Text = "Добавление сотрудника";
                    MesAccept = "Сотрудник успешно добавлен";
                }
                else
                {
                    this.Text = "Редактирование сотрудника";
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        staff = context.Staffs.Find(StaffId);
                        metroTextBoxSurname.Text = staff.StafftSurName;
                        metroTextBoxFName.Text = staff.StaffFirstName;
                        metroTextBoxSName.Text = staff.StaffSecondName;
                        metroComboBoxPosition.SelectedValue = staff.PositionId;
                        dateTimePickerBirth.Value = staff.StaffBirthDate;
                        metroComboBoxGender.Text = staff.StaffGender;
                        metroTextBoxAdress.Text = staff.StaffAdress;
                        maskedTextBox1.Text = staff.StaffTelephone;
                    }
                    MesAccept = "Сотрудник успешно изменен";
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
                if (String.IsNullOrEmpty(metroTextBoxSurname.Text))
                {
                    throw new Exception("Введите фамилию сотрудника");
                }
                else if (String.IsNullOrEmpty(metroTextBoxFName.Text))
                {
                    throw new Exception("Введите имя сотрудника");
                }
                else if (String.IsNullOrEmpty(metroTextBoxSName.Text))
                {
                    throw new Exception("Введите отчество сотрудника");
                }
                else if (String.IsNullOrEmpty(metroComboBoxGender.Text))
                {
                    throw new Exception("Выберите пол сотрудника");
                }
                else if (String.IsNullOrEmpty(metroTextBoxAdress.Text))
                {
                    throw new Exception("Введите адрес сотрудника");
                }
                else if (String.IsNullOrEmpty(maskedTextBox1.Text))
                {
                    throw new Exception("Введите телефон сотрудника");
                }                

                using(ApplicationDbContext context = new ApplicationDbContext())
                {
                    staff.StafftSurName = metroTextBoxSurname.Text;
                    staff.StaffFirstName = metroTextBoxFName.Text;
                    staff.StaffSecondName = metroTextBoxSName.Text;
                    staff.PositionId = Convert.ToInt32(metroComboBoxPosition.SelectedValue);
                    staff.StaffBirthDate = dateTimePickerBirth.Value;
                    staff.StaffGender = metroComboBoxGender.Text;
                    staff.StaffAdress = metroTextBoxAdress.Text;
                    staff.StaffTelephone = maskedTextBox1.Text;

                    if (StaffId == 0)
                    {
                        context.Staffs.Add(staff);
                    }
                    else
                    {
                        context.Entry(staff).State = EntityState.Modified;
                    }

                    await context.SaveChangesAsync();
                    sf.StaffTable(await context.Staffs.Include(s => s.Position).ToListAsync());
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
