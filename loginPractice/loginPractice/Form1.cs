using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginPractice
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                txtPassword.PasswordChar = '\0'; //show password
            }
            else
            {
                txtPassword.PasswordChar = '*';//hide password
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                MessageBox.Show("Admin Verification Successful....");
                Form2 fm1 = new Form2();
                fm1.Show();
                this.Hide();
            }
            else if(txtUsername.Text == "staff" && txtPassword.Text == "staff")
            {
                MessageBox.Show("Staff Verification Successfull..");
                Form3 fm2 = new Form3();
                fm2.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Add username & password");
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!!", "Error", MessageBoxButtons.RetryCancel);
            }
        }
    }
}
