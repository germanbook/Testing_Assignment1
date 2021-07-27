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

namespace WindowsFormsApp1
{
    
    public partial class AddingForm : Form
    {
        MainMenu _mainMenu;

        private bool markerID = false;
        private bool markerName = false;
        private bool markerEmail = false;
        private bool markerSalary = false;

        public AddingForm(MainMenu mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void AddingForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddStaff_Click(object sender, EventArgs e)
        {
            int tempGender = 0;
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
                if (markerID == true && markerName == true && markerEmail == true && markerSalary == true)
                {
                    Staff staff = new Staff(Convert.ToInt32(tbxID.Text),
                                    tbxName.Text,
                                    tempGender,
                                    Convert.ToDateTime(dtpDateOfBirth.Value),
                                    tbxEmail.Text,
                                    Convert.ToSingle(tbxSalary.Text)
                                    );
                    bool result = FileManager.SaveStaffs(staff);
                    if (result == false)
                    {
                        MessageBox.Show("Error Saving Creature", "File IO Error");
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
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check input format!");
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
            Console.WriteLine(Regex.IsMatch(tbxEmail.Text, emailFormat));
            if (Regex.IsMatch(tbxEmail.Text, emailFormat))
            {
                markerEmail = true;
            }
            else
            {
                MessageBox.Show("Email format not correct", "Format!");
            }
        }
    }
}
