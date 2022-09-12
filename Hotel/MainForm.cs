﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenScreen cs=new OpenScreen();
            cs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewCustomer cs = new NewCustomer();
            cs.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customers customer=new Customers();
            customer.Show(); 
            
        }
    }
}
