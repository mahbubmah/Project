using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourse.DLL.DAO
{
    class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }

        public Course(string title, string name)
            : this()
        {
            Title = title;
            Name = name;
        }
        public Course()
        {
        }
    }
}
