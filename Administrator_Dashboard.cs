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
    public partial class Administrator_Dashboard : Form
    {
        public Administrator_Dashboard()
        {
            InitializeComponent();
        }

        DBConnection database = new DBConnection();

        private bool Entering()
        {
            //Opening connection to database
            database.openconnect();

            //Setting data to database
            MySqlCommand newAppliance = new MySqlCommand("insert into Appliances (Appliance_Name, Appliance_Brand, Appliance_Category, Appliance_Quantity, Appliance_Price) values (@Appliance_name_box, @Appliance_brand_box, @Appliance_category_cbox, @Appliance_quantity_box, @Appliance_price_box)", database.getconnection());
            newAppliance.Parameters.Add("@Appliance_name_box", MySqlDbType.VarChar).Value = Appliance_name_box.Text;
            newAppliance.Parameters.Add("@Appliance_brand_box", MySqlDbType.VarChar).Value = Appliance_brand_box.Text;
            newAppliance.Parameters.Add("@Appliance_category_cbox", MySqlDbType.VarChar).Value = Appliance_category_cbox.SelectedItem.ToString();
            newAppliance.Parameters.Add("@Appliance_quantity_box", MySqlDbType.VarChar).Value = Appliance_quantity_box.Text;
            newAppliance.Parameters.Add("@Appliance_price_box", MySqlDbType.VarChar).Value = Appliance_price_box.Text;

            if (newAppliance.ExecuteNonQuery() == 1)
            {
                return true;
            }

            else
            {
                return false;
            }
        }


        private void admin_add_button_Click(object sender, EventArgs e)
        {

            //Checking if entry boxes are not empty
            if (Appliance_name_box.Text == "" || Appliance_brand_box.Text == "" || Appliance_quantity_box.Text == "" || Appliance_price_box.Text == "" || Appliance_category_cbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter all details");
            }

            else
            {
                try
                {
                    if (Entering() == true)
                    {
                        MessageBox.Show("Data entry successful");

                    }

                    else
                    {
                        MessageBox.Show("Data entry unseccessful");
                    }
                }

                catch (MySqlException failedEntry)
                {
                    database.openconnect();
                    MessageBox.Show(failedEntry.Message);
                }
            }
        }

        private void administratorlogout_picture_Click(object sender, EventArgs e)
        {
            //Confirming user logout
            DialogResult dialog = MessageBox.Show("Do you want to log out?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Admin AdminForm = new Admin();
                AdminForm.Show();
                this.Hide();
            }

            else if (dialog == DialogResult.No)
            {
                return;
            }
        }

        private void Administrator_Dashboard_Load(object sender, EventArgs e)
        {
            //Displaying data on datagridview fetched from database
            MySqlDataAdapter AppList = new MySqlDataAdapter("Select * from Appliances", database.getconnection());
            DataTable AppListStore = new DataTable();
            AppList.Fill(AppListStore);
            admin_datagridview.DataSource = AppListStore;

        }
    }
}
