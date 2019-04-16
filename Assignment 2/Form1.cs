using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double R6 = 0;
            double R7 = 0;
            double R8 = 0;
            double R9 = 0;
            double R10 = 0;

         
        
            try
            {
                R6 = double.Parse(textBox4.Text);
                R7 = double.Parse(textBox5.Text);
                R8 = double.Parse(textBox6.Text);
                R9 = double.Parse(textBox9.Text);
                R10 = double.Parse(textBox10.Text);

            }

            catch
            {
                MessageBox.Show("Error");
                //this message will show when a letter is entered into the text box.
            }

            //
            double Resistance = R6 + R7 + R8 + R9 + R10;

            //The answer will be displayed by a a label.
            label8.Text = "Resistance (Ω) = " + Resistance;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double R1 = 0.0;
            double R2 = 0.0;
            double R3 = 0.0;
            double R4 = 0.0;
            double R5 = 0.0;


            try
            {
                R1 = double.Parse(textBox1.Text);
                R2 = double.Parse(textBox2.Text);
                if (textBox3.Text == "0")
                    R3 = double.PositiveInfinity;
                else R3 = double.Parse(textBox3.Text);

                if (textBox7.Text == "0")
                    R4 = double.PositiveInfinity;
                else R4 = double.Parse(textBox7.Text);

                if (textBox8.Text == "0")
                    R5 = double.PositiveInfinity;
                else R5 = double.Parse(textBox8.Text);
                //This means the program will still work if a "0" is typed in a textbox for any of the resistors apart for the first 2. 
                //This only needs to  be done for parallel.

                //Whatever is put in textBox1 will be R1 in the equation, same for  R2, R3 and so on.
            }
            catch
            {
                MessageBox.Show("Error");
                //this message will show when a letter is entered into the text box.
            }

            //
            double Resistance = 1.0/(1.0/R1 + 1.0/R2 + 1.0/R3 + 1.0/R4 + 1.0/R5);

            //The answer will be displayed by a a label, this is how.
            label9.Text = "Resistance (Ω) = " + Resistance;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
