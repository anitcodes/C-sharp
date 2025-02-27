using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtons
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                MessageBox.Show("You are Nepali");
            }
            else if(radioButton2.Checked == true)
            {
                MessageBox.Show("You are Indian");
            }
            else if(radioButton3.Checked == true)
            {
                MessageBox.Show("You are American");
            }
            else if(radioButton4.Checked == true)
            {
                MessageBox.Show("You are Japanese");
            }
            else
            {
                MessageBox.Show("Please select a country");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton5.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Yellow;
            }
            else if(radioButton6.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Green;
            }
            else if (radioButton7.Checked == true)
            {
                this.BackColor = System.Drawing.Color.White;
            }
            else if (radioButton8.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                MessageBox.Show("i dont know");
            }
        }
    }
}
