namespace ThomasFreemanAssignment01
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
            this.CalcRev = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.total = new System.Windows.Forms.TextBox();
            this.revC = new System.Windows.Forms.TextBox();
            this.revB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.revA = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalcRev
            // 
            this.CalcRev.Location = new System.Drawing.Point(407, 414);
            this.CalcRev.Name = "CalcRev";
            this.CalcRev.Size = new System.Drawing.Size(140, 72);
            this.CalcRev.TabIndex = 0;
            this.CalcRev.Text = "Calculate Revenue";
            this.CalcRev.UseVisualStyleBackColor = true;
            this.CalcRev.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 74);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(736, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 72);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.C);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.A);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.groupBox1.Location = new System.Drawing.Point(58, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 319);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Class C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class B:";
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(140, 215);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(134, 26);
            this.C.TabIndex = 3;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(140, 142);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(134, 26);
            this.B.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class A:";
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(140, 82);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(134, 26);
            this.A.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.total);
            this.groupBox2.Controls.Add(this.revC);
            this.groupBox2.Controls.Add(this.revB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.revA);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.groupBox2.Location = new System.Drawing.Point(736, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 319);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(140, 245);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(100, 26);
            this.total.TabIndex = 7;
            // 
            // revC
            // 
            this.revC.Location = new System.Drawing.Point(140, 192);
            this.revC.Name = "revC";
            this.revC.ReadOnly = true;
            this.revC.Size = new System.Drawing.Size(100, 26);
            this.revC.TabIndex = 6;
            // 
            // revB
            // 
            this.revB.Location = new System.Drawing.Point(140, 133);
            this.revB.Name = "revB";
            this.revB.ReadOnly = true;
            this.revB.Size = new System.Drawing.Size(100, 26);
            this.revB.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Class C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Class B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class A:";
            // 
            // revA
            // 
            this.revA.Location = new System.Drawing.Point(140, 82);
            this.revA.Name = "revA";
            this.revA.ReadOnly = true;
            this.revA.Size = new System.Drawing.Size(100, 26);
            this.revA.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CalcRev);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalcRev;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox revA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox revC;
        private System.Windows.Forms.TextBox revB;
    }
}

