namespace Login_interface_and_so_on
{
    partial class Form_Mini_Games
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
            this.Mini_Games_Exit_Button = new System.Windows.Forms.Button();
            this.Mini_Games_Return_Button = new System.Windows.Forms.Button();
            this.Mini_Games_Dice_Games_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mini_Games_Exit_Button
            // 
            this.Mini_Games_Exit_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Mini_Games_Exit_Button.Location = new System.Drawing.Point(758, 12);
            this.Mini_Games_Exit_Button.Name = "Mini_Games_Exit_Button";
            this.Mini_Games_Exit_Button.Size = new System.Drawing.Size(30, 25);
            this.Mini_Games_Exit_Button.TabIndex = 3;
            this.Mini_Games_Exit_Button.Text = "X";
            this.Mini_Games_Exit_Button.UseVisualStyleBackColor = true;
            this.Mini_Games_Exit_Button.Click += new System.EventHandler(this.Mini_Games_Exit_Button_Click);
            // 
            // Mini_Games_Return_Button
            // 
            this.Mini_Games_Return_Button.Location = new System.Drawing.Point(722, 12);
            this.Mini_Games_Return_Button.Name = "Mini_Games_Return_Button";
            this.Mini_Games_Return_Button.Size = new System.Drawing.Size(30, 25);
            this.Mini_Games_Return_Button.TabIndex = 2;
            this.Mini_Games_Return_Button.Text = "<--";
            this.Mini_Games_Return_Button.UseVisualStyleBackColor = true;
            this.Mini_Games_Return_Button.Click += new System.EventHandler(this.Mini_Games_Return_Button_Click);
            // 
            // Mini_Games_Dice_Games_Button
            // 
            this.Mini_Games_Dice_Games_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mini_Games_Dice_Games_Button.Location = new System.Drawing.Point(280, 108);
            this.Mini_Games_Dice_Games_Button.Name = "Mini_Games_Dice_Games_Button";
            this.Mini_Games_Dice_Games_Button.Size = new System.Drawing.Size(64, 49);
            this.Mini_Games_Dice_Games_Button.TabIndex = 0;
            this.Mini_Games_Dice_Games_Button.Text = "Dice Games";
            this.Mini_Games_Dice_Games_Button.UseVisualStyleBackColor = true;
            this.Mini_Games_Dice_Games_Button.Click += new System.EventHandler(this.Mini_Games_Dice_Games_Button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Blackjack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form_Mini_Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Mini_Games_Exit_Button;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mini_Games_Dice_Games_Button);
            this.Controls.Add(this.Mini_Games_Return_Button);
            this.Controls.Add(this.Mini_Games_Exit_Button);
            this.Name = "Form_Mini_Games";
            this.Text = "Mini Games";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Mini_Games_Exit_Button;
        private System.Windows.Forms.Button Mini_Games_Return_Button;
        private System.Windows.Forms.Button Mini_Games_Dice_Games_Button;
        private System.Windows.Forms.Button button1;
    }
}