using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentCourse.UI;

namespace StudentCourse
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            CourseEnrollment aCourseEnrollment=new CourseEnrollment();
            aCourseEnrollment.ShowDialog();
        }

        private void enterResultButton_Click(object sender, EventArgs e)
        {
            ResultEntryUI aResultEntryUi=new ResultEntryUI();
            aResultEntryUi.ShowDialog();
        }

        private void showResultSheetButton_Click(object sender, EventArgs e)
        {
            ResultSheetUI aResultSheetUi=new ResultSheetUI();
            aResultSheetUi.ShowDialog();
        }

  
    }
}
