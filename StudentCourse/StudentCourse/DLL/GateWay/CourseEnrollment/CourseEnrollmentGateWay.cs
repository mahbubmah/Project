using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCourse.DLL.DAO;

namespace StudentCourse.DLL.GateWay.CourseEnrollment
{
    class CourseEnrollmentGateWay
    {
        private SqlConnection connection;
        public CourseEnrollmentGateWay()
        {
            

            string conn = @"server=MAHBUB; database=StudentCourse; integrated security=true";
            connection=new SqlConnection();
            connection.ConnectionString = conn;


        }

        public string Enroll(Student aStudent)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_Student VALUES('{0}','{1}','{2}')",aStudent.RegNo,aStudent.Name,aStudent.Email);
            SqlCommand command=new SqlCommand(query,connection);

            int affectedRows = command.ExecuteNonQuery();

            connection.Close();

            if (affectedRows > 0)
                return "Student Added";

            return "Some problem";


        }

        public Student HasThisStudentExist(string regNo)
        {
            Student aStudent=new Student();
            connection.Open();
            string query = string.Format("SELECT * FROM t_Student WHERE RegNo='{0}'", regNo);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            aReader.Read();

            aStudent.RegNo = aReader[1].ToString();
            aStudent.Name = aReader[2].ToString();
            aStudent.Email = aReader[3].ToString();
            
            connection.Close();
            return aStudent;
        }

        public bool HasThisStudentValid(string regNo)
        {
           
            connection.Open();
            string query = string.Format("SELECT * FROM t_Student WHERE RegNo='{0}'", regNo);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }
    }

}
