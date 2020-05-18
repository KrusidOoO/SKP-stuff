using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Microsoft.VisualBasic;

namespace Login_interface_and_so_on
{
    public partial class Form_Countdown : Form
    {

        public Form_Countdown()
        {
            InitializeComponent();
        }

        public void Form_Countdown_Load(object sender, EventArgs e)
        {
            textBox1.Show();
            textBox2.Show();
            TenMinutesLeft_TextBox.Hide();
            Reeeeee_Pepe_Picture.Hide();
            Ikke_Fri_Endnu_Label.Hide();
            Happy_Sad_Pepe_Picture.Hide();
            Du_Har_Fri_Label.Hide();
            Smug_Pepe_Picture.Hide();
            You_Have_A_Break_Label.Hide();
            PepeHype_Picture.Hide();
            Hype_Label.Hide();
            Check_in_Button.Show();
            CountDownTimer.Stop();



        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main_Menu FMM = new Form_Main_Menu();
            FMM.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void CountDownTimer_Tick(object sender, EventArgs e)
        {
            string HourCheckIn;
            string MinuteCheckIn;
            int HourCheckInInt = 0;
            int MinuteCheckInInt = 0;
            HourCheckIn = textBox1.Text;
            MinuteCheckIn = textBox2.Text;
            int MinuteCheckInIntX = 0;
            int HourCheckInIntX = 0;
            //HourCheckInInt = HourCheckInIntX;
            /*if(MinuteCheckInInt==0||MinuteCheckInInt<10)
            {
                MinuteCheckInIntX = MinuteCheckInInt.ToString("D").Length;

            }
            if(HourCheckInInt==0||HourCheckInInt<10)
            {
                HourCheckInIntX = MinuteCheckInInt.ToString("D").Length;
            }*/

            HourCheckInInt = Convert.ToInt32(HourCheckIn);
            MinuteCheckInInt = Convert.ToInt32(MinuteCheckIn);
            //MinuteCheckInInt = MinuteCheckInIntX;
            //HourCheckInInt = HourCheckInIntX;



            Time.Text = DateTime.Now.ToString("HH:mm:ss");

            Date.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();


            #region DateTime & TimeSpan
            var DTN = DateTime.Now;
            var DTD = DTN.AddDays(1);

            int DtD = DTD.Day;
            DateTime DTNMMS = new DateTime(DTN.Year, DTN.Month, DTN.Day, DTN.Hour, DTN.Minute, DTN.Second);
            //var DTNTest = new DateTime(DTN.Year, DTN.Month, 26, 13, 00, 00);


            //Time.Text = DTNTest.ToString("HH:mm:ss");

            DateTime WorkDayStart = new DateTime(DTN.Year, DTN.Month, DTN.Day, HourCheckInInt, MinuteCheckInInt, 00);
            DateTime WorkDayEnd = new DateTime(DTN.Year, DTN.Month, DTN.Day, HourCheckInInt + 8, MinuteCheckInInt, 00);
            DateTime WorkPeriod1Start = new DateTime(DTN.Year, DTN.Month, DTN.Day, HourCheckInInt, MinuteCheckInInt + 5, 00);
            DateTime WorkPeriod1End = new DateTime(DTN.Year, DTN.Month, DTN.Day, 9, 0, 0);
            DateTime WorkPeriod2Start = new DateTime(DTN.Year, DTN.Month, DTN.Day, 9, 15, 0);
            DateTime WorkPeriod2End = new DateTime(DTN.Year, DTN.Month, DTN.Day, 11, 30, 0);
            DateTime WorkPeriod3Start = new DateTime(DTN.Year, DTN.Month, DTN.Day, 12, 00, 00);
            DateTime WorkPeriod3End = new DateTime(DTN.Year, DTN.Month, DTN.Day, 13, 30, 00);
            DateTime WorkPeriod4Start = new DateTime(DTN.Year, DTN.Month, DTN.Day, 13, 45, 00);
            DateTime WorkPeriod4End = new DateTime(DTN.Year, DTN.Month, DTN.Day, HourCheckInInt + 8, MinuteCheckInInt, 00);

            DateTime FridayWorkDayStart = new DateTime(DTN.Year, DTN.Month, DTN.Day, HourCheckInInt, MinuteCheckInInt, 00);
            DateTime FridayWorkDayEnd = new DateTime(DTN.Year, DTN.Month, DTN.Day, HourCheckInInt + 6, MinuteCheckInInt, 00);
            DateTime FridayWorkPeriod1Start = new DateTime(DTN.Year, DTN.Month, DTN.Day, HourCheckInInt, MinuteCheckInInt + 5, 00);
            DateTime FridayWorkPeriod1End = new DateTime(DTN.Year, DTN.Month, DTN.Day, 9, 00, 00);
            DateTime FridayWorkPeriod2Start = new DateTime(DTN.Year, DTN.Month, DTN.Day, 9, 30, 00);
            DateTime FridayWorkPeriod2End = new DateTime(DTN.Year, DTN.Month, DTN.Day, 11, 00, 00);
            DateTime FridayWorkPeriod3Start = new DateTime(DTN.Year, DTN.Month, DTN.Day, 12, 00, 00);
            DateTime FridayWorkPeriod3End = new DateTime(DTN.Year, DTN.Month, DTN.Day, HourCheckInInt + 6, MinuteCheckInInt, 00);

            DateTime MorgenPauseStart = new DateTime(DTN.Year, DTN.Month, DTN.Day, 9, 00, 00);
            DateTime MorgenPauseSlut = new DateTime(DTN.Year, DTN.Month, DTN.Day, 9, 15, 00);
            DateTime MiddagsPauseStart = new DateTime(DTN.Year, DTN.Month, DTN.Day, 11, 30, 00);
            DateTime MiddagsPauseSlut = new DateTime(DTN.Year, DTN.Month, DTN.Day, 12, 00, 00);
            DateTime KagePauseStart = new DateTime(DTN.Year, DTN.Month, DTN.Day, 13, 30, 00);
            DateTime KagePauseSlut = new DateTime(DTN.Year, DTN.Month, DTN.Day, 13, 45, 00);
            DateTime FredagMorgenPauseStart = new DateTime(DTN.Year, DTN.Month, DTN.Day, 9, 00, 00);
            DateTime FredagMorgenPauseSlut = new DateTime(DTN.Year, DTN.Month, DTN.Day, 9, 30, 00);
            DateTime FredagMiddagsPauseStart = new DateTime(DTN.Year, DTN.Month, DTN.Day, 11, 00, 00);
            DateTime FredagMiddagsPauseSlut = new DateTime(DTN.Year, DTN.Month, DTN.Day, 11, 30, 00);
            DateTime FredagTenMinutesLeft = new DateTime(DTN.Year, DTN.Month, DTN.Day, 13, 10, 00);
            DateTime TenMinutesLeft = new DateTime(DTN.Year, DTN.Month, DTN.Day, HourCheckInInt + 8, MinuteCheckInInt - 10, 00);
            DateTime WorkDayStartTomorrow = new DateTime(DTN.Year, DTN.Month, DtD, HourCheckInInt, MinuteCheckInInt, 00);
            DateTime WorkDayStartAfterWeekend = new DateTime(DTN.Year, DTN.Month, DtD, HourCheckInInt, MinuteCheckInInt, 00);
            DateTime WorkDayStartAfterSaturday = new DateTime(DTN.Year, DTN.Month, DtD, HourCheckInInt, MinuteCheckInInt, 00);
            DateTime WorkDayStartAfterSunday = new DateTime(DTN.Year, DTN.Month, DtD, HourCheckInInt, MinuteCheckInInt, 00);
            
            /*TimeSpan MPS;
            if (DTN >= DTNMMS && DTN <= MorgenPauseStart)
            {
                TimeSpan MPS;
                MPS = MorgenPauseStart.Subtract(DTNMMS);
            }else if(DTN<=DTNMMS&&DTN>=MorgenPauseStart)
            {

            }*/
            
            TimeSpan MIPS = MiddagsPauseStart - DTNMMS;
            TimeSpan KPS = KagePauseStart-DTNMMS;
            TimeSpan FMPS = FredagMorgenPauseStart-DTNMMS;
            TimeSpan FMIPS = FredagMiddagsPauseStart-DTNMMS;
            TimeSpan timeLeft = WorkDayEnd-DTNMMS;
            TimeSpan TenMINLeft = WorkDayEnd-TenMinutesLeft;
            TimeSpan FridayTenMinLeft = FridayWorkDayEnd-FredagTenMinutesLeft;
            TimeSpan DayOffTillNextWorkDay = WorkDayStartTomorrow-DTNMMS;
            TimeSpan WorkdayStartAfterWeekend = WorkDayStartAfterWeekend-DTNMMS;
            TimeSpan WorkDayStartAfterWESaturday = WorkDayStartAfterSaturday-DTNMMS;
            TimeSpan WorkDayStartAfterWESunday = WorkDayStartAfterSunday-DTNMMS;

            #endregion

            //Day of the week tester, sets the day to Friday
            //DayOfWeek Friday = DayOfWeek.Friday;

            Day.Text = DateTime.Now.DayOfWeek.ToString();
            GoHomeAtClock_Label.Text = WorkDayEnd.ToString("HH:mm:ss");
            //Day.Text = Friday.ToString();

            #region Hverdage


            if (DTN >= WorkPeriod1Start && DTN <= WorkPeriod1End)
            {
                Next_Break_TextBox.Show();
                Break_Ends_TextBox.Hide();
                Next_Break_Counter_Label.Text = MorgenPauseStart.Subtract(DTNMMS).ToString();
                Reeeeee_Pepe_Picture.Show();
                Ikke_Fri_Endnu_Label.Show();
                Happy_Sad_Pepe_Picture.Hide();
                Du_Har_Fri_Label.Hide();
                Smug_Pepe_Picture.Hide();
                You_Have_A_Break_Label.Hide();
                PepeHype_Picture.Hide();
                Hype_Label.Hide();
                Time_Left_HHmmss.Text = timeLeft.ToString();
                Time_Left_HHmmss.Show();
                TimeLeftSaturday_Label.Hide();
                TimeLeftSunday_Label.Hide();
                this.Refresh();
                Application.DoEvents();
            }

            if (DTN >= MorgenPauseStart && DTN <= MorgenPauseSlut)
            {
                Next_Break_TextBox.Hide();
                Break_Ends_TextBox.Show();
                Next_Break_Counter_Label.Text = MorgenPauseSlut.Subtract(DTNMMS).ToString();
                Reeeeee_Pepe_Picture.Hide();
                Ikke_Fri_Endnu_Label.Hide();
                Happy_Sad_Pepe_Picture.Hide();
                Du_Har_Fri_Label.Hide();
                Smug_Pepe_Picture.Show();
                You_Have_A_Break_Label.Show();
                PepeHype_Picture.Hide();
                Hype_Label.Hide();
                Time_Left_HHmmss.Text = timeLeft.ToString();
                Time_Left_HHmmss.Show();
                TimeLeftSaturday_Label.Hide();
                TimeLeftSunday_Label.Hide();
                this.Refresh();
                Application.DoEvents();
            }

            if (DTN >= WorkPeriod2Start && DTN <= WorkPeriod2End)
            {
                Next_Break_TextBox.Show();
                Break_Ends_TextBox.Hide();
                Next_Break_Counter_Label.Text = MIPS.ToString();
                Reeeeee_Pepe_Picture.Show();
                Ikke_Fri_Endnu_Label.Show();
                Happy_Sad_Pepe_Picture.Hide();
                Du_Har_Fri_Label.Hide();
                Smug_Pepe_Picture.Hide();
                You_Have_A_Break_Label.Hide();
                PepeHype_Picture.Hide();
                Hype_Label.Hide();
                Time_Left_HHmmss.Text = timeLeft.ToString();
                Time_Left_HHmmss.Show();
                TimeLeftSaturday_Label.Hide();
                TimeLeftSunday_Label.Hide();
                this.Refresh();
                Application.DoEvents();
            }
            if (DTN >= MiddagsPauseStart && DTN <= MiddagsPauseSlut)
            {
                Next_Break_TextBox.Hide();
                Break_Ends_TextBox.Show();
                Next_Break_Counter_Label.Text = MiddagsPauseSlut.Subtract(DTNMMS).ToString();
                Reeeeee_Pepe_Picture.Hide();
                Ikke_Fri_Endnu_Label.Hide();
                Happy_Sad_Pepe_Picture.Hide();
                Du_Har_Fri_Label.Hide();
                Smug_Pepe_Picture.Show();
                You_Have_A_Break_Label.Show();
                PepeHype_Picture.Hide();
                Hype_Label.Hide();
                Time_Left_HHmmss.Text = timeLeft.ToString();
                Time_Left_HHmmss.Show();
                TimeLeftSaturday_Label.Hide();
                TimeLeftSunday_Label.Hide();
                this.Refresh();
                Application.DoEvents();
            }
            if (DTN >= WorkPeriod3Start && DTN <= WorkPeriod3End)
            {
                Break_Ends_TextBox.Hide();
                Next_Break_TextBox.Show();
                Next_Break_Counter_Label.Text = KPS.ToString();
                Reeeeee_Pepe_Picture.Show();
                Ikke_Fri_Endnu_Label.Show();
                Happy_Sad_Pepe_Picture.Hide();
                Du_Har_Fri_Label.Hide();
                Smug_Pepe_Picture.Hide();
                You_Have_A_Break_Label.Hide();
                PepeHype_Picture.Hide();
                Hype_Label.Hide();
                Time_Left_HHmmss.Text = timeLeft.ToString();
                Time_Left_HHmmss.Show();
                TimeLeftSaturday_Label.Hide();
                TimeLeftSunday_Label.Hide();
                this.Refresh();
                Application.DoEvents();
            }
            if (DTN >= KagePauseStart && DTN <= KagePauseSlut)
            {
                Next_Break_TextBox.Hide();
                Break_Ends_TextBox.Show();
                Next_Break_Counter_Label.Text = KagePauseSlut.Subtract(DTNMMS).ToString();
                Reeeeee_Pepe_Picture.Hide();
                Ikke_Fri_Endnu_Label.Hide();
                Happy_Sad_Pepe_Picture.Hide();
                Du_Har_Fri_Label.Hide();
                Smug_Pepe_Picture.Show();
                You_Have_A_Break_Label.Show();
                PepeHype_Picture.Hide();
                Hype_Label.Hide();
                Time_Left_HHmmss.Text = timeLeft.ToString();
                Time_Left_HHmmss.Show();
                TimeLeftSaturday_Label.Hide();
                TimeLeftSunday_Label.Hide();
                this.Refresh();
                Application.DoEvents();
            }
            if (DTN >= WorkPeriod4Start && DTN <= TenMinutesLeft)
            {
                Break_Ends_TextBox.Hide();
                Next_Break_TextBox.Hide();
                Next_Break_Counter_Label.Hide();
                Reeeeee_Pepe_Picture.Show();
                Ikke_Fri_Endnu_Label.Show();
                Happy_Sad_Pepe_Picture.Hide();
                Du_Har_Fri_Label.Hide();
                Smug_Pepe_Picture.Hide();
                You_Have_A_Break_Label.Hide();
                PepeHype_Picture.Hide();
                Hype_Label.Hide();
                Time_Left_HHmmss.Text = timeLeft.ToString();
                Time_Left_HHmmss.Show();
                TimeLeftSaturday_Label.Hide();
                TimeLeftSunday_Label.Hide();
                this.Refresh();
                Application.DoEvents();
            }
            if (DTN >= TenMinutesLeft && DTN <= WorkDayEnd)
            {
                Break_Ends_TextBox.Hide();
                TenMinutesLeft_TextBox.Show();
                Next_Break_TextBox.Hide();
                Next_Break_Counter_Label.Show();
                Next_Break_Counter_Label.Text = timeLeft.ToString();
                Reeeeee_Pepe_Picture.Hide();
                Ikke_Fri_Endnu_Label.Hide();
                Happy_Sad_Pepe_Picture.Hide();
                Du_Har_Fri_Label.Hide();
                Smug_Pepe_Picture.Hide();
                You_Have_A_Break_Label.Hide();
                PepeHype_Picture.Show();
                Hype_Label.Show();
                Time_Left_HHmmss.Text = timeLeft.ToString();
                Time_Left_HHmmss.Show();
                TimeLeftSaturday_Label.Hide();
                TimeLeftSunday_Label.Hide();
                this.Refresh();
                Application.DoEvents();
            }

            if (DTN >= WorkDayEnd && DTN <= WorkDayStartTomorrow)
            {
                Break_Ends_TextBox.Hide();
                TenMinutesLeft_TextBox.Hide();
                Next_Break_TextBox.Hide();
                Next_Break_Counter_Label.Hide();
                Reeeeee_Pepe_Picture.Hide();
                Ikke_Fri_Endnu_Label.Hide();
                Happy_Sad_Pepe_Picture.Show();
                Du_Har_Fri_Label.Show();
                Smug_Pepe_Picture.Hide();
                You_Have_A_Break_Label.Hide();
                PepeHype_Picture.Hide();
                Hype_Label.Hide();
                Time_Left_HHmmss.Text = DayOffTillNextWorkDay.ToString("HH:MM:ss");
                Time_Left_HHmmss.Show();
                TimeLeftSaturday_Label.Hide();
                TimeLeftSunday_Label.Hide();
                this.Refresh();
                Application.DoEvents();
            }

            #endregion

            #region Fredag

            if (DTN.DayOfWeek == DayOfWeek.Friday)
            {

                TimeSpan FridaytimeLeft = FridayWorkDayEnd-DTNMMS;
                if (DTN >= FridayWorkPeriod1Start && DTN <= FridayWorkPeriod1End)
                {
                    Next_Break_TextBox.Show();
                    Break_Ends_TextBox.Hide();
                    Next_Break_Counter_Label.Text = FMPS.ToString();
                    Reeeeee_Pepe_Picture.Show();
                    Ikke_Fri_Endnu_Label.Show();
                    Happy_Sad_Pepe_Picture.Hide();
                    Du_Har_Fri_Label.Hide();
                    Smug_Pepe_Picture.Hide();
                    You_Have_A_Break_Label.Hide();
                    Time_Left_HHmmss.Text = FridaytimeLeft.ToString();
                    Time_Left_HHmmss.Show();
                    TimeLeftSaturday_Label.Hide();
                    TimeLeftSunday_Label.Hide();
                    this.Refresh();
                    Application.DoEvents();
                }
                if (DTN >= FredagMorgenPauseStart && DTN <= FredagMorgenPauseSlut)
                {
                    Next_Break_TextBox.Hide();
                    Break_Ends_TextBox.Show();
                    Next_Break_Counter_Label.Text = (FredagMorgenPauseSlut-DTNMMS).ToString();
                    Reeeeee_Pepe_Picture.Hide();
                    Ikke_Fri_Endnu_Label.Hide();
                    Happy_Sad_Pepe_Picture.Hide();
                    Du_Har_Fri_Label.Hide();
                    Smug_Pepe_Picture.Show();
                    You_Have_A_Break_Label.Show();
                    Time_Left_HHmmss.Text = FridaytimeLeft.ToString();
                    Time_Left_HHmmss.Show();
                    TimeLeftSaturday_Label.Hide();
                    TimeLeftSunday_Label.Hide();
                    this.Refresh();
                    Application.DoEvents();
                }
                if (DTN >= FridayWorkPeriod2Start && DTN <= FridayWorkPeriod2End)
                {
                    Next_Break_TextBox.Show();
                    Break_Ends_TextBox.Hide();
                    Next_Break_Counter_Label.Text = FMIPS.ToString();
                    Reeeeee_Pepe_Picture.Show();
                    Ikke_Fri_Endnu_Label.Show();
                    Happy_Sad_Pepe_Picture.Hide();
                    Du_Har_Fri_Label.Hide();
                    Smug_Pepe_Picture.Hide();
                    You_Have_A_Break_Label.Hide();
                    Time_Left_HHmmss.Text = FridaytimeLeft.ToString();
                    Time_Left_HHmmss.Show();
                    TimeLeftSaturday_Label.Hide();
                    TimeLeftSunday_Label.Hide();
                    this.Refresh();
                    Application.DoEvents();
                }
                if (DTN >= FredagMiddagsPauseStart && DTN <= FredagMiddagsPauseSlut)
                {
                    Next_Break_TextBox.Hide();
                    Break_Ends_TextBox.Show();
                    Next_Break_Counter_Label.Text = (FredagMiddagsPauseSlut-DTNMMS).ToString();
                    Reeeeee_Pepe_Picture.Hide();
                    Ikke_Fri_Endnu_Label.Hide();
                    Happy_Sad_Pepe_Picture.Hide();
                    Du_Har_Fri_Label.Hide();
                    Smug_Pepe_Picture.Show();
                    You_Have_A_Break_Label.Show();
                    Time_Left_HHmmss.Text = FridaytimeLeft.ToString();
                    Time_Left_HHmmss.Show();
                    TimeLeftSaturday_Label.Hide();
                    TimeLeftSunday_Label.Hide();
                    this.Refresh();
                    Application.DoEvents();
                }
                if (DTN >= FridayWorkPeriod3Start && DTN <= FredagTenMinutesLeft)
                {
                    Next_Break_TextBox.Hide();
                    Break_Ends_TextBox.Hide();
                    Reeeeee_Pepe_Picture.Show();
                    Ikke_Fri_Endnu_Label.Show();
                    Happy_Sad_Pepe_Picture.Hide();
                    Du_Har_Fri_Label.Hide();
                    Smug_Pepe_Picture.Hide();
                    You_Have_A_Break_Label.Hide();
                    Time_Left_HHmmss.Text = FridaytimeLeft.ToString();
                    Time_Left_HHmmss.Show();
                    TimeLeftSaturday_Label.Hide();
                    TimeLeftSunday_Label.Hide();
                    this.Refresh();
                    Application.DoEvents();
                }
                if (DTN >= FredagTenMinutesLeft && DTN <= FridayWorkDayEnd)
                {
                    Next_Break_TextBox.Hide();
                    Break_Ends_TextBox.Hide();
                    Reeeeee_Pepe_Picture.Hide();
                    Ikke_Fri_Endnu_Label.Hide();
                    Happy_Sad_Pepe_Picture.Hide();
                    Du_Har_Fri_Label.Hide();
                    Smug_Pepe_Picture.Hide();
                    You_Have_A_Break_Label.Hide();
                    PepeHype_Picture.Show();
                    Hype_Label.Show();
                    Time_Left_HHmmss.Text = FridayTenMinLeft.ToString();
                    Time_Left_HHmmss.Show();
                    TimeLeftSaturday_Label.Hide();
                    TimeLeftSunday_Label.Hide();
                    this.Refresh();
                    Application.DoEvents();
                }

                if (DTN >= FridayWorkDayEnd && DTN <= WorkDayStartAfterWeekend)
                {
                    Next_Break_TextBox.Hide();
                    Break_Ends_TextBox.Hide();
                    Time_Left_HHmmss.Text = WorkdayStartAfterWeekend.ToString();
                    Reeeeee_Pepe_Picture.Hide();
                    Ikke_Fri_Endnu_Label.Hide();
                    Happy_Sad_Pepe_Picture.Show();
                    Du_Har_Fri_Label.Show();
                    Smug_Pepe_Picture.Hide();
                    You_Have_A_Break_Label.Hide();
                    PepeHype_Picture.Hide();
                    Hype_Label.Hide();
                    Time_Left_HHmmss.Show();
                    TimeLeftSaturday_Label.Hide();
                    TimeLeftSunday_Label.Hide();
                    this.Refresh();
                    Application.DoEvents();
                }

            }
            #endregion

            #region Weekend
            if (DTN.DayOfWeek == DayOfWeek.Saturday)
            {
                Next_Break_TextBox.Hide();
                Break_Ends_TextBox.Hide();
                Next_Break_Counter_Label.Text = "Du har weekend for faen!!";
                Reeeeee_Pepe_Picture.Hide();
                Ikke_Fri_Endnu_Label.Hide();
                Happy_Sad_Pepe_Picture.Show();
                Du_Har_Fri_Label.Show();
                Smug_Pepe_Picture.Hide();
                You_Have_A_Break_Label.Hide();
                TimeLeftSaturday_Label.Show();
                TimeLeftSunday_Label.Hide();
                Time_Left_HHmmss.Hide();
                //TimeLeftSaturday_Label.Text = WorkDayStartAfterWESaturday.ToString();

                this.Refresh();
                Application.DoEvents();
            }
            if (DTN.DayOfWeek == DayOfWeek.Sunday)
            {
                Next_Break_TextBox.Hide();
                Break_Ends_TextBox.Hide();
                Next_Break_Counter_Label.Text = "Du har weekend for faen!!";
                Reeeeee_Pepe_Picture.Hide();
                Ikke_Fri_Endnu_Label.Hide();
                Happy_Sad_Pepe_Picture.Show();
                Du_Har_Fri_Label.Show();
                Smug_Pepe_Picture.Hide();
                You_Have_A_Break_Label.Hide();
                Time_Left_HHmmss.Hide();
                TimeLeftSaturday_Label.Hide();
                TimeLeftSunday_Label.Show();
                //TimeLeftSunday_Label.Text = WorkDayStartAfterWESunday.ToString();
                this.Refresh();
                Application.DoEvents();
            }
            #endregion


        }

        private void Form_Countdown_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Back:
                    Return.PerformClick();
                    break;
            }
        }

        public void Check_in_Button_Click(object sender, EventArgs e)
        {
            string checkInTid1;
            string Convertible1;
            checkInTid1 = "";
            Convertible1 = Interaction.InputBox("At what hour did you clock in?", "", checkInTid1);
            textBox1.Text = Convertible1;

            string checkInTid2;
            string Convertible2;
            checkInTid2 = "";
            Convertible2 = Interaction.InputBox("At what minuted did you clock in?", "", checkInTid2);
            textBox2.Text = Convertible2;

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                CountDownTimer.Start();
            }else if(textBox1.Text==""&&textBox2.Text=="")
            {
                CountDownTimer.Stop();
            }

            return;
        }
    }
}
