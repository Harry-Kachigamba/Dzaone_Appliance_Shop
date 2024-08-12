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
    public partial class Customer_Dashboard : Form
    {
        public Customer_Dashboard()
        {
            InitializeComponent();
        }

        DBConnection database = new DBConnection();

        private void customerlogout_picture_Click(object sender, EventArgs e)
        {
            //Confirming user logout
            DialogResult dialog = MessageBox.Show("Do you want to log out?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Login UserLog = new Login();
                UserLog.Show();
                this.Hide();
            }

            else if (dialog == DialogResult.No)
            {
                return;
            }
        }
    }
}
