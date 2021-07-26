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
    
    public partial class AddingForm : Form
    {
        MainMenu _mainMenu;
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

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            _mainMenu.Show();
        }
    }
}
