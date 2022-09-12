using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Hotel
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }
       
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-3399AHH;Initial Catalog=WelcomeToHotel;Integrated Security=True");


        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //Room101
           
            connection.Open();
            SqlCommand command1 = new SqlCommand("select * from Room101", connection);
            SqlDataReader read1 = command1.ExecuteReader();

            while (read1.Read())
            {
                btnRoom101.Text = read1["Name"].ToString() + " " + read1["Surname"].ToString();
            }
            connection.Close();

            if (btnRoom101.Text != "101")
            {
                btnRoom101.BackColor = Color.Red;
                btnRoom101.Enabled = false;
            }

            //Room102
            connection.Open();
            SqlCommand command2 = new SqlCommand("select * from Room102", connection);
            SqlDataReader read2 = command2.ExecuteReader();

            while (read2.Read())
            {
                btnRoom102.Text = read2["Name"].ToString() + " " + read2["Surname"].ToString();
            }
            connection.Close();

            if (btnRoom102.Text != "102")
            {
                btnRoom102.BackColor = Color.Red;
                btnRoom102.Enabled = false;
            }

            //Room103
            connection.Open();
            SqlCommand command3 = new SqlCommand("select * from Room101", connection);
            SqlDataReader read3 = command3.ExecuteReader();

            while (read3.Read())
            {
                btnRoom103.Text = read3["Name"].ToString() + " " + read3["Surname"].ToString();
            }
            connection.Close();

            if (btnRoom103.Text != "103")
            {
                btnRoom103.BackColor = Color.Red;
                btnRoom103.Enabled = false;
            }

            //Room201
            connection.Open();
            SqlCommand command4 = new SqlCommand("select * from Room201", connection);
            SqlDataReader read4 = command4.ExecuteReader();

            while (read4.Read())
            {
                btnRoom201.Text = read4["Name"].ToString() + " " + read4["Surname"].ToString();
            }
            connection.Close();

            if (btnRoom201.Text != "201")
            {
                btnRoom201.BackColor = Color.Red;
                btnRoom201.Enabled = false;
            }
            //Room202
            connection.Open();
            SqlCommand command5 = new SqlCommand("select * from Room202", connection);
            SqlDataReader read5 = command5.ExecuteReader();

            while (read5.Read())
            {
                btnRoom202.Text = read5["Name"].ToString() + " " + read5["Surname"].ToString();
            }
            connection.Close();

            if (btnRoom202.Text != "2012")
            {
                btnRoom202.BackColor = Color.Red;
                btnRoom202.Enabled = false;
            }

            //Room203
            connection.Open();
            SqlCommand command6 = new SqlCommand("select * from Room203", connection);
            SqlDataReader read6 = command6.ExecuteReader();

            while (read6.Read())
            {
                btnRoom203.Text = read6["Name"].ToString() + " " + read6["Surname"].ToString();
            }
            connection.Close();

            if (btnRoom203.Text != "203")
            {
                btnRoom203.BackColor = Color.Red;
                btnRoom203.Enabled = false;
            }
            //Room301
            connection.Open();
            SqlCommand command7 = new SqlCommand("select * from Room203", connection);
            SqlDataReader read7 = command7.ExecuteReader();

            while (read7.Read())
            {
                btnRoom301.Text = read7["Name"].ToString() + " " + read7["Surname"].ToString();
            }
            connection.Close();

            if (btnRoom301.Text != "301")
            {
                btnRoom301.BackColor = Color.Red;
                btnRoom301.Enabled = false;
            }

            //Room302
            connection.Open();
            SqlCommand command8 = new SqlCommand("select * from Room203", connection);
            SqlDataReader read8 = command8.ExecuteReader();

            while (read8.Read())
            {
                btnRoom302.Text = read8["Name"].ToString() + " " + read8["Surname"].ToString();
            }
            connection.Close();

            if (btnRoom302.Text != "302")
            {
                btnRoom302.BackColor = Color.Red;

                btnRoom302.Enabled = false;
            }
            //Room303
            connection.Open();
            SqlCommand command9 = new SqlCommand("select * from Room203", connection);
            SqlDataReader read9 = command9.ExecuteReader();

            while (read9.Read())
            {
                btnRoom303.Text = read9["Name"].ToString() + " " + read9["Surname"].ToString();
            }
            connection.Close();

            if (btnRoom303.Text != "303")
            {
                btnRoom303.BackColor = Color.Red;
                btnRoom303.Enabled = false;
            }

        }

        private void btnRoom101_Click(object sender, EventArgs e)
        {
            
        }
    }
}
