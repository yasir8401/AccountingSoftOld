using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Branch
    {
        public Branch()
        {
            AccountGroups = new HashSet<AccountGroups>();
            AccountTypes = new HashSet<AccountTypes>();
            Accounts = new HashSet<Accounts>();
            Applications = new HashSet<Applications>();
            ApprovalRoutes = new HashSet<ApprovalRoutes>();
            ApprovalTasks = new HashSet<ApprovalTasks>();
            Bills = new HashSet<Bills>();
            BillsLines = new HashSet<BillsLines>();
            Comments = new HashSet<Comments>();
            CreditNotes = new HashSet<CreditNotes>();
            CreditNotesLines = new HashSet<CreditNotesLines>();
            Customers = new HashSet<Customers>();
            Departments = new HashSet<Departments>();
            Divisions = new HashSet<Divisions>();
            Documents = new HashSet<Documents>();
            FeeVouchers = new HashSet<FeeVouchers>();
            FeeVouchersLines = new HashSet<FeeVouchersLines>();
            FixedAsset = new HashSet<FixedAsset>();
            GeneralEntries = new HashSet<GeneralEntries>();
            GeneralEntriesLines = new HashSet<GeneralEntriesLines>();
            Invoices = new HashSet<Invoices>();
            InvoicesLines = new HashSet<InvoicesLines>();
            Leaves = new HashSet<Leaves>();
            Loans = new HashSet<Loans>();
            LookupTypes = new HashSet<LookupTypes>();
            Lookups = new HashSet<Lookups>();
            OvertimeRequests = new HashSet<OvertimeRequests>();
            OvertimeRequestsLines = new HashSet<OvertimeRequestsLines>();
            Payments = new HashSet<Payments>();
            Projects = new HashSet<Projects>();
            Receipts = new HashSet<Receipts>();
            Refunds = new HashSet<Refunds>();
            RefundsLines = new HashSet<RefundsLines>();
            Sections = new HashSet<Sections>();
            StdLetters = new HashSet<StdLetters>();
            SubSections = new HashSet<SubSections>();
            Tasks = new HashSet<Tasks>();
            TaxRates = new HashSet<TaxRates>();
            TeamMembers = new HashSet<TeamMembers>();
            Teams = new HashSet<Teams>();
            Units = new HashSet<Units>();
            VacantJobs = new HashSet<VacantJobs>();
        }

        public int BranchId { get; set; }
        public string BranchNameEn { get; set; }
        public string BranchNameAr { get; set; }
        public string BranchEmail { get; set; }
        public string BranchPhone { get; set; }
        public string BranchAddressEn { get; set; }
        public string BranchAddressAr { get; set; }
        public bool? IsEnable { get; set; }
        public int? CompanyId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<AccountGroups> AccountGroups { get; set; }
        public virtual ICollection<AccountTypes> AccountTypes { get; set; }
        public virtual ICollection<Accounts> Accounts { get; set; }
        public virtual ICollection<Applications> Applications { get; set; }
        public virtual ICollection<ApprovalRoutes> ApprovalRoutes { get; set; }
        public virtual ICollection<ApprovalTasks> ApprovalTasks { get; set; }
        public virtual ICollection<Bills> Bills { get; set; }
        public virtual ICollection<BillsLines> BillsLines { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<CreditNotes> CreditNotes { get; set; }
        public virtual ICollection<CreditNotesLines> CreditNotesLines { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Departments> Departments { get; set; }
        public virtual ICollection<Divisions> Divisions { get; set; }
        public virtual ICollection<Documents> Documents { get; set; }
        public virtual ICollection<FeeVouchers> FeeVouchers { get; set; }
        public virtual ICollection<FeeVouchersLines> FeeVouchersLines { get; set; }
        public virtual ICollection<FixedAsset> FixedAsset { get; set; }
        public virtual ICollection<GeneralEntries> GeneralEntries { get; set; }
        public virtual ICollection<GeneralEntriesLines> GeneralEntriesLines { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
        public virtual ICollection<InvoicesLines> InvoicesLines { get; set; }
        public virtual ICollection<Leaves> Leaves { get; set; }
        public virtual ICollection<Loans> Loans { get; set; }
        public virtual ICollection<LookupTypes> LookupTypes { get; set; }
        public virtual ICollection<Lookups> Lookups { get; set; }
        public virtual ICollection<OvertimeRequests> OvertimeRequests { get; set; }
        public virtual ICollection<OvertimeRequestsLines> OvertimeRequestsLines { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<Receipts> Receipts { get; set; }
        public virtual ICollection<Refunds> Refunds { get; set; }
        public virtual ICollection<RefundsLines> RefundsLines { get; set; }
        public virtual ICollection<Sections> Sections { get; set; }
        public virtual ICollection<StdLetters> StdLetters { get; set; }
        public virtual ICollection<SubSections> SubSections { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
        public virtual ICollection<TaxRates> TaxRates { get; set; }
        public virtual ICollection<TeamMembers> TeamMembers { get; set; }
        public virtual ICollection<Teams> Teams { get; set; }
        public virtual ICollection<Units> Units { get; set; }
        public virtual ICollection<VacantJobs> VacantJobs { get; set; }
    }
}
