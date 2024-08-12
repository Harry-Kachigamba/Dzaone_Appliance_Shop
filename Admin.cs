using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzaone_Appliance_Shop
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_cancel_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Clicking cancel goes to previous page
            Login log2 = new Login();
            log2.Show();
            this.Hide();
        }

        private void Admin_Login_button_Click(object sender, EventArgs e)
        {
           //Admin conditions to login
            if (Admin_textbox.Text == "Admin123")
            {
                Administrator_Dashboard AdminDash = new Administrator_Dashboard();
                AdminDash.Show();
                this.Hide();
            }

            else if (Admin_textbox.Text == "")
            {
                MessageBox.Show("Please enter password to Login!");
            }

            else
            {
                MessageBox.Show("Invalid Password");
            }
        }
    }
}
