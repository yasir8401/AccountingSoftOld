using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Lookups
    {
        public Lookups()
        {
            ActivityLog = new HashSet<ActivityLog>();
            AdmissionForms = new HashSet<AdmissionForms>();
            Comments = new HashSet<Comments>();
            CourseCorrection = new HashSet<CourseCorrection>();
            DocumentsDocIssuedFromNavigation = new HashSet<Documents>();
            DocumentsDocOwnerTypeNavigation = new HashSet<Documents>();
            DocumentsDocTypeNavigation = new HashSet<Documents>();
            EmpEducation = new HashSet<EmpEducation>();
            ExpClaims = new HashSet<ExpClaims>();
            FixedAssetAssetType = new HashSet<FixedAsset>();
            FixedAssetAverageMethod = new HashSet<FixedAsset>();
            FixedAssetDepreciationMethod = new HashSet<FixedAsset>();
            LeavesAttachmentTypeNavigation = new HashSet<Leaves>();
            LeavesLeaveStatusNavigation = new HashSet<Leaves>();
            LeavesLeaveType = new HashSet<Leaves>();
            LoansAttachmentTypeNavigation = new HashSet<Loans>();
            LoansLoanStatusNavigation = new HashSet<Loans>();
            LoansLoanType = new HashSet<Loans>();
            OvertimeRequests = new HashSet<OvertimeRequests>();
            PayrunPayslip = new HashSet<PayrunPayslip>();
            ProjectsProjectStatus = new HashSet<Projects>();
            ProjectsProjectType = new HashSet<Projects>();
            Quiz = new HashSet<Quiz>();
            RequestsRequestStatusNavigation = new HashSet<Requests>();
            RequestsRequestType = new HashSet<Requests>();
            SeatEnroll = new HashSet<SeatEnroll>();
            StdEnroll = new HashSet<StdEnroll>();
            StdLetters = new HashSet<StdLetters>();
            StdSemesters = new HashSet<StdSemesters>();
            StudentAttendance = new HashSet<StudentAttendance>();
            TasksTaskStatus = new HashSet<Tasks>();
            TasksTaskType = new HashSet<Tasks>();
            TeamMembers = new HashSet<TeamMembers>();
            TimeInOutCorrection = new HashSet<TimeInOutCorrection>();
            VacantJobsJobDepartment = new HashSet<VacantJobs>();
            VacantJobsJobStatus = new HashSet<VacantJobs>();
            VacantJobsJobType = new HashSet<VacantJobs>();
            Voucher = new HashSet<Voucher>();
            WeekendOvertime = new HashSet<WeekendOvertime>();
        }

        public string Code { get; set; }
        public string LookupTypeId { get; set; }
        public string LookupId { get; set; }
        public string LookupNameEn { get; set; }
        public string LookupNameAr { get; set; }
        public string Abbreviation { get; set; }
        public string ParentCode { get; set; }
        public bool? ActiveStatus { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public double? Value { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual LookupTypes LookupType { get; set; }
        public virtual ICollection<ActivityLog> ActivityLog { get; set; }
        public virtual ICollection<AdmissionForms> AdmissionForms { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<CourseCorrection> CourseCorrection { get; set; }
        public virtual ICollection<Documents> DocumentsDocIssuedFromNavigation { get; set; }
        public virtual ICollection<Documents> DocumentsDocOwnerTypeNavigation { get; set; }
        public virtual ICollection<Documents> DocumentsDocTypeNavigation { get; set; }
        public virtual ICollection<EmpEducation> EmpEducation { get; set; }
        public virtual ICollection<ExpClaims> ExpClaims { get; set; }
        public virtual ICollection<FixedAsset> FixedAssetAssetType { get; set; }
        public virtual ICollection<FixedAsset> FixedAssetAverageMethod { get; set; }
        public virtual ICollection<FixedAsset> FixedAssetDepreciationMethod { get; set; }
        public virtual ICollection<Leaves> LeavesAttachmentTypeNavigation { get; set; }
        public virtual ICollection<Leaves> LeavesLeaveStatusNavigation { get; set; }
        public virtual ICollection<Leaves> LeavesLeaveType { get; set; }
        public virtual ICollection<Loans> LoansAttachmentTypeNavigation { get; set; }
        public virtual ICollection<Loans> LoansLoanStatusNavigation { get; set; }
        public virtual ICollection<Loans> LoansLoanType { get; set; }
        public virtual ICollection<OvertimeRequests> OvertimeRequests { get; set; }
        public virtual ICollection<PayrunPayslip> PayrunPayslip { get; set; }
        public virtual ICollection<Projects> ProjectsProjectStatus { get; set; }
        public virtual ICollection<Projects> ProjectsProjectType { get; set; }
        public virtual ICollection<Quiz> Quiz { get; set; }
        public virtual ICollection<Requests> RequestsRequestStatusNavigation { get; set; }
        public virtual ICollection<Requests> RequestsRequestType { get; set; }
        public virtual ICollection<SeatEnroll> SeatEnroll { get; set; }
        public virtual ICollection<StdEnroll> StdEnroll { get; set; }
        public virtual ICollection<StdLetters> StdLetters { get; set; }
        public virtual ICollection<StdSemesters> StdSemesters { get; set; }
        public virtual ICollection<StudentAttendance> StudentAttendance { get; set; }
        public virtual ICollection<Tasks> TasksTaskStatus { get; set; }
        public virtual ICollection<Tasks> TasksTaskType { get; set; }
        public virtual ICollection<TeamMembers> TeamMembers { get; set; }
        public virtual ICollection<TimeInOutCorrection> TimeInOutCorrection { get; set; }
        public virtual ICollection<VacantJobs> VacantJobsJobDepartment { get; set; }
        public virtual ICollection<VacantJobs> VacantJobsJobStatus { get; set; }
        public virtual ICollection<VacantJobs> VacantJobsJobType { get; set; }
        public virtual ICollection<Voucher> Voucher { get; set; }
        public virtual ICollection<WeekendOvertime> WeekendOvertime { get; set; }
    }
}
