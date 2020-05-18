namespace Login_interface_and_so_on
{
    partial class Form_Countdown
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Countdown));
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Seconds_Counter_Timer = new System.Windows.Forms.Timer(this.components);
            this.Du_Har_Fri_Label = new System.Windows.Forms.Label();
            this.Ikke_Fri_Endnu_Label = new System.Windows.Forms.Label();
            this.Time_Left_HHmmss = new System.Windows.Forms.Label();
            this.CountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.Time_Now_Label = new System.Windows.Forms.Label();
            this.Day_Today_Label = new System.Windows.Forms.Label();
            this.Date_Today_Label = new System.Windows.Forms.Label();
            this.Time_Left_TextBox = new System.Windows.Forms.TextBox();
            this.You_Have_A_Break_Label = new System.Windows.Forms.Label();
            this.Next_Break_Counter_Label = new System.Windows.Forms.Label();
            this.Next_Break_TextBox = new System.Windows.Forms.TextBox();
            this.Break_Ends_TextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Check_in_Button = new System.Windows.Forms.Button();
            this.PepeHype_Picture = new System.Windows.Forms.PictureBox();
            this.Smug_Pepe_Picture = new System.Windows.Forms.PictureBox();
            this.Reeeeee_Pepe_Picture = new System.Windows.Forms.PictureBox();
            this.Happy_Sad_Pepe_Picture = new System.Windows.Forms.PictureBox();
            this.Hype_Label = new System.Windows.Forms.Label();
            this.TenMinutesLeft_TextBox = new System.Windows.Forms.TextBox();
            this.TimeLeftSunday_Label = new System.Windows.Forms.Label();
            this.TimeLeftSaturday_Label = new System.Windows.Forms.Label();
            this.GoHomeAt_Label = new System.Windows.Forms.Label();
            this.GoHomeAtClock_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PepeHype_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smug_Pepe_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reeeeee_Pepe_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Happy_Sad_Pepe_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(171, 36);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(52, 23);
            this.Time.TabIndex = 0;
            this.Time.Text = "Time";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(171, 94);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(49, 23);
            this.Date.TabIndex = 1;
            this.Date.Text = "Date";
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.Location = new System.Drawing.Point(171, 138);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(43, 23);
            this.Day.TabIndex = 2;
            this.Day.Text = "Day";
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(1068, 12);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(38, 34);
            this.Return.TabIndex = 3;
            this.Return.Text = "<--";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Exit
            // 
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1112, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(38, 34);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Seconds_Counter_Timer
            // 
            this.Seconds_Counter_Timer.Enabled = true;
            // 
            // Du_Har_Fri_Label
            // 
            this.Du_Har_Fri_Label.AutoSize = true;
            this.Du_Har_Fri_Label.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Du_Har_Fri_Label.Location = new System.Drawing.Point(604, 26);
            this.Du_Har_Fri_Label.Name = "Du_Har_Fri_Label";
            this.Du_Har_Fri_Label.Size = new System.Drawing.Size(331, 36);
            this.Du_Har_Fri_Label.TabIndex = 5;
            this.Du_Har_Fri_Label.Text = "You Can Go Home Man!";
            // 
            // Ikke_Fri_Endnu_Label
            // 
            this.Ikke_Fri_Endnu_Label.AutoSize = true;
            this.Ikke_Fri_Endnu_Label.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ikke_Fri_Endnu_Label.Location = new System.Drawing.Point(630, 26);
            this.Ikke_Fri_Endnu_Label.Name = "Ikke_Fri_Endnu_Label";
            this.Ikke_Fri_Endnu_Label.Size = new System.Drawing.Size(273, 36);
            this.Ikke_Fri_Endnu_Label.TabIndex = 6;
            this.Ikke_Fri_Endnu_Label.Text = "You\'re Still Working";
            // 
            // Time_Left_HHmmss
            // 
            this.Time_Left_HHmmss.AutoSize = true;
            this.Time_Left_HHmmss.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Left_HHmmss.Location = new System.Drawing.Point(58, 285);
            this.Time_Left_HHmmss.Name = "Time_Left_HHmmss";
            this.Time_Left_HHmmss.Size = new System.Drawing.Size(115, 33);
            this.Time_Left_HHmmss.TabIndex = 10;
            this.Time_Left_HHmmss.Text = "00:00:00";
            // 
            // CountDownTimer
            // 
            this.CountDownTimer.Enabled = true;
            this.CountDownTimer.Tick += new System.EventHandler(this.CountDownTimer_Tick);
            // 
            // Time_Now_Label
            // 
            this.Time_Now_Label.AutoSize = true;
            this.Time_Now_Label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Now_Label.Location = new System.Drawing.Point(52, 36);
            this.Time_Now_Label.Name = "Time_Now_Label";
            this.Time_Now_Label.Size = new System.Drawing.Size(113, 23);
            this.Time_Now_Label.TabIndex = 11;
            this.Time_Now_Label.Text = "The Time is:";
            // 
            // Day_Today_Label
            // 
            this.Day_Today_Label.AutoSize = true;
            this.Day_Today_Label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day_Today_Label.Location = new System.Drawing.Point(6, 138);
            this.Day_Today_Label.Name = "Day_Today_Label";
            this.Day_Today_Label.Size = new System.Drawing.Size(159, 23);
            this.Day_Today_Label.TabIndex = 12;
            this.Day_Today_Label.Text = "The Day Today Is:";
            // 
            // Date_Today_Label
            // 
            this.Date_Today_Label.AutoSize = true;
            this.Date_Today_Label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Today_Label.Location = new System.Drawing.Point(55, 94);
            this.Date_Today_Label.Name = "Date_Today_Label";
            this.Date_Today_Label.Size = new System.Drawing.Size(110, 23);
            this.Date_Today_Label.TabIndex = 13;
            this.Date_Today_Label.Text = "The Date is:";
            // 
            // Time_Left_TextBox
            // 
            this.Time_Left_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Time_Left_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Time_Left_TextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Left_TextBox.Location = new System.Drawing.Point(30, 235);
            this.Time_Left_TextBox.Multiline = true;
            this.Time_Left_TextBox.Name = "Time_Left_TextBox";
            this.Time_Left_TextBox.ReadOnly = true;
            this.Time_Left_TextBox.Size = new System.Drawing.Size(193, 52);
            this.Time_Left_TextBox.TabIndex = 14;
            this.Time_Left_TextBox.Text = "Time Left Till You Can Go Home:";
            this.Time_Left_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // You_Have_A_Break_Label
            // 
            this.You_Have_A_Break_Label.AutoSize = true;
            this.You_Have_A_Break_Label.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.You_Have_A_Break_Label.Location = new System.Drawing.Point(514, 26);
            this.You_Have_A_Break_Label.Name = "You_Have_A_Break_Label";
            this.You_Have_A_Break_Label.Size = new System.Drawing.Size(489, 36);
            this.You_Have_A_Break_Label.TabIndex = 16;
            this.You_Have_A_Break_Label.Text = "You can relax now.. You have a break";
            // 
            // Next_Break_Counter_Label
            // 
            this.Next_Break_Counter_Label.AutoSize = true;
            this.Next_Break_Counter_Label.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Break_Counter_Label.Location = new System.Drawing.Point(58, 404);
            this.Next_Break_Counter_Label.Name = "Next_Break_Counter_Label";
            this.Next_Break_Counter_Label.Size = new System.Drawing.Size(115, 33);
            this.Next_Break_Counter_Label.TabIndex = 18;
            this.Next_Break_Counter_Label.Text = "00:00:00";
            // 
            // Next_Break_TextBox
            // 
            this.Next_Break_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Next_Break_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Next_Break_TextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Break_TextBox.Location = new System.Drawing.Point(53, 350);
            this.Next_Break_TextBox.Multiline = true;
            this.Next_Break_TextBox.Name = "Next_Break_TextBox";
            this.Next_Break_TextBox.Size = new System.Drawing.Size(112, 60);
            this.Next_Break_TextBox.TabIndex = 19;
            this.Next_Break_TextBox.Text = "Time Till Next Break:";
            // 
            // Break_Ends_TextBox
            // 
            this.Break_Ends_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Break_Ends_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Break_Ends_TextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Break_Ends_TextBox.Location = new System.Drawing.Point(57, 350);
            this.Break_Ends_TextBox.Multiline = true;
            this.Break_Ends_TextBox.Name = "Break_Ends_TextBox";
            this.Break_Ends_TextBox.Size = new System.Drawing.Size(129, 60);
            this.Break_Ends_TextBox.TabIndex = 20;
            this.Break_Ends_TextBox.Text = "Time Till Break Ends:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 441);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 70);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 441);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 70);
            this.textBox2.TabIndex = 22;
            // 
            // Check_in_Button
            // 
            this.Check_in_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Check_in_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_in_Button.Location = new System.Drawing.Point(199, 441);
            this.Check_in_Button.Name = "Check_in_Button";
            this.Check_in_Button.Size = new System.Drawing.Size(83, 70);
            this.Check_in_Button.TabIndex = 2;
            this.Check_in_Button.Text = "Check-In";
            this.Check_in_Button.UseVisualStyleBackColor = true;
            this.Check_in_Button.Click += new System.EventHandler(this.Check_in_Button_Click);
            // 
            // PepeHype_Picture
            // 
            this.PepeHype_Picture.Image = global::Login_interface_and_so_on.Properties.Resources.PepeHype3;
            this.PepeHype_Picture.Location = new System.Drawing.Point(491, 74);
            this.PepeHype_Picture.Name = "PepeHype_Picture";
            this.PepeHype_Picture.Size = new System.Drawing.Size(525, 450);
            this.PepeHype_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PepeHype_Picture.TabIndex = 24;
            this.PepeHype_Picture.TabStop = false;
            // 
            // Smug_Pepe_Picture
            // 
            this.Smug_Pepe_Picture.Image = global::Login_interface_and_so_on.Properties.Resources.SmugPePe;
            this.Smug_Pepe_Picture.Location = new System.Drawing.Point(491, 74);
            this.Smug_Pepe_Picture.Name = "Smug_Pepe_Picture";
            this.Smug_Pepe_Picture.Size = new System.Drawing.Size(525, 450);
            this.Smug_Pepe_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Smug_Pepe_Picture.TabIndex = 15;
            this.Smug_Pepe_Picture.TabStop = false;
            // 
            // Reeeeee_Pepe_Picture
            // 
            this.Reeeeee_Pepe_Picture.Image = global::Login_interface_and_so_on.Properties.Resources.REEEEEEE;
            this.Reeeeee_Pepe_Picture.Location = new System.Drawing.Point(491, 74);
            this.Reeeeee_Pepe_Picture.Name = "Reeeeee_Pepe_Picture";
            this.Reeeeee_Pepe_Picture.Size = new System.Drawing.Size(525, 450);
            this.Reeeeee_Pepe_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Reeeeee_Pepe_Picture.TabIndex = 8;
            this.Reeeeee_Pepe_Picture.TabStop = false;
            // 
            // Happy_Sad_Pepe_Picture
            // 
            this.Happy_Sad_Pepe_Picture.Image = global::Login_interface_and_so_on.Properties.Resources.Crying_happy_PePe;
            this.Happy_Sad_Pepe_Picture.Location = new System.Drawing.Point(491, 74);
            this.Happy_Sad_Pepe_Picture.Name = "Happy_Sad_Pepe_Picture";
            this.Happy_Sad_Pepe_Picture.Size = new System.Drawing.Size(525, 450);
            this.Happy_Sad_Pepe_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Happy_Sad_Pepe_Picture.TabIndex = 7;
            this.Happy_Sad_Pepe_Picture.TabStop = false;
            // 
            // Hype_Label
            // 
            this.Hype_Label.AutoSize = true;
            this.Hype_Label.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hype_Label.Location = new System.Drawing.Point(651, 26);
            this.Hype_Label.Name = "Hype_Label";
            this.Hype_Label.Size = new System.Drawing.Size(207, 36);
            this.Hype_Label.TabIndex = 25;
            this.Hype_Label.Text = "Almost There!!";
            // 
            // TenMinutesLeft_TextBox
            // 
            this.TenMinutesLeft_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TenMinutesLeft_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TenMinutesLeft_TextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenMinutesLeft_TextBox.Location = new System.Drawing.Point(56, 341);
            this.TenMinutesLeft_TextBox.Multiline = true;
            this.TenMinutesLeft_TextBox.Name = "TenMinutesLeft_TextBox";
            this.TenMinutesLeft_TextBox.Size = new System.Drawing.Size(117, 60);
            this.TenMinutesLeft_TextBox.TabIndex = 26;
            this.TenMinutesLeft_TextBox.Text = "We\'re Closing In!";
            // 
            // TimeLeftSunday_Label
            // 
            this.TimeLeftSunday_Label.AutoSize = true;
            this.TimeLeftSunday_Label.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeftSunday_Label.Location = new System.Drawing.Point(58, 290);
            this.TimeLeftSunday_Label.Name = "TimeLeftSunday_Label";
            this.TimeLeftSunday_Label.Size = new System.Drawing.Size(115, 33);
            this.TimeLeftSunday_Label.TabIndex = 27;
            this.TimeLeftSunday_Label.Text = "00:00:00";
            // 
            // TimeLeftSaturday_Label
            // 
            this.TimeLeftSaturday_Label.AutoSize = true;
            this.TimeLeftSaturday_Label.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeftSaturday_Label.Location = new System.Drawing.Point(58, 290);
            this.TimeLeftSaturday_Label.Name = "TimeLeftSaturday_Label";
            this.TimeLeftSaturday_Label.Size = new System.Drawing.Size(115, 33);
            this.TimeLeftSaturday_Label.TabIndex = 28;
            this.TimeLeftSaturday_Label.Text = "00:00:00";
            // 
            // GoHomeAt_Label
            // 
            this.GoHomeAt_Label.AutoSize = true;
            this.GoHomeAt_Label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoHomeAt_Label.Location = new System.Drawing.Point(6, 187);
            this.GoHomeAt_Label.Name = "GoHomeAt_Label";
            this.GoHomeAt_Label.Size = new System.Drawing.Size(200, 23);
            this.GoHomeAt_Label.TabIndex = 29;
            this.GoHomeAt_Label.Text = "You Can Go Home At:";
            // 
            // GoHomeAtClock_Label
            // 
            this.GoHomeAtClock_Label.AutoSize = true;
            this.GoHomeAtClock_Label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoHomeAtClock_Label.Location = new System.Drawing.Point(212, 187);
            this.GoHomeAtClock_Label.Name = "GoHomeAtClock_Label";
            this.GoHomeAtClock_Label.Size = new System.Drawing.Size(88, 23);
            this.GoHomeAtClock_Label.TabIndex = 30;
            this.GoHomeAtClock_Label.Text = "00:00:00";
            // 
            // Form_Countdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(1182, 536);
            this.Controls.Add(this.GoHomeAtClock_Label);
            this.Controls.Add(this.GoHomeAt_Label);
            this.Controls.Add(this.TimeLeftSaturday_Label);
            this.Controls.Add(this.TimeLeftSunday_Label);
            this.Controls.Add(this.TenMinutesLeft_TextBox);
            this.Controls.Add(this.Hype_Label);
            this.Controls.Add(this.PepeHype_Picture);
            this.Controls.Add(this.Check_in_Button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Break_Ends_TextBox);
            this.Controls.Add(this.Next_Break_TextBox);
            this.Controls.Add(this.Next_Break_Counter_Label);
            this.Controls.Add(this.You_Have_A_Break_Label);
            this.Controls.Add(this.Smug_Pepe_Picture);
            this.Controls.Add(this.Time_Left_TextBox);
            this.Controls.Add(this.Date_Today_Label);
            this.Controls.Add(this.Day_Today_Label);
            this.Controls.Add(this.Time_Now_Label);
            this.Controls.Add(this.Time_Left_HHmmss);
            this.Controls.Add(this.Reeeeee_Pepe_Picture);
            this.Controls.Add(this.Happy_Sad_Pepe_Picture);
            this.Controls.Add(this.Ikke_Fri_Endnu_Label);
            this.Controls.Add(this.Du_Har_Fri_Label);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Time);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Countdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countdown";
            this.Load += new System.EventHandler(this.Form_Countdown_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_Countdown_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PepeHype_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smug_Pepe_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reeeeee_Pepe_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Happy_Sad_Pepe_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Timer Seconds_Counter_Timer;
        private System.Windows.Forms.Label Du_Har_Fri_Label;
        private System.Windows.Forms.Label Ikke_Fri_Endnu_Label;
        private System.Windows.Forms.PictureBox Happy_Sad_Pepe_Picture;
        private System.Windows.Forms.PictureBox Reeeeee_Pepe_Picture;
        private System.Windows.Forms.Label Time_Left_HHmmss;
        private System.Windows.Forms.Timer CountDownTimer;
        private System.Windows.Forms.Label Time_Now_Label;
        private System.Windows.Forms.Label Day_Today_Label;
        private System.Windows.Forms.Label Date_Today_Label;
        private System.Windows.Forms.TextBox Time_Left_TextBox;
        private System.Windows.Forms.PictureBox Smug_Pepe_Picture;
        private System.Windows.Forms.Label You_Have_A_Break_Label;
        private System.Windows.Forms.Label Next_Break_Counter_Label;
        private System.Windows.Forms.TextBox Next_Break_TextBox;
        private System.Windows.Forms.TextBox Break_Ends_TextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Check_in_Button;
        private System.Windows.Forms.PictureBox PepeHype_Picture;
        private System.Windows.Forms.Label Hype_Label;
        private System.Windows.Forms.TextBox TenMinutesLeft_TextBox;
        private System.Windows.Forms.Label TimeLeftSunday_Label;
        private System.Windows.Forms.Label TimeLeftSaturday_Label;
        private System.Windows.Forms.Label GoHomeAt_Label;
        private System.Windows.Forms.Label GoHomeAtClock_Label;
    }
}