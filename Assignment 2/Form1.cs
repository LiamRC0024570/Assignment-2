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
            try
            {
                R4 = double.Parse(textBox4.Text);
                R4 = 0;
            }
            catch
            {

            }

            double R5 = 0;
            try
            {
                R5 = double.Parse(textBox5.Text);
                R5 = 0;
            }
            catch
            {

            }

            double R6 = 0;
            try
            {
                R6 = double.Parse(textBox6.Text);
                R6 = 0;
            }
            catch
            {

            }
            double Resistance = R4 + R5 + R6;
            label8.Text = "Resistance = "+;
           
        }
    }
}
