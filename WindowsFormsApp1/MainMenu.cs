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
        List<Staff> staffs = new List<Staff>(); // staffs from text file
        List<Staff> searchResultStaffs = new List<Staff>(); // search result

        public MainMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void fillListView(List<Staff> staffs)
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
                listView1.Items[i].SubItems.Add(Convert.ToString(staffs[i].DateOfBirth.ToShortDateString()));
                listView1.Items[i].SubItems.Add(staffs[i].Email);
                listView1.Items[i].SubItems.Add(Convert.ToString(staffs[i].AnnualSalary));

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            staffs.Clear();
            listView1.Items.Clear();
            tbxSearch.Clear();

            staffs = FileManager.GetStaffs();
            if( staffs == null )
            {
                MessageBox.Show("Error loading Information", "File to Error");
            }
            else
            {
                fillListView(staffs);
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
            if (listView1.SelectedItems.Count == 1) // item selected
            {

                DialogResult dr = MessageBox.Show("Are you sure?", "Delete item", MessageBoxButtons.YesNo);
                if (dr.Equals(DialogResult.Yes))
                {
                    if (Filter.DeleteStaff(staffs, Convert.ToInt32(listView1.SelectedItems[0].Text)))
                    {
                        MessageBox.Show("Item deleted!", "Delete Success", MessageBoxButtons.OK);
                        if (tbxSearch.Text.Length != 0) // refresh result
                        {
                            listView1.Items.Clear();
                            searchResultStaffs = Filter.Search(staffs, tbxSearch.Text);
                            fillListView(searchResultStaffs);
                        }
                        else
                        if (tbxSearch.Text.Length == 0)
                        {
                            btnLoad.PerformClick();
                        }
                    }
                }
            }
            else
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select one record", "Delete item", MessageBoxButtons.OK);
            }
        }

        private void btnAZ_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (tbxSearch.Text.Length != 0) // sort result
            {
                searchResultStaffs = Filter.SortAZ(searchResultStaffs);
                fillListView(searchResultStaffs);
            }
            else
            if (tbxSearch.Text.Length == 0) // sort original data
            {
                staffs = Filter.SortAZ(staffs);
                fillListView(staffs);
            }

        }

        private void btnZA_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (tbxSearch.Text.Length != 0) // sort result
            {
                searchResultStaffs = Filter.SortZA(searchResultStaffs);
                fillListView(searchResultStaffs);
            }
            else
            if (tbxSearch.Text.Length == 0) // sort original data
            {
                staffs = Filter.SortZA(staffs);
                fillListView(staffs);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            searchResultStaffs = Filter.Search(staffs, tbxSearch.Text); // search result
            fillListView(searchResultStaffs);
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void btnLoad_MouseEnter(object sender, EventArgs e)
        {
            btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        private void btnLoad_MouseLeave(object sender, EventArgs e)
        {
            btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void btnAZ_MouseEnter(object sender, EventArgs e)
        {
            btnAZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        private void btnAZ_MouseLeave(object sender, EventArgs e)
        {
            btnAZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void btnZA_MouseEnter(object sender, EventArgs e)
        {
            btnZA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        private void btnZA_MouseLeave(object sender, EventArgs e)
        {
            btnZA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void btnDel_MouseEnter(object sender, EventArgs e)
        {
            btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        private void btnDel_MouseLeave(object sender, EventArgs e)
        {
            btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
    }
}
