using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentCourse.DLL.DAO;
using StudentCourse.BLL.CourseEnrollment;

namespace StudentCourse.UI
{
    public partial class CourseEnrollment : Form
    {
        public CourseEnrollment()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student();
            CourseEnrollmentBll aCourseEnrollmentBll = new CourseEnrollmentBll();
            aStudent=aCourseEnrollmentBll.HasThisStudentExist(regNoTextBox.Text);

            nameTextBox.Text = aStudent.Name;
            emailTextBox.Text = aStudent.Email;

        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student(regNoTextBox.Text,nameTextBox.Text,emailTextBox.Text);

            CourseEnrollmentBll aCourseEnrollmentBll=new CourseEnrollmentBll();

            string msg=aCourseEnrollmentBll.AddStudent(aStudent);

            MessageBox.Show(msg);


        }

      

      
    }
}
