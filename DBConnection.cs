using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dzaone_Appliance_Shop
{
    class DBConnection
    {
        MySqlConnection connect = new MySqlConnection("server=localhost; userID=root; password=; database=Dzaone_Appliances");


        public MySqlConnection getconnection()
        {
            return connect;
        }

        public void openconnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        public void closeconnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }
    }
}
