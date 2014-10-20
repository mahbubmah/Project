using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarsityAdmission.DLL.DAO;

namespace VarsityAdmission.DLL.GateWay
{
    class StudentGateway
    {
        private SqlConnection connection;
        private List<Student> showStudentData;
        private Student aStudent;

        public StudentGateway()
        {
            string connect = @"server=ASHIQ; database=VarsityAdmissionDB; integrated security=true";
            connection = new SqlConnection();
            connection.ConnectionString = connect;
        }
        public string Save(Student aStudent)
        {
           
            connection.Open();
            string query = string.Format("INSERT INTO t_Student VALUES('{0}','{1}','{2}','{3}')",aStudent.RegNO,aStudent.Name,aStudent.Email,aStudent.Coursetitle);
            
            SqlCommand command=new SqlCommand(query,connection);
            int affectedrow = command.ExecuteNonQuery();
            connection.Close();
            if (affectedrow > 0)
            {
                return "enrolled";
            }
            else
            {
                return "something wrong";
            }
        }


        public bool CheckRegNO(string regNo)
        {
           
            connection.Open();
            string query = string.Format("SELECT * FROM t_Student WHERE RegNo='{0}'",regNo);

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool hasrow = aReader.HasRows;
            connection.Close();
            if (hasrow)
            {
                return true;
            }
            return false;
        }

        public List<Student> ShowStudentData()
        {

            connection.Open();
            string query = string.Format("SELECT * FROM t_Student");

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            showStudentData = new List<Student>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aStudent = new Student();
                    aStudent.RegNO = aReader[1].ToString();
                    aStudent.Name = aReader[2].ToString();
                    aStudent.Email = aReader[3].ToString();
                    aStudent.Coursetitle = aReader[4].ToString();
                    showStudentData.Add(aStudent);
                }
            }
            connection.Close();
            return showStudentData;

        }

        public bool CheckCoursetitle(string coursetitle)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Student WHERE CourseTitle='{0}'", coursetitle);

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool hasrow = aReader.HasRows;
            connection.Close();
            if (hasrow)
            {
                return true;
            }
            return false;
        }

        public Student GetStudent(string regNo)
        {
            
            connection.Open();
            string query = string.Format("SELECT * FROM t_Student");

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aStudent = new Student();
                    aStudent.RegNO = aReader[1].ToString();
                    aStudent.Name = aReader[2].ToString();
                    aStudent.Email = aReader[3].ToString();
                    aStudent.Coursetitle = aReader[4].ToString();
                    
                }
            }
            connection.Close();
            return aStudent;
        }

        public Student GetStudent(Student aStudent)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Student WHERE Name='{0}'",aStudent.Name);

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aStudent = new Student();
                    aStudent.RegNO = aReader.GetValue(1).ToString();
                    aStudent.Name = aReader.GetValue(2).ToString();
                    aStudent.Email = aReader.GetValue(3).ToString();
                    aStudent.Score = aReader.GetValue(4).ToString();


                }
            }
            connection.Close();
            return aStudent;
        }

        public string SaveWithScore(Student aStudent)
        {
            string score = aStudent.Score;
            string regNo = aStudent.RegNO;
            connection.Open();
            string query = string.Format("UPDATE t_Student SET CourseScore='{0}'" + "WHERE RegNo='{1}'", score,
                regNo);
            SqlCommand command=new SqlCommand(query,connection);

            int affectedrow = command.ExecuteNonQuery();
            connection.Close();
            if (affectedrow > 0)
            {
                return "Score added";
            }
            else
            {
                return "something wrong";
            }

        }

       
    }
}
