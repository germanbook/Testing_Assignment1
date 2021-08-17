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

        private void btn_AddStaff_Click(object sender, EventArgs e)
        {
            List<Staff> staffs = new List<Staff>();
            // gender
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
                // all fields format match
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

                    // saved
                    if (result == false)
                    {
                        MessageBox.Show("Error Saving", "File IO Error");
                    }
                    else
                    {
                        MessageBox.Show("Save Success");
                    }
                }
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
                    MessageBox.Show("  All fileds are required!\n And please check input format!", "Error!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("  All fileds are required!\n And please check input format!", "Error!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _mainMenu.Show();

        }

        private void tbxEmail_Leave(object sender, EventArgs e)
        {
            string emailFormat = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

            if (tbxEmail.Text.Length != 0) // if textbox email is not empty
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

        private void tbxID_Leave(object sender, EventArgs e)
        {
            string idFormat = @"^[0-9]{6}$";

            if (tbxID.Text.Length != 0) // if textbox ID is not empty
            {
                if (Regex.IsMatch(tbxID.Text, idFormat)) // ID format match
                {
                    markerID = true;
                    if (Filter.CheckID(Convert.ToInt32(tbxID.Text)) == true) // ID not available
                    {
                        markerIDAvailable = false;
                        lblStaffIDIsAvailable.Visible = true; // warnning
                        lblIDHint.ForeColor = Color.Black;
                    }
                    else
                    {
                        markerIDAvailable = true; // ID format match and available
                        lblIDHint.ForeColor = Color.Black;
                        lblStaffIDIsAvailable.Visible = false;
                    }
                }
                else // format not match
                {
                    markerID = false;
                    lblIDHint.ForeColor = Color.Red;
                }
            }
            else
            {
                markerID = false; // format not match 
                lblStaffIDIsAvailable.Visible = false;
            }
        }

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

        private void tbxName_Leave(object sender, EventArgs e)
        {
            string nameFormat = @"^[A-Za-z]*(\s[A-Za-z]*)*$";
            string spacePattern = "\\s+"; // extra space
            string replacement = " "; // replacement only one space between firstname and lastname
            
            Regex rgx = new Regex(spacePattern);

            if (tbxName.Text.Length != 0)
            {
                if (Regex.IsMatch(tbxName.Text, nameFormat))
                {
                    markerName = true;
                    lblNameHint.ForeColor = Color.Black;

                    tbxName.Text = rgx.Replace(tbxName.Text, replacement); // replacement extra space to single space
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

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMale.Checked == true)
            {
                markerGender = true;
            }
        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFemale.Checked == true)
            {
                markerGender = true;
            }
        }

        private void rbtnMale_Click(object sender, EventArgs e)
        {
            if (markerGender == true)
            {
                lblGenderHint.ForeColor = Color.Black;
            }
        }

        private void rbtnFemale_Click(object sender, EventArgs e)
        {
            if (markerGender == true)
            {
                lblGenderHint.ForeColor = Color.Black;
            }
        }

        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

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
