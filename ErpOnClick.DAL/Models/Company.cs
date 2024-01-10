using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Company
    {
        public Company()
        {
            AccountGroups = new HashSet<AccountGroups>();
            AccountTypes = new HashSet<AccountTypes>();
            Accounts = new HashSet<Accounts>();
            AppConfig = new HashSet<AppConfig>();
            ApprovalRoutes = new HashSet<ApprovalRoutes>();
            ApprovalTasks = new HashSet<ApprovalTasks>();
            Branch = new HashSet<Branch>();
            Comments = new HashSet<Comments>();
            Departments = new HashSet<Departments>();
            Divisions = new HashSet<Divisions>();
            Documents = new HashSet<Documents>();
            FixedAsset = new HashSet<FixedAsset>();
            GeneralEntries = new HashSet<GeneralEntries>();
            GeneralEntriesLines = new HashSet<GeneralEntriesLines>();
            Leaves = new HashSet<Leaves>();
            Loans = new HashSet<Loans>();
            LookupTypes = new HashSet<LookupTypes>();
            Lookups = new HashSet<Lookups>();
            Parents = new HashSet<Parents>();
            Projects = new HashSet<Projects>();
            Sections = new HashSet<Sections>();
            StdLetters = new HashSet<StdLetters>();
            SubSections = new HashSet<SubSections>();
            Tasks = new HashSet<Tasks>();
            TeamMembers = new HashSet<TeamMembers>();
            Teams = new HashSet<Teams>();
            Units = new HashSet<Units>();
            VacantJobs = new HashSet<VacantJobs>();
        }

        public int CompanyId { get; set; }
        public string CoNameEn { get; set; }
        public string CoNameAr { get; set; }
        public string CoEmail { get; set; }
        public string CoPhone { get; set; }
        public string CoWebsite { get; set; }
        public string CoAddressEn { get; set; }
        public string CoAddressAr { get; set; }
        public string CrNo { get; set; }
        public string VatNo { get; set; }
        public string Language { get; set; }
        public string Currency { get; set; }
        public string BankDetailEn { get; set; }
        public string BankDetailAr { get; set; }
        public int? FiscalYearStartMonth { get; set; }
        public string FiscalYearIsBasedOn { get; set; }
        public bool? IsEnable { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<AccountGroups> AccountGroups { get; set; }
        public virtual ICollection<AccountTypes> AccountTypes { get; set; }
        public virtual ICollection<Accounts> Accounts { get; set; }
        public virtual ICollection<AppConfig> AppConfig { get; set; }
        public virtual ICollection<ApprovalRoutes> ApprovalRoutes { get; set; }
        public virtual ICollection<ApprovalTasks> ApprovalTasks { get; set; }
        public virtual ICollection<Branch> Branch { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Departments> Departments { get; set; }
        public virtual ICollection<Divisions> Divisions { get; set; }
        public virtual ICollection<Documents> Documents { get; set; }
        public virtual ICollection<FixedAsset> FixedAsset { get; set; }
        public virtual ICollection<GeneralEntries> GeneralEntries { get; set; }
        public virtual ICollection<GeneralEntriesLines> GeneralEntriesLines { get; set; }
        public virtual ICollection<Leaves> Leaves { get; set; }
        public virtual ICollection<Loans> Loans { get; set; }
        public virtual ICollection<LookupTypes> LookupTypes { get; set; }
        public virtual ICollection<Lookups> Lookups { get; set; }
        public virtual ICollection<Parents> Parents { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<Sections> Sections { get; set; }
        public virtual ICollection<StdLetters> StdLetters { get; set; }
        public virtual ICollection<SubSections> SubSections { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
        public virtual ICollection<TeamMembers> TeamMembers { get; set; }
        public virtual ICollection<Teams> Teams { get; set; }
        public virtual ICollection<Units> Units { get; set; }
        public virtual ICollection<VacantJobs> VacantJobs { get; set; }
    }
}
