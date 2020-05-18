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
    public partial class Form_Login_Interface : Form
    {
        public Form_Login_Interface()
        {
            InitializeComponent();
        }
        Login login = new Login("admin", "1234");

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string user = Username_TextBox.Text;
            string pass = Password_TextBox.Text;

            if(login.IsLoggedIn(user,pass))
            {
                MessageBox.Show("You have logged in succesfully");
                this.Hide();
                Form_Main_Menu MM = new Form_Main_Menu();
                MM.Show();
            }
            else
            {
                MessageBox.Show("Error! Please check your login information and try again");
            }
        }

        private void Form_Login_Interface_Load(object sender, EventArgs e)
        {

        }
    }
}