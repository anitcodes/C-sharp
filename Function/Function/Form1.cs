using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function
{
    public partial class Form1: Form
    {
        public void one()
        {
            MessageBox.Show("You are a good Hearted Person :)");
        }

        public void two()
        {
            MessageBox.Show("You are a bad Hearted Person :(");
        }

        public void three()
        {
            MessageBox.Show("You are will be reach one day :)");
        }
        public void four()
        {
            MessageBox.Show("You are a Cycopath!!");
        }
        public void five()
        {
            MessageBox.Show("You will marry at the age of 23");
        }
        public void six()
        {
            MessageBox.Show("You will get a surprise from your close one today");
        }
        public void seven()
        {
            MessageBox.Show("I love you:)");
        }
        public void eight()
        {
            MessageBox.Show("You are a selfish person");
        }
        public void nine()
        {
            MessageBox.Show("I hate you");
        }
        public void ten()
        {
            MessageBox.Show("Your visa will be accepted soon!");
        }
        public void eleven()
        {
            MessageBox.Show("You will have 4 babies");
        }
        public void twelve()
        {
            MessageBox.Show("Thank you for choosing me!! You got no message");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            one();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            two();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            three();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            four();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            five();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            six();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seven();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            eight();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            nine();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ten();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            eleven();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            twelve();
        }
    }
}
