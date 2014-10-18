using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourse.DLL.DAO
{
    class Course
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public string Score { get; set; }
        public string Grade { get; set; }

        public Course(string title, string score, string code, string grade):this()
        {
            Title = title;
            Score = score;
            Code = code;
            Grade = grade;
        }

        public Course(string score):this()
        {
            Score = score;
        }

        public Course()
        {
        }
    }
}
