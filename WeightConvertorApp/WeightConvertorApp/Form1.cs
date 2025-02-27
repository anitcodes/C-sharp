using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightConvertorApp
{
    public partial class Form1: Form
    {
   
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKg.Text = "";
            label3.Text = "Converted value is: ";
        }

        private void txtKg_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int kg,  result;
            kg = int.Parse(txtKg.Text);
            result = kg * 1000;

            label3.Text = "Converted value is: " + result;
        }
    }
}
