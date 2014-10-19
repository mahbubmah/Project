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
            courseComboBox.DisplayMember = "Title";
            List<Course> aCoursesList=new List<Course>();

            CourseEnrollmentBll aCourseEnrollmentBll = new CourseEnrollmentBll();
            aCoursesList=aCourseEnrollmentBll.GetCourse();

            foreach (Course course in aCoursesList)
            {
                courseComboBox.Items.Add(course);
            }
            
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

            string msg=aCourseEnrollmentBll.EnrollCourse(aStudent);

            MessageBox.Show(msg);


        }

      

      
    }
}
