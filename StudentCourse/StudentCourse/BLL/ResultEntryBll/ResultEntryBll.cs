using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCourse.DLL.DAO;
using StudentCourse.DLL.GateWay;

namespace StudentCourse.BLL.ResultEntryBll
{
    class ResultEntryBll
    {
        //ResultEntryBll aResultEntryBll=new ResultEntryBll();
        ResultEntryGateWay aResultEntryGateWay=new ResultEntryGateWay();
        public string Save(Student aStudent)
        {
            return aResultEntryGateWay.save(aStudent);
        }
    }
}
