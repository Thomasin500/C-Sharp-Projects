using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThomasFreemanAssignment01
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            setZeros();
        }

        private void setZeros() //set all textboxes to zero upon program start
        {
            foreach (Control GBs in this.Controls)  //find all group boxes
            {
                if (GBs is GroupBox)
                {
                    foreach (Control tb in GBs.Controls)    //find all text boxes in those group boxes
                    {
                        if (tb is TextBox)  //make sure it is a text box
                        {

                            tb.Text = "0";
                        }
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //calculate revenue
        {

            int numATix = 0;
            int numBTix = 0;
            int numCTix = 0;           
            int total = 0;

            foreach (Control GBs in this.Controls)  //find all group boxes
            {
                if (GBs is GroupBox)
                {
                    foreach (Control tb in GBs.Controls)    //find all text boxes in those group boxes
                    {
                        if (tb is TextBox)
                        {
                            // System.Diagnostics.Debug.Write(tb.Text);
                            switch (tb.Name) //find out which text box this is
                            {

                                case "A":
                                    numATix = Int32.Parse(tb.Text);
                                    break;

                                case "B":
                                    numBTix = Int32.Parse(tb.Text);
                                    break;

                                case "C":
                                    numCTix = Int32.Parse(tb.Text);
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                }
            }

            System.Diagnostics.Debug.Write("A:" + numATix);
            System.Diagnostics.Debug.Write("B:" + numBTix);
            System.Diagnostics.Debug.Write("C:" + numCTix);

            //do the same loop again, but this time setting the revenue amounts in the appropriate locations
            foreach (Control GBs in this.Controls)  //find all group boxes
            {
                if (GBs is GroupBox)
                {
                    
                    foreach (Control tb in GBs.Controls)    //find all text boxes in those group boxes
                    {
                        if (tb is TextBox)
                        {
                            switch (tb.Name) //find out which text box this is
                            {

                                case "revA":

                                    int valA = numATix * 15;    //store numeric value 
                                    total += valA;  //add to total
                                    tb.Text =  string.Format("{0:C}", Convert.ToDecimal(valA));  //format as money                                 
                                    break;

                                case "revB":

                                    int valB = numBTix * 12;
                                    total += valB;
                                    tb.Text = string.Format("{0:C}", Convert.ToDecimal(valB));
                                    break;

                                case "revC":

                                    int valC = numCTix * 9;
                                    total += valC;
                                    tb.Text = string.Format("{0:C}", Convert.ToDecimal(valC));
                                    break;                            

                                default:
                                    break;
                            }
                        }
                    }
                }
            }

            var totalBox = Controls.Find("total", true); //MUCH better way of finding controls by name, though may not work for multiples
            totalBox[0].Text = string.Format("{0:C}", Convert.ToDecimal(total)); //format as currency and set to text
        }

        private void button2_Click(object sender, EventArgs e) //clear
        {      
            foreach (Control GBs in this.Controls)  //find all group boxes
            {                
                if (GBs is GroupBox)
                {
                    foreach (Control tb in GBs.Controls)    //find all text boxes in those group boxes
                    {                        
                        if (tb is TextBox)
                        {                             
                            tb.Text = "0";    //clear the text
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //exit
        {

            this.Close();
        }
    }
}
