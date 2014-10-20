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
    public partial class ResultSheetUI : Form
    {
        public ResultSheetUI()
        {
            InitializeComponent();
        }

        private Student aStudent;
        private StudentBLL aStudentBll;
        private List<Student> aStudentList;
        CourseBLL aCourseBll = new CourseBLL();
        private List<Course> aCoursesList;
        

        private void findCEUiTutton_Click(object sender, EventArgs e)
        {
            aStudent=new Student();
            aStudentBll=new StudentBLL();
            aStudent.RegNO = regNoREUiTextBox.Text;
            aStudent = aStudentBll.GetStudent(aStudent);
            regNoREUiTextBox.Text = aStudent.RegNO;
            nameREUiTextBox.Text = aStudent.Name;
            emailREUiTextBox.Text = aStudent.Email;
            ListViewItem aListViewItem=new ListViewItem(aStudent.RegNO);
            aListViewItem.SubItems.Add(aStudent.Name);
            aListViewItem.SubItems.Add(aStudent.Coursetitle);
            aListViewItem.SubItems.Add(aStudent.Score);
            resultListView.Items.Add(aListViewItem);

            ShowScoreTextBox(aStudent);
        }

        private void ShowScoreTextBox(Student student)
        {
            Student newStudent= aStudentBll.GetStudent(student);
            showScoreTextBox.Text = newStudent.Score;
        }
    }
}
