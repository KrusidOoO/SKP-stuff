namespace Login_interface_and_so_on
{
    partial class Check_in_Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.HourCheckIn_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(191, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(391, 165);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check-In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // HourCheckIn_TextBox
            // 
            this.HourCheckIn_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.HourCheckIn_TextBox.Location = new System.Drawing.Point(160, 68);
            this.HourCheckIn_TextBox.Multiline = true;
            this.HourCheckIn_TextBox.Name = "HourCheckIn_TextBox";
            this.HourCheckIn_TextBox.Size = new System.Drawing.Size(148, 115);
            this.HourCheckIn_TextBox.TabIndex = 1;
            // 
            // Check_in_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HourCheckIn_TextBox);
            this.Controls.Add(this.button1);
            this.Name = "Check_in_Form";
            this.Text = "Check_in_Form";
            this.Load += new System.EventHandler(this.Check_in_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox HourCheckIn_TextBox;
    }
}