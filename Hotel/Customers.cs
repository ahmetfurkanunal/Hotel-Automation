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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        SqlConnection connection=new SqlConnection(@"Data Source=DESKTOP-3399AHH;Initial Catalog=WelcomeToHotel;Integrated Security=True");

        private void showvariable()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from AddCustomers", connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {

                ListViewItem add = new ListViewItem();
                add.Text = read["CustomerId"].ToString();
                add.SubItems.Add(read["Name"].ToString());
                add.SubItems.Add(read["Surname"].ToString());
                add.SubItems.Add(read["Male"].ToString());
                add.SubItems.Add(read["Number"].ToString());
                add.SubItems.Add(read["Mail"].ToString());
                add.SubItems.Add(read["IdentityNumber"].ToString());
                add.SubItems.Add(read["Amount"].ToString());
                add.SubItems.Add(read["RoomNo"].ToString());
                add.SubItems.Add(read["DateOfEntry"].ToString());
                add.SubItems.Add(read["DateOfRelease"].ToString());

                listView1.Items.Add(add);
            }
            connection.Close();
        }
        private void Customers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showvariable();
        }

        int id=0;   

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id= int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
           TxtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSurname.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            mskTextNo.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtIdentity.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtRoomNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtAmount.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpEntry.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpRelease.Text = listView1.SelectedItems[0].SubItems[10].Text; 
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from AddCustomers where CustomerID=@id",connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
            showvariable();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtSurname.Clear();
            comboBox2.Text = "";
            mskTextNo.Clear();
            txtMail.Text = "";
            txtIdentity.Clear();
            txtRoomNo.Clear();
            txtAmount.Clear();
            dtpEntry.Text = "";
            dtpRelease.Text = "";

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" UPDATE AddCustomers SET Name = @Name, Surname= @Surname, Male= @Male ,Number=@Number ,Mail=@Mail ,IdentityNumber=@IdentityNumber,Amount=@Amount,RoomNo=@RoomNo,DateOfRelease=@DateOfRelease,DateOfEntry=@DateOfEntry WHERE CustomerID = @id ", connection);
            connection.Open();
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Name", TxtName.Text);
            command.Parameters.AddWithValue("@Surname", TxtSurname.Text);
            command.Parameters.AddWithValue("@Male", comboBox2.SelectedText);
            command.Parameters.AddWithValue("@Mail", txtMail.Text);
            command.Parameters.AddWithValue("@Number", mskTextNo.SelectedText);
            command.Parameters.AddWithValue("@IdentityNumber", txtIdentity.Text);
            command.Parameters.AddWithValue("@Amount", txtAmount.Text);
            command.Parameters.AddWithValue("@RoomNo", txtRoomNo.Text);
            command.Parameters.AddWithValue("@DateOfRelease", dtpRelease.Text);
            command.Parameters.AddWithValue("@DateOfEntry", dtpEntry.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Updated Variables");
            showvariable();
        }
    }
}
