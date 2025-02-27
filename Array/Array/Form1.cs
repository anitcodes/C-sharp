using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        //One Dimentional Array

            //int[] num = new int[5] {13,25,37,42,59}; //Integer type array
            //listBox1.Items.Add(num[0]);
            //listBox1.Items.Add(num[1]);
            //listBox1.Items.Add(num[2]);
            //listBox1.Items.Add(num[3]);
            //listBox1.Items.Add(num[4]);

            //String[] num = new String[3] { "Anit", "Mamata", "Shila" };//string type string
            //listBox1.Items.Add(num[0]);//it prints Anit when clicked on fill button

            //int[] num = new int[3]; //another method of declaring array
            //num[0] = 3;
            //num[1] = 5;
            //num[2] = 9;
            //listBox1.Items.Add(num[0]);

                         //Two Dimentional Array

            //int[,] num = new int[2, 2] { { 22,44 }, { 23,55 } };//2D array 
            //listBox1.Items.Add(num[0, 0]);
            //listBox1.Items.Add(num[0, 1]);
            //listBox1.Items.Add(num[1, 0]);
            //listBox1.Items.Add(num[1, 1]);

            //Another Method of 2D Array
            //int[,] num = new int[2, 2];
            //num[0, 0] = 2;
            //num[0, 1] = 3;
            //num[1, 0] = 4;
            //num[1, 1] = 5;
            //listBox1.Items.Add(num[0, 0]);
            //listBox1.Items.Add(num[0, 1]);
            //listBox1.Items.Add(num[1, 0]);
            //listBox1.Items.Add(num[1, 1]);
        }
    }
}
