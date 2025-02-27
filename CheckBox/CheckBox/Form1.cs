using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1: Form
    {
        string text1 = "";
        string text2 = "";
        string text3 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                text1 = checkBox1.Text;
            }
            else
            {
                text1 = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                text2 = checkBox2.Text;
            }
            else
            {
                text2 = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                text1 = checkBox3.Text;
            }
            else
            {
                text3 = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Selected Hobbies is : " + text1 + " " + text2 + " " + text3);
        }
    }
}
