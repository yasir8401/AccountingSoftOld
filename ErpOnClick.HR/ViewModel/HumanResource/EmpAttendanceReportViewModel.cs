using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.ViewModel.HumanResource
{
    public class EmpAttendanceReportViewModel
    {
        public int EmpId { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public string EmpCNIC { get; set; }
        public string NTN { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime LeavingDate { get; set; }
        public string JoinerLeaver { get; set; }
        public string OfficeLocation { get; set; }
        public string Department { get; set; }
        public string Shift { get; set; }
        public string Designation { get; set; }
        public string EmpType { get; set; }
        public string WageGroup { get; set; }
        public string BeneficiaryName { get; set; }
        public string CustomerRef { get; set; }
        public string BankAccountNo { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
        public string Currency { get; set; }
        public List<string> ListMonthAttendancePresentAbsent { get; set; }
        public int Tardies { get; set; }
        public int ShortLeaves { get; set; }
        public int Absents { get; set; }
        public int PaidLeaves { get; set; }
        public int UnpaidLeaves { get; set; }
        public int Presents { get; set; }
        public int TotalDays { get; set; }
        public int DeductedDays { get; set; }
        public DateTime SalaryMonth { get; set; }


      
    }
}
