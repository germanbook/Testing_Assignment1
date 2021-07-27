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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            List<Staff> staffs = FileManager.GetStaffs();
            listView1.Items.Clear();
            if( staffs == null )
            {
                MessageBox.Show("Error loading Information", "File to Error");
            }
            else
            {
                for (int i = 0; i < staffs.Count; i++)
                {

                    listView1.Items.Add(Convert.ToString(staffs[i].StaffId));
                    listView1.Items[i].SubItems.Add(staffs[i].Name);
                    if (staffs[i].Gender == 0)
                    {
                        listView1.Items[i].SubItems.Add("Female");
                    }
                    else
                    {
                        listView1.Items[i].SubItems.Add("Male");
                    }
                    listView1.Items[i].SubItems.Add(Convert.ToString(staffs[i].DateOfBirth));
                    listView1.Items[i].SubItems.Add(staffs[i].Email);
                    listView1.Items[i].SubItems.Add(Convert.ToString(staffs[i].AnnualSalary));

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddingForm addingForm = new AddingForm(this);
            addingForm.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }
    }
}
