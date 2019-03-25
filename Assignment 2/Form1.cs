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

            double R4 = 0;
            double R5 = 0;
            double R6 = 0;
            try
            {
                R4 = double.Parse(textBox1.Text);
                R5 = double.Parse(textBox2.Text);
                R6 = double.Parse(textBox3.Text);
            }
            catch
            {

            }

           string st = "three";
            try
            {
                int it = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st + "eigfouershgoseiyg ");
            }


            double Resistance = R4 + R5 + R6;
            //The answer will be displayed by a a label.
            label8.Text = "Resistance = " +Resistance;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double R1 = 0;
            double R2 = 0;
            double R3 = 0;
            try
            {
                R1 = double.Parse(textBox1.Text);
                R2 = double.Parse(textBox2.Text);
                R3 = double.Parse(textBox3.Text);
            }
            catch
            {

            }

            string st = "three";
            try
            {
                int it = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st + ". ");
            }

            //The second part of the code, parallel, was done the same was as the first, but with the equations changed
            double Resistance = 1/(1/R1 + 1/R2 + 1/R3);
            //The answer will be displayed by a a label.
            label9.Text = "Resistance = " + Resistance;
        }
    }
}
