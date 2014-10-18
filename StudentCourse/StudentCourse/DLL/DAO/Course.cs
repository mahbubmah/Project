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

        public Course(string code, string score):this()
        {
            Code = code;
            Score = score;
        }

        public Course()
        {

        }
    }
}
