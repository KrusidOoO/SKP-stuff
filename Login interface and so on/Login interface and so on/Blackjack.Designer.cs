namespace Login_interface_and_so_on
{
    partial class Form_Blackjack
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
            this.Return = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(704, 12);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(42, 30);
            this.Return.TabIndex = 0;
            this.Return.Text = "<--";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(752, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(36, 30);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form_Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Return);
            this.Name = "Form_Blackjack";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form_Blackjack_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Exit;
    }
}