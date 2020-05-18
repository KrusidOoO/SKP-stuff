namespace Login_interface_and_so_on
{
    partial class Form_Fun_Facts
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
            this.Fun_Fact_TextBox = new System.Windows.Forms.TextBox();
            this.Random_Fun_fact_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Return_Button = new System.Windows.Forms.Button();
            this.Fun_Facts_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Fun_Fact_TextBox
            // 
            this.Fun_Fact_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Fun_Fact_TextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fun_Fact_TextBox.Location = new System.Drawing.Point(200, 75);
            this.Fun_Fact_TextBox.Multiline = true;
            this.Fun_Fact_TextBox.Name = "Fun_Fact_TextBox";
            this.Fun_Fact_TextBox.ReadOnly = true;
            this.Fun_Fact_TextBox.Size = new System.Drawing.Size(400, 250);
            this.Fun_Fact_TextBox.TabIndex = 0;
            this.Fun_Fact_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fun_Fact_TextBox.TextChanged += new System.EventHandler(this.Fun_Fact_TextBox_TextChanged_1);
            // 
            // Random_Fun_fact_Button
            // 
            this.Random_Fun_fact_Button.Location = new System.Drawing.Point(325, 375);
            this.Random_Fun_fact_Button.Name = "Random_Fun_fact_Button";
            this.Random_Fun_fact_Button.Size = new System.Drawing.Size(150, 65);
            this.Random_Fun_fact_Button.TabIndex = 1;
            this.Random_Fun_fact_Button.Text = "Hit it!";
            this.Random_Fun_fact_Button.UseVisualStyleBackColor = true;
            this.Random_Fun_fact_Button.Click += new System.EventHandler(this.Random_Fun_fact_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit_Button.Location = new System.Drawing.Point(758, 12);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(30, 25);
            this.Exit_Button.TabIndex = 2;
            this.Exit_Button.Text = "X";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Return_Button
            // 
            this.Return_Button.Location = new System.Drawing.Point(722, 12);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(30, 25);
            this.Return_Button.TabIndex = 3;
            this.Return_Button.Text = "<--";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // Fun_Facts_Label
            // 
            this.Fun_Facts_Label.AutoSize = true;
            this.Fun_Facts_Label.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fun_Facts_Label.Location = new System.Drawing.Point(12, 9);
            this.Fun_Facts_Label.Name = "Fun_Facts_Label";
            this.Fun_Facts_Label.Size = new System.Drawing.Size(129, 22);
            this.Fun_Facts_Label.TabIndex = 6;
            this.Fun_Facts_Label.Text = "Random Facts";
            // 
            // Form_Fun_Facts
            // 
            this.AcceptButton = this.Random_Fun_fact_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit_Button;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fun_Facts_Label);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Random_Fun_fact_Button);
            this.Controls.Add(this.Fun_Fact_TextBox);
            this.Name = "Form_Fun_Facts";
            this.Text = "Random Facts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Fun_Fact_TextBox;
        private System.Windows.Forms.Button Random_Fun_fact_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Label Fun_Facts_Label;
    }
}