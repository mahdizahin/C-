using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace CRUD_Operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=---ServerName----;Initial Catalog=test1;Integrated Security=True");

        public int StudentID;

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void GetStudentsRecord()
        {
          //  SqlConnection con = new SqlConnection(@"Data Source=---ServerName---;Initial Catalog=test1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from StudentsTb ",con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            StudentRecordDataGirdView.DataSource= dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentsTb Values(@Name, @FatherName,@Rool, @Address, @Mobile) ",con);
                cmd.CommandType= CommandType.Text;
                cmd.Parameters.AddWithValue("@name",txtStudentName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@Rool", txtRollNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Student is successfully saved in the database","saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
               
                GetStudentsRecord();
                ResetFromControls();
            }
        }

        private bool IsValid()
        {
             if(txtStudentName.Text==string.Empty)
            {
                MessageBox.Show("Student Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
             return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE StudentsTb SET Name = @Name, FatherName = @FatherName,RollNumber = @Rool, Address = @Address,Mobile = @Mobile WHERE StudentID = @ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@Rool", txtRollNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);

                cmd.Parameters.AddWithValue("@ID", this.StudentID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Updated successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsRecord();
                ResetFromControls();
            }
            else
            {
                MessageBox.Show("Select student to Update", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetFromControls();
        }

        private void ResetFromControls()
        {
            StudentID= 0;
            txtStudentName.Clear();
            txtFatherName.Clear();
            txtRollNumber.Clear();
            txtAddress.Clear();
            txtMobile.Clear();

            txtStudentName.Focus();
        }

        private void StudentRecordDataGirdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = Convert.ToInt32(StudentRecordDataGirdView.SelectedRows[0].Cells[0].Value);
            txtStudentName.Text = StudentRecordDataGirdView.SelectedRows[0].Cells[1].Value.ToString();
            txtFatherName.Text  = StudentRecordDataGirdView.SelectedRows[0].Cells[2].Value.ToString();
            txtRollNumber.Text  = StudentRecordDataGirdView.SelectedRows[0].Cells[3].Value.ToString();
            txtAddress.Text     = StudentRecordDataGirdView.SelectedRows[0].Cells[4].Value.ToString();
            txtMobile.Text      = StudentRecordDataGirdView.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE StudentsTb WHERE StudentID = @ID ", con);
                cmd.CommandType = CommandType.Text; 

                cmd.Parameters.AddWithValue("@ID", this.StudentID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Deleted successfully ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsRecord();
                ResetFromControls();
            }
            else
            {
                MessageBox.Show("Select student to Delete", "Delete?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
