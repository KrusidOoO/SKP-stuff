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
    public partial class Form_Dice_Games : Form
    {
        bool DiceHeld1 = false;
        bool DiceHeld2 = false;
        bool DiceHeld3 = false;
        bool DiceHeld4 = false;
        bool DiceHeld5 = false;
        bool AllHeldSwitch = false;
        int TurnCounter = 1;
        
        public Form_Dice_Games()
        {
            InitializeComponent();
            #region Hidden
            Dice1Value.Hide();
            Dice2Value.Hide();
            Dice3Value.Hide();
            Dice4Value.Hide();
            Dice5Value.Hide();
            Hold_Dice1.Hide();
            Hold_Dice1_Label.Hide();
            Hold_Dice1_Value_Label.Hide();
            Hold_Dice2.Hide();
            Hold_Dice2_Label.Hide();
            Hold_Dice2_Value_Label.Hide();
            Hold_Dice3.Hide();
            Hold_Dice3_Label.Hide();
            Hold_Dice3_Value_Label.Hide();
            Hold_Dice4.Hide();
            Hold_Dice4_Label.Hide();
            Hold_Dice4_Value_Label.Hide();
            Hold_Dice5.Hide();
            Hold_Dice5_Label.Hide();
            Hold_Dice5_Value_Label.Hide();
            Unhold_Dice1.Hide();
            Unhold_Dice2.Hide();
            Unhold_Dice3.Hide();
            Unhold_Dice4.Hide();
            Unhold_Dice5.Hide();
            Dice1_1.Hide();
            Dice1_2.Hide();
            Dice1_3.Hide();
            Dice1_4.Hide();
            Dice1_5.Hide();
            Dice1_6.Hide();
            Dice2_1.Hide();
            Dice2_2.Hide();
            Dice2_3.Hide();
            Dice2_4.Hide();
            Dice2_5.Hide();
            Dice2_6.Hide();
            Dice3_1.Hide();
            Dice3_2.Hide();
            Dice3_3.Hide();
            Dice3_4.Hide();
            Dice3_5.Hide();
            Dice3_6.Hide();
            Dice4_1.Hide();
            Dice4_2.Hide();
            Dice4_3.Hide();
            Dice4_4.Hide();
            Dice4_5.Hide();
            Dice4_6.Hide();
            Dice5_1.Hide();
            Dice5_2.Hide();
            Dice5_3.Hide();
            Dice5_4.Hide();
            Dice5_5.Hide();
            Dice5_6.Hide();
            Hold_Dice1_1.Hide();
            Hold_Dice1_2.Hide();
            Hold_Dice1_3.Hide();
            Hold_Dice1_4.Hide();
            Hold_Dice1_5.Hide();
            Hold_Dice1_6.Hide();
            Hold_Dice2_1.Hide();
            Hold_Dice2_2.Hide();
            Hold_Dice2_3.Hide();
            Hold_Dice2_4.Hide();
            Hold_Dice2_5.Hide();
            Hold_Dice2_6.Hide();
            Hold_Dice3_1.Hide();
            Hold_Dice3_2.Hide();
            Hold_Dice3_3.Hide();
            Hold_Dice3_4.Hide();
            Hold_Dice3_5.Hide();
            Hold_Dice3_6.Hide();
            Hold_Dice4_1.Hide();
            Hold_Dice4_2.Hide();
            Hold_Dice4_3.Hide();
            Hold_Dice4_4.Hide();
            Hold_Dice4_5.Hide();
            Hold_Dice4_6.Hide();
            Hold_Dice5_1.Hide();
            Hold_Dice5_2.Hide();
            Hold_Dice5_3.Hide();
            Hold_Dice5_4.Hide();
            Hold_Dice5_5.Hide();
            Hold_Dice5_6.Hide();
            #endregion

            #region Enabled/Disabled
            Hold_Dice1_Value_Label.Enabled = false;
            Hold_Dice2_Value_Label.Enabled = false;
            Hold_Dice3_Value_Label.Enabled = false;
            Hold_Dice4_Value_Label.Enabled = false;
            Hold_Dice5_Value_Label.Enabled = false;
            Score_Ones_P1_Label.Enabled = false;
            Score_Ones_P1_Button.Enabled = false;
            Score_Ones_P2_Label.Enabled = false;
            Score_Twos_Sixes_P1_Label.Enabled = false;
            Score_Twos_Sixes_P2_Label.Enabled = false;
            Score_Bonus_P1_Label.Enabled = false;
            Score_Bonus_P2_Label.Enabled = false;
            Score_OnePair_P1_Label.Enabled = false;
            Score_OnePair_P2_Label.Enabled = false;
            Score_TwoPairs_P1_Label.Enabled = false;
            Score_TwoPairs_P2_Label.Enabled = false;
            Score_ThreeIdentical_P1_Label.Enabled = false;
            Score_ThreeIdentical_P2_Label.Enabled = false;
            Score_FourIdentical_P1_Label.Enabled = false;
            Score_FourIdentical_P2_Label.Enabled = false;
            Score_SmallStraight_P1_Label.Enabled = false;
            Score_SmallStraight_P2_Label.Enabled = false;
            Score_BigStraight_P1_Label.Enabled = false;
            Score_BigStraight_P2_Label.Enabled = false;
            Score_FullHouse_P1_Label.Enabled = false;
            Score_FullHouse_P2_Label.Enabled = false;
            Score_TheChance_P1_Label.Enabled = false;
            Score_TheChance_P2_Label.Enabled = false;
            Score_Yatzy_P1_Label.Enabled = false;
            Score_Yatzy_P2_Label.Enabled = false;
            #endregion
        }

        private void Dice_Games_Roll_Button_Click(object sender, EventArgs e)
        {
            TurnCounter_Label.Text = TurnCounter.ToString();
            Dice_Games_Roll_Button.Show();
                Random rnd = new Random();

                int dice1;
                int dice2;
                int dice3;
                int dice4;
                int dice5;

                int dice1Score;
                int dice2Score;
                int dice3Score;
                int dice4Score;
                int dice5Score;

                dice1 = rnd.Next(1, 7);
                dice2 = rnd.Next(1, 7);
                dice3 = rnd.Next(1, 7);
                dice4 = rnd.Next(1, 7);
                dice5 = rnd.Next(1, 7);

                Dice1Value.Text = dice1.ToString();
                Dice2Value.Text = dice2.ToString();
                Dice3Value.Text = dice3.ToString();
                Dice4Value.Text = dice4.ToString();
                Dice5Value.Text = dice5.ToString();

                Hold_Dice1.Show();
                Hold_Dice2.Show();
                Hold_Dice3.Show();
                Hold_Dice4.Show();
                Hold_Dice5.Show();

                #region Dice Pictures

                if (Dice1Value.Text == "1" && DiceHeld1 == false)
                {
                    Dice1_1.Show();
                    Dice1_2.Hide();
                    Dice1_3.Hide();
                    Dice1_4.Hide();
                    Dice1_5.Hide();
                    Dice1_6.Hide();
                }
                if (Dice1Value.Text == "2" && DiceHeld1 == false)
                {
                    Dice1_1.Hide();
                    Dice1_2.Show();
                    Dice1_3.Hide();
                    Dice1_4.Hide();
                    Dice1_5.Hide();
                    Dice1_6.Hide();
                }
                if (Dice1Value.Text == "3" && DiceHeld1 == false)
                {
                    Dice1_1.Hide();
                    Dice1_2.Hide();
                    Dice1_3.Show();
                    Dice1_4.Hide();
                    Dice1_5.Hide();
                    Dice1_6.Hide();
                }
                if (Dice1Value.Text == "4" && DiceHeld1 == false)
                {
                    Dice1_1.Hide();
                    Dice1_2.Hide();
                    Dice1_3.Hide();
                    Dice1_4.Show();
                    Dice1_5.Hide();
                    Dice1_6.Hide();
                }
                if (Dice1Value.Text == "5" && DiceHeld1 == false)
                {
                    Dice1_1.Hide();
                    Dice1_2.Hide();
                    Dice1_3.Hide();
                    Dice1_4.Hide();
                    Dice1_5.Show();
                    Dice1_6.Hide();
                }
                if (Dice1Value.Text == "6" && DiceHeld1 == false)
                {
                    Dice1_1.Hide();
                    Dice1_2.Hide();
                    Dice1_3.Hide();
                    Dice1_4.Hide();
                    Dice1_5.Hide();
                    Dice1_6.Show();
                }
                if (Dice2Value.Text == "1" && DiceHeld2 == false)
                {
                    Dice2_1.Show();
                    Dice2_2.Hide();
                    Dice2_3.Hide();
                    Dice2_4.Hide();
                    Dice2_5.Hide();
                    Dice2_6.Hide();
                }
                if (Dice2Value.Text == "2" && DiceHeld2 == false)
                {
                    Dice2_1.Hide();
                    Dice2_2.Show();
                    Dice2_3.Hide();
                    Dice2_4.Hide();
                    Dice2_5.Hide();
                    Dice2_6.Hide();
                }
                if (Dice2Value.Text == "3" && DiceHeld2 == false)
                {
                    Dice2_1.Hide();
                    Dice2_2.Hide();
                    Dice2_3.Show();
                    Dice2_4.Hide();
                    Dice2_5.Hide();
                    Dice2_6.Hide();
                }
                if (Dice2Value.Text == "4" && DiceHeld2 == false)
                {
                    Dice2_1.Hide();
                    Dice2_2.Hide();
                    Dice2_3.Hide();
                    Dice2_4.Show();
                    Dice2_5.Hide();
                    Dice2_6.Hide();
                }
                if (Dice2Value.Text == "5" && DiceHeld2 == false)
                {
                    Dice2_1.Hide();
                    Dice2_2.Hide();
                    Dice2_3.Hide();
                    Dice2_4.Hide();
                    Dice2_5.Show();
                    Dice2_6.Hide();
                }
                if (Dice2Value.Text == "6" && DiceHeld2 == false)
                {
                    Dice2_1.Hide();
                    Dice2_2.Hide();
                    Dice2_3.Hide();
                    Dice2_4.Hide();
                    Dice2_5.Hide();
                    Dice2_6.Show();
                }
                if (Dice3Value.Text == "1" && DiceHeld3 == false)
                {
                    Dice3_1.Show();
                    Dice3_2.Hide();
                    Dice3_3.Hide();
                    Dice3_4.Hide();
                    Dice3_5.Hide();
                    Dice3_6.Hide();
                }
                if (Dice3Value.Text == "2" && DiceHeld3 == false)
                {
                    Dice3_1.Hide();
                    Dice3_2.Show();
                    Dice3_3.Hide();
                    Dice3_4.Hide();
                    Dice3_5.Hide();
                    Dice3_6.Hide();
                }
                if (Dice3Value.Text == "3" && DiceHeld3 == false)
                {
                    Dice3_1.Hide();
                    Dice3_2.Hide();
                    Dice3_3.Show();
                    Dice3_4.Hide();
                    Dice3_5.Hide();
                    Dice3_6.Hide();
                }
                if (Dice3Value.Text == "4" && DiceHeld3 == false)
                {
                    Dice3_1.Hide();
                    Dice3_2.Hide();
                    Dice3_3.Hide();
                    Dice3_4.Show();
                    Dice3_5.Hide();
                    Dice3_6.Hide();
                }
                if (Dice3Value.Text == "5" && DiceHeld3 == false)
                {
                    Dice3_1.Hide();
                    Dice3_2.Hide();
                    Dice3_3.Hide();
                    Dice3_4.Hide();
                    Dice3_5.Show();
                    Dice3_6.Hide();
                }
                if (Dice3Value.Text == "6" && DiceHeld3 == false)
                {
                    Dice3_1.Hide();
                    Dice3_2.Hide();
                    Dice3_3.Hide();
                    Dice3_4.Hide();
                    Dice3_5.Hide();
                    Dice3_6.Show();
                }
                if (Dice4Value.Text == "1" && DiceHeld4 == false)
                {
                    Dice4_1.Show();
                    Dice4_2.Hide();
                    Dice4_3.Hide();
                    Dice4_4.Hide();
                    Dice4_5.Hide();
                    Dice4_6.Hide();
                }
                if (Dice4Value.Text == "2" && DiceHeld4 == false)
                {
                    Dice4_1.Hide();
                    Dice4_2.Show();
                    Dice4_3.Hide();
                    Dice4_4.Hide();
                    Dice4_5.Hide();
                    Dice4_6.Hide();
                }
                if (Dice4Value.Text == "3" && DiceHeld4 == false)
                {
                    Dice4_1.Hide();
                    Dice4_2.Hide();
                    Dice4_3.Show();
                    Dice4_4.Hide();
                    Dice4_5.Hide();
                    Dice4_6.Hide();
                }
                if (Dice4Value.Text == "4" && DiceHeld4 == false)
                {
                    Dice4_1.Hide();
                    Dice4_2.Hide();
                    Dice4_3.Hide();
                    Dice4_4.Show();
                    Dice4_5.Hide();
                    Dice4_6.Hide();
                }
                if (Dice4Value.Text == "5" && DiceHeld4 == false)
                {
                    Dice4_1.Hide();
                    Dice4_2.Hide();
                    Dice4_3.Hide();
                    Dice4_4.Hide();
                    Dice4_5.Show();
                    Dice4_6.Hide();
                }
                if (Dice4Value.Text == "6" && DiceHeld4 == false)
                {
                    Dice4_1.Hide();
                    Dice4_2.Hide();
                    Dice4_3.Hide();
                    Dice4_4.Hide();
                    Dice4_5.Hide();
                    Dice4_6.Show();
                }
                if (Dice5Value.Text == "1" && DiceHeld5 == false)
                {
                    Dice5_1.Show();
                    Dice5_2.Hide();
                    Dice5_3.Hide();
                    Dice5_4.Hide();
                    Dice5_5.Hide();
                    Dice5_6.Hide();
                }
                if (Dice5Value.Text == "2" && DiceHeld5 == false)
                {
                    Dice5_1.Hide();
                    Dice5_2.Show();
                    Dice5_3.Hide();
                    Dice5_4.Hide();
                    Dice5_5.Hide();
                    Dice5_6.Hide();
                }
                if (Dice5Value.Text == "3" && DiceHeld5 == false)
                {
                    Dice5_1.Hide();
                    Dice5_2.Hide();
                    Dice5_3.Show();
                    Dice5_4.Hide();
                    Dice5_5.Hide();
                    Dice5_6.Hide();
                }
                if (Dice5Value.Text == "4" && DiceHeld5 == false)
                {
                    Dice5_1.Hide();
                    Dice5_2.Hide();
                    Dice5_3.Hide();
                    Dice5_4.Show();
                    Dice5_5.Hide();
                    Dice5_6.Hide();
                }
                if (Dice5Value.Text == "5" && DiceHeld5 == false)
                {
                    Dice5_1.Hide();
                    Dice5_2.Hide();
                    Dice5_3.Hide();
                    Dice5_4.Hide();
                    Dice5_5.Show();
                    Dice5_6.Hide();
                }
                if (Dice5Value.Text == "6" && DiceHeld5 == false)
                {
                    Dice5_1.Hide();
                    Dice5_2.Hide();
                    Dice5_3.Hide();
                    Dice5_4.Hide();
                    Dice5_5.Hide();
                    Dice5_6.Show();
                }

            #endregion

            #region Dice Held
                if (DiceHeld1 == true)
                {
                    Hold_Dice1.Hide();
                    Dice1_1.Hide();
                    Dice1_2.Hide();
                    Dice1_3.Hide();
                    Dice1_4.Hide();
                    Dice1_5.Hide();
                    Dice1_6.Hide();
                }
                if (DiceHeld2 == true)
                {
                    Hold_Dice2.Hide();
                    Dice2_1.Hide();
                    Dice2_2.Hide();
                    Dice2_3.Hide();
                    Dice2_4.Hide();
                    Dice2_5.Hide();
                    Dice2_6.Hide();
                }
                if (DiceHeld3 == true)
                {
                    Hold_Dice3.Hide();
                    Dice3_1.Hide();
                    Dice3_2.Hide();
                    Dice3_3.Hide();
                    Dice3_4.Hide();
                    Dice3_5.Hide();
                    Dice3_6.Hide();
                }
                if (DiceHeld4 == true)
                {
                    Hold_Dice4.Hide();
                    Dice4_1.Hide();
                    Dice4_2.Hide();
                    Dice4_3.Hide();
                    Dice4_4.Hide();
                    Dice4_5.Hide();
                    Dice4_6.Hide();
                }
                if (DiceHeld5 == true)
                {
                    Hold_Dice5.Hide();
                    Dice5_1.Hide();
                    Dice5_2.Hide();
                    Dice5_3.Hide();
                    Dice5_4.Hide();
                    Dice5_5.Hide();
                    Dice5_6.Hide();
                }
            #endregion

            

            dice1Score = Convert.ToInt32(Hold_Dice1_Value_Label.Text);
            dice2Score = Convert.ToInt32(Hold_Dice2_Value_Label.Text);
            dice3Score = Convert.ToInt32(Hold_Dice3_Value_Label.Text);
            dice4Score = Convert.ToInt32(Hold_Dice4_Value_Label.Text);
            dice5Score = Convert.ToInt32(Hold_Dice5_Value_Label.Text);

            if (dice1Score == 1 && dice2Score == 1 && dice3Score == 1 && dice4Score == 1 && dice5Score == 1)
            {
                Score_Ones_P1_Button.Enabled = true;
            }
            if (DiceHeld1==true&&DiceHeld2==true&&DiceHeld3==true&&DiceHeld4==true&&DiceHeld5==true)
            {
                AllHeldSwitch = true;
            }
            if (TurnCounter % 3 == 0 || AllHeldSwitch == true)
            {



                const string message = "Are you ready to switch turns?";
                const string caption = "";
                var resultMessage = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);




                if (resultMessage == DialogResult.Yes)
                {
                    #region End turn

                    TurnCounter = 1;
                    AllHeldSwitch = false;
                    TurnCounter_Label.Text = TurnCounter.ToString();

                    dice1 = rnd.Next(1, 7);
                    dice2 = rnd.Next(1, 7);
                    dice3 = rnd.Next(1, 7);
                    dice4 = rnd.Next(1, 7);
                    dice5 = rnd.Next(1, 7);

                    Dice1Value.Text = dice1.ToString();
                    Dice2Value.Text = dice2.ToString();
                    Dice3Value.Text = dice3.ToString();
                    Dice4Value.Text = dice4.ToString();
                    Dice5Value.Text = dice5.ToString();

                    Hold_Dice1.Show();
                    Unhold_Dice1.Hide();
                    Dice1Value.Hide();
                    Hold_Dice1_1.Hide();
                    Hold_Dice1_2.Hide();
                    Hold_Dice1_3.Hide();
                    Hold_Dice1_4.Hide();
                    Hold_Dice1_5.Hide();
                    Hold_Dice1_6.Hide();
                    DiceHeld1 = false;

                    Hold_Dice2.Show();
                    Unhold_Dice2.Hide();
                    DiceHeld2 = false;
                    Dice2Value.Hide();
                    Hold_Dice2_1.Hide();
                    Hold_Dice2_2.Hide();
                    Hold_Dice2_3.Hide();
                    Hold_Dice2_4.Hide();
                    Hold_Dice2_5.Hide();
                    Hold_Dice2_6.Hide();

                    Hold_Dice3.Show();
                    Unhold_Dice3.Hide();
                    DiceHeld3 = false;
                    Dice3Value.Hide();
                    Hold_Dice3_1.Hide();
                    Hold_Dice3_2.Hide();
                    Hold_Dice3_3.Hide();
                    Hold_Dice3_4.Hide();
                    Hold_Dice3_5.Hide();
                    Hold_Dice3_6.Hide();

                    Hold_Dice4.Show();
                    Unhold_Dice4.Hide();
                    DiceHeld4 = false;
                    Dice4Value.Hide();
                    Hold_Dice4_1.Hide();
                    Hold_Dice4_2.Hide();
                    Hold_Dice4_3.Hide();
                    Hold_Dice4_4.Hide();
                    Hold_Dice4_5.Hide();
                    Hold_Dice4_6.Hide();

                    Hold_Dice5.Show();
                    Unhold_Dice5.Hide();
                    DiceHeld5 = false;
                    Dice5Value.Hide();
                    Hold_Dice5_1.Hide();
                    Hold_Dice5_2.Hide();
                    Hold_Dice5_3.Hide();
                    Hold_Dice5_4.Hide();
                    Hold_Dice5_5.Hide();
                    Hold_Dice5_6.Hide();

                    if (Dice1Value.Text == "1" && DiceHeld1 == false)
                    {
                        Dice1_1.Show();
                        Dice1_2.Hide();
                        Dice1_3.Hide();
                        Dice1_4.Hide();
                        Dice1_5.Hide();
                        Dice1_6.Hide();
                    }
                    if (Dice1Value.Text == "2" && DiceHeld1 == false)
                    {
                        Dice1_1.Hide();
                        Dice1_2.Show();
                        Dice1_3.Hide();
                        Dice1_4.Hide();
                        Dice1_5.Hide();
                        Dice1_6.Hide();
                    }
                    if (Dice1Value.Text == "3" && DiceHeld1 == false)
                    {
                        Dice1_1.Hide();
                        Dice1_2.Hide();
                        Dice1_3.Show();
                        Dice1_4.Hide();
                        Dice1_5.Hide();
                        Dice1_6.Hide();
                    }
                    if (Dice1Value.Text == "4" && DiceHeld1 == false)
                    {
                        Dice1_1.Hide();
                        Dice1_2.Hide();
                        Dice1_3.Hide();
                        Dice1_4.Show();
                        Dice1_5.Hide();
                        Dice1_6.Hide();
                    }
                    if (Dice1Value.Text == "5" && DiceHeld1 == false)
                    {
                        Dice1_1.Hide();
                        Dice1_2.Hide();
                        Dice1_3.Hide();
                        Dice1_4.Hide();
                        Dice1_5.Show();
                        Dice1_6.Hide();
                    }
                    if (Dice1Value.Text == "6" && DiceHeld1 == false)
                    {
                        Dice1_1.Hide();
                        Dice1_2.Hide();
                        Dice1_3.Hide();
                        Dice1_4.Hide();
                        Dice1_5.Hide();
                        Dice1_6.Show();
                    }
                    if (Dice2Value.Text == "1" && DiceHeld2 == false)
                    {
                        Dice2_1.Show();
                        Dice2_2.Hide();
                        Dice2_3.Hide();
                        Dice2_4.Hide();
                        Dice2_5.Hide();
                        Dice2_6.Hide();
                    }
                    if (Dice2Value.Text == "2" && DiceHeld2 == false)
                    {
                        Dice2_1.Hide();
                        Dice2_2.Show();
                        Dice2_3.Hide();
                        Dice2_4.Hide();
                        Dice2_5.Hide();
                        Dice2_6.Hide();
                    }
                    if (Dice2Value.Text == "3" && DiceHeld2 == false)
                    {
                        Dice2_1.Hide();
                        Dice2_2.Hide();
                        Dice2_3.Show();
                        Dice2_4.Hide();
                        Dice2_5.Hide();
                        Dice2_6.Hide();
                    }
                    if (Dice2Value.Text == "4" && DiceHeld2 == false)
                    {
                        Dice2_1.Hide();
                        Dice2_2.Hide();
                        Dice2_3.Hide();
                        Dice2_4.Show();
                        Dice2_5.Hide();
                        Dice2_6.Hide();
                    }
                    if (Dice2Value.Text == "5" && DiceHeld2 == false)
                    {
                        Dice2_1.Hide();
                        Dice2_2.Hide();
                        Dice2_3.Hide();
                        Dice2_4.Hide();
                        Dice2_5.Show();
                        Dice2_6.Hide();
                    }
                    if (Dice2Value.Text == "6" && DiceHeld2 == false)
                    {
                        Dice2_1.Hide();
                        Dice2_2.Hide();
                        Dice2_3.Hide();
                        Dice2_4.Hide();
                        Dice2_5.Hide();
                        Dice2_6.Show();
                    }
                    if (Dice3Value.Text == "1" && DiceHeld3 == false)
                    {
                        Dice3_1.Show();
                        Dice3_2.Hide();
                        Dice3_3.Hide();
                        Dice3_4.Hide();
                        Dice3_5.Hide();
                        Dice3_6.Hide();
                    }
                    if (Dice3Value.Text == "2" && DiceHeld3 == false)
                    {
                        Dice3_1.Hide();
                        Dice3_2.Show();
                        Dice3_3.Hide();
                        Dice3_4.Hide();
                        Dice3_5.Hide();
                        Dice3_6.Hide();
                    }
                    if (Dice3Value.Text == "3" && DiceHeld3 == false)
                    {
                        Dice3_1.Hide();
                        Dice3_2.Hide();
                        Dice3_3.Show();
                        Dice3_4.Hide();
                        Dice3_5.Hide();
                        Dice3_6.Hide();
                    }
                    if (Dice3Value.Text == "4" && DiceHeld3 == false)
                    {
                        Dice3_1.Hide();
                        Dice3_2.Hide();
                        Dice3_3.Hide();
                        Dice3_4.Show();
                        Dice3_5.Hide();
                        Dice3_6.Hide();
                    }
                    if (Dice3Value.Text == "5" && DiceHeld3 == false)
                    {
                        Dice3_1.Hide();
                        Dice3_2.Hide();
                        Dice3_3.Hide();
                        Dice3_4.Hide();
                        Dice3_5.Show();
                        Dice3_6.Hide();
                    }
                    if (Dice3Value.Text == "6" && DiceHeld3 == false)
                    {
                        Dice3_1.Hide();
                        Dice3_2.Hide();
                        Dice3_3.Hide();
                        Dice3_4.Hide();
                        Dice3_5.Hide();
                        Dice3_6.Show();
                    }
                    if (Dice4Value.Text == "1" && DiceHeld4 == false)
                    {
                        Dice4_1.Show();
                        Dice4_2.Hide();
                        Dice4_3.Hide();
                        Dice4_4.Hide();
                        Dice4_5.Hide();
                        Dice4_6.Hide();
                    }
                    if (Dice4Value.Text == "2" && DiceHeld4 == false)
                    {
                        Dice4_1.Hide();
                        Dice4_2.Show();
                        Dice4_3.Hide();
                        Dice4_4.Hide();
                        Dice4_5.Hide();
                        Dice4_6.Hide();
                    }
                    if (Dice4Value.Text == "3" && DiceHeld4 == false)
                    {
                        Dice4_1.Hide();
                        Dice4_2.Hide();
                        Dice4_3.Show();
                        Dice4_4.Hide();
                        Dice4_5.Hide();
                        Dice4_6.Hide();
                    }
                    if (Dice4Value.Text == "4" && DiceHeld4 == false)
                    {
                        Dice4_1.Hide();
                        Dice4_2.Hide();
                        Dice4_3.Hide();
                        Dice4_4.Show();
                        Dice4_5.Hide();
                        Dice4_6.Hide();
                    }
                    if (Dice4Value.Text == "5" && DiceHeld4 == false)
                    {
                        Dice4_1.Hide();
                        Dice4_2.Hide();
                        Dice4_3.Hide();
                        Dice4_4.Hide();
                        Dice4_5.Show();
                        Dice4_6.Hide();
                    }
                    if (Dice4Value.Text == "6" && DiceHeld4 == false)
                    {
                        Dice4_1.Hide();
                        Dice4_2.Hide();
                        Dice4_3.Hide();
                        Dice4_4.Hide();
                        Dice4_5.Hide();
                        Dice4_6.Show();
                    }
                    if (Dice5Value.Text == "1" && DiceHeld5 == false)
                    {
                        Dice5_1.Show();
                        Dice5_2.Hide();
                        Dice5_3.Hide();
                        Dice5_4.Hide();
                        Dice5_5.Hide();
                        Dice5_6.Hide();
                    }
                    if (Dice5Value.Text == "2" && DiceHeld5 == false)
                    {
                        Dice5_1.Hide();
                        Dice5_2.Show();
                        Dice5_3.Hide();
                        Dice5_4.Hide();
                        Dice5_5.Hide();
                        Dice5_6.Hide();
                    }
                    if (Dice5Value.Text == "3" && DiceHeld5 == false)
                    {
                        Dice5_1.Hide();
                        Dice5_2.Hide();
                        Dice5_3.Show();
                        Dice5_4.Hide();
                        Dice5_5.Hide();
                        Dice5_6.Hide();
                    }
                    if (Dice5Value.Text == "4" && DiceHeld5 == false)
                    {
                        Dice5_1.Hide();
                        Dice5_2.Hide();
                        Dice5_3.Hide();
                        Dice5_4.Show();
                        Dice5_5.Hide();
                        Dice5_6.Hide();
                    }
                    if (Dice5Value.Text == "5" && DiceHeld5 == false)
                    {
                        Dice5_1.Hide();
                        Dice5_2.Hide();
                        Dice5_3.Hide();
                        Dice5_4.Hide();
                        Dice5_5.Show();
                        Dice5_6.Hide();
                    }
                    if (Dice5Value.Text == "6" && DiceHeld5 == false)
                    {
                        Dice5_1.Hide();
                        Dice5_2.Hide();
                        Dice5_3.Hide();
                        Dice5_4.Hide();
                        Dice5_5.Hide();
                        Dice5_6.Show();
                    }
                    #endregion
                }


                if (resultMessage == DialogResult.No)
                {

                    TurnCounter = 3;

                }

            }

            TurnCounter++;

        }


        #region Practical Buttons
        private void Dice_Games_Exit_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Dice_Games_Return_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Mini_Games FMG = new Form_Mini_Games();
            FMG.Show();
        }
        #endregion

        #region Hold Dices
        private void Hold_Dice1_Click(object sender, EventArgs e)
        {
            Dice1_1.Hide();
            Dice1_2.Hide();
            Dice1_3.Hide();
            Dice1_4.Hide();
            Dice1_5.Hide();
            Dice1_6.Hide();
            Hold_Dice1.Hide();
            Hold_Dice1_Label.Hide();
            Hold_Dice1_Value_Label.Hide();
            Unhold_Dice1.Show();
            Hold_Dice1_Value_Label.Text = Dice1Value.Text;
            Dice1Value.Hide();
            DiceHeld1 = true;
            Dice1_1.Hide();
            if (Hold_Dice1_Value_Label.Text == "1"&&DiceHeld1==true)
            {
                Hold_Dice1_1.Show();
                Hold_Dice1_2.Hide();
                Hold_Dice1_3.Hide();
                Hold_Dice1_4.Hide();
                Hold_Dice1_5.Hide();
                Hold_Dice1_6.Hide();
                

            }
            if (Hold_Dice1_Value_Label.Text == "2" && DiceHeld1 == true)
            {
                Hold_Dice1_1.Hide();
                Hold_Dice1_2.Show();
                Hold_Dice1_3.Hide();
                Hold_Dice1_4.Hide();
                Hold_Dice1_5.Hide();
                Hold_Dice1_6.Hide();
                

            }
            if (Hold_Dice1_Value_Label.Text == "3" && DiceHeld1 == true)
            {
                Hold_Dice1_1.Hide();
                Hold_Dice1_2.Hide();
                Hold_Dice1_3.Show();
                Hold_Dice1_4.Hide();
                Hold_Dice1_5.Hide();
                Hold_Dice1_6.Hide();
                

            }
            if (Hold_Dice1_Value_Label.Text == "4" && DiceHeld1 == true)
            {
                Hold_Dice1_1.Hide();
                Hold_Dice1_2.Hide();
                Hold_Dice1_3.Hide();
                Hold_Dice1_4.Show();
                Hold_Dice1_5.Hide();
                Hold_Dice1_6.Hide();
                

            }
            if (Hold_Dice1_Value_Label.Text == "5" && DiceHeld1 == true)
            {
                Hold_Dice1_1.Hide();
                Hold_Dice1_2.Hide();
                Hold_Dice1_3.Hide();
                Hold_Dice1_4.Hide();
                Hold_Dice1_5.Show();
                Hold_Dice1_6.Hide();
                

            }
            if (Hold_Dice1_Value_Label.Text == "6" && DiceHeld1 == true)
            {
                Hold_Dice1_1.Hide();
                Hold_Dice1_2.Hide();
                Hold_Dice1_3.Hide();
                Hold_Dice1_4.Hide();
                Hold_Dice1_5.Hide();
                Hold_Dice1_6.Show();
                

            }


        }

        private void Hold_Dice2_Click(object sender, EventArgs e)
        {
            Dice2_1.Hide();
            Dice2_2.Hide();
            Dice2_3.Hide();
            Dice2_4.Hide();
            Dice2_5.Hide();
            Dice2_6.Hide();
            Hold_Dice2.Hide();
            Hold_Dice2_Label.Hide();
            Hold_Dice2_Value_Label.Hide();
            Unhold_Dice2.Show();
            Hold_Dice2_Value_Label.Text = Dice2Value.Text;
            Dice2Value.Hide();
            DiceHeld2 = true;
            if (Hold_Dice2_Value_Label.Text == "1" && DiceHeld2 == true)
            {
                Hold_Dice2_1.Show();
                Hold_Dice2_2.Hide();
                Hold_Dice2_3.Hide();
                Hold_Dice2_4.Hide();
                Hold_Dice2_5.Hide();
                Hold_Dice2_6.Hide();
                

            }
            if (Hold_Dice2_Value_Label.Text == "2" && DiceHeld2 == true)
            {
                Hold_Dice2_1.Hide();
                Hold_Dice2_2.Show();
                Hold_Dice2_3.Hide();
                Hold_Dice2_4.Hide();
                Hold_Dice2_5.Hide();
                Hold_Dice2_6.Hide();
                

            }
            if (Hold_Dice2_Value_Label.Text == "3" && DiceHeld2 == true)
            {
                Hold_Dice2_1.Hide();
                Hold_Dice2_2.Hide();
                Hold_Dice2_3.Show();
                Hold_Dice2_4.Hide();
                Hold_Dice2_5.Hide();
                Hold_Dice2_6.Hide();
                

            }
            if (Hold_Dice2_Value_Label.Text == "4" && DiceHeld2 == true)
            {
                Hold_Dice2_1.Hide();
                Hold_Dice2_2.Hide();
                Hold_Dice2_3.Hide();
                Hold_Dice2_4.Show();
                Hold_Dice2_5.Hide();
                Hold_Dice2_6.Hide();
                

            }
            if (Hold_Dice2_Value_Label.Text == "5" && DiceHeld2 == true)
            {
                Hold_Dice2_1.Hide();
                Hold_Dice2_2.Hide();
                Hold_Dice2_3.Hide();
                Hold_Dice2_4.Hide();
                Hold_Dice2_5.Show();
                Hold_Dice2_6.Hide();
                

            }
            if (Hold_Dice2_Value_Label.Text == "6" && DiceHeld2 == true)
            {
                Hold_Dice2_1.Hide();
                Hold_Dice2_2.Hide();
                Hold_Dice2_3.Hide();
                Hold_Dice2_4.Hide();
                Hold_Dice2_5.Hide();
                Hold_Dice2_6.Show();
                

            }

        }

        private void Hold_Dice3_Click(object sender, EventArgs e)
        {
            Dice3_1.Hide();
            Dice3_2.Hide();
            Dice3_3.Hide();
            Dice3_4.Hide();
            Dice3_5.Hide();
            Dice3_6.Hide();
            Hold_Dice3.Hide();
            Hold_Dice3_Label.Hide();
            Hold_Dice3_Value_Label.Hide();
            Unhold_Dice3.Show();
            Hold_Dice3_Value_Label.Text = Dice3Value.Text;
            DiceHeld3 = true;
            Dice3Value.Hide();

            if (Hold_Dice3_Value_Label.Text == "1" && DiceHeld3 == true)
            {
                Hold_Dice3_1.Show();
                Hold_Dice3_2.Hide();
                Hold_Dice3_3.Hide();
                Hold_Dice3_4.Hide();
                Hold_Dice3_5.Hide();
                Hold_Dice3_6.Hide();
                

            }
            if (Hold_Dice3_Value_Label.Text == "2" && DiceHeld3 == true)
            {
                Hold_Dice3_1.Hide();
                Hold_Dice3_2.Show();
                Hold_Dice3_3.Hide();
                Hold_Dice3_4.Hide();
                Hold_Dice3_5.Hide();
                Hold_Dice3_6.Hide();
                

            }
            if (Hold_Dice3_Value_Label.Text == "3" && DiceHeld3 == true)
            {
                Hold_Dice3_1.Hide();
                Hold_Dice3_2.Hide();
                Hold_Dice3_3.Show();
                Hold_Dice3_4.Hide();
                Hold_Dice3_5.Hide();
                Hold_Dice3_6.Hide();
                

            }
            if (Hold_Dice3_Value_Label.Text == "4" && DiceHeld3 == true)
            {
                Hold_Dice3_1.Hide();
                Hold_Dice3_2.Hide();
                Hold_Dice3_3.Hide();
                Hold_Dice3_4.Show();
                Hold_Dice3_5.Hide();
                Hold_Dice3_6.Hide();
                

            }
            if (Hold_Dice3_Value_Label.Text == "5" && DiceHeld3 == true)
            {
                Hold_Dice3_1.Hide();
                Hold_Dice3_2.Hide();
                Hold_Dice3_3.Hide();
                Hold_Dice3_4.Hide();
                Hold_Dice3_5.Show();
                Hold_Dice3_6.Hide();
                

            }
            if (Hold_Dice3_Value_Label.Text == "6" && DiceHeld3 == true)
            {
                Hold_Dice3_1.Hide();
                Hold_Dice3_2.Hide();
                Hold_Dice3_3.Hide();
                Hold_Dice3_4.Hide();
                Hold_Dice3_5.Hide();
                Hold_Dice3_6.Show();
                

            }

        }

        private void Hold_Dice4_Click(object sender, EventArgs e)
        {
            Dice4_1.Hide();
            Dice4_2.Hide();
            Dice4_3.Hide();
            Dice4_4.Hide();
            Dice4_5.Hide();
            Dice4_6.Hide();
            Hold_Dice4.Hide();
            Hold_Dice4_Label.Hide();
            Hold_Dice4_Value_Label.Hide();
            Unhold_Dice4.Show();
            Hold_Dice4_Value_Label.Text = Dice4Value.Text;
            DiceHeld4 = true;
            Dice4Value.Hide();

            if (Hold_Dice4_Value_Label.Text == "1" && DiceHeld4 == true)
            {
                Hold_Dice4_1.Show();
                Hold_Dice4_2.Hide();
                Hold_Dice4_3.Hide();
                Hold_Dice4_4.Hide();
                Hold_Dice4_5.Hide();
                Hold_Dice4_6.Hide();
                

            }
            if (Hold_Dice4_Value_Label.Text == "2" && DiceHeld4 == true)
            {
                Hold_Dice4_1.Hide();
                Hold_Dice4_2.Show();
                Hold_Dice4_3.Hide();
                Hold_Dice4_4.Hide();
                Hold_Dice4_5.Hide();
                Hold_Dice4_6.Hide();
                

            }
            if (Hold_Dice4_Value_Label.Text == "3" && DiceHeld4 == true)
            {
                Hold_Dice4_1.Hide();
                Hold_Dice4_2.Hide();
                Hold_Dice4_3.Show();
                Hold_Dice4_4.Hide();
                Hold_Dice4_5.Hide();
                Hold_Dice4_6.Hide();
                

            }
            if (Hold_Dice4_Value_Label.Text == "4" && DiceHeld4 == true)
            {
                Hold_Dice4_1.Hide();
                Hold_Dice4_2.Hide();
                Hold_Dice4_3.Hide();
                Hold_Dice4_4.Show();
                Hold_Dice4_5.Hide();
                Hold_Dice4_6.Hide();
                

            }
            if (Hold_Dice4_Value_Label.Text == "5" && DiceHeld4 == true)
            {
                Hold_Dice4_1.Hide();
                Hold_Dice4_2.Hide();
                Hold_Dice4_3.Hide();
                Hold_Dice4_4.Hide();
                Hold_Dice4_5.Show();
                Hold_Dice4_6.Hide();
                

            }
            if (Hold_Dice4_Value_Label.Text == "6" && DiceHeld4 == true)
            {
                Hold_Dice4_1.Hide();
                Hold_Dice4_2.Hide();
                Hold_Dice4_3.Hide();
                Hold_Dice4_4.Hide();
                Hold_Dice4_5.Hide();
                Hold_Dice4_6.Show();
                

            }

        }

        private void Hold_Dice5_Click(object sender, EventArgs e)
        {
            Dice5_1.Hide();
            Dice5_2.Hide();
            Dice5_3.Hide();
            Dice5_4.Hide();
            Dice5_5.Hide();
            Dice5_6.Hide();
            Hold_Dice5.Hide();
            Hold_Dice5_Label.Hide();
            Hold_Dice5_Value_Label.Hide();
            Unhold_Dice5.Show();
            Hold_Dice5_Value_Label.Text = Dice5Value.Text;
            DiceHeld5 = true;
            Dice5Value.Hide();

            if (Hold_Dice5_Value_Label.Text == "1" && DiceHeld5 == true)
            {
                Hold_Dice5_1.Show();
                Hold_Dice5_2.Hide();
                Hold_Dice5_3.Hide();
                Hold_Dice5_4.Hide();
                Hold_Dice5_5.Hide();
                Hold_Dice5_6.Hide();
                

            }
            if (Hold_Dice5_Value_Label.Text == "2" && DiceHeld5 == true)
            {
                Hold_Dice5_1.Hide();
                Hold_Dice5_2.Show();
                Hold_Dice5_3.Hide();
                Hold_Dice5_4.Hide();
                Hold_Dice5_5.Hide();
                Hold_Dice5_6.Hide();
                

            }
            if (Hold_Dice5_Value_Label.Text == "3" && DiceHeld5 == true)
            {
                Hold_Dice5_1.Hide();
                Hold_Dice5_2.Hide();
                Hold_Dice5_3.Show();
                Hold_Dice5_4.Hide();
                Hold_Dice5_5.Hide();
                Hold_Dice5_6.Hide();
                

            }
            if (Hold_Dice5_Value_Label.Text == "4" && DiceHeld5 == true)
            {
                Hold_Dice5_1.Hide();
                Hold_Dice5_2.Hide();
                Hold_Dice5_3.Hide();
                Hold_Dice5_4.Show();
                Hold_Dice5_5.Hide();
                Hold_Dice5_6.Hide();
                

            }
            if (Hold_Dice5_Value_Label.Text == "5" && DiceHeld5 == true)
            {
                Hold_Dice5_1.Hide();
                Hold_Dice5_2.Hide();
                Hold_Dice5_3.Hide();
                Hold_Dice5_4.Hide();
                Hold_Dice5_5.Show();
                Hold_Dice5_6.Hide();
                
            }
            if (Hold_Dice5_Value_Label.Text == "6" && DiceHeld5 == true)
            {
                Hold_Dice5_1.Hide();
                Hold_Dice5_2.Hide();
                Hold_Dice5_3.Hide();
                Hold_Dice5_4.Hide();
                Hold_Dice5_5.Hide();
                Hold_Dice5_6.Show();
                

            }

        }
#endregion

        #region Unhold Dices
        private void Unhold_Dice1_Click(object sender, EventArgs e)
        {
            Hold_Dice1.Show();
            Hold_Dice1_Label.Hide();
            Hold_Dice1_Value_Label.Hide();
            Unhold_Dice1.Hide();
            Dice1Value.Text = Hold_Dice1_Value_Label.Text;
            Dice1Value.Hide();
            Hold_Dice1_1.Hide();
            Hold_Dice1_2.Hide();
            Hold_Dice1_3.Hide();
            Hold_Dice1_4.Hide();
            Hold_Dice1_5.Hide();
            Hold_Dice1_6.Hide();
            DiceHeld1 = false;
            if (Dice1Value.Text == "1"&&DiceHeld1==false)
            {
                Dice1_1.Show();
                Dice1_2.Hide();
                Dice1_3.Hide();
                Dice1_4.Hide();
                Dice1_5.Hide();
                Dice1_6.Hide();
            }
            if (Dice1Value.Text == "2" && DiceHeld1 == false)
            {
                Dice1_1.Hide();
                Dice1_2.Show();
                Dice1_3.Hide();
                Dice1_4.Hide();
                Dice1_5.Hide();
                Dice1_6.Hide();
            }
            if (Dice1Value.Text == "3" && DiceHeld1 == false)
            {
                Dice1_1.Hide();
                Dice1_2.Hide();
                Dice1_3.Show();
                Dice1_4.Hide();
                Dice1_5.Hide();
                Dice1_6.Hide();
            }
            if (Dice1Value.Text == "4" && DiceHeld1 == false)
            {
                Dice1_1.Hide();
                Dice1_2.Hide();
                Dice1_3.Hide();
                Dice1_4.Show();
                Dice1_5.Hide();
                Dice1_6.Hide();
            }
            if (Dice1Value.Text == "5" && DiceHeld1 == false)
            {
                Dice1_1.Hide();
                Dice1_2.Hide();
                Dice1_3.Hide();
                Dice1_4.Hide();
                Dice1_5.Show();
                Dice1_6.Hide();
            }
            if (Dice1Value.Text == "6" && DiceHeld1 == false)
            {
                Dice1_1.Hide();
                Dice1_2.Hide();
                Dice1_3.Hide();
                Dice1_4.Hide();
                Dice1_5.Hide();
                Dice1_6.Show();
            }
        }

        private void Unhold_Dice2_Click(object sender, EventArgs e)
        {
            Hold_Dice2.Show();
            Hold_Dice2_Label.Hide();
            Hold_Dice2_Value_Label.Hide();
            Unhold_Dice2.Hide();
            Dice2Value.Text = Hold_Dice2_Value_Label.Text;
            DiceHeld2 = false;
            Dice2Value.Hide();
            Hold_Dice2_1.Hide();
            Hold_Dice2_2.Hide();
            Hold_Dice2_3.Hide();
            Hold_Dice2_4.Hide();
            Hold_Dice2_5.Hide();
            Hold_Dice2_6.Hide();

            if (Dice2Value.Text == "1"&&DiceHeld2==false)
            {
                Dice2_1.Show();
                Dice2_2.Hide();
                Dice2_3.Hide();
                Dice2_4.Hide();
                Dice2_5.Hide();
                Dice2_6.Hide();
            }
            if (Dice2Value.Text == "2" && DiceHeld2 == false)
            {
                Dice2_1.Hide();
                Dice2_2.Show();
                Dice2_3.Hide();
                Dice2_4.Hide();
                Dice2_5.Hide();
                Dice2_6.Hide();
            }
            if (Dice2Value.Text == "3" && DiceHeld2 == false)
            {
                Dice2_1.Hide();
                Dice2_2.Hide();
                Dice2_3.Show();
                Dice2_4.Hide();
                Dice2_5.Hide();
                Dice2_6.Hide();
            }
            if (Dice2Value.Text == "4" && DiceHeld2 == false)
            {
                Dice2_1.Hide();
                Dice2_2.Hide();
                Dice2_3.Hide();
                Dice2_4.Show();
                Dice2_5.Hide();
                Dice2_6.Hide();
            }
            if (Dice2Value.Text == "5" && DiceHeld2 == false)
            {
                Dice2_1.Hide();
                Dice2_2.Hide();
                Dice2_3.Hide();
                Dice2_4.Hide();
                Dice2_5.Show();
                Dice2_6.Hide();
            }
            if (Dice2Value.Text == "6" && DiceHeld2 == false)
            {
                Dice2_1.Hide();
                Dice2_2.Hide();
                Dice2_3.Hide();
                Dice2_4.Hide();
                Dice2_5.Hide();
                Dice2_6.Show();
            }
        }

        private void Unhold_Dice3_Click(object sender, EventArgs e)
        {
            Hold_Dice3.Show();
            Hold_Dice3_Label.Hide();
            Hold_Dice3_Value_Label.Hide();
            Unhold_Dice3.Hide();
            Dice3Value.Text = Hold_Dice3_Value_Label.Text;
            DiceHeld3 = false;
            Dice3Value.Hide();
            Hold_Dice3_1.Hide();
            Hold_Dice3_2.Hide();
            Hold_Dice3_3.Hide();
            Hold_Dice3_4.Hide();
            Hold_Dice3_5.Hide();
            Hold_Dice3_6.Hide();
            if (Dice3Value.Text == "1"&&DiceHeld3==false)
            {
                Dice3_1.Show();
                Dice3_2.Hide();
                Dice3_3.Hide();
                Dice3_4.Hide();
                Dice3_5.Hide();
                Dice3_6.Hide();
            }
            if (Dice3Value.Text == "2" && DiceHeld3 == false)
            {
                Dice3_1.Hide();
                Dice3_2.Show();
                Dice3_3.Hide();
                Dice3_4.Hide();
                Dice3_5.Hide();
                Dice3_6.Hide();
            }
            if (Dice3Value.Text == "3" && DiceHeld3 == false)
            {
                Dice3_1.Hide();
                Dice3_2.Hide();
                Dice3_3.Show();
                Dice3_4.Hide();
                Dice3_5.Hide();
                Dice3_6.Hide();
            }
            if (Dice3Value.Text == "4" && DiceHeld3 == false)
            {
                Dice3_1.Hide();
                Dice3_2.Hide();
                Dice3_3.Hide();
                Dice3_4.Show();
                Dice3_5.Hide();
                Dice3_6.Hide();
            }
            if (Dice3Value.Text == "5" && DiceHeld3 == false)
            {
                Dice3_1.Hide();
                Dice3_2.Hide();
                Dice3_3.Hide();
                Dice3_4.Hide();
                Dice3_5.Show();
                Dice3_6.Hide();
            }
            if (Dice3Value.Text == "6" && DiceHeld3 == false)
            {
                Dice3_1.Hide();
                Dice3_2.Hide();
                Dice3_3.Hide();
                Dice3_4.Hide();
                Dice3_5.Hide();
                Dice3_6.Show();
            }
        }

        private void Unhold_Dice4_Click(object sender, EventArgs e)
        {
            Hold_Dice4.Show();
            Hold_Dice4_Label.Hide();
            Hold_Dice4_Value_Label.Hide();
            Unhold_Dice4.Hide();
            Dice4Value.Text = Hold_Dice4_Value_Label.Text;
            DiceHeld4 = false;
            Dice4Value.Hide();
            Hold_Dice4_1.Hide();
            Hold_Dice4_2.Hide();
            Hold_Dice4_3.Hide();
            Hold_Dice4_4.Hide();
            Hold_Dice4_5.Hide();
            Hold_Dice4_6.Hide();

            if (Dice4Value.Text == "1"&&DiceHeld4==false)
            {
                Dice4_1.Show();
                Dice4_2.Hide();
                Dice4_3.Hide();
                Dice4_4.Hide();
                Dice4_5.Hide();
                Dice4_6.Hide();
            }
            if (Dice4Value.Text == "2" && DiceHeld4 == false)
            {
                Dice4_1.Hide();
                Dice4_2.Show();
                Dice4_3.Hide();
                Dice4_4.Hide();
                Dice4_5.Hide();
                Dice4_6.Hide();
            }
            if (Dice4Value.Text == "3" && DiceHeld4 == false)
            {
                Dice4_1.Hide();
                Dice4_2.Hide();
                Dice4_3.Show();
                Dice4_4.Hide();
                Dice4_5.Hide();
                Dice4_6.Hide();
            }
            if (Dice4Value.Text == "4" && DiceHeld4 == false)
            {
                Dice4_1.Hide();
                Dice4_2.Hide();
                Dice4_3.Hide();
                Dice4_4.Show();
                Dice4_5.Hide();
                Dice4_6.Hide();
            }
            if (Dice4Value.Text == "5" && DiceHeld4 == false)
            {
                Dice4_1.Hide();
                Dice4_2.Hide();
                Dice4_3.Hide();
                Dice4_4.Hide();
                Dice4_5.Show();
                Dice4_6.Hide();
            }
            if (Dice4Value.Text == "6" && DiceHeld4 == false)
            {
                Dice4_1.Hide();
                Dice4_2.Hide();
                Dice4_3.Hide();
                Dice4_4.Hide();
                Dice4_5.Hide();
                Dice4_6.Show();
            }
        }

        private void Unhold_Dice5_Click(object sender, EventArgs e)
        {
            Hold_Dice5.Show();
            Hold_Dice5_Label.Hide();
            Hold_Dice5_Value_Label.Hide();
            Unhold_Dice5.Hide();
            Dice5Value.Text = Hold_Dice5_Value_Label.Text;
            DiceHeld5 = false;
            Dice5Value.Hide();
            Hold_Dice5_1.Hide();
            Hold_Dice5_2.Hide();
            Hold_Dice5_3.Hide();
            Hold_Dice5_4.Hide();
            Hold_Dice5_5.Hide();
            Hold_Dice5_6.Hide();

            if (Dice5Value.Text == "1"&&DiceHeld5==false)
            {
                Dice5_1.Show();
                Dice5_2.Hide();
                Dice5_3.Hide();
                Dice5_4.Hide();
                Dice5_5.Hide();
                Dice5_6.Hide();
            }
            if (Dice5Value.Text == "2" && DiceHeld5 == false)
            {
                Dice5_1.Hide();
                Dice5_2.Show();
                Dice5_3.Hide();
                Dice5_4.Hide();
                Dice5_5.Hide();
                Dice5_6.Hide();
            }
            if (Dice5Value.Text == "3" && DiceHeld5 == false)
            {
                Dice5_1.Hide();
                Dice5_2.Hide();
                Dice5_3.Show();
                Dice5_4.Hide();
                Dice5_5.Hide();
                Dice5_6.Hide();
            }
            if (Dice5Value.Text == "4" && DiceHeld5 == false)
            {
                Dice5_1.Hide();
                Dice5_2.Hide();
                Dice5_3.Hide();
                Dice5_4.Show();
                Dice5_5.Hide();
                Dice5_6.Hide();
            }
            if (Dice5Value.Text == "5" && DiceHeld5 == false)
            {
                Dice5_1.Hide();
                Dice5_2.Hide();
                Dice5_3.Hide();
                Dice5_4.Hide();
                Dice5_5.Show();
                Dice5_6.Hide();
            }
            if (Dice5Value.Text == "6" && DiceHeld5 == false)
            {
                Dice5_1.Hide();
                Dice5_2.Hide();
                Dice5_3.Hide();
                Dice5_4.Hide();
                Dice5_5.Hide();
                Dice5_6.Show();
            }
        }

        #endregion




        private void Score_Ones_P1_Label_Click(object sender, EventArgs e)
        {
            if(Hold_Dice1_Value_Label.Text=="1"&&Hold_Dice2_Value_Label.Text=="1"
                &&Hold_Dice3_Value_Label.Text=="1"&&Hold_Dice4_Value_Label.Text=="1"&&Hold_Dice5_Value_Label.Text=="1")
            {
                Score_Ones_P1_Label.Enabled=true;
                Score_Ones_P2_Label.Enabled = true;
            }
        }

        private void Score_Ones_P1_Button_Click(object sender, EventArgs e)
        {
            int dice1;
            int dice2;
            int dice3;
            int dice4;
            int dice5;

            dice1 = Convert.ToInt32(Hold_Dice1_Value_Label.Text);
            dice2 = Convert.ToInt32(Hold_Dice2_Value_Label.Text);
            dice3 = Convert.ToInt32(Hold_Dice3_Value_Label.Text);
            dice4 = Convert.ToInt32(Hold_Dice4_Value_Label.Text);
            dice5 = Convert.ToInt32(Hold_Dice5_Value_Label.Text);

            if (dice1==1&&dice2==1&&dice3==1&&dice4==1&&dice5==1)
            {
                Score_Ones_P1_Button.Enabled = true;
            }

            
        }
    }
}
