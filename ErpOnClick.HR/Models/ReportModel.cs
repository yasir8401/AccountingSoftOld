using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models
{
    public class ReportModel
    {
        public string EmpName { get; set; }
        public string EmpPostion { get; set; }
        public string EmpJobTitle { get; set; }
        public string EmpDivison { get; set; }
        public string EmpDepartment { get; set; }
        public string EmpSection { get; set; }
        public string EmpSubSection { get; set; }
        public string EmpUnit { get; set; }
        public string EmpTeam { get; set; }
        public string EmpCompany { get; set; }
        public string EmpBranch { get; set; }
        public string EmpSalaray { get; set; }
        public decimal BasicSalray { get; set; }
        public decimal Housing { get; set; }
        public decimal Transport { get; set; }
        public decimal Food { get; set; }
        public decimal Other { get; set; }
        public decimal LeavePay { get; set; }
        public decimal Indemnity { get; set; }

        //public List<Allowances> EmpAllowances { get; set; }
    }
    //public class Allowances
    //{
    //    public int BasicSalray { get; set; }
    //    public int Housing { get; set; }
    //    public int Transport { get; set; }
    //    public int Food { get; set; }
    //    public int Other { get; set; }
    //    public int LeavePay { get; set; }
    //    public int Indemnity { get; set; }
    //}
}
