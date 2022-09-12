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
    public partial class Customer : Form
    {
        public object TxtUcret { get; private set; }
        public int BuyukTarih { get; private set; }
        public int KucukTarih { get; private set; }

        public Customer()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-3399AHH;Initial Catalog=WelcomeToHotel;Integrated Security=True");
        private object comboBox1;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRoom101_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "101";
        }

        private void btnRoom102_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "102";
        }

        private void btnRoom103_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "103";
        }

        private void btnRoom201_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "201";
        }

        private void btnRoom202_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "202";
        }

        private void btnRoom203_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "203";
        }

        private void btnRoom301_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "301";
        }

        private void btnRoom302_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "302";
        }

        private void btnRoom303_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "303";
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Green Room is show Free Room");
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Red Room is show FullRoom");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = SqlCommand("İnsert İnto  AddCustomer(Name,Surname,Male) values ('" + TxtName.Text + "','" + TxtSurname.Text + "','" + comboBox2.Text + "') ", connection);
            komut.ExecuteNonQuery();
            connection.Close(); 
        }

        private SqlCommand SqlCommand(object value, SqlConnection connection)
        {
            throw new NotImplementedException();
        }

        private SqlCommand SqlCommand(string v1, object value, string v2, SqlConnection connection)
        {
            throw new NotImplementedException();
        }

        private void txtIdentity_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpRelease_ValueChanged(object sender, EventArgs e)
        {
            int amount;

            DateTime KucukTarih = Convert.ToDateTime(dtpEntry.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dtpRelease.Text);


            TimeSpan Conclusion;
            Conclusion = BuyukTarih - KucukTarih;

         
        label10.Text = Conclusion.ToString();   
            
            
            amount =Convert.ToInt32(label10.Text)*50;
            txtAmount.Text=amount.ToString();
            
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}


//Data Source=DESKTOP-3399AHH;Initial Catalog=WelcomeToHotel;Integrated Security=True