using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Emp
    {
        public Emp()
        {
            Achievement = new HashSet<Achievement>();
            DepartmentsDepartmentHeadU = new HashSet<Departments>();
            DepartmentsReportingToU = new HashSet<Departments>();
            DivisionsDivisionHeadU = new HashSet<Divisions>();
            DivisionsReportingToU = new HashSet<Divisions>();
            EmpAddresses = new HashSet<EmpAddresses>();
            EmpAttendance = new HashSet<EmpAttendance>();
            EmpBanks = new HashSet<EmpBanks>();
            EmpContracts = new HashSet<EmpContracts>();
            EmpDependents = new HashSet<EmpDependents>();
            EmpExperience = new HashSet<EmpExperience>();
            EmpGosiSettings = new HashSet<EmpGosiSettings>();
            EmpMedicals = new HashSet<EmpMedicals>();
            EmpPreviousexperience = new HashSet<EmpPreviousexperience>();
            EmpShifts = new HashSet<EmpShifts>();
            EmpVehicles = new HashSet<EmpVehicles>();
            ExpClaims = new HashSet<ExpClaims>();
            Leaves = new HashSet<Leaves>();
            LeavesReturn = new HashSet<LeavesReturn>();
            Loans = new HashSet<Loans>();
            OvertimeRequestsLines = new HashSet<OvertimeRequestsLines>();
            PayrunD = new HashSet<PayrunD>();
            PerformanceBaseSalary = new HashSet<PerformanceBaseSalary>();
            Projects = new HashSet<Projects>();
            Requests = new HashSet<Requests>();
            SalaryPayablesPerMonth = new HashSet<SalaryPayablesPerMonth>();
            SectionsReportingToU = new HashSet<Sections>();
            SectionsSectionHeadU = new HashSet<Sections>();
            SubSectionsReportingToU = new HashSet<SubSections>();
            SubSectionsSubSectionHeadU = new HashSet<SubSections>();
            Tasks = new HashSet<Tasks>();
            TeamMembers = new HashSet<TeamMembers>();
            TeamsReportingToU = new HashSet<Teams>();
            TeamsTeamHeadU = new HashSet<Teams>();
            TimeInOutCorrection = new HashSet<TimeInOutCorrection>();
            UnitsReportingToU = new HashSet<Units>();
            UnitsUnitHeadU = new HashSet<Units>();
            Users = new HashSet<Users>();
            WeekendOvertimeAssignedByNavigation = new HashSet<WeekendOvertime>();
            WeekendOvertimeEmp = new HashSet<WeekendOvertime>();
        }

        public int EmpId { get; set; }
        public string EmpCode { get; set; }
        public string FirstNameEn { get; set; }
        public string FatherNameEn { get; set; }
        public string GrandNameEn { get; set; }
        public string FamilyNameEn { get; set; }
        public string FirstNameAr { get; set; }
        public string FatherNameAr { get; set; }
        public string GrandNameAr { get; set; }
        public string FamilyNameAr { get; set; }
        public string EmpPosition { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? DobH { get; set; }
        public int? Age { get; set; }
        public string BirthPlaceId { get; set; }
        public string NationalityId { get; set; }
        public string ReligionId { get; set; }
        public string GenderId { get; set; }
        public string MaritalStatusId { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string SponsorId { get; set; }
        public bool? StayingWithFamily { get; set; }
        public string ProfilePic { get; set; }
        public string ActiveStatus { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string EmpCnic { get; set; }
        public string EmpNtn { get; set; }
        public int? DesignationPositionId { get; set; }
        public string EmpType { get; set; }
        public string IdtypeId { get; set; }
        public string PassportNo { get; set; }
        public string PassportIssuedFrom { get; set; }
        public string PassportIssuedDate { get; set; }
        public string PassportIssuedDateH { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public string PassportExpiryDateH { get; set; }
        public string PassportAttachment { get; set; }
        public string VisaCode { get; set; }
        public string VisaJob { get; set; }
        public string VisaDate { get; set; }
        public string PassCode { get; set; }
        public string PassPort { get; set; }
        public string PassDate { get; set; }
        public string EmpOfficeLaborCode { get; set; }
        public DateTime? IdIssueDate { get; set; }
        public DateTime? IdIssueDateH { get; set; }
        public DateTime? IdExpiryDate { get; set; }
        public DateTime? IdExpiryDateH { get; set; }

        public virtual Positions DesignationPosition { get; set; }
        public virtual ICollection<Achievement> Achievement { get; set; }
        public virtual ICollection<Departments> DepartmentsDepartmentHeadU { get; set; }
        public virtual ICollection<Departments> DepartmentsReportingToU { get; set; }
        public virtual ICollection<Divisions> DivisionsDivisionHeadU { get; set; }
        public virtual ICollection<Divisions> DivisionsReportingToU { get; set; }
        public virtual ICollection<EmpAddresses> EmpAddresses { get; set; }
        public virtual ICollection<EmpAttendance> EmpAttendance { get; set; }
        public virtual ICollection<EmpBanks> EmpBanks { get; set; }
        public virtual ICollection<EmpContracts> EmpContracts { get; set; }
        public virtual ICollection<EmpDependents> EmpDependents { get; set; }
        public virtual ICollection<EmpExperience> EmpExperience { get; set; }
        public virtual ICollection<EmpGosiSettings> EmpGosiSettings { get; set; }
        public virtual ICollection<EmpMedicals> EmpMedicals { get; set; }
        public virtual ICollection<EmpPreviousexperience> EmpPreviousexperience { get; set; }
        public virtual ICollection<EmpShifts> EmpShifts { get; set; }
        public virtual ICollection<EmpVehicles> EmpVehicles { get; set; }
        public virtual ICollection<ExpClaims> ExpClaims { get; set; }
        public virtual ICollection<Leaves> Leaves { get; set; }
        public virtual ICollection<LeavesReturn> LeavesReturn { get; set; }
        public virtual ICollection<Loans> Loans { get; set; }
        public virtual ICollection<OvertimeRequestsLines> OvertimeRequestsLines { get; set; }
        public virtual ICollection<PayrunD> PayrunD { get; set; }
        public virtual ICollection<PerformanceBaseSalary> PerformanceBaseSalary { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<Requests> Requests { get; set; }
        public virtual ICollection<SalaryPayablesPerMonth> SalaryPayablesPerMonth { get; set; }
        public virtual ICollection<Sections> SectionsReportingToU { get; set; }
        public virtual ICollection<Sections> SectionsSectionHeadU { get; set; }
        public virtual ICollection<SubSections> SubSectionsReportingToU { get; set; }
        public virtual ICollection<SubSections> SubSectionsSubSectionHeadU { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
        public virtual ICollection<TeamMembers> TeamMembers { get; set; }
        public virtual ICollection<Teams> TeamsReportingToU { get; set; }
        public virtual ICollection<Teams> TeamsTeamHeadU { get; set; }
        public virtual ICollection<TimeInOutCorrection> TimeInOutCorrection { get; set; }
        public virtual ICollection<Units> UnitsReportingToU { get; set; }
        public virtual ICollection<Units> UnitsUnitHeadU { get; set; }
        public virtual ICollection<Users> Users { get; set; }
        public virtual ICollection<WeekendOvertime> WeekendOvertimeAssignedByNavigation { get; set; }
        public virtual ICollection<WeekendOvertime> WeekendOvertimeEmp { get; set; }
    }
}
