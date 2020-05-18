using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_interface_and_so_on
{
    public partial class Form_Main_Menu : Form
    {
        public Form_Main_Menu()
        {
            InitializeComponent();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Fun_Facts_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Fun_Facts FFF = new Form_Fun_Facts();
            FFF.Show();
        }

        private void Calculator_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Calculator FC = new Form_Calculator();
            FC.Show();
        }

        private void Mini_Games_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Mini_Games FMG = new Form_Mini_Games();
            FMG.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Countdown FCD = new Form_Countdown();
            FCD.Show();
        }

        private void Dialog_Form_Test_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Check_in_Form FCI = new Check_in_Form();
            FCI.Show();
        }
    }
}
