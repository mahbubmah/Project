using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ResultSheetUI.DLL.GATEWAY
{
    internal class ResultSheetGateWay
    {
        public SqlConnection connection;

        public ResultSheetGateWay()
        {
            string conn = @"server=BITM-401-PC06\SQLEXPRESS; database=ResultSheet; integrated security=true";
            connection = new SqlConnection();
            connection.ConnectionString = conn;

        }

        public string Save(ResultSheet aResultSheet)
        {
            connection.open();
            string query = string.Format("INSERT INTO ResultSheet VALUES ('{0}','{1}','{2}','{3}')", aResultSheet.RegNo,
                aResultSheet.Name, aResultSheet.Email, aResultSheet.Score);
            SqlCommand command = new SqlCommand(query, connection);

            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRows > 0)
                return "insert success";
            return "something wrong";
        }

        public bool HasThisRegNoValid(string RegNo)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM ResultSheet WHERE RegNo='{0}'", RegNo);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }
    }
}
