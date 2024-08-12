using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dzaone_Appliance_Shop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        DBConnection database = new DBConnection();

        private void Admin_button_Click(object sender, EventArgs e)
        {
            //Forwards to admin form
            Admin Administrator = new Admin();
            Administrator.Show();
            this.Hide();
        }

        private void Login_link_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Forwards to registration form
            Register registration = new Register();
            registration.Show();
            this.Hide();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            database.openconnect();

            string Username = username_box.Text;
            string Password = password_box.Text;
            string LoggingIn = " Select * from Users where Username = '"+ Username +"' and Password = '"+ Password +"' ";

            MySqlDataAdapter accountuser = new MySqlDataAdapter(LoggingIn, database.getconnection());
            DataTable userTable = new DataTable();
            accountuser.Fill(userTable);
            if (userTable.Rows.Count == 1)
            {
                Customer_Dashboard customerdash = new Customer_Dashboard();
                customerdash.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Account does not exist");
            }
        }
    }
}
