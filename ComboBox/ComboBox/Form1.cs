using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1: Form
    {
        public void reset()
        {
            txtAdd.Text = "";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAdd.Text != "")
            {
                if(cmbCity.Items.Contains(txtAdd.Text))
                {
                    MessageBox.Show("This Item Already Exist");
                }
                else
                {
                    //cmbCity.Items.Add("kathmandu");
                    cmbCity.Items.Add(txtAdd.Text);
                    cmbCity.Sorted = true;// arranges items in alphabatical order
                    reset();
                    txtAdd.Focus();

                }
            }
            else
            {
                MessageBox.Show("Can't add empty items!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = cmbCity.Items.Count;
            MessageBox.Show("Total Items in ComboBox = " + count);
            txtAdd.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text != "" || cmbCity.Text != "")//if textbox or combobox ma kunai auta empty xaina vane item delete garna milxa
            {
                cmbCity.Items.Remove(cmbCity.SelectedItem);// combobox ma select gareko item delete hunxa
            //cmbCity.Items.Remove(txtAdd.Text);//textbox ma lekheko city delete hunxa
            }
            else
            {
                MessageBox.Show("Please enter the city to be removed!!");
            }
                reset();
            txtAdd.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbCity.Items.Clear();
        }

        private void btnSorted_Click(object sender, EventArgs e)
        {
            cmbCity.Sorted = true;
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "Selected City is : " + cmbCity.SelectedItem.ToString();
        }
    }
}
