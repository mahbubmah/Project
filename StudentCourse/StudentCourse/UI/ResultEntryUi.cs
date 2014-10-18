using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentCourse.BLL.ResultEntryBll;
using StudentCourse.DLL.DAO;

namespace StudentCourse
{
    public partial class ResultEntryForm : Form
    {
        public ResultEntryForm()
        {
            InitializeComponent();
            courseTitleComboBox.DisplayMember = "Title";
            Course aCourse = new Course();
            courseTitleComboBox.Items.Add(aCourse);

        }
        ResultEntryBll aResultEntryBll=new ResultEntryBll();
        private Student aStudent;

        private void findResultEntryUibutton_Click(object sender, EventArgs e)
        {
            
        }

        private void viewResultEntryUibutton_Click(object sender, EventArgs e)
        {

        }

        private void saveResultEntrybutton_Click(object sender, EventArgs e)
        {
            aStudent = new Student();
            aStudent.RegNo = textBoxResultEntryUiRegNo.Text;
            aStudent.Name = textBoxResultEntryUiName.Text;
            aStudent.Email = textBoxResultEntryUiEmail.Text;
            string msg = aResultEntryBll.Save(aStudent);
        }
    }
}
