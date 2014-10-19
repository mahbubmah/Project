﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarsityAdmission.BLL;
using VarsityAdmission.DLL.DAO;

namespace VarsityAdmission
{
    public partial class CourseEnrollmentUI : Form
    {
        private Student aStudent=new Student();
        StudentBLL aStudentBll=new StudentBLL();
        private List<Student> aStudentList;

        public CourseEnrollmentUI()
        {
            InitializeComponent();
        }

        private void enrollCEUiTutton_Click(object sender, System.EventArgs e)
        {
            
            aStudent.RegNO = regNoCEUiTextBox.Text;
            aStudent.Name = nameCEUiTextBox.Text;
            aStudent.Email = emailCEUiTextBox.Text;
            
            string msg= aStudentBll.save(aStudent);
            MessageBox.Show(msg);

        }

        private void findCEUiTutton_Click(object sender, System.EventArgs e)
        {
            aStudent.RegNO = regNoCEUiTextBox.Text;
            bool find=aStudentBll.CheckRegNO(aStudent.RegNO);
            if (find)
            {
                MessageBox.Show("RegNO exists");
                ShowStudentData();

            }
            else
                MessageBox.Show("you can insert this RegNO");
            

        }

        private void ShowStudentData()
        {
            aStudentList = aStudentBll.ShowStudentData();
            dataGridView1.DataSource = aStudentList;
        }
    }
}
