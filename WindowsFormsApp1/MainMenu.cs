using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_loding_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            for(int i = 0; i < FileManager.GetStaffs().Count; i++ )
            {
                staff = FileManager.GetStaffs()[i];
                listView1.Items.Add(Convert.ToString(staff.StaffId));
                listView1.Items[i].SubItems.Add(staff.Name);
                listView1.Items[i].SubItems.Add(Convert.ToString(staff.DateOfBirth));
                listView1.Items[i].SubItems.Add(staff.Email);
                listView1.Items[i].SubItems.Add(Convert.ToString(staff.AnnualSalary));
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddingForm addingForm = new AddingForm(this);
            addingForm.Show();
            this.Hide();
        }
    }
}
