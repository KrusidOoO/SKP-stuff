namespace Login_interface_and_so_on
{
    partial class Form_Calculator
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
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Return_Button = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.Calculator_Input_TextBox = new System.Windows.Forms.TextBox();
            this.Calculator_Preview_TextBox = new System.Windows.Forms.TextBox();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bmul = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.bpow = new System.Windows.Forms.Button();
            this.bsqr = new System.Windows.Forms.Button();
            this.Calculator_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit_Button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.Location = new System.Drawing.Point(360, 13);
            this.Exit_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(30, 25);
            this.Exit_Button.TabIndex = 150;
            this.Exit_Button.Text = "X";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Return_Button
            // 
            this.Return_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Return_Button.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_Button.Location = new System.Drawing.Point(324, 13);
            this.Return_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(30, 25);
            this.Return_Button.TabIndex = 6;
            this.Return_Button.Text = "<--";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // n2
            // 
            this.n2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.n2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(112, 159);
            this.n2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(65, 40);
            this.n2.TabIndex = 9;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.N2_Click);
            // 
            // Calculator_Input_TextBox
            // 
            this.Calculator_Input_TextBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculator_Input_TextBox.Location = new System.Drawing.Point(41, 107);
            this.Calculator_Input_TextBox.Multiline = true;
            this.Calculator_Input_TextBox.Name = "Calculator_Input_TextBox";
            this.Calculator_Input_TextBox.ReadOnly = true;
            this.Calculator_Input_TextBox.Size = new System.Drawing.Size(349, 45);
            this.Calculator_Input_TextBox.TabIndex = 12;
            this.Calculator_Input_TextBox.Text = "0";
            this.Calculator_Input_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Calculator_Input_TextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Calculator_Preview_TextBox
            // 
            this.Calculator_Preview_TextBox.Location = new System.Drawing.Point(254, 66);
            this.Calculator_Preview_TextBox.Multiline = true;
            this.Calculator_Preview_TextBox.Name = "Calculator_Preview_TextBox";
            this.Calculator_Preview_TextBox.ReadOnly = true;
            this.Calculator_Preview_TextBox.Size = new System.Drawing.Size(136, 35);
            this.Calculator_Preview_TextBox.TabIndex = 13;
            this.Calculator_Preview_TextBox.Text = " ";
            this.Calculator_Preview_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Calculator_Preview_TextBox.TextChanged += new System.EventHandler(this.Calculator_Preview_TextBox_TextChanged);
            // 
            // n5
            // 
            this.n5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.n5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(112, 207);
            this.n5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(65, 40);
            this.n5.TabIndex = 14;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.N5_Click);
            // 
            // n6
            // 
            this.n6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.n6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(183, 207);
            this.n6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(65, 40);
            this.n6.TabIndex = 15;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.N6_Click);
            // 
            // n1
            // 
            this.n1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.n1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(41, 159);
            this.n1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(65, 40);
            this.n1.TabIndex = 16;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.N1_Click_1);
            // 
            // n8
            // 
            this.n8.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.n8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.Location = new System.Drawing.Point(112, 255);
            this.n8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(65, 40);
            this.n8.TabIndex = 17;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.N8_Click);
            // 
            // n4
            // 
            this.n4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.n4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(41, 207);
            this.n4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(65, 40);
            this.n4.TabIndex = 18;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.N4_Click);
            // 
            // n0
            // 
            this.n0.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.n0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.Location = new System.Drawing.Point(112, 303);
            this.n0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(65, 40);
            this.n0.TabIndex = 19;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.N0_Click);
            // 
            // n7
            // 
            this.n7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.n7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(41, 255);
            this.n7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(65, 40);
            this.n7.TabIndex = 20;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.N7_Click);
            // 
            // n9
            // 
            this.n9.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.n9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.Location = new System.Drawing.Point(183, 255);
            this.n9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(65, 40);
            this.n9.TabIndex = 21;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.N9_Click);
            // 
            // n3
            // 
            this.n3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(183, 159);
            this.n3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(65, 40);
            this.n3.TabIndex = 22;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.N3_Click);
            // 
            // badd
            // 
            this.badd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.badd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badd.Location = new System.Drawing.Point(254, 159);
            this.badd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(65, 40);
            this.badd.TabIndex = 23;
            this.badd.Text = "+";
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.Badd_Click);
            // 
            // bdot
            // 
            this.bdot.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bdot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdot.Location = new System.Drawing.Point(41, 303);
            this.bdot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(65, 40);
            this.bdot.TabIndex = 24;
            this.bdot.Text = ".";
            this.bdot.UseVisualStyleBackColor = true;
            this.bdot.Click += new System.EventHandler(this.Bdot_Click);
            // 
            // bClear
            // 
            this.bClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(183, 303);
            this.bClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(65, 40);
            this.bClear.TabIndex = 25;
            this.bClear.Text = "C";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // bdiv
            // 
            this.bdiv.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bdiv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdiv.Location = new System.Drawing.Point(254, 303);
            this.bdiv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(65, 40);
            this.bdiv.TabIndex = 26;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = true;
            this.bdiv.Click += new System.EventHandler(this.Bdiv_Click);
            // 
            // bmul
            // 
            this.bmul.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bmul.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmul.Location = new System.Drawing.Point(254, 255);
            this.bmul.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bmul.Name = "bmul";
            this.bmul.Size = new System.Drawing.Size(65, 40);
            this.bmul.TabIndex = 27;
            this.bmul.Text = "*";
            this.bmul.UseVisualStyleBackColor = true;
            this.bmul.Click += new System.EventHandler(this.Bmul_Click);
            // 
            // bsub
            // 
            this.bsub.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bsub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsub.Location = new System.Drawing.Point(254, 207);
            this.bsub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(65, 40);
            this.bsub.TabIndex = 28;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = true;
            this.bsub.Click += new System.EventHandler(this.Bsub_Click);
            // 
            // bequal
            // 
            this.bequal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bequal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bequal.Location = new System.Drawing.Point(325, 303);
            this.bequal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(65, 40);
            this.bequal.TabIndex = 1;
            this.bequal.Text = "=";
            this.bequal.UseVisualStyleBackColor = true;
            this.bequal.Click += new System.EventHandler(this.Bequal_Click);
            // 
            // bpow
            // 
            this.bpow.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bpow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpow.Location = new System.Drawing.Point(325, 207);
            this.bpow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bpow.Name = "bpow";
            this.bpow.Size = new System.Drawing.Size(65, 40);
            this.bpow.TabIndex = 31;
            this.bpow.Text = "power";
            this.bpow.UseVisualStyleBackColor = true;
            this.bpow.Click += new System.EventHandler(this.Bpow_Click);
            // 
            // bsqr
            // 
            this.bsqr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bsqr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsqr.Location = new System.Drawing.Point(325, 159);
            this.bsqr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bsqr.Name = "bsqr";
            this.bsqr.Size = new System.Drawing.Size(65, 40);
            this.bsqr.TabIndex = 32;
            this.bsqr.Text = "sqr";
            this.bsqr.UseVisualStyleBackColor = true;
            this.bsqr.Click += new System.EventHandler(this.Bsqr_Click);
            // 
            // Calculator_Label
            // 
            this.Calculator_Label.AutoSize = true;
            this.Calculator_Label.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculator_Label.Location = new System.Drawing.Point(12, 9);
            this.Calculator_Label.Name = "Calculator_Label";
            this.Calculator_Label.Size = new System.Drawing.Size(97, 22);
            this.Calculator_Label.TabIndex = 33;
            this.Calculator_Label.Text = "Calculator";
            // 
            // Form_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit_Button;
            this.ClientSize = new System.Drawing.Size(410, 519);
            this.Controls.Add(this.Calculator_Label);
            this.Controls.Add(this.bsqr);
            this.Controls.Add(this.bpow);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.bmul);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.Calculator_Preview_TextBox);
            this.Controls.Add(this.Calculator_Input_TextBox);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.Exit_Button);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_Calculator_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.TextBox Calculator_Input_TextBox;
        private System.Windows.Forms.TextBox Calculator_Preview_TextBox;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bdot;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bmul;
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button bequal;
        private System.Windows.Forms.Button bpow;
        private System.Windows.Forms.Button bsqr;
        private System.Windows.Forms.Label Calculator_Label;
    }
}