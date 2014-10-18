using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using StudentCourse.DLL.DAO;
using StudentCourse.DLL.GateWay.CourseEnrollment;

namespace StudentCourse.BLL.CourseEnrollment
{
    class CourseEnrollmentBll
    {
        private CourseEnrollmentGateWay aCourseEnrollmentGateWay;

        public CourseEnrollmentBll()
        {
            aCourseEnrollmentGateWay=new CourseEnrollmentGateWay();
        }

        public string AddStudent(Student aStudent)
        {


            if (aStudent.Name == string.Empty || aStudent.RegNo == string.Empty || aStudent.Email == string.Empty)
                return "please fill all field";
            else
            {

                if (aCourseEnrollmentGateWay.HasThisStudentValid(aStudent.RegNo))
                {
                    return "This RegNo is already exist. Try another";
                }
                else
                {
                    return aCourseEnrollmentGateWay.Enroll(aStudent);
                }

            }

        }

        public Student HasThisStudentExist(string regNo)
        {
            return aCourseEnrollmentGateWay.HasThisStudentExist(regNo);
        }
    }
}
