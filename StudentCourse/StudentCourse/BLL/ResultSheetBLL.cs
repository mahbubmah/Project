using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ResultSheetUI.DLL.DAO;
using ResultSheetUI.DLL.GATEWAY;

namespace ResultSheetUI.BLL
{
     class ResultSheetBLL
    {
        public ResultSheetBLL()
        {
            aResultSheetGateWay = new ResultSheetGateWay();
        }

        public ResultSheetGateWay aResultSheetGateWay;
        public ResultSheet aResultSheet = new ResultSheet();

        public string Save(ResultSheet aResultSheet)
        {
            if (aResultSheet.RegNo == string.Empty || aResultSheet.Name == string.Empty ||
                aResultSheet.Email == string.Empty)
            {
                return "Fill up All the Field";
            }

            else
            {
                string msg = "";

                if (HasThisRegNoValid(aResultSheet.RegNo))
                {
                    msg += "Reg No Already Exist";
                }
                return msg;
            }
        else
            {
                return aResultSheetGateWay.Save(ResultSheet);
            }
        }
    }

    public bool HasThisRegNoValid(string regno)
        {
            return aResultSheetGateWay.HasThisRegNoValid(RegNo);
        }

        public string RegNo { get; set; }
    }
  

}
