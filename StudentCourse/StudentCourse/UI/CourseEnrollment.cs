using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentCourse.BLL;
using StudentCourse.DLL.DAO;

namespace StudentCourse.UI
{
    public partial class CourseEnrollment : Form
    {
        EnrollmentBLL anEnrollmentBll = new EnrollmentBLL();
        public CourseEnrollment()
        {
            InitializeComponent();
            AddCoursesToComboBox();

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student();
            EnrollmentBLL aCourseEnrollmentBll = new EnrollmentBLL();
            try
            {
                aStudent = aCourseEnrollmentBll.Find(regNoTextBox.Text);

                nameTextBox.Text = aStudent.Name;
                emailTextBox.Text = aStudent.Email;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No match found");
            }
            

        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            
            Student aStudent=new Student(regNoTextBox.Text,nameTextBox.Text,emailTextBox.Text);
            Course aCourse = (Course)courseComboBox.SelectedItem;
            try
            {
                Enrollment anEnrollment = new Enrollment();
                anEnrollment.DateTime = courseEnrollmentDateTimePicker.Value;
                anEnrollment.AStudent = aStudent;
                anEnrollment.ACourse = (Course)courseComboBox.SelectedItem;
                string msg = anEnrollmentBll.Enroll(anEnrollment);
                MessageBox.Show(msg);
                enrolledCoursesListView.Items.Clear();
                enrolledCoursesListView.Items.Add(anEnrollmentBll.lvi);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select course to Enroll");
            }
            
        }

        private void AddCoursesToComboBox()
        {
            courseComboBox.DisplayMember = "Name";
            courseComboBox.ValueMember = "Id";

            List<Course> aCoursesList = anEnrollmentBll.GetAllCourse();

            foreach (Course course in aCoursesList)
            {
                courseComboBox.Items.Add(course);
            }
        }

      

      
    }
}
