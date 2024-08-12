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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void register_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //When clicked forwards to the Login form
            Login log3 = new Login();
            log3.Show();
            this.Hide();
        }

        //Database connection
        DBConnection database = new DBConnection();

        private bool Registration()
        {
            //Opening connection to database
            database.openconnect();

            //Setting data to database
            MySqlCommand newUser = new MySqlCommand("insert into Users values (@register_username_box, @register_password_box)", database.getconnection());
            MySqlCommand newCustomer = new MySqlCommand("insert into Customers (Firstname, Lastname, Email, Username) values (@register_firstname_box, @register_lastname_box, @email_box, @register_username_box)", database.getconnection());
            newUser.Parameters.Add("@register_username_box", MySqlDbType.VarChar).Value = register_username_box.Text;
            newUser.Parameters.Add("@register_password_box", MySqlDbType.VarChar).Value = register_password_box.Text;
            newCustomer.Parameters.Add("@register_firstname_box", MySqlDbType.VarChar).Value = register_firstname_box.Text;
            newCustomer.Parameters.Add("@register_lastname_box", MySqlDbType.VarChar).Value = register_lastname_box.Text;
            newCustomer.Parameters.Add("@email_box", MySqlDbType.VarChar).Value = email_box.Text;
            newCustomer.Parameters.Add("@register_username_box", MySqlDbType.VarChar).Value = register_username_box.Text;
            

            if (newUser.ExecuteNonQuery() == 1 && newCustomer.ExecuteNonQuery() == 1)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            //Checking all fields are filled
            if (register_firstname_box.Text == "" || register_lastname_box.Text == "" || email_box.Text == "" || register_username_box.Text == "" || register_password_box.Text == "")
            {
                MessageBox.Show("Please enter all the details");
                return;
            }
            
            //Checking if passwords match
            if (register_password_box.Text != confirmpassword_label.Text)
            {
                MessageBox.Show("Password does not match");
                confirmpassword_label.Focus();
                return;
            }

            //Dialogbox for if registration is successfull or not
            try
            {
                if (Registration() == true)
                {
                    MessageBox.Show("Registration Successful");
                }

                else
                {
                    MessageBox.Show("Registration Failed");
                }
            }

            catch (MySqlException failedEntry)
            {
                database.openconnect();
                MessageBox.Show(failedEntry.Message);
                MySqlCommand deleteuser = new MySqlCommand("delete from Users where Username = @register_username_box", database.getconnection());
                deleteuser.Parameters.AddWithValue("@register_username_box", register_username_box.Text);
                deleteuser.ExecuteNonQuery();
            }
        }
    }
}
