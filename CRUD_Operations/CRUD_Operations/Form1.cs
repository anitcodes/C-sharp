using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CRUD_Operations
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Publicly defined SQL string to access from anywhere
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TMGR3BP\\SQLEXPRESS;Initial Catalog=CRUD_DB;Integrated Security=True;TrustServerCertificate=True");
        public int StudentID;//variable for studentID

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }

        //insert data of student to the datagrid view when this function is called
        private void GetStudentsRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from StudentsTb", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            StudentRecordDataGridView.DataSource = dt;

        }

        //Add details to database(Create)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentsTb VALUES (@name, @FatherName, @Roll, @Address, @Mobile)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtFullName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@Roll", txtRollNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobileNumber.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Student added sucessfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsRecord();//function called to store data to DataGridView when details are inserted and clicked on Add button
                ResetFormControls();
                txtFullName.Focus();
            }
        }

        private bool IsValid()//check if student name is given or not.. if not show error message
        {
            if(txtFullName.Text == string.Empty)
            {
                MessageBox.Show("Student Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        //Reset all the details of the form
        private void ResetFormControls()
        {
            StudentID = 0;
            txtFullName.Clear();
            txtFatherName.Clear();
            txtRollNumber.Clear();
            txtAddress.Clear();
            txtMobileNumber.Clear();

            txtFullName.Focus();
        }

        //dataGridView ko property ma gayeaara selection mode lai fullRowSelect garne
        //Ani event generator ma gayera cellclick event generate garne
        private void StudentRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = Convert.ToInt32(StudentRecordDataGridView.SelectedRows[0].Cells[0].Value);
            txtFullName.Text = StudentRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtFatherName.Text = StudentRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtRollNumber.Text = StudentRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtAddress.Text = StudentRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtMobileNumber.Text = StudentRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE StudentsTb SET Name=@name, FatherName=@FatherName, RollNumber=@Roll, Address=@Address, Mobile=@Mobile WHERE StudentID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtFullName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@Roll", txtRollNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobileNumber.Text);
                cmd.Parameters.AddWithValue("@ID", this.StudentID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student details updated sucessfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsRecord();//function called to store data to DataGridView when details are inserted and clicked on Add button
                ResetFormControls();
                txtFullName.Focus();
            }

            else
            {
                MessageBox.Show("Please select an student to update", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Delete Student 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentsTb WHERE StudentID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.StudentID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student details updated sucessfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsRecord();//function called to store data to DataGridView when details are inserted and clicked on Add button
                ResetFormControls();
                txtFullName.Focus();
            }
            else
            {
                MessageBox.Show("Please select an student to delete", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
