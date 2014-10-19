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

        public string EnrollCourse(Student aStudent)
        {


            if (aStudent.RegNo == string.Empty)
                return "please Enter Reg No";
            else
            {

                if (aCourseEnrollmentGateWay.HasThisStudentValid(aStudent.RegNo))
                {
                    return aCourseEnrollmentGateWay.Enroll(aStudent);
                    
                }
                else
                {
                    return "Please Enter Valid Reg No";
                }

            }

        }

        public Student HasThisStudentExist(string regNo)
        {
            return aCourseEnrollmentGateWay.HasThisStudentExist(regNo);
        }

        public List<Course> GetCourse()
        {
            return aCourseEnrollmentGateWay.GetCourse();
        }
    }
}
