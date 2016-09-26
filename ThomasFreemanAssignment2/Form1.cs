using System;
using System.Data;
using System.Windows.Forms;
using  static System.Text.RegularExpressions.Regex;

//Assignment 2 by Thomas Freeman

namespace Assignment_2
{
    public partial class Form1 : Form
    {

        double height = 0;
        double velocity = 0;

        Control maxHeightControl;
        Control timeBallGroundControl;

        public Form1()
        {
            InitializeComponent();

            foreach (Control tb in this.Controls)    //find all text boxes in those group boxes
            {
                if (tb is TextBox)
                {
                    tb.Text = "0";    //clear the text
                }
            }
        }

        private void getInput()
        {            

            foreach (Control controls in this.Controls)  //find all controls and assign to vars
            {
                switch (controls.Name)
                {
                    
                    case ("initialHeight"):  
                        
                        if (! System.Text.RegularExpressions.Regex.IsMatch(controls.Text, "^[a-zA-z]+$")) //if it does not contain a letter
                        {
                            height = Convert.ToDouble(controls.Text);

                            if (height < 0.0) System.Windows.Forms.MessageBox.Show("Input must be positive");
                        } else System.Windows.Forms.MessageBox.Show("Input must be a number");
                        break;

                    case ("initialVelocity"):

                        if (! System.Text.RegularExpressions.Regex.IsMatch(controls.Text, "^[a-zA-z]+$")) //if it does not contain a letter
                        {
                            velocity = Convert.ToDouble(controls.Text);

                            if (velocity < 0.0) System.Windows.Forms.MessageBox.Show("Input must be positive");
                        } else System.Windows.Forms.MessageBox.Show("Input must be a number");

                        break;

                    case ("maxHeight"):
                        maxHeightControl = controls;
                        break;

                    case ("timeBallGound"):
                        timeBallGroundControl = controls;
                        break;

                    default:
                        break;
                }
            }
        }

        private void displayMaximumHeight(object sender, EventArgs e)
        {

            getInput();

            double maxHeightTime = velocity / 32.0;

            double maxHeight = height + (velocity * maxHeightTime) - (16 * Math.Pow(maxHeightTime, 2 )); // formula  = h + vt - 16t^2

            Controls.Find("maxHeight", true)[0].Text = maxHeight.ToString();

        }

        private void TimeBallGround(object sender, EventArgs e)
        {

            getInput();

            double time = 0.0;
            double currentHeight = height;

            for (double i = 0; currentHeight > 0.0; i += 0.1) //calculate height every .1s
            {

                currentHeight = height + (velocity * i) - (16 * Math.Pow(i, 2));

                time = i;
            }


            Controls.Find("timeBallGroundBox", true)[0].Text = time.ToString();
        }

        private void displayTable(object sender, EventArgs e)
        {

            getInput();

            DataGridView gridView = null; //create grid
            double currentHeight = height;

            foreach (Control control in this.Controls)
            {

                if (control is DataGridView) gridView = (DataGridView)control; //asign it to the actual grid on the form
            }

            DataTable dataTable = new DataTable(); //create data table

            dataTable.Columns.Add(new DataColumn("Time", typeof(double))); //set columns
            dataTable.Columns.Add(new DataColumn("Height", typeof(double)));

            DataRow row;    //create data row var for use in loop when building table

            double i = 0;
            do {

                currentHeight = height + (velocity * i) - (16 * Math.Pow(i, 2));

                if (currentHeight < 0.0) break; //check if the ball has hit the ground

                row = dataTable.NewRow(); //create new row for this time 
                row["Time"] = i;    //add data
                row["Height"] = currentHeight;

                dataTable.Rows.Add(row);    //add row to the table

                i += 0.25;

                if (i > 5.0) break; //stop counting after 5s
            } while (currentHeight > 0.0) ;

            gridView.DataSource = dataTable;


        }

        private void quit (object sender, EventArgs e)
        {

            this.Close();
        }

    }
}
