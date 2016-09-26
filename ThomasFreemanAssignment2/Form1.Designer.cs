namespace Assignment_2
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
            this.components = new System.ComponentModel.Container();
            this.initialHeight = new System.Windows.Forms.TextBox();
            this.initialVelocity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeBallGroundBox = new System.Windows.Forms.TextBox();
            this.maxHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // initialHeight
            // 
            this.initialHeight.Location = new System.Drawing.Point(340, 228);
            this.initialHeight.Name = "initialHeight";
            this.initialHeight.Size = new System.Drawing.Size(174, 26);
            this.initialHeight.TabIndex = 0;
            // 
            // initialVelocity
            // 
            this.initialVelocity.Location = new System.Drawing.Point(340, 276);
            this.initialVelocity.Name = "initialVelocity";
            this.initialVelocity.Size = new System.Drawing.Size(174, 26);
            this.initialVelocity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Intitial Height (ft) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Intitial Velocity (ft/s) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time when the ball hits the ground (s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Maximum Height (ft): ";
            // 
            // timeBallGroundBox
            // 
            this.timeBallGroundBox.Location = new System.Drawing.Point(340, 440);
            this.timeBallGroundBox.Name = "timeBallGroundBox";
            this.timeBallGroundBox.Size = new System.Drawing.Size(174, 26);
            this.timeBallGroundBox.TabIndex = 5;
            // 
            // maxHeight
            // 
            this.maxHeight.Location = new System.Drawing.Point(340, 397);
            this.maxHeight.Name = "maxHeight";
            this.maxHeight.Size = new System.Drawing.Size(174, 26);
            this.maxHeight.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-7, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1107, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "_________________________________________________________________________________" +
    "_________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "INPUT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "RESULTS";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 59);
            this.button2.TabIndex = 11;
            this.button2.Text = "Determine Maximum Height";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.displayMaximumHeight);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 59);
            this.button3.TabIndex = 12;
            this.button3.Text = "Determine Landing time";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.TimeBallGround);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(329, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 59);
            this.button4.TabIndex = 13;
            this.button4.Text = "Quit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.quit);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(43, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 59);
            this.button5.TabIndex = 14;
            this.button5.Text = "Display Table";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.displayTable);
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.EnableHeadersVisualStyles = false;
            this.table.Location = new System.Drawing.Point(43, 510);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 28;
            this.table.Size = new System.Drawing.Size(471, 307);
            this.table.TabIndex = 15;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(Assignment_2.Program);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Assignment_2.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 847);
            this.Controls.Add(this.table);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeBallGroundBox);
            this.Controls.Add(this.maxHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.initialVelocity);
            this.Controls.Add(this.initialHeight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox initialHeight;
        private System.Windows.Forms.TextBox initialVelocity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timeBallGroundBox;
        private System.Windows.Forms.TextBox maxHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridView table;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

