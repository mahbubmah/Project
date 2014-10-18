using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCourse.DLL.DAO;

namespace StudentCourse.DLL.GateWay
{
    class ResultEntryGateWay
    {
        ResultEntryGateWay aResultEntryGateWay=new ResultEntryGateWay();


        public string save(Student aStudent)
        {
            string RegNo = aStudent.RegNo;
            String Name = aStudent.Name;
            String Email=aStudent.Email;


            string conn = @"server=BITM-401-PC08\SQLEXPRESS; database=StudentCourse; integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = string.Format("INSERT INTO t_Shop VALUES('{0}','{1}','{2}',)", RegNo,Name,Email);
            SqlCommand command = new SqlCommand(query, connection);
            int affectedrow = command.ExecuteNonQuery();
            if (affectedrow > 0)
            {


                return "inserted successfully";
            }
            return "something is wrong";
        }
    }
}
