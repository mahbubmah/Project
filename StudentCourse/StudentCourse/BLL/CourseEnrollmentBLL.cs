using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingCenterApp.DAL.DAO;
using TrainingCenterApp.DAL.Gateway;

namespace TrainingCenterApp.BLL
{

    class CourseEnrollmentBLL
    {
        private CourseEnrollmentGateway aCourseEnrollmentGateway;
        public CourseEnrollment ACouresCourseEnrollment { get; set; }
        public ListViewItem AListViewItem { get; set; }

        public CourseEnrollmentBLL()
        {
            aCourseEnrollmentGateway= new CourseEnrollmentGateway();

            AListViewItem = new ListViewItem("");
            AListViewItem.SubItems.Add("");
            AListViewItem.SubItems.Add("");
        }
        public Student Find(string regNo)
        {
            return aCourseEnrollmentGateway.Find(regNo);
        }

        public string Enroll(CourseEnrollment anCourseEnrollment)
        {
            if (HasThisStudentExistInCourse(anCourseEnrollment.AStudent,anCourseEnrollment.ACourse))
            {


                ACouresCourseEnrollment = aCourseEnrollmentGateway.GetEnrolledStudent(anCourseEnrollment.AStudent,anCourseEnrollment.ACourse);



                AListViewItem = new ListViewItem(ACouresCourseEnrollment.ACourse.Title);

                AListViewItem.SubItems.Add(ACouresCourseEnrollment.DateTime.ToString());
                return "Student already enrolled in this course";


            }
            return aCourseEnrollmentGateway.EnrollCourse(anCourseEnrollment);
        }

        private bool HasThisStudentExistInCourse(Student aStudent,Course aCourse)
        {



            return aCourseEnrollmentGateway.HasThisStudentInCourse(aStudent,aCourse);



        }

        public List<Course> GetAllCourse()
        {



            return aCourseEnrollmentGateway.GetAllCourse();


        }
    }
}
