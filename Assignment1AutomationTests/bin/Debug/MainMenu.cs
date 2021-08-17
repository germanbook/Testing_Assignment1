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
    // Main menu class
    public partial class MainMenu : Form
    {
        List<Staff> staffs = new List<Staff>();             
        List<Staff> searchResultStaffs = new List<Staff>();

        public MainMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Fill listview use a list of staffs' object
        private void fillListView(List<Staff> staffs)
        {
            listView1.Items.Clear();
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

        // Load button click
        private void btnLoad_Click(object sender, EventArgs e)
        {
            // clear listview
            listView1.Items.Clear();

            // clear search textbox
            tbxSearch.Clear();              

            // Read staffs from Info.txt
            staffs = FileManager.GetStaffs();   

            if( staffs == null )
            {
                MessageBox.Show("Error loading Information", "File to Error");
            }
            else
            {
                // Fill the listview
                fillListView(staffs);      
            }
        }

        // Add Staff button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddingForm addingForm = new AddingForm(this);
            // Open new form
            addingForm.Show();

            // Main menu hidden
            this.Hide();     
        }

        // Delete button click
        private void btnDel_Click(object sender, EventArgs e)
        {
            // have one and only one item seleted from listview
            if (listView1.SelectedItems.Count == 1) 
            {
                // MessageBox ask user to confirm whether to delete
                DialogResult dr = MessageBox.Show("Are you sure?", "Delete item", MessageBoxButtons.YesNo);
                if (dr.Equals(DialogResult.Yes))
                {
                    // Delete staff by given staff ID
                    if (Filter.DeleteStaff(staffs, Convert.ToInt32(listView1.SelectedItems[0].Text)))
                    {
                        MessageBox.Show("Item deleted!", "Delete Success", MessageBoxButtons.OK);
                        
                        // Refresh listview after deletion

                        // If deleted from search results
                        if (tbxSearch.Text.Length != 0)
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
                // Reminder user to select one item to delete
                MessageBox.Show("Please select one record", "Delete item", MessageBoxButtons.OK);
            }
        }

        // AZ button click
        private void btnAZ_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            // Sorting search results
            if (tbxSearch.Text.Length != 0) 
            {
                searchResultStaffs = Filter.SortAZ(searchResultStaffs);
                fillListView(searchResultStaffs);
            }
            else
            // Sorting original data
            if (tbxSearch.Text.Length == 0) 
            {
                staffs = Filter.SortAZ(staffs);
                fillListView(staffs);
            }

        }

        // ZA button click
        private void btnZA_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            // Sorting search results
            if (tbxSearch.Text.Length != 0) 
            {
                searchResultStaffs = Filter.SortZA(searchResultStaffs);
                fillListView(searchResultStaffs);
            }
            else
            // Sorting original data
            if (tbxSearch.Text.Length == 0)
            {
                staffs = Filter.SortZA(staffs);
                fillListView(staffs);
            }
        }

        // Search textbox changed
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            // search result
            searchResultStaffs = Filter.Search(staffs, tbxSearch.Text); 

            // fill listview with results
            fillListView(searchResultStaffs);
        }

        // button effects 
        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }
        // button effects 
        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        // button effects 
        private void btnLoad_MouseEnter(object sender, EventArgs e)
        {
            btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }
        // button effects 
        private void btnLoad_MouseLeave(object sender, EventArgs e)
        {
            btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        // button effects 
        private void btnAZ_MouseEnter(object sender, EventArgs e)
        {
            btnAZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }
        // button effects 
        private void btnAZ_MouseLeave(object sender, EventArgs e)
        {
            btnAZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        // button effects 
        private void btnZA_MouseEnter(object sender, EventArgs e)
        {
            btnZA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }
        // button effects 
        private void btnZA_MouseLeave(object sender, EventArgs e)
        {
            btnZA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        // button effects 
        private void btnDel_MouseEnter(object sender, EventArgs e)
        {
            btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }
        // button effects 
        private void btnDel_MouseLeave(object sender, EventArgs e)
        {
            btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

    }
}
