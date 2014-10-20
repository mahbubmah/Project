using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TrainingCenterApp.DAL.DAO;

namespace TrainingCenterApp.DAL.Gateway
{
    internal class CourseEnrollmentGateway
    {
        private SqlConnection connection;

        public CourseEnrollmentGateway()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        }

        public Student Find(string regNo)
        {
            Student aStudent = new Student();
            connection.Open();
            string qurey = string.Format("SELECT * FROM t_Student WHERE RegNo='{0}'", regNo);
            SqlCommand cmd = new SqlCommand(qurey, connection);
            SqlDataReader aReader = cmd.ExecuteReader();
            bool HasRow = aReader.HasRows;
            if (HasRow)
            {
                while (aReader.Read())
                {
                    aStudent.Id = (int) aReader[0];
                    aStudent.RegNo = aReader[1].ToString();
                    aStudent.Name = aReader[2].ToString();
                    aStudent.Email = aReader[3].ToString();
                }
            }
            connection.Close();
            return aStudent;
        }

        public string EnrollCourse(CourseEnrollment anCourseEnrollment)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_Enrollment VALUES ({0},{1},'{2}')", anCourseEnrollment.AStudent.Id,anCourseEnrollment.ACourse.Id, anCourseEnrollment.DateTime);
            SqlCommand cmd = new SqlCommand(query,connection);
            int affectedrow = cmd.ExecuteNonQuery();
            connection.Close();
            if (affectedrow > 0)
            {
                return "Enrollment Success";
            }
            return "Something went wrong";
        }

        public bool HasThisStudentInCourse(Student aStudent,Course aCourse)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Enrollment WHERE StudentId={0} AND CourseId={1}", aStudent.Id,aCourse.Id);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader aDataReader = cmd.ExecuteReader();
            bool Hasrow = aDataReader.HasRows;
            connection.Close();
            return Hasrow;
        }

        public List<Course> GetAllCourse()
        {
            Course aCourse;
            connection.Open();
            string qurey = string.Format("SELECT * FROM t_Course");
            SqlCommand cmd = new SqlCommand(qurey, connection);
            SqlDataReader aReader = cmd.ExecuteReader();
            List<Course> courses = new List<Course>();
            bool HasRow = aReader.HasRows;
            if (HasRow)
            {
                while (aReader.Read())
                {
                    aCourse = new Course();
                    aCourse.Id = (int) aReader[0];
                    aCourse.Name = aReader[1].ToString();
                    aCourse.Title = aReader[2].ToString();
                    courses.Add(aCourse);
                }
            }
            connection.Close();
            return courses;
        }

        public CourseEnrollment GetEnrolledStudent(Student aStudent, Course aCourse)
        {
            connection.Open();
            string qurey = string.Format("SELECT * From v_SCEnrollment WHERE StudentId={0} AND CourseId={1}", aStudent.Id, aCourse.Id);
            SqlCommand cmd = new SqlCommand(qurey, connection);
            SqlDataReader aReader = cmd.ExecuteReader();
            CourseEnrollment courseEnrollment = new CourseEnrollment();
            bool HasRow = aReader.HasRows;
            if (HasRow)
            {
                
                while (aReader.Read())
                {
                    courseEnrollment.ACourse = new Course();
                    courseEnrollment.AStudent = new Student();

                    courseEnrollment.Id = (int) aReader[0];
                    courseEnrollment.CourseId = (int) aReader[1];
                    courseEnrollment.StudentId = (int) aReader[2];
                    courseEnrollment.ACourse.Id = (int) aReader[3];
                    courseEnrollment.ACourse.Name = aReader[4].ToString();
                    courseEnrollment.ACourse.Title = aReader[5].ToString();
                    courseEnrollment.AStudent.Id = (int) aReader[6];
                    courseEnrollment.AStudent.RegNo = aReader[7].ToString();
                    courseEnrollment.AStudent.Name = aReader[8].ToString();
                    courseEnrollment.AStudent.Email = aReader[9].ToString();
                    courseEnrollment.DateTime = (DateTime) aReader[10];
                }
            }
            connection.Close();
            return courseEnrollment;
        }
    }
}
