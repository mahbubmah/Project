using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarsityAdmission.DLL.DAO;
using VarsityAdmission.DLL.GateWay;

namespace VarsityAdmission.BLL
{
    class StudentBLL
    {
        StudentGateway aStudentGateway=new StudentGateway();
        public string save(Student aStudent)
        {
            if (aStudent.RegNO == "" || aStudent.Name == "" || aStudent.Email == "")
            {
                return "please fill up fields";
            }
            else
            {
                if (CheckRegNO(aStudent.RegNO) && CheckCourseTitle(aStudent.Coursetitle))
                    return "same course taken already";
            }
            
                    return aStudentGateway.Save(aStudent);
        }

        public bool CheckRegNO(string regNo)
        {
            return aStudentGateway.CheckRegNO(regNo);
        }

        public bool CheckCourseTitle(string coursetitle)
        {
            return aStudentGateway.CheckCoursetitle(coursetitle);
        }

        public List<Student> ShowStudentData()
        {
            return aStudentGateway.ShowStudentData();
        }


        public Student GetStudent(string regNo)
        {
            return aStudentGateway.GetStudent(regNo);
        }

        public Student GetStudent(Student aStudent)
        {
            
            return aStudentGateway.GetStudent(aStudent);


        }

        public string SaveWithScore(Student aStudent)
        {
            if (aStudent.RegNO == "" || aStudent.Name == "" || aStudent.Email == "")
            {
                return "please fill up fields";
            }
            else
            {
                return aStudentGateway.SaveWithScore(aStudent);
                    //return "same course takes already";
            }

            
        }


        
    }
}
