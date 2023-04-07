using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetGuestRecord();
        }

        private void GetGuestRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=XAHIN7-9K4ZX\SQLEXPRESS;Initial Catalog=forCrud;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from GuestTable",con);

            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            GuestRecordDataGirdView.DataSource= dt;


        }
         
 
 
 
    }
}
