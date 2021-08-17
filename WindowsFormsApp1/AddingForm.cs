using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApp1
{
    // Adding form class
    public partial class AddingForm : Form
    {
        MainMenu _mainMenu;

        private bool markerID = false;
        private bool markerEmail = false;
        private bool markerSalary = false;
        private bool markerName = false; 
        private bool markerGender = false;

        private bool markerIDAvailable = false;

        public AddingForm(MainMenu mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Ok button click
        private void btn_AddStaff_Click(object sender, EventArgs e)
        {
            List<Staff> staffs = new List<Staff>();
            // transfer gender from radiobutton to 0 or 1
            int tempGender = 0; // Gender 0 : F, 1 : M
            if (rbtnMale.Checked)
            {
                tempGender = 1;
            }
            else 
            if(rbtnMale.Checked)
            {
                tempGender = 0;
            }


            try
            {
                // all fields' value must be valid data
                if (markerIDAvailable == true &&
                    markerID == true &&
                    markerEmail == true &&
                    markerSalary == true &&
                    markerName == true &&
                    markerGender == true)
                {
                    Staff staff = new Staff(Convert.ToInt32(tbxID.Text),
                                    tbxName.Text,
                                    tempGender,
                                    Convert.ToDateTime(dtpDateOfBirth.Value),
                                    tbxEmail.Text,
                                    Convert.ToSingle(tbxSalary.Text)
                                    );
                    staffs.Add(staff);

                    bool result = FileManager.SaveStaffs(staffs, 0);

                    // If save sucess or not
                    if (result == false)
                    {
                        MessageBox.Show("Error Saving", "File IO Error");
                    }
                    else
                    {
                        MessageBox.Show("Save Success");
                    }
                }
                // If any field's value invalid
                // get the hint in red color
                else
                {
                    if (markerID == false)
                    {
                        lblIDHint.ForeColor = Color.Red;
                    }
                    else
                    {
                        if (markerIDAvailable == false)
                        {
                            lblStaffIDIsAvailable.Visible = true;
                        }
                    }

                    if (markerEmail == false)
                    {
                        lblEmailHint.ForeColor = Color.Red;
                    }
                    if (markerSalary == false)
                    {
                        lblSalaryHint.ForeColor = Color.Red;
                    }
                    if (markerName == false)
                    {
                        lblNameHint.ForeColor = Color.Red;
                    }
                    if (markerGender == false)
                    {
                        lblGenderHint.ForeColor = Color.Red;
                    }
                    // Show a messagebox
                    MessageBox.Show("  All fileds are required!\n And please check input format!", "Error!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                // Show a messagebox
                MessageBox.Show("  All fileds are required!\n And please check input format!", "Error!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Back button click
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _mainMenu.Show();

        }
        // email textbox validation
        private void tbxEmail_Leave(object sender, EventArgs e)
        {
            string emailFormat = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

            // if textbox email is not empty
            if (tbxEmail.Text.Length != 0) 
            {
                if (Regex.IsMatch(tbxEmail.Text, emailFormat))
                {
                    markerEmail = true;
                    lblEmailHint.ForeColor = Color.Black;
                }
                else
                {
                    markerEmail = false;
                    lblEmailHint.ForeColor = Color.Red;
                }
            }
            else
            {
                markerEmail = false;
            }
          
        }

        // ID textbox validation
        private void tbxID_Leave(object sender, EventArgs e)
        {
            string idFormat = @"^[0-9]{6}$";

            // if textbox ID is not empty
            if (tbxID.Text.Length != 0) 
            {
                // ID format match
                if (Regex.IsMatch(tbxID.Text, idFormat)) 
                {
                    markerID = true;
                    // ID not available
                    if (Filter.CheckID(Convert.ToInt32(tbxID.Text)) == true) 
                    {
                        markerIDAvailable = false;
                        // show hint
                        lblStaffIDIsAvailable.Visible = true; 
                        lblIDHint.ForeColor = Color.Black;
                    }
                    else
                    {
                        // ID format match and available
                        markerIDAvailable = true; 
                        lblIDHint.ForeColor = Color.Black;
                        lblStaffIDIsAvailable.Visible = false;
                    }
                }
                // format not match
                else
                {
                    markerID = false;
                    lblIDHint.ForeColor = Color.Red;
                }
            }
            else
            {
                // format not match
                markerID = false;  
                lblStaffIDIsAvailable.Visible = false;
            }
        }

        // salary textbox validation
        private void tbxSalary_Leave(object sender, EventArgs e)
        {
            string salaryFormat = @"^\d+(\.\d+)?$";

            if (tbxSalary.Text.Length != 0)
            {
                if (Regex.IsMatch(tbxSalary.Text, salaryFormat))
                {
                    markerSalary = true;
                    lblSalaryHint.ForeColor = Color.Black;
                }
                else
                {
                    markerSalary = false;
                    lblSalaryHint.ForeColor = Color.Red;
                }
            }
            else
            {
                markerSalary = false;
            }
        }

        // name textbox validation
        private void tbxName_Leave(object sender, EventArgs e)
        {
            string nameFormat = @"^[A-Za-z]*(\s[A-Za-z]*)*$";
            // extra space
            string spacePattern = "\\s+";
            // replacement only one space between firstname and lastname
            string replacement = " "; 
            
            Regex rgx = new Regex(spacePattern);

            if (tbxName.Text.Length != 0)
            {
                if (Regex.IsMatch(tbxName.Text, nameFormat))
                {
                    markerName = true;
                    lblNameHint.ForeColor = Color.Black;

                    // replacement extra space to single space
                    tbxName.Text = rgx.Replace(tbxName.Text, replacement); 
                }
                else
                {
                    markerName = false;
                    lblNameHint.ForeColor = Color.Red;
                }
            }
            else
            {
                markerName = false;
            }
        }

        // male radiobutton changed
        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMale.Checked == true)
            {
                markerGender = true;
            }
        }

        // female radiobutton changed
        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFemale.Checked == true)
            {
                markerGender = true;
            }
        }

        // male radiobutton click
        private void rbtnMale_Click(object sender, EventArgs e)
        {
            if (markerGender == true)
            {
                lblGenderHint.ForeColor = Color.Black;
            }
        }

        // female radiobutton click
        private void rbtnFemale_Click(object sender, EventArgs e)
        {
            if (markerGender == true)
            {
                lblGenderHint.ForeColor = Color.Black;
            }
        }

        // button effects
        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        }
        // button effects
        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        // button effects
        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }
        // button effects
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        // set groupbox transparent
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }
    }
}
