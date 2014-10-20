using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingCenterApp.BLL;
using TrainingCenterApp.DAL.DAO;

namespace TrainingCenterApp.UI
{
    public partial class EnrollmentEntryUI : Form
    {
        private CourseEnrollmentBLL aCourseEnrollmentBll = new CourseEnrollmentBLL();
        private CourseEnrollment anCourseEnrollment;
        private Student aStudent;

        public EnrollmentEntryUI()
        {
            InitializeComponent();
            PutCoursesInComboBox();
        }
        private void findButton_Click(object sender, EventArgs e)
        {
            aStudent = aCourseEnrollmentBll.Find(regNoTextBox.Text);
            nameTextBox.Text = aStudent.Name;
            emailTextBox.Text = aStudent.Email;
        }
        private void PutCoursesInComboBox()
        {
            List<Course> courses = aCourseEnrollmentBll.GetAllCourse();
            foreach (Course aCourse in courses)
            {
                courseComboBox.Items.Add(aCourse);
            }
            courseComboBox.DisplayMember = "Name";
            courseComboBox.ValueMember = "Id";
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            anCourseEnrollment = new CourseEnrollment();


            anCourseEnrollment.DateTime = enrollmentDtateTimePicker.Value;
            anCourseEnrollment.AStudent = aStudent;
            anCourseEnrollment.ACourse = (Course) courseComboBox.SelectedItem;


            string msg=aCourseEnrollmentBll.Enroll(anCourseEnrollment);


            MessageBox.Show(msg);


            enrolledCourseListView.Items.Clear();
            enrolledCourseListView.Items.Add(aCourseEnrollmentBll.AListViewItem);
            

        }
    }
}
