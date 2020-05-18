namespace Login_interface_and_so_on
{
    partial class Form_Login_Interface
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
            this.Username_Label = new System.Windows.Forms.Label();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Login_Interface_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Label.Location = new System.Drawing.Point(31, 105);
            this.Username_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(77, 19);
            this.Username_Label.TabIndex = 0;
            this.Username_Label.Text = "Username :";
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Location = new System.Drawing.Point(125, 106);
            this.Username_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(171, 20);
            this.Username_TextBox.TabIndex = 1;
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(125, 167);
            this.Password_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(171, 20);
            this.Password_TextBox.TabIndex = 2;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.Location = new System.Drawing.Point(31, 166);
            this.Password_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(76, 19);
            this.Password_Label.TabIndex = 3;
            this.Password_Label.Text = "Password :";
            // 
            // Login_Button
            // 
            this.Login_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.Location = new System.Drawing.Point(73, 215);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(70, 51);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.Location = new System.Drawing.Point(197, 215);
            this.Exit_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(73, 51);
            this.Exit_Button.TabIndex = 5;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Login_Interface_Label
            // 
            this.Login_Interface_Label.AutoSize = true;
            this.Login_Interface_Label.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Interface_Label.Location = new System.Drawing.Point(12, 9);
            this.Login_Interface_Label.Name = "Login_Interface_Label";
            this.Login_Interface_Label.Size = new System.Drawing.Size(136, 22);
            this.Login_Interface_Label.TabIndex = 6;
            this.Login_Interface_Label.Text = "Login Interface";
            // 
            // Form_Login_Interface
            // 
            this.AcceptButton = this.Login_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit_Button;
            this.ClientSize = new System.Drawing.Size(340, 364);
            this.Controls.Add(this.Login_Interface_Label);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Username_TextBox);
            this.Controls.Add(this.Username_Label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Login_Interface";
            this.Text = "Login Interface";
            this.Load += new System.EventHandler(this.Form_Login_Interface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label Login_Interface_Label;
    }
}

