using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;




namespace Login_and_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        SqlConnection con = new SqlConnection(@"Data Source=XAHIN7-9K4ZX\SQLEXPRESS;Initial Catalog=db_users;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '.';
                txtConfirmPassword.PasswordChar = '.';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmLogin login= new frmLogin();
            login.Show();
            this.Hide();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text =="" && txtPassword.Text == "" && txtConfirmPassword.Text=="")
            {
                MessageBox.Show("Username and Password is empty","Signup failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (txtPassword.Text==txtConfirmPassword.Text)
            {
               // con.Open();
               // string register = "INSERT INTO tbl_user VALUES ('"+txtUsername.Text+"','"+txtPassword.Text+"')";
               // cmd= new SqlCommand(register,con);
          
                //MyWay
                 
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_users VALUES (@username,@password)",con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your Account has been successfully created","Registration Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password does not match, re-enter Password","Regi Faild",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtPassword.Focus();
            }
        }
    }
}
