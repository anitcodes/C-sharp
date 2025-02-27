using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentDetail
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData() //for dataGridView to show details of database
        {
            try
            {
                // Create a connection to the database
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-TMGR3BP\\SQLEXPRESS;Initial Catalog=StudentDetails;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    // Create a SqlDataAdapter to fetch data from the 'ut' table
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ut", con))
                    {
                        // Create a DataTable to store the fetched data
                        DataTable dt = new DataTable();

                        // Fill the DataTable with the fetched data
                        da.Fill(dt);

                        // Bind the DataTable to the DataGridView to display the data
                        studentRecords.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TMGR3BP\\SQLEXPRESS;Initial Catalog=StudentDetail;Integrated Security=True;TrustServerCertificate=True"); //This is connection string
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ut values(@id,@name,@address)", con); //ut is the table name
            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added Sucessfully...");
            //To clear the textbox after data is inserted sucessfully
            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            LoadData();//Load the contents of database in datagrid view
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TMGR3BP\\SQLEXPRESS;Initial Catalog=StudentDetail;Integrated Security=True;TrustServerCertificate=True"); //This is connection string
            con.Open();
            SqlCommand cmd = new SqlCommand("update ut set name=@name, address=@address where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully updated");
            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TMGR3BP\\SQLEXPRESS;Initial Catalog=StudentDetail;Integrated Security=True;TrustServerCertificate=True"); //This is connection string
            con.Open();
            SqlCommand cmd = new SqlCommand("delete ut where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully deleted");
            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TMGR3BP\\SQLEXPRESS;Initial Catalog=StudentDetail;Integrated Security=True;TrustServerCertificate=True"); //This is connection string
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ut where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentRecords.DataSource = dt;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
