using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Login_interface_and_so_on
{
    public partial class Form_Calculator : Form
    {

        double FirstNumber;
        string Operation;
        public Form_Calculator()
        {
            InitializeComponent();
            
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main_Menu MM = new Form_Main_Menu();
            MM.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void N1_Click_1(object sender, EventArgs e)
        {   
              
                    
            if (Calculator_Input_TextBox.Text == "0" && Calculator_Input_TextBox.Text != null)
            {
                Calculator_Input_TextBox.Text = "1";
            }
            else
            {
                Calculator_Input_TextBox.Text = Calculator_Input_TextBox.Text + "1";
            }
        }

        private void N2_Click(object sender, EventArgs e)
        {
            if(Calculator_Input_TextBox.Text=="0"&&Calculator_Input_TextBox.Text!=null)
            {
                Calculator_Input_TextBox.Text = "2";
            }
            else
            {
                Calculator_Input_TextBox.Text = Calculator_Input_TextBox.Text + "2";
            }
        }

        private void N3_Click(object sender, EventArgs e)
        {
            
            if(Calculator_Input_TextBox.Text=="0"&&Calculator_Input_TextBox.Text!=null)
            {
                Calculator_Input_TextBox.Text = "3";
            }
            else
            {
                Calculator_Input_TextBox.Text = Calculator_Input_TextBox.Text + "3";
            }
        }

        private void N4_Click(object sender, EventArgs e)
        {
            if(Calculator_Input_TextBox.Text=="0"&&Calculator_Input_TextBox.Text!=null)
            {
                Calculator_Input_TextBox.Text = "4";
            }
            else
            {
                Calculator_Input_TextBox.Text = Calculator_Input_TextBox.Text + "4";
            }
        }

        private void N5_Click(object sender, EventArgs e)
        {
            if(Calculator_Input_TextBox.Text=="0"&&Calculator_Input_TextBox.Text!=null)
            {
                Calculator_Input_TextBox.Text = "5";
            }
            else
            {
                Calculator_Input_TextBox.Text = Calculator_Input_TextBox.Text + "5";
            }
        }

        private void N6_Click(object sender, EventArgs e)
        {
            if(Calculator_Input_TextBox.Text=="0"&&Calculator_Input_TextBox.Text!=null)
            {
                Calculator_Input_TextBox.Text = "6";
            }
            else
            {
                Calculator_Input_TextBox.Text = Calculator_Input_TextBox.Text + "6";
            }
        }

        private void N7_Click(object sender, EventArgs e)
        {
            if(Calculator_Input_TextBox.Text=="0"&&Calculator_Input_TextBox.Text!=null)
            {
                Calculator_Input_TextBox.Text = "7";
            }
            else
            {
                Calculator_Input_TextBox.Text = Calculator_Input_TextBox.Text + "7";
            }
        }

        private void N8_Click(object sender, EventArgs e)
        {
            if (Calculator_Input_TextBox.Text == "0" && Calculator_Input_TextBox.Text !=null)
            {
                Calculator_Input_TextBox.Text = "8";
            }
            else
            {
                Calculator_Input_TextBox.Text = Calculator_Input_TextBox.Text + "8";
            }
        }

        private void N9_Click(object sender, EventArgs e)
        {
            if(Calculator_Input_TextBox.Text=="0"&&Calculator_Input_TextBox.Text!=null)
            {
                Calculator_Input_TextBox.Text = "9";
            }
            else
            {
                Calculator_Input_TextBox.Text = Calculator_Input_TextBox.Text + "9";
            }
        }

        private void N0_Click(object sender, EventArgs e)
        {
            if(Calculator_Input_TextBox.Text=="0"&&Calculator_Input_TextBox.Text!=null)
            {
                Calculator_Input_TextBox.Text = "0";
            }
            else
            {
                Calculator_Input_TextBox.Text = Calculator_Input_TextBox.Text + "0";
            }
        }

        private void Badd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Calculator_Input_TextBox.Text);
            Calculator_Input_TextBox.Text = "0";
            Operation = "+";
        }

        private void Bsub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Calculator_Input_TextBox.Text);
            Calculator_Input_TextBox.Text = "0";
            Operation = "-";
        }

        private void Bmul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Calculator_Input_TextBox.Text);
            Calculator_Input_TextBox.Text = "0";
            Operation = "*";
        }

        private void Bdiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Calculator_Input_TextBox.Text);
            Calculator_Input_TextBox.Text = "0";
            Operation = "/";
        }

        private void Bdot_Click(object sender, EventArgs e)
        {
            Calculator_Input_TextBox.Text = Calculator_Input_TextBox.Text + ".";
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            Calculator_Input_TextBox.Text = "0";
        }

        private void Bsqr_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Calculator_Input_TextBox.Text);
            Operation = "V";
        }

        private void Bpow_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Calculator_Input_TextBox.Text);
            Calculator_Input_TextBox.Text = "0";
            Operation = "^";
        }

        private void Calculator_Preview_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bequal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(Calculator_Input_TextBox.Text);

            if(Operation=="+")
            {
                Result = (FirstNumber + SecondNumber);
                Calculator_Input_TextBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if(Operation=="-")
            {
                Result = (FirstNumber - SecondNumber);
                Calculator_Input_TextBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if(Operation=="*")
            {
                Result = (FirstNumber * SecondNumber);
                Calculator_Input_TextBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if(Operation=="/")
            {
                if(SecondNumber==0)
                {
                    Calculator_Input_TextBox.Text = "Please select a non-zero divisor";
                }
                Result = (FirstNumber / SecondNumber);
                Calculator_Input_TextBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if(Operation=="V")
            {
                Result = (Math.Sqrt(FirstNumber));
                Calculator_Input_TextBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if(Operation=="^")
            {
                Result = (Math.Pow(FirstNumber, SecondNumber));
                Calculator_Input_TextBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }

        private void Form_Calculator_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.D1:
                    n1.PerformClick();
                    break;
                case Keys.D2:
                    n2.PerformClick();
                    break;
                case Keys.D3:
                    n3.PerformClick();
                    break;
                case Keys.D4:
                    n4.PerformClick();
                    break;
                case Keys.D5:
                    n5.PerformClick();
                    break;
                case Keys.D6:
                    n6.PerformClick();
                    break;
                case Keys.D7:
                    n7.PerformClick();
                    break;
                case Keys.D8:
                    n8.PerformClick();
                    break;
                case Keys.D9:
                    n9.PerformClick();
                    break;
                case Keys.Add:
                    badd.PerformClick();
                    break;
                case Keys.Subtract:
                    bsub.PerformClick();
                    break;
                case Keys.Multiply:
                    bmul.PerformClick();
                    break;
                case Keys.Divide:
                    bdiv.PerformClick();
                    break;
                case Keys.Back:
                    bClear.PerformClick();
                    break;
                case Keys.Enter:
                    bequal.PerformClick();
                    break;
            }
        }

    }
}
