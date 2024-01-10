using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Calendar
    {
        public int CalendarId { get; set; }
        public int AcademicYearId { get; set; }
        public DateTime? AdmissionStart { get; set; }
        public DateTime? AdmissionEnd { get; set; }
        public DateTime? RegistrationStart { get; set; }
        public DateTime? RegistrationEnd { get; set; }
        public DateTime? LateRegistrationStart { get; set; }
        public DateTime? LateRegistrationEnd { get; set; }
        public DateTime? SwapStart { get; set; }
        public DateTime? SwapEnd { get; set; }
        public DateTime? DropStart { get; set; }
        public DateTime? DropEnd { get; set; }
        public DateTime? WithdrawStart { get; set; }
        public DateTime? WithdrawEnd { get; set; }
        public DateTime? ClassStart { get; set; }
        public DateTime? ClassEnd { get; set; }
        public decimal? LateRegistrationDeductionPercent { get; set; }
        public decimal? DropDeductionPercent { get; set; }
        public decimal? WithdrawDeductionPercent { get; set; }
        public bool? IsActive { get; set; }
        public string Remarks { get; set; }
        public string CalendarStatusId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? MidtermStartDate { get; set; }
        public DateTime? MidtermEndDate { get; set; }
        public DateTime? FinaltermStartDate { get; set; }
        public DateTime? FinaltermEndDate { get; set; }
        public DateTime? ResultDate { get; set; }
        public DateTime? PostPoneDateStart { get; set; }
        public DateTime? PostPoneDateEnd { get; set; }

        public virtual AcademicYears AcademicYear { get; set; }
    }
}
