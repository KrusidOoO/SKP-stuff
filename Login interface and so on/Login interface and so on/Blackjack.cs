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
    public partial class Form_Blackjack : Form
    {
        public Form_Blackjack()
        {
            InitializeComponent();
        }

        private void Form_Blackjack_Load(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Mini_Games FMG = new Form_Mini_Games();
            FMG.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
