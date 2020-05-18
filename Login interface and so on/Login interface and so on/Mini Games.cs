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
    public partial class Form_Mini_Games : Form
    {
        public Form_Mini_Games()
        {
            InitializeComponent();
        }

        private void Mini_Games_Exit_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Mini_Games_Return_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main_Menu FMM = new Form_Main_Menu();
            FMM.Show();
        }

        private void Mini_Games_Dice_Games_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Dice_Games FDG = new Form_Dice_Games();
            FDG.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Blackjack FB = new Form_Blackjack();
            FB.Show();
        }
    }
}
