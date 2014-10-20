using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarsityAdmission.BLL;
using VarsityAdmission.DLL.DAO;

namespace VarsityAdmission
{
    public partial class ResultEntryUI : Form
    {
        public ResultEntryUI()
        {
            InitializeComponent();
        }
        Student aStudent=new Student();
        StudentBLL aStudentBll=new StudentBLL();
        CourseBLL aCourseBll=new CourseBLL();
         Course aCourse=new Course();
        private List<Course> aCoursesList; 

        private void findCEUiTutton_Click(object sender, EventArgs e)
        {
            aStudent.RegNO = regNoREUiTextBox.Text;
            bool find = aStudentBll.CheckRegNO(aStudent.RegNO);
            if (find)
            {
                MessageBox.Show("RegNO exists");
                ShowInTextbox();
                ShowCourseComboBox();

            }
            else
                MessageBox.Show("you can insert this RegNO");
        }

        public void ShowInTextbox()
        {
            

            aStudent = aStudentBll.GetStudent(aStudent);
            regNoREUiTextBox.Text = aStudent.RegNO;
            nameREUiTextBox.Text = aStudent.Name;
            emailREUiTextBox.Text = aStudent.Email;
        }

        private void ShowCourseComboBox()
        {

            aCoursesList = aCourseBll.ShowCourseData();
            foreach (Course tempCourse in aCoursesList)
            {
                REUiComboBox.Items.Add(tempCourse);

            }
            REUiComboBox.DisplayMember = "CourseTitle";

        }

        private void viewResultSheetButton_Click(object sender, EventArgs e)
        {
            ResultSheetUI aResultSheetUi = new ResultSheetUI();
            aResultSheetUi.ShowDialog();
        }

        private void saveScoreButton_Click(object sender, EventArgs e)
        {
            
            Course aCourse = (Course)REUiComboBox.SelectedItem;
            aStudent.Name = nameREUiTextBox.Text;
            aStudent.Email = emailREUiTextBox.Text;
            aStudent.RegNO = regNoREUiTextBox.Text;
            aStudent.Score = saveScoreREUiTextBox.Text;
            aStudent.Coursetitle = aCourse.CourseTitle;
            string msg = aStudentBll.SaveWithScore(aStudent);
            MessageBox.Show(msg);

        }

      
    }
}
