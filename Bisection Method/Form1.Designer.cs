namespace Bisection_Method
{
    partial class Form1
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
            this.chkKMax = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kTB9 = new System.Windows.Forms.TextBox();
            this.absTB8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fxTB7 = new System.Windows.Forms.TextBox();
            this.xTB6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kmTB5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tTB4 = new System.Windows.Forms.TextBox();
            this.bTB3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fTB1 = new System.Windows.Forms.TextBox();
            this.aTB2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkKMax
            // 
            this.chkKMax.AutoSize = true;
            this.chkKMax.BackColor = System.Drawing.Color.LightGray;
            this.chkKMax.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.chkKMax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkKMax.Location = new System.Drawing.Point(475, 228);
            this.chkKMax.Name = "chkKMax";
            this.chkKMax.Size = new System.Drawing.Size(120, 29);
            this.chkKMax.TabIndex = 25;
            this.chkKMax.Text = "use K max";
            this.chkKMax.UseVisualStyleBackColor = false;
            this.chkKMax.CheckedChanged += new System.EventHandler(this.chkKMax_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar1.Location = new System.Drawing.Point(465, 131);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(162, 31);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 22;
            this.progressBar1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.kTB9);
            this.groupBox2.Controls.Add(this.absTB8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.fxTB7);
            this.groupBox2.Controls.Add(this.xTB6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 204);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // kTB9
            // 
            this.kTB9.BackColor = System.Drawing.Color.LightGray;
            this.kTB9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kTB9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kTB9.Location = new System.Drawing.Point(111, 138);
            this.kTB9.Name = "kTB9";
            this.kTB9.ReadOnly = true;
            this.kTB9.Size = new System.Drawing.Size(330, 31);
            this.kTB9.TabIndex = 8;
            this.kTB9.Text = "0";
            // 
            // absTB8
            // 
            this.absTB8.BackColor = System.Drawing.Color.LightGray;
            this.absTB8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.absTB8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.absTB8.Location = new System.Drawing.Point(111, 101);
            this.absTB8.Name = "absTB8";
            this.absTB8.ReadOnly = true;
            this.absTB8.Size = new System.Drawing.Size(330, 31);
            this.absTB8.TabIndex = 7;
            this.absTB8.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(114, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkGray;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(6, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "Time(msec):";
            // 
            // fxTB7
            // 
            this.fxTB7.BackColor = System.Drawing.Color.LightGray;
            this.fxTB7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fxTB7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fxTB7.Location = new System.Drawing.Point(111, 64);
            this.fxTB7.Name = "fxTB7";
            this.fxTB7.ReadOnly = true;
            this.fxTB7.Size = new System.Drawing.Size(330, 31);
            this.fxTB7.TabIndex = 6;
            this.fxTB7.Text = "0";
            // 
            // xTB6
            // 
            this.xTB6.BackColor = System.Drawing.Color.LightGray;
            this.xTB6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xTB6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xTB6.Location = new System.Drawing.Point(111, 27);
            this.xTB6.Name = "xTB6";
            this.xTB6.ReadOnly = true;
            this.xTB6.Size = new System.Drawing.Size(330, 31);
            this.xTB6.TabIndex = 5;
            this.xTB6.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "X*:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "F(X*):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(6, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "K:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(6, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "ABS(B-A):";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(465, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 94);
            this.button1.TabIndex = 19;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(465, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 68);
            this.button2.TabIndex = 21;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.kmTB5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tTB4);
            this.groupBox1.Controls.Add(this.bTB3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fTB1);
            this.groupBox1.Controls.Add(this.aTB2);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 258);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(120, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 31);
            this.textBox1.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkGray;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(6, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "Time(msec):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Function:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "B:";
            // 
            // kmTB5
            // 
            this.kmTB5.BackColor = System.Drawing.Color.LightGray;
            this.kmTB5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kmTB5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kmTB5.Location = new System.Drawing.Point(120, 215);
            this.kmTB5.Name = "kmTB5";
            this.kmTB5.Size = new System.Drawing.Size(321, 31);
            this.kmTB5.TabIndex = 4;
            this.kmTB5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tolerance:";
            // 
            // tTB4
            // 
            this.tTB4.BackColor = System.Drawing.Color.LightGray;
            this.tTB4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tTB4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tTB4.Location = new System.Drawing.Point(120, 141);
            this.tTB4.Name = "tTB4";
            this.tTB4.Size = new System.Drawing.Size(321, 31);
            this.tTB4.TabIndex = 3;
            // 
            // bTB3
            // 
            this.bTB3.BackColor = System.Drawing.Color.LightGray;
            this.bTB3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bTB3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bTB3.Location = new System.Drawing.Point(120, 104);
            this.bTB3.Name = "bTB3";
            this.bTB3.Size = new System.Drawing.Size(321, 31);
            this.bTB3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "K max:";
            this.label5.Visible = false;
            // 
            // fTB1
            // 
            this.fTB1.BackColor = System.Drawing.Color.LightGray;
            this.fTB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fTB1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fTB1.Location = new System.Drawing.Point(120, 30);
            this.fTB1.Name = "fTB1";
            this.fTB1.Size = new System.Drawing.Size(321, 31);
            this.fTB1.TabIndex = 0;
            // 
            // aTB2
            // 
            this.aTB2.BackColor = System.Drawing.Color.LightGray;
            this.aTB2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aTB2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aTB2.Location = new System.Drawing.Point(120, 67);
            this.aTB2.Name = "aTB2";
            this.aTB2.Size = new System.Drawing.Size(321, 31);
            this.aTB2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(12, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(12, 519);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 25);
            this.label13.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(7, 546);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 25);
            this.label15.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(639, 580);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkKMax);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(655, 619);
            this.MinimumSize = new System.Drawing.Size(655, 619);
            this.Name = "Form1";
            this.Text = "Bisection Method";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkKMax;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox kTB9;
        private System.Windows.Forms.TextBox absTB8;
        private System.Windows.Forms.TextBox fxTB7;
        private System.Windows.Forms.TextBox xTB6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kmTB5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tTB4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bTB3;
        private System.Windows.Forms.TextBox fTB1;
        private System.Windows.Forms.TextBox aTB2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;

    }
}

