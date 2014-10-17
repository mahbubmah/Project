using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Super_Shop_App.BLL
{
    class ShopGateWay
    {

        private SqlConnection connection;
        private string TABLE_NAME1;


        public ShopGateWay()
        {


            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["con"];

            string connectionString = "";

            if (settings != null)
                connectionString = settings.ConnectionString;
            
            TABLE_NAME1 = "table_Shop";


            connection = new SqlConnection();
            connection.ConnectionString = connectionString;

        }

        public int Save(Shop aShop)
        {
            connection.Open();

            string query = string.Format("INSERT INTO {2} VALUES('{0}','{1}');"
                ,aShop.Name ,aShop.Address,TABLE_NAME1);



            
            query.Replace("INSERT", "insert");

            MessageBox.Show(query);

            SqlCommand command = new SqlCommand(query ,connection);
            
            int affectedRow = command.ExecuteNonQuery();


            connection.Close();

            return affectedRow;
        }
    }
}
