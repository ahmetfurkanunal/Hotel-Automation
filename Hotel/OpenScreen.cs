using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class OpenScreen : Form
    {
        public OpenScreen()
        {
            InitializeComponent();
        }

        private void OpenScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="admin" && txtPassword.Text=="12345"){
                MainForm fr = new MainForm();
                fr.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Username or Password wrong.");
            }
                
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
