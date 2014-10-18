using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultSheetUI.DLL.DAO
{
    class ResultSheet
    {
        public string RegNo { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public double Result { set; get; }

        public double Score { set; get; }

        public double AverageScore(double score)
        {
            double average=
        }

        public string GradeLetter(double AverageScore)
        {
            if (AverageScore >= 90)
                return "A";
            else if (AverageScore >= 70 && AverageScore < 90)
                return "B";
            else if (AverageScore >= 50 && AverageScore < 70)
                return "C";
            else if (AverageScore < 50)
                return "F";
         

        }
    }
}
