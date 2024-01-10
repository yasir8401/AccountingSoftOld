using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ErpOnClick.DAL.Models
{
    public partial class ERPonClickContext : DbContext
    {
        public ERPonClickContext()
        {
        }

        public ERPonClickContext(DbContextOptions<ERPonClickContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbsentProfiles> AbsentProfiles { get; set; }
        public virtual DbSet<AcademicYears> AcademicYears { get; set; }
        public virtual DbSet<AccountGroups> AccountGroups { get; set; }
        public virtual DbSet<AccountTypes> AccountTypes { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Achievement> Achievement { get; set; }
        public virtual DbSet<ActivityLog> ActivityLog { get; set; }
        public virtual DbSet<AddmissionFormsRemarks> AddmissionFormsRemarks { get; set; }
        public virtual DbSet<AdmissionForms> AdmissionForms { get; set; }
        public virtual DbSet<AdmissionFormsAttachments> AdmissionFormsAttachments { get; set; }
        public virtual DbSet<AdmissionFormsEducations> AdmissionFormsEducations { get; set; }
        public virtual DbSet<AirTicketProfiles> AirTicketProfiles { get; set; }
        public virtual DbSet<Annoucment> Annoucment { get; set; }
        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<AppConfig> AppConfig { get; set; }
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<ApprovalRoutes> ApprovalRoutes { get; set; }
        public virtual DbSet<ApprovalRoutesDetail> ApprovalRoutesDetail { get; set; }
        public virtual DbSet<ApprovalTasks> ApprovalTasks { get; set; }
        public virtual DbSet<Assignment> Assignment { get; set; }
        public virtual DbSet<Banks> Banks { get; set; }
        public virtual DbSet<Bills> Bills { get; set; }
        public virtual DbSet<BillsLines> BillsLines { get; set; }
        public virtual DbSet<BookBorrow> BookBorrow { get; set; }
        public virtual DbSet<BookReturn> BookReturn { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Buildings> Buildings { get; set; }
        public virtual DbSet<Calendar> Calendar { get; set; }
        public virtual DbSet<Campus> Campus { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<ClassesSchedule> ClassesSchedule { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Conversation> Conversation { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseCorrection> CourseCorrection { get; set; }
        public virtual DbSet<CourseScore> CourseScore { get; set; }
        public virtual DbSet<Courseerp> Courseerp { get; set; }
        public virtual DbSet<CreditNotes> CreditNotes { get; set; }
        public virtual DbSet<CreditNotesLines> CreditNotesLines { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Divisions> Divisions { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<EmailLog> EmailLog { get; set; }
        public virtual DbSet<Emp> Emp { get; set; }
        public virtual DbSet<EmpAddresses> EmpAddresses { get; set; }
        public virtual DbSet<EmpAttendance> EmpAttendance { get; set; }
        public virtual DbSet<EmpBanks> EmpBanks { get; set; }
        public virtual DbSet<EmpContracts> EmpContracts { get; set; }
        public virtual DbSet<EmpContractsPackage> EmpContractsPackage { get; set; }
        public virtual DbSet<EmpDependents> EmpDependents { get; set; }
        public virtual DbSet<EmpEducation> EmpEducation { get; set; }
        public virtual DbSet<EmpExperience> EmpExperience { get; set; }
        public virtual DbSet<EmpGosiSettings> EmpGosiSettings { get; set; }
        public virtual DbSet<EmpMedicals> EmpMedicals { get; set; }
        public virtual DbSet<EmpPreviousexperience> EmpPreviousexperience { get; set; }
        public virtual DbSet<EmpShifts> EmpShifts { get; set; }
        public virtual DbSet<EmpVehicles> EmpVehicles { get; set; }
        public virtual DbSet<Evaluation> Evaluation { get; set; }
        public virtual DbSet<ExamSchedule> ExamSchedule { get; set; }
        public virtual DbSet<ExamScheduleLines> ExamScheduleLines { get; set; }
        public virtual DbSet<ExceptionsClassCapacity> ExceptionsClassCapacity { get; set; }
        public virtual DbSet<ExceptionsCourses> ExceptionsCourses { get; set; }
        public virtual DbSet<ExpClaims> ExpClaims { get; set; }
        public virtual DbSet<FeeVouchers> FeeVouchers { get; set; }
        public virtual DbSet<FeeVouchersLines> FeeVouchersLines { get; set; }
        public virtual DbSet<FixedAsset> FixedAsset { get; set; }
        public virtual DbSet<GeneralEntries> GeneralEntries { get; set; }
        public virtual DbSet<GeneralEntriesLines> GeneralEntriesLines { get; set; }
        public virtual DbSet<GosiSettings> GosiSettings { get; set; }
        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<Grades1> Grades1 { get; set; }
        public virtual DbSet<GradesDetail> GradesDetail { get; set; }
        public virtual DbSet<HospitalDept> HospitalDept { get; set; }
        public virtual DbSet<HospitalSeats> HospitalSeats { get; set; }
        public virtual DbSet<Hospitals> Hospitals { get; set; }
        public virtual DbSet<HousingAllowances> HousingAllowances { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<InvoicesLines> InvoicesLines { get; set; }
        public virtual DbSet<ItemCategories> ItemCategories { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<JobOffers> JobOffers { get; set; }
        public virtual DbSet<JobPortalUsers> JobPortalUsers { get; set; }
        public virtual DbSet<Leaves> Leaves { get; set; }
        public virtual DbSet<LeavesProfile> LeavesProfile { get; set; }
        public virtual DbSet<LeavesReturn> LeavesReturn { get; set; }
        public virtual DbSet<Loans> Loans { get; set; }
        public virtual DbSet<LookupTypes> LookupTypes { get; set; }
        public virtual DbSet<Lookups> Lookups { get; set; }
        public virtual DbSet<Major> Major { get; set; }
        public virtual DbSet<MajorType> MajorType { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<NationalHolidays> NationalHolidays { get; set; }
        public virtual DbSet<Navigations> Navigations { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<Operator> Operator { get; set; }
        public virtual DbSet<OvertimeRequests> OvertimeRequests { get; set; }
        public virtual DbSet<OvertimeRequestsLines> OvertimeRequestsLines { get; set; }
        public virtual DbSet<OvertimeSettings> OvertimeSettings { get; set; }
        public virtual DbSet<Owner> Owner { get; set; }
        public virtual DbSet<Parents> Parents { get; set; }
        public virtual DbSet<PayGroups> PayGroups { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<PayrunD> PayrunD { get; set; }
        public virtual DbSet<PayrunM> PayrunM { get; set; }
        public virtual DbSet<PayrunPayslip> PayrunPayslip { get; set; }
        public virtual DbSet<PerformanceBaseSalary> PerformanceBaseSalary { get; set; }
        public virtual DbSet<PlanCourses> PlanCourses { get; set; }
        public virtual DbSet<PlanMain> PlanMain { get; set; }
        public virtual DbSet<PlanPrerequisites> PlanPrerequisites { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<Privileges> Privileges { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<QuestionOptions> QuestionOptions { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Quiz> Quiz { get; set; }
        public virtual DbSet<Receipts> Receipts { get; set; }
        public virtual DbSet<Refunds> Refunds { get; set; }
        public virtual DbSet<RefundsLines> RefundsLines { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<Research> Research { get; set; }
        public virtual DbSet<RolePrivileges> RolePrivileges { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<RuleAndRegulations> RuleAndRegulations { get; set; }
        public virtual DbSet<SalaryPayablesPerMonth> SalaryPayablesPerMonth { get; set; }
        public virtual DbSet<SeatEnroll> SeatEnroll { get; set; }
        public virtual DbSet<Sections> Sections { get; set; }
        public virtual DbSet<Semesters> Semesters { get; set; }
        public virtual DbSet<Shifts> Shifts { get; set; }
        public virtual DbSet<SpecialOccasions> SpecialOccasions { get; set; }
        public virtual DbSet<StdEnroll> StdEnroll { get; set; }
        public virtual DbSet<StdGpa> StdGpa { get; set; }
        public virtual DbSet<StdLetters> StdLetters { get; set; }
        public virtual DbSet<StdSemesters> StdSemesters { get; set; }
        public virtual DbSet<StudentAccountDues> StudentAccountDues { get; set; }
        public virtual DbSet<StudentAttachments> StudentAttachments { get; set; }
        public virtual DbSet<StudentAttendance> StudentAttendance { get; set; }
        public virtual DbSet<StudentDiscountType> StudentDiscountType { get; set; }
        public virtual DbSet<StudentEducations> StudentEducations { get; set; }
        public virtual DbSet<StudentGpa> StudentGpa { get; set; }
        public virtual DbSet<StudentSeat> StudentSeat { get; set; }
        public virtual DbSet<StudentSponsor> StudentSponsor { get; set; }
        public virtual DbSet<StudentUsers> StudentUsers { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<SubSections> SubSections { get; set; }
        public virtual DbSet<Submissions> Submissions { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<TaxRates> TaxRates { get; set; }
        public virtual DbSet<TeamMembers> TeamMembers { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<TimeInOutCorrection> TimeInOutCorrection { get; set; }
        public virtual DbSet<Trusties> Trusties { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<UserPrivileges> UserPrivileges { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VacantJobs> VacantJobs { get; set; }
        public virtual DbSet<VacationProfiles> VacationProfiles { get; set; }
        public virtual DbSet<Vendors> Vendors { get; set; }
        public virtual DbSet<Visitor> Visitor { get; set; }
        public virtual DbSet<Voucher> Voucher { get; set; }
        public virtual DbSet<VoucherLines> VoucherLines { get; set; }
        public virtual DbSet<WeekendOvertime> WeekendOvertime { get; set; }
        public virtual DbSet<Zoom> Zoom { get; set; }
        public virtual DbSet<ZoomMeeting> ZoomMeeting { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-PF56OQF;Database=DB_A29478_nsDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbsentProfiles>(entity =>
            {
                entity.HasKey(e => e.AbsentProfileId);

                entity.ToTable("ABSENT_PROFILES", "HR");

                entity.Property(e => e.AbsentProfileId).HasColumnName("ABSENT_PROFILE_ID");

                entity.Property(e => e.AbsentProfileCode)
                    .HasColumnName("ABSENT_PROFILE_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AbsentProfileNameAr)
                    .HasColumnName("ABSENT_PROFILE_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.AbsentProfileNameEn)
                    .IsRequired()
                    .HasColumnName("ABSENT_PROFILE_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");
            });

            modelBuilder.Entity<AcademicYears>(entity =>
            {
                entity.HasKey(e => e.AcademicYearId)
                    .HasName("PK_ACADEMIC_YEAR");

                entity.ToTable("ACADEMIC_YEARS", "ACD");

                entity.Property(e => e.AcademicYearId).HasColumnName("ACADEMIC_YEAR_ID");

                entity.Property(e => e.ActiveStatus)
                    .HasColumnName("ACTIVE_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CampusId).HasColumnName("CAMPUS_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.SemesterId).HasColumnName("SEMESTER_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Year).HasColumnName("YEAR");

                entity.HasOne(d => d.Campus)
                    .WithMany(p => p.AcademicYears)
                    .HasForeignKey(d => d.CampusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACADEMIC_YEARS_CAMPUS");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.AcademicYears)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACADEMIC_YEARS_SEMESTERS");
            });

            modelBuilder.Entity<AccountGroups>(entity =>
            {
                entity.HasKey(e => e.AccountGroupId);

                entity.ToTable("ACCOUNT_GROUPS", "FN");

                entity.Property(e => e.AccountGroupId).HasColumnName("ACCOUNT_GROUP_ID");

                entity.Property(e => e.AccountGroupCode)
                    .HasColumnName("ACCOUNT_GROUP_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccountGroupNameAr)
                    .HasColumnName("ACCOUNT_GROUP_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountGroupNameEn)
                    .IsRequired()
                    .HasColumnName("ACCOUNT_GROUP_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentAccountGroupId).HasColumnName("PARENT_ACCOUNT_GROUP_ID");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.AccountGroups)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCOUNT_GROUPS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AccountGroups)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCOUNT_GROUPS_COMPANY");
            });

            modelBuilder.Entity<AccountTypes>(entity =>
            {
                entity.HasKey(e => e.AccountTypeId);

                entity.ToTable("ACCOUNT_TYPES", "FN");

                entity.Property(e => e.AccountTypeId).HasColumnName("ACCOUNT_TYPE_ID");

                entity.Property(e => e.AccountTypeCode)
                    .HasColumnName("ACCOUNT_TYPE_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccountTypeNameAr)
                    .HasColumnName("ACCOUNT_TYPE_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountTypeNameEn)
                    .IsRequired()
                    .HasColumnName("ACCOUNT_TYPE_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentAccountTypeId).HasColumnName("PARENT_ACCOUNT_TYPE_ID");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.AccountTypes)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCOUNT_TYPES_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AccountTypes)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCOUNT_TYPES_COMPANY");

                entity.HasOne(d => d.ParentAccountType)
                    .WithMany(p => p.InverseParentAccountType)
                    .HasForeignKey(d => d.ParentAccountTypeId)
                    .HasConstraintName("FK_ACCOUNT_TYPES_ACCOUNT_TYPES");
            });

            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("ACCOUNTS", "FN");

                entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("ACCOUNT_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountGroupId).HasColumnName("ACCOUNT_GROUP_ID");

                entity.Property(e => e.AccountLevel).HasColumnName("ACCOUNT_LEVEL");

                entity.Property(e => e.AccountNameAr)
                    .HasColumnName("ACCOUNT_NAME_AR")
                    .HasMaxLength(150);

                entity.Property(e => e.AccountNameEn)
                    .IsRequired()
                    .HasColumnName("ACCOUNT_NAME_EN")
                    .HasMaxLength(150);

                entity.Property(e => e.AccountTypeId).HasColumnName("ACCOUNT_TYPE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.ClosingBalance)
                    .HasColumnName("CLOSING_BALANCE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultType)
                    .HasColumnName("DEFAULT_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsTransactionable).HasColumnName("IS_TRANSACTIONABLE");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpeningBalance)
                    .HasColumnName("OPENING_BALANCE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentAccountId).HasColumnName("PARENT_ACCOUNT_ID");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.HasOne(d => d.AccountGroup)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AccountGroupId)
                    .HasConstraintName("FK_ACCOUNTS_ACCOUNT_GROUPS");

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AccountTypeId)
                    .HasConstraintName("FK_ACCOUNTS_ACCOUNT_TYPES");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCOUNTS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCOUNTS_COMPANY");

                entity.HasOne(d => d.ParentAccount)
                    .WithMany(p => p.InverseParentAccount)
                    .HasForeignKey(d => d.ParentAccountId)
                    .HasConstraintName("FK_ACCOUNTS_ACCOUNTS");
            });

            modelBuilder.Entity<Achievement>(entity =>
            {
                entity.ToTable("ACHIEVEMENT", "HR");

                entity.Property(e => e.AchievementId).HasColumnName("ACHIEVEMENT_ID");

                entity.Property(e => e.AchievementDate)
                    .HasColumnName("ACHIEVEMENT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.AchievementTitle)
                    .HasColumnName("ACHIEVEMENT_TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.Attachments)
                    .HasColumnName("ATTACHMENTS")
                    .HasMaxLength(50);

                entity.Property(e => e.AwardName)
                    .HasColumnName("AWARD_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Detail)
                    .HasColumnName("DETAIL")
                    .HasMaxLength(500);

                entity.Property(e => e.Donor)
                    .HasColumnName("DONOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.Achievement)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_ACHIEVEMENT_EMP");
            });

            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.ToTable("ACTIVITY_LOG", "AUTH");

                entity.Property(e => e.ActivityLogId).HasColumnName("ACTIVITY_LOG_ID");

                entity.Property(e => e.LogDate)
                    .HasColumnName("LOG_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogDetail)
                    .IsRequired()
                    .HasColumnName("LOG_DETAIL");

                entity.Property(e => e.LogType)
                    .IsRequired()
                    .HasColumnName("LOG_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleId).HasColumnName("MODULE_ID");

                entity.Property(e => e.NavigationId).HasColumnName("NAVIGATION_ID");

                entity.Property(e => e.RefId).HasColumnName("REF_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200);

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.UserIp)
                    .HasColumnName("USER_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.LogTypeNavigation)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.LogType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACTIVITY_LOG_LOOKUPS");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_ACTIVITY_LOG_MODULES");

                entity.HasOne(d => d.Navigation)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.NavigationId)
                    .HasConstraintName("FK_ACTIVITY_LOG_NAVIGATIONS");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACTIVITY_LOG_USERS");
            });

            modelBuilder.Entity<AddmissionFormsRemarks>(entity =>
            {
                entity.ToTable("ADDMISSION_FORMS_REMARKS", "ACD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdmissionFormId).HasColumnName("ADMISSION_FORM_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(550)
                    .IsUnicode(false);

                entity.HasOne(d => d.AdmissionForm)
                    .WithMany(p => p.AddmissionFormsRemarks)
                    .HasForeignKey(d => d.AdmissionFormId)
                    .HasConstraintName("FK_ADDMISSION_FORMS_REMARKS_ADMISSION_FORMS");
            });

            modelBuilder.Entity<AdmissionForms>(entity =>
            {
                entity.HasKey(e => e.AdmissionFormId)
                    .HasName("PK_APPLICATIONS");

                entity.ToTable("ADMISSION_FORMS", "ACD");

                entity.Property(e => e.AdmissionFormId).HasColumnName("ADMISSION_FORM_ID");

                entity.Property(e => e.AcademicYearId).HasColumnName("ACADEMIC_YEAR_ID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(150);

                entity.Property(e => e.AdmissionFormStatus)
                    .HasColumnName("ADMISSION_FORM_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AdmittedDate)
                    .HasColumnName("ADMITTED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.AdvisorId).HasColumnName("ADVISOR_ID");

                entity.Property(e => e.AnySpecialCaseForCommittee)
                    .HasColumnName("ANY_SPECIAL_CASE_FOR_COMMITTEE")
                    .HasMaxLength(30);

                entity.Property(e => e.BatchNo).HasColumnName("BATCH_NO");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("BIRTH_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.BirthDateHijgri)
                    .HasColumnName("BIRTH_DATE_HIJGRI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BirthPlaceId)
                    .HasColumnName("BIRTH_PLACE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BloodGroup)
                    .HasColumnName("BLOOD_GROUP")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CampusId).HasColumnName("CAMPUS_ID");

                entity.Property(e => e.ChronicDieses)
                    .HasColumnName("CHRONIC_DIESES")
                    .HasMaxLength(30);

                entity.Property(e => e.ChronicDiesesFamilyHistory)
                    .HasColumnName("CHRONIC_DIESES_FAMILY_HISTORY")
                    .HasMaxLength(30);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrentQualificationId)
                    .HasColumnName("CURRENT_QUALIFICATION_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DEPARTMENT_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DoesFatherWork).HasColumnName("DOES_FATHER_WORK");

                entity.Property(e => e.DoesMotherWork).HasColumnName("DOES_MOTHER_WORK");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyMobileNo)
                    .HasColumnName("EMERGENCY_MOBILE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyName)
                    .HasColumnName("EMERGENCY_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.EmergencyPhoneNo)
                    .HasColumnName("EMERGENCY_PHONE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyRelationship)
                    .HasColumnName("EMERGENCY_RELATIONSHIP")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FahterWorkingSector)
                    .HasColumnName("FAHTER_WORKING_SECTOR")
                    .HasMaxLength(50);

                entity.Property(e => e.FamilyMembersNo)
                    .HasColumnName("FAMILY_MEMBERS_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.FamilyMonthlyIncomeRange)
                    .HasColumnName("FAMILY_MONTHLY_INCOME_RANGE")
                    .HasMaxLength(50);

                entity.Property(e => e.FamilyName)
                    .HasColumnName("FAMILY_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FamilyNameAr)
                    .HasColumnName("FAMILY_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.FatherAlive).HasColumnName("FATHER_ALIVE");

                entity.Property(e => e.FatherIncomeSource)
                    .HasColumnName("FATHER_INCOME_SOURCE")
                    .HasMaxLength(50);

                entity.Property(e => e.FatherName)
                    .HasColumnName("FATHER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FatherNameAr)
                    .HasColumnName("FATHER_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.FatherQualification)
                    .HasColumnName("FATHER_QUALIFICATION")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstNameAr)
                    .HasColumnName("FIRST_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.GenderId)
                    .HasColumnName("GENDER_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GrandFatherName)
                    .HasColumnName("GRAND_FATHER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrandFatherNameAr)
                    .HasColumnName("GRAND_FATHER_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.HasFatherIncome).HasColumnName("HAS_FATHER_INCOME");

                entity.Property(e => e.HasParentSocialCase)
                    .HasColumnName("HAS_PARENT_SOCIAL_CASE")
                    .HasMaxLength(50);

                entity.Property(e => e.HousingType)
                    .HasColumnName("HOUSING_TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.HowDoYouKnowAboutTheCollege)
                    .HasColumnName("HOW_DO_YOU_KNOW_ABOUT_THE_COLLEGE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdType)
                    .HasColumnName("ID_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.JobDate)
                    .HasColumnName("JOB_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(30);

                entity.Property(e => e.LastJob)
                    .HasColumnName("LAST_JOB")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastNameAr)
                    .HasColumnName("LAST_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.MajorId).HasColumnName("MAJOR_ID");

                entity.Property(e => e.MajorTypeId).HasColumnName("MAJOR_TYPE_ID");

                entity.Property(e => e.MaritalStatusId)
                    .HasColumnName("MARITAL_STATUS_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("MIDDLE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleNameAr)
                    .HasColumnName("MIDDLE_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MotherAlive).HasColumnName("MOTHER_ALIVE");

                entity.Property(e => e.MotherMobileNo)
                    .HasColumnName("MOTHER_MOBILE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MotherName)
                    .HasColumnName("MOTHER_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.MotherQualification)
                    .HasColumnName("MOTHER_QUALIFICATION")
                    .HasMaxLength(50);

                entity.Property(e => e.MotherWorkingSector)
                    .HasColumnName("MOTHER_WORKING_SECTOR")
                    .HasMaxLength(50);

                entity.Property(e => e.NationalIdentity)
                    .HasColumnName("NATIONAL_IDENTITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NationalIdentityExpiryDate)
                    .HasColumnName("NATIONAL_IDENTITY_EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.NationalIdentityExpiryDateHijri)
                    .HasColumnName("NATIONAL_IDENTITY_EXPIRY_DATE_HIJRI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NationalIdentityIssuedDate)
                    .HasColumnName("NATIONAL_IDENTITY_ISSUED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.NationalIdentityIssuedDateHijri)
                    .HasColumnName("NATIONAL_IDENTITY_ISSUED_DATE_HIJRI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityId)
                    .HasColumnName("NATIONALITY_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfChildrens).HasColumnName("NO_OF_CHILDRENS");

                entity.Property(e => e.PassportExpiryDate)
                    .HasColumnName("PASSPORT_EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.PassportExpiryDateHijri)
                    .HasColumnName("PASSPORT_EXPIRY_DATE_HIJRI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PassportIssuedDate)
                    .HasColumnName("PASSPORT_ISSUED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.PassportIssuedDateHijri)
                    .HasColumnName("PASSPORT_ISSUED_DATE_HIJRI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PassportIssuedFrom)
                    .HasColumnName("PASSPORT_ISSUED_FROM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PassportNo)
                    .HasColumnName("PASSPORT_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfIssue)
                    .HasColumnName("PLACE_OF_ISSUE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ProfilePic)
                    .HasColumnName("PROFILE_PIC")
                    .HasMaxLength(200);

                entity.Property(e => e.Sector)
                    .HasColumnName("SECTOR")
                    .HasMaxLength(30);

                entity.Property(e => e.SponsorEmail)
                    .HasColumnName("SPONSOR_EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorMobileNo)
                    .HasColumnName("SPONSOR_MOBILE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorName)
                    .HasColumnName("SPONSOR_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.SponsorNotes)
                    .HasColumnName("SPONSOR_NOTES")
                    .HasMaxLength(50);

                entity.Property(e => e.SponsorPhoneNo)
                    .HasColumnName("SPONSOR_PHONE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorRelationship)
                    .HasColumnName("SPONSOR_RELATIONSHIP")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StdOrderAmongSiblings)
                    .HasColumnName("STD_ORDER_AMONG_SIBLINGS")
                    .HasMaxLength(20);

                entity.Property(e => e.StudentUserId).HasColumnName("STUDENT_USER_ID");

                entity.Property(e => e.ThirdName)
                    .HasColumnName("THIRD_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdNameAr)
                    .HasColumnName("THIRD_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.Transportation)
                    .HasColumnName("TRANSPORTATION")
                    .HasMaxLength(30);

                entity.Property(e => e.WithWhomStudentsLive)
                    .HasColumnName("WITH_WHOM_STUDENTS_LIVE")
                    .HasMaxLength(20);

                entity.Property(e => e.WorkingPlace)
                    .HasColumnName("WORKING_PLACE")
                    .HasMaxLength(30);

                entity.HasOne(d => d.AcademicYear)
                    .WithMany(p => p.AdmissionForms)
                    .HasForeignKey(d => d.AcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMISSION_FORMS_ACADEMIC_YEARS");

                entity.HasOne(d => d.AdmissionFormStatusNavigation)
                    .WithMany(p => p.AdmissionForms)
                    .HasForeignKey(d => d.AdmissionFormStatus)
                    .HasConstraintName("FK_ADMISSION_FORMS_LOOKUPS");

                entity.HasOne(d => d.Campus)
                    .WithMany(p => p.AdmissionForms)
                    .HasForeignKey(d => d.CampusId)
                    .HasConstraintName("FK_ADMISSION_FORMS_CAMPUS");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.AdmissionForms)
                    .HasForeignKey(d => d.MajorId)
                    .HasConstraintName("FK_ADMISSION_FORMS_MAJOR");

                entity.HasOne(d => d.MajorType)
                    .WithMany(p => p.AdmissionForms)
                    .HasForeignKey(d => d.MajorTypeId)
                    .HasConstraintName("FK_ADMISSION_FORMS_MAJOR_TYPE");

                entity.HasOne(d => d.StudentUser)
                    .WithMany(p => p.AdmissionForms)
                    .HasForeignKey(d => d.StudentUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMISSION_FORMS_STUDENT_USERS");
            });

            modelBuilder.Entity<AdmissionFormsAttachments>(entity =>
            {
                entity.HasKey(e => e.AdmissionFormsAttachmentId);

                entity.ToTable("ADMISSION_FORMS_ATTACHMENTS", "ACD");

                entity.Property(e => e.AdmissionFormsAttachmentId).HasColumnName("ADMISSION_FORMS_ATTACHMENT_ID");

                entity.Property(e => e.AdmissionDocumentId)
                    .HasColumnName("ADMISSION_DOCUMENT_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AdmissionFormId).HasColumnName("ADMISSION_FORM_ID");

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(300);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentDetail)
                    .HasColumnName("DOCUMENT_DETAIL")
                    .HasMaxLength(250);

                entity.Property(e => e.DocumentName)
                    .HasColumnName("DOCUMENT_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("ISSUE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.StudentUserId).HasColumnName("STUDENT_USER_ID");

                entity.HasOne(d => d.AdmissionForm)
                    .WithMany(p => p.AdmissionFormsAttachments)
                    .HasForeignKey(d => d.AdmissionFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMISSION_FORMS_ATTACHMENTS_ADMISSION_FORMS");

                entity.HasOne(d => d.StudentUser)
                    .WithMany(p => p.AdmissionFormsAttachments)
                    .HasForeignKey(d => d.StudentUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMISSION_FORMS_ATTACHMENTS_STUDENT_USERS");
            });

            modelBuilder.Entity<AdmissionFormsEducations>(entity =>
            {
                entity.HasKey(e => e.AdmissionFormsEducationId);

                entity.ToTable("ADMISSION_FORMS_EDUCATIONS", "ACD");

                entity.Property(e => e.AdmissionFormsEducationId).HasColumnName("ADMISSION_FORMS_EDUCATION_ID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(250);

                entity.Property(e => e.AdmissionFormId).HasColumnName("ADMISSION_FORM_ID");

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrentQualificationId)
                    .HasColumnName("CURRENT_QUALIFICATION_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfGraduate)
                    .HasColumnName("DATE_OF_GRADUATE")
                    .HasColumnType("date");

                entity.Property(e => e.DegreeName)
                    .HasColumnName("DEGREE_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.DiplomaGrade)
                    .HasColumnName("DIPLOMA_GRADE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DiplomaMajor)
                    .HasColumnName("DIPLOMA_MAJOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiplomaUniversityName)
                    .HasColumnName("DIPLOMA_UNIVERSITY_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndMonth).HasColumnName("END_MONTH");

                entity.Property(e => e.EndYear).HasColumnName("END_YEAR");

                entity.Property(e => e.Grade)
                    .HasColumnName("GRADE")
                    .HasMaxLength(50);

                entity.Property(e => e.GradeInHighSchool)
                    .HasColumnName("GRADE_IN_HIGH_SCHOOL")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GradeTransfer)
                    .HasColumnName("GRADE_TRANSFER")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HighSchoolMajor)
                    .HasColumnName("HIGH_SCHOOL_MAJOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionName)
                    .HasColumnName("INSTITUTION_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Major)
                    .HasColumnName("MAJOR")
                    .HasMaxLength(50);

                entity.Property(e => e.MajorTransfer)
                    .HasColumnName("MAJOR_TRANSFER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.NameOfHighSchool)
                    .HasColumnName("NAME_OF_HIGH_SCHOOL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassedYear).HasColumnName("PASSED_YEAR");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.QudaratGrade)
                    .HasColumnName("QUDARAT_GRADE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StartMonth).HasColumnName("START_MONTH");

                entity.Property(e => e.StartYear).HasColumnName("START_YEAR");

                entity.Property(e => e.StudentUserId).HasColumnName("STUDENT_USER_ID");

                entity.Property(e => e.TahsiliGrade)
                    .HasColumnName("TAHSILI_GRADE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UniversityNameTransfer)
                    .HasColumnName("UNIVERSITY_NAME_TRANSFER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AdmissionForm)
                    .WithMany(p => p.AdmissionFormsEducations)
                    .HasForeignKey(d => d.AdmissionFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMISSION_FORMS_EDUCATIONS_ADMISSION_FORMS");

                entity.HasOne(d => d.StudentUser)
                    .WithMany(p => p.AdmissionFormsEducations)
                    .HasForeignKey(d => d.StudentUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMISSION_FORMS_EDUCATIONS_STUDENT_USERS");
            });

            modelBuilder.Entity<AirTicketProfiles>(entity =>
            {
                entity.HasKey(e => e.AirTicketProfileId);

                entity.ToTable("AIR_TICKET_PROFILES", "HR");

                entity.Property(e => e.AirTicketProfileId).HasColumnName("AIR_TICKET_PROFILE_ID");

                entity.Property(e => e.AirTicketProfileCode)
                    .HasColumnName("AIR_TICKET_PROFILE_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirTicketProfileNameAr)
                    .HasColumnName("AIR_TICKET_PROFILE_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.AirTicketProfileNameEn)
                    .IsRequired()
                    .HasColumnName("AIR_TICKET_PROFILE_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");
            });

            modelBuilder.Entity<Annoucment>(entity =>
            {
                entity.ToTable("ANNOUCMENT", "ACD");

                entity.Property(e => e.AnnoucmentId).HasColumnName("ANNOUCMENT_ID");

                entity.Property(e => e.AnnoucementDate)
                    .HasColumnName("ANNOUCEMENT_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.AnnoucementFrom).HasColumnName("ANNOUCEMENT_FROM");

                entity.Property(e => e.AnnoucementType)
                    .HasColumnName("ANNOUCEMENT_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleAr)
                    .HasColumnName("TITLE_AR")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Answers>(entity =>
            {
                entity.HasKey(e => e.AnswerId);

                entity.ToTable("ANSWERS", "ACD");

                entity.Property(e => e.AnswerId).HasColumnName("ANSWER_ID");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("CATEGORY_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.OptionId).HasColumnName("OPTION_ID");

                entity.Property(e => e.QuestionId).HasColumnName("QUESTION_ID");

                entity.Property(e => e.QuizId).HasColumnName("QUIZ_ID");

                entity.Property(e => e.StdId).HasColumnName("STD_ID");

                entity.Property(e => e.Survey)
                    .HasColumnName("SURVEY")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.OptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSWERS_QUESTION_OPTIONS");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSWERS_QUESTIONS");

                entity.HasOne(d => d.Std)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.StdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSWERS_STUDENTS");
            });

            modelBuilder.Entity<AppConfig>(entity =>
            {
                entity.HasKey(e => e.ConfigId)
                    .HasName("PK_CONFIGS");

                entity.ToTable("APP_CONFIG");

                entity.Property(e => e.ConfigId).HasColumnName("CONFIG_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.ConfigName)
                    .HasColumnName("CONFIG_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigType)
                    .HasColumnName("CONFIG_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigVal).HasColumnName("CONFIG_VAL");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AppConfig)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_APP_CONFIG_COMPANY");
            });

            modelBuilder.Entity<Applications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId);

                entity.ToTable("APPLICATIONS", "HR");

                entity.Property(e => e.ApplicationId).HasColumnName("APPLICATION_ID");

                entity.Property(e => e.ApplicantId).HasColumnName("APPLICANT_ID");

                entity.Property(e => e.ApplicantName)
                    .HasColumnName("APPLICANT_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.ApplicationSourceType)
                    .HasColumnName("APPLICATION_SOURCE_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationStatus)
                    .HasColumnName("APPLICATION_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment(@"1- Initial Qualification
2- First Interview
3- Second Interview
4- Contract Proposal
5- Contract Signed");

                entity.Property(e => e.ApplicationSummary)
                    .HasColumnName("APPLICATION_SUMMARY")
                    .HasMaxLength(500);

                entity.Property(e => e.Availability)
                    .HasColumnName("AVAILABILITY")
                    .HasColumnType("datetime");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CoverNote)
                    .HasColumnName("COVER_NOTE")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CvAttachment)
                    .HasColumnName("CV_ATTACHMENT")
                    .HasMaxLength(50);

                entity.Property(e => e.DegreeId)
                    .HasColumnName("DEGREE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedExtra)
                    .HasColumnName("EXPECTED_EXTRA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ExpectedSalary)
                    .HasColumnName("EXPECTED_SALARY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.JobDepartmentId)
                    .HasColumnName("JOB_DEPARTMENT_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ProposedExtra)
                    .HasColumnName("PROPOSED_EXTRA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProposedSalary)
                    .HasColumnName("PROPOSED_SALARY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VacantJobId).HasColumnName("VACANT_JOB_ID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_APPLICATIONS_VACANT_JOBS");
            });

            modelBuilder.Entity<ApprovalRoutes>(entity =>
            {
                entity.HasKey(e => e.ApprovalRouteId)
                    .HasName("PK_APPROVAL_ROUTE");

                entity.ToTable("APPROVAL_ROUTES", "AUTH");

                entity.Property(e => e.ApprovalRouteId).HasColumnName("APPROVAL_ROUTE_ID");

                entity.Property(e => e.ApprovalTaskId).HasColumnName("APPROVAL_TASK_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.IsDepartment).HasColumnName("IS_DEPARTMENT");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.SeqId).HasColumnName("SEQ_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.ApprovalRoutes)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APPROVAL_ROUTES_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ApprovalRoutes)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APPROVAL_ROUTES_COMPANY");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.ApprovalRoutes)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_APPROVAL_ROUTES_DEPARTMENTS");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ApprovalRoutes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_APPROVAL_ROUTES_USERS");
            });

            modelBuilder.Entity<ApprovalRoutesDetail>(entity =>
            {
                entity.HasKey(e => e.RouteDetailId);

                entity.ToTable("APPROVAL_ROUTES_DETAIL", "AUTH");

                entity.Property(e => e.RouteDetailId).HasColumnName("ROUTE_DETAIL_ID");

                entity.Property(e => e.ActionDate)
                    .HasColumnName("ACTION_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ApprovalRouteId).HasColumnName("APPROVAL_ROUTE_ID");

                entity.Property(e => e.ApprovalStatus)
                    .HasColumnName("APPROVAL_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalTaskId)
                    .HasColumnName("APPROVAL_TASK_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ApproverNotes)
                    .HasColumnName("APPROVER_NOTES")
                    .HasMaxLength(100);

                entity.Property(e => e.ApproverUserId).HasColumnName("APPROVER_USER_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.IsDepartment).HasColumnName("IS_DEPARTMENT");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RECORD_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordName)
                    .HasColumnName("RECORD_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordNotes)
                    .HasColumnName("RECORD_NOTES")
                    .HasMaxLength(100);

                entity.Property(e => e.RequestedBy).HasColumnName("REQUESTED_BY");

                entity.Property(e => e.SeqId).HasColumnName("SEQ_ID");

                entity.HasOne(d => d.ApprovalRoute)
                    .WithMany(p => p.ApprovalRoutesDetail)
                    .HasForeignKey(d => d.ApprovalRouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APPROVAL_ROUTES_DETAIL_APPROVAL_ROUTES");
            });

            modelBuilder.Entity<ApprovalTasks>(entity =>
            {
                entity.HasKey(e => e.ApprovalTaskId)
                    .HasName("PK_APPROVAL_TASK");

                entity.ToTable("APPROVAL_TASKS", "AUTH");

                entity.Property(e => e.ApprovalTaskId).HasColumnName("APPROVAL_TASK_ID");

                entity.Property(e => e.ApprovalTaskCode)
                    .HasColumnName("APPROVAL_TASK_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalTaskDescriptionAr)
                    .HasColumnName("APPROVAL_TASK_DESCRIPTION_AR")
                    .HasMaxLength(200);

                entity.Property(e => e.ApprovalTaskDescriptionEn)
                    .IsRequired()
                    .HasColumnName("APPROVAL_TASK_DESCRIPTION_EN")
                    .HasMaxLength(200);

                entity.Property(e => e.ApprovalTaskNameAr)
                    .HasColumnName("APPROVAL_TASK_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.ApprovalTaskNameEn)
                    .IsRequired()
                    .HasColumnName("APPROVAL_TASK_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.NavigationIds)
                    .HasColumnName("NAVIGATION_IDS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.ApprovalTasks)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APPROVAL_TASKS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ApprovalTasks)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APPROVAL_TASKS_COMPANY");
            });

            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.ToTable("ASSIGNMENT", "ACD");

                entity.Property(e => e.AssignmentId).HasColumnName("ASSIGNMENT_ID");

                entity.Property(e => e.AcademicYearId).HasColumnName("ACADEMIC_YEAR_ID");

                entity.Property(e => e.AllowLatesubmission).HasColumnName("ALLOW_LATESUBMISSION");

                entity.Property(e => e.AllowResubmitting).HasColumnName("ALLOW_RESUBMITTING");

                entity.Property(e => e.AssignmentViewDate)
                    .HasColumnName("ASSIGNMENT_VIEW_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasColumnName("DUE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.MaterialType)
                    .HasColumnName("MATERIAL_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.TeacherId).HasColumnName("TEACHER_ID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleAr)
                    .HasColumnName("TITLE_AR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TutorialLink)
                    .HasColumnName("TUTORIAL_LINK")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Banks>(entity =>
            {
                entity.HasKey(e => e.BankId);

                entity.ToTable("BANKS", "FN");

                entity.Property(e => e.BankId).HasColumnName("BANK_ID");

                entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");

                entity.Property(e => e.ActiveStatus)
                    .HasColumnName("ACTIVE_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(250);

                entity.Property(e => e.BankNameAr)
                    .HasColumnName("BANK_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.BankNameEn)
                    .HasColumnName("BANK_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CompanyRegistrationNo)
                    .HasColumnName("COMPANY_REGISTRATION_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.GstNo)
                    .HasColumnName("GST_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.NtnNo)
                    .HasColumnName("NTN_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PrimaryPerson)
                    .HasColumnName("PRIMARY_PERSON")
                    .HasMaxLength(50);

                entity.Property(e => e.Skype)
                    .HasColumnName("SKYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasColumnName("WEBSITE")
                    .HasMaxLength(50);

                entity.Property(e => e.ZipCode)
                    .HasColumnName("ZIP_CODE")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Banks)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_BANKS_ACCOUNTS");
            });

            modelBuilder.Entity<Bills>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.ToTable("BILLS", "AP");

                entity.Property(e => e.BillId).HasColumnName("BILL_ID");

                entity.Property(e => e.BillDate)
                    .HasColumnName("BILL_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.BillNo)
                    .HasColumnName("BILL_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPer)
                    .HasColumnName("DISCOUNT_PER")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DueDate)
                    .HasColumnName("DUE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.GlBatchId)
                    .HasColumnName("GL_BATCH_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsPosted).HasColumnName("IS_POSTED");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(1000);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PostedBy).HasColumnName("POSTED_BY");

                entity.Property(e => e.PostedDate)
                    .HasColumnName("POSTED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RefNo)
                    .HasColumnName("REF_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.SubTotal)
                    .HasColumnName("SUB_TOTAL")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRateId).HasColumnName("TAX_RATE_ID");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalDiscount)
                    .HasColumnName("TOTAL_DISCOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalTax)
                    .HasColumnName("TOTAL_TAX")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId).HasColumnName("VENDOR_ID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_BILLS_BRANCH");

                entity.HasOne(d => d.TaxRate)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.TaxRateId)
                    .HasConstraintName("FK_BILLS_TAX_RATES");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_BILLS_VENDORS");
            });

            modelBuilder.Entity<BillsLines>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("BILLS_LINES", "AP");

                entity.Property(e => e.LineId).HasColumnName("LINE_ID");

                entity.Property(e => e.BillId).HasColumnName("BILL_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountAmount)
                    .HasColumnName("DISCOUNT_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountPercent)
                    .HasColumnName("DISCOUNT_PERCENT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.ItemPrice)
                    .HasColumnName("ITEM_PRICE")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineAmount)
                    .HasColumnName("LINE_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxAmount)
                    .HasColumnName("TAX_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRate)
                    .HasColumnName("TAX_RATE")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRateId).HasColumnName("TAX_RATE_ID");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("UNIT_PRICE")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.BillsLines)
                    .HasForeignKey(d => d.BillId)
                    .HasConstraintName("FK_BILLS_LINES_BILLS");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BillsLines)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_BILLS_LINES_BRANCH");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.BillsLines)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_BILLS_LINES_ITEMS");

                entity.HasOne(d => d.TaxRateNavigation)
                    .WithMany(p => p.BillsLines)
                    .HasForeignKey(d => d.TaxRateId)
                    .HasConstraintName("FK_BILLS_LINES_TAX_RATES");
            });

            modelBuilder.Entity<BookBorrow>(entity =>
            {
                entity.ToTable("BOOK_BORROW", "ACD");

                entity.Property(e => e.BookBorrowId).HasColumnName("BOOK_BORROW_ID");

                entity.Property(e => e.BookId).HasColumnName("BOOK_ID");

                entity.Property(e => e.Borrowdate)
                    .HasColumnName("BORROWDATE")
                    .HasColumnType("date");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.IssuedBy).HasColumnName("ISSUED_BY");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(255);

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookBorrow)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOOK_BORROW_BOOKS");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.BookBorrow)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOOK_BORROW_STUDENTS");
            });

            modelBuilder.Entity<BookReturn>(entity =>
            {
                entity.HasKey(e => e.ReturnId);

                entity.ToTable("BOOK_RETURN", "ACD");

                entity.Property(e => e.ReturnId).HasColumnName("RETURN_ID");

                entity.Property(e => e.BookId).HasColumnName("BOOK_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(255);

                entity.Property(e => e.ReturnDate)
                    .HasColumnName("RETURN_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookReturn)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOOK_RETURN_BOOKS");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.BookReturn)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOOK_RETURN_STUDENTS");
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasKey(e => e.BookId)
                    .HasName("PK_BOOK");

                entity.ToTable("BOOKS", "ACD");

                entity.Property(e => e.BookId).HasColumnName("BOOK_ID");

                entity.Property(e => e.AuthorName)
                    .HasColumnName("AUTHOR_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.BookCode)
                    .HasColumnName("BOOK_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BookFee)
                    .HasColumnName("BOOK_FEE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BookImplementationDate)
                    .HasColumnName("BOOK_IMPLEMENTATION_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.BookLanguageId)
                    .HasColumnName("BOOK_LANGUAGE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BookLastEditionYear).HasColumnName("BOOK_LAST_EDITION_YEAR");

                entity.Property(e => e.BookNameAr)
                    .HasColumnName("BOOK_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.BookNameEn)
                    .IsRequired()
                    .HasColumnName("BOOK_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.BookPictureUrl)
                    .HasColumnName("BOOK_PICTURE_URL")
                    .HasMaxLength(100);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiscountId).HasColumnName("DISCOUNT_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.SoftVersionUrl)
                    .HasColumnName("SOFT_VERSION_URL")
                    .HasMaxLength(100);

                entity.Property(e => e.TeachingEditionYear).HasColumnName("TEACHING_EDITION_YEAR");

                entity.Property(e => e.TextbookBoardId)
                    .HasColumnName("TEXTBOOK_BOARD_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPages).HasColumnName("TOTAL_PAGES");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOOKS_COURSE");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("BRANCH");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.BranchAddressAr)
                    .HasColumnName("BRANCH_ADDRESS_AR")
                    .HasMaxLength(150);

                entity.Property(e => e.BranchAddressEn)
                    .HasColumnName("BRANCH_ADDRESS_EN")
                    .HasMaxLength(150);

                entity.Property(e => e.BranchEmail)
                    .HasColumnName("BRANCH_EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNameAr)
                    .HasColumnName("BRANCH_NAME_AR")
                    .HasMaxLength(100);

                entity.Property(e => e.BranchNameEn)
                    .HasColumnName("BRANCH_NAME_EN")
                    .HasMaxLength(100);

                entity.Property(e => e.BranchPhone)
                    .HasColumnName("BRANCH_PHONE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsEnable).HasColumnName("IS_ENABLE");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_BRANCH_COMPANY");
            });

            modelBuilder.Entity<Buildings>(entity =>
            {
                entity.HasKey(e => e.BuildingId)
                    .HasName("PK_BUILDING");

                entity.ToTable("BUILDINGS");

                entity.Property(e => e.BuildingId).HasColumnName("BUILDING_ID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(150);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.BuildingCode)
                    .HasColumnName("BUILDING_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingNameAr)
                    .HasColumnName("BUILDING_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.BuildingNameEn)
                    .IsRequired()
                    .HasColumnName("BUILDING_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.CityId)
                    .HasColumnName("CITY_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CountryId)
                    .HasColumnName("COUNTRY_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Latitude)
                    .HasColumnName("LATITUDE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasColumnName("LONGITUDE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.ToTable("CALENDAR", "ACD");

                entity.Property(e => e.CalendarId).HasColumnName("CALENDAR_ID");

                entity.Property(e => e.AcademicYearId).HasColumnName("ACADEMIC_YEAR_ID");

                entity.Property(e => e.AdmissionEnd)
                    .HasColumnName("ADMISSION_END")
                    .HasColumnType("datetime");

                entity.Property(e => e.AdmissionStart)
                    .HasColumnName("ADMISSION_START")
                    .HasColumnType("datetime");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CalendarStatusId)
                    .HasColumnName("CALENDAR_STATUS_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ClassEnd)
                    .HasColumnName("CLASS_END")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClassStart)
                    .HasColumnName("CLASS_START")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DropDeductionPercent)
                    .HasColumnName("DROP_DEDUCTION_PERCENT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DropEnd)
                    .HasColumnName("DROP_END")
                    .HasColumnType("datetime");

                entity.Property(e => e.DropStart)
                    .HasColumnName("DROP_START")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinaltermEndDate)
                    .HasColumnName("FINALTERM_END_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.FinaltermStartDate)
                    .HasColumnName("FINALTERM_START_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.LateRegistrationDeductionPercent)
                    .HasColumnName("LATE_REGISTRATION_DEDUCTION_PERCENT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LateRegistrationEnd)
                    .HasColumnName("LATE_REGISTRATION_END")
                    .HasColumnType("datetime");

                entity.Property(e => e.LateRegistrationStart)
                    .HasColumnName("LATE_REGISTRATION_START")
                    .HasColumnType("datetime");

                entity.Property(e => e.MidtermEndDate)
                    .HasColumnName("MIDTERM_END_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.MidtermStartDate)
                    .HasColumnName("MIDTERM_START_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PostPoneDateEnd)
                    .HasColumnName("POST_PONE_DATE_END")
                    .HasColumnType("date");

                entity.Property(e => e.PostPoneDateStart)
                    .HasColumnName("POST_PONE_DATE_START")
                    .HasColumnType("date");

                entity.Property(e => e.RegistrationEnd)
                    .HasColumnName("REGISTRATION_END")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegistrationStart)
                    .HasColumnName("REGISTRATION_START")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(500);

                entity.Property(e => e.ResultDate)
                    .HasColumnName("RESULT_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.SwapEnd)
                    .HasColumnName("SWAP_END")
                    .HasColumnType("datetime");

                entity.Property(e => e.SwapStart)
                    .HasColumnName("SWAP_START")
                    .HasColumnType("datetime");

                entity.Property(e => e.WithdrawDeductionPercent)
                    .HasColumnName("WITHDRAW_DEDUCTION_PERCENT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WithdrawEnd)
                    .HasColumnName("WITHDRAW_END")
                    .HasColumnType("datetime");

                entity.Property(e => e.WithdrawStart)
                    .HasColumnName("WITHDRAW_START")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AcademicYear)
                    .WithMany(p => p.Calendar)
                    .HasForeignKey(d => d.AcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CALENDAR_ACADEMIC_YEARS");
            });

            modelBuilder.Entity<Campus>(entity =>
            {
                entity.ToTable("CAMPUS", "ACD");

                entity.Property(e => e.CampusId).HasColumnName("CAMPUS_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.BuildingId).HasColumnName("BUILDING_ID");

                entity.Property(e => e.CampusCode)
                    .HasColumnName("CAMPUS_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CampusNameAr)
                    .HasColumnName("CAMPUS_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.CampusNameEn)
                    .IsRequired()
                    .HasColumnName("CAMPUS_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.Campus)
                    .HasForeignKey(d => d.BuildingId)
                    .HasConstraintName("FK_CAMPUS_BUILDINGS");
            });

            modelBuilder.Entity<Classes>(entity =>
            {
                entity.HasKey(e => e.ClassId);

                entity.ToTable("CLASSES", "ACD");

                entity.Property(e => e.ClassId).HasColumnName("CLASS_ID");

                entity.Property(e => e.AcademicYearId).HasColumnName("ACADEMIC_YEAR_ID");

                entity.Property(e => e.AttendanceCount).HasColumnName("ATTENDANCE_COUNT");

                entity.Property(e => e.AttendanePercentage).HasColumnName("ATTENDANE_PERCENTAGE");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.ClassCode)
                    .HasColumnName("CLASS_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClassStatusId)
                    .HasColumnName("CLASS_STATUS_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("Active, Cancelled, Closed");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CourseDesc)
                    .HasColumnName("COURSE_DESC")
                    .HasMaxLength(500);

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.CourseSpecification)
                    .HasColumnName("COURSE_SPECIFICATION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DEPARTMENT_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.F10GMarks)
                    .HasColumnName("F10_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F10Per)
                    .HasColumnName("F10_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F10Show).HasColumnName("F10_SHOW");

                entity.Property(e => e.F10Title)
                    .HasColumnName("F10_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F1GMarks)
                    .HasColumnName("F1_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F1Per)
                    .HasColumnName("F1_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F1Show).HasColumnName("F1_SHOW");

                entity.Property(e => e.F1Title)
                    .HasColumnName("F1_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F2GMarks)
                    .HasColumnName("F2_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F2Per)
                    .HasColumnName("F2_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F2Show).HasColumnName("F2_SHOW");

                entity.Property(e => e.F2Title)
                    .HasColumnName("F2_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F3GMarks)
                    .HasColumnName("F3_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F3Per)
                    .HasColumnName("F3_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F3Show).HasColumnName("F3_SHOW");

                entity.Property(e => e.F3Title)
                    .HasColumnName("F3_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F4GMarks)
                    .HasColumnName("F4_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F4Per)
                    .HasColumnName("F4_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F4Show).HasColumnName("F4_SHOW");

                entity.Property(e => e.F4Title)
                    .HasColumnName("F4_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F5GMarks)
                    .HasColumnName("F5_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F5Per)
                    .HasColumnName("F5_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F5Show).HasColumnName("F5_SHOW");

                entity.Property(e => e.F5Title)
                    .HasColumnName("F5_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F6GMarks)
                    .HasColumnName("F6_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F6Per)
                    .HasColumnName("F6_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F6Show).HasColumnName("F6_SHOW");

                entity.Property(e => e.F6Title)
                    .HasColumnName("F6_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F7GMarks)
                    .HasColumnName("F7_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F7Per)
                    .HasColumnName("F7_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F7Show).HasColumnName("F7_SHOW");

                entity.Property(e => e.F7Title)
                    .HasColumnName("F7_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F8GMarks)
                    .HasColumnName("F8_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F8Per)
                    .HasColumnName("F8_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F8Show).HasColumnName("F8_SHOW");

                entity.Property(e => e.F8Title)
                    .HasColumnName("F8_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F9GMarks)
                    .HasColumnName("F9_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F9Per)
                    .HasColumnName("F9_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F9Show).HasColumnName("F9_SHOW");

                entity.Property(e => e.F9Title)
                    .HasColumnName("F9_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.FacultyEmpId).HasColumnName("FACULTY_EMP_ID");

                entity.Property(e => e.GenderId)
                    .HasColumnName("GENDER_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GradeStatusId)
                    .HasColumnName("GRADE_STATUS_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("Active, Cancelled, Closed");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(500);

                entity.Property(e => e.StudentCapacity).HasColumnName("STUDENT_CAPACITY");

                entity.Property(e => e.TotalGMarks)
                    .HasColumnName("TOTAL_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalPer)
                    .HasColumnName("TOTAL_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UserIdFaculty).HasColumnName("USER_ID_FACULTY");

                entity.HasOne(d => d.AcademicYear)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.AcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLASSES_ACADEMIC_YEARS");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLASSES_COURSE");

                entity.HasOne(d => d.UserIdFacultyNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.UserIdFaculty)
                    .HasConstraintName("FK_CLASSES_USERS");
            });

            modelBuilder.Entity<ClassesSchedule>(entity =>
            {
                entity.HasKey(e => e.ClassScheduleId)
                    .HasName("PK_CLASS_SCHEDULEES");

                entity.ToTable("CLASSES_SCHEDULE", "ACD");

                entity.Property(e => e.ClassScheduleId).HasColumnName("CLASS_SCHEDULE_ID");

                entity.Property(e => e.ActiveStatus)
                    .HasColumnName("ACTIVE_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.ClassId).HasColumnName("CLASS_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnName("END_TIME");

                entity.Property(e => e.FacultyEmpId).HasColumnName("FACULTY_EMP_ID");

                entity.Property(e => e.Fri).HasColumnName("FRI");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mon).HasColumnName("MON");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.RoomId).HasColumnName("ROOM_ID");

                entity.Property(e => e.Sat).HasColumnName("SAT");

                entity.Property(e => e.StartTime).HasColumnName("START_TIME");

                entity.Property(e => e.Sun).HasColumnName("SUN");

                entity.Property(e => e.Thu).HasColumnName("THU");

                entity.Property(e => e.Tue).HasColumnName("TUE");

                entity.Property(e => e.Wed).HasColumnName("WED");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassesSchedule)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLASSES_SCHEDULE_CLASSES");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.ClassesSchedule)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_CLASSES_SCHEDULE_ROOMS");
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("COMMENTS");

                entity.Property(e => e.CommentId)
                    .HasColumnName("COMMENT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CommentDate)
                    .HasColumnName("COMMENT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CommentedBy).HasColumnName("COMMENTED_BY");

                entity.Property(e => e.Comments1)
                    .HasColumnName("COMMENTS")
                    .HasMaxLength(500);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocType)
                    .HasColumnName("DOC_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.RefId).HasColumnName("REF_ID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_COMMENTS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMMENTS_COMPANY");

                entity.HasOne(d => d.DocTypeNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.DocType)
                    .HasConstraintName("FK_COMMENTS_DOC_TYPE");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("COMPANY");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.BankDetailAr)
                    .HasColumnName("BANK_DETAIL_AR")
                    .HasMaxLength(500);

                entity.Property(e => e.BankDetailEn)
                    .HasColumnName("BANK_DETAIL_EN")
                    .HasMaxLength(500);

                entity.Property(e => e.CoAddressAr)
                    .HasColumnName("CO_ADDRESS_AR")
                    .HasMaxLength(150);

                entity.Property(e => e.CoAddressEn)
                    .HasColumnName("CO_ADDRESS_EN")
                    .HasMaxLength(150);

                entity.Property(e => e.CoEmail)
                    .HasColumnName("CO_EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoNameAr)
                    .HasColumnName("CO_NAME_AR")
                    .HasMaxLength(100);

                entity.Property(e => e.CoNameEn)
                    .HasColumnName("CO_NAME_EN")
                    .HasMaxLength(100);

                entity.Property(e => e.CoPhone)
                    .HasColumnName("CO_PHONE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CoWebsite)
                    .HasColumnName("CO_WEBSITE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrNo)
                    .HasColumnName("CR_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalYearIsBasedOn)
                    .HasColumnName("FISCAL_YEAR_IS_BASED_ON")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalYearStartMonth).HasColumnName("FISCAL__YEAR_START_MONTH");

                entity.Property(e => e.IsEnable).HasColumnName("IS_ENABLE");

                entity.Property(e => e.Language)
                    .HasColumnName("LANGUAGE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.VatNo)
                    .HasColumnName("VAT_NO")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Conversation>(entity =>
            {
                entity.Property(e => e.ConversationId).HasColumnName("ConversationID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.OperatorId).HasColumnName("OperatorID");

                entity.Property(e => e.PageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PageUrl)
                    .HasColumnName("PageURL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.VisitorId).HasColumnName("VisitorID");

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("COURSE", "ACD");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CampusId).HasColumnName("CAMPUS_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CourseCode)
                    .HasColumnName("COURSE_CODE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CourseDept)
                    .HasColumnName("COURSE_DEPT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CourseDescAr)
                    .HasColumnName("COURSE_DESC_AR")
                    .HasMaxLength(500);

                entity.Property(e => e.CourseDescEn)
                    .IsRequired()
                    .HasColumnName("COURSE_DESC_EN")
                    .HasMaxLength(500);

                entity.Property(e => e.CourseDetailId)
                    .HasColumnName("COURSE_DETAIL_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CourseFee)
                    .HasColumnName("COURSE_FEE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CourseImplementationDate)
                    .HasColumnName("COURSE_IMPLEMENTATION_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.CourseNameAr)
                    .HasColumnName("COURSE_NAME_AR")
                    .HasMaxLength(200);

                entity.Property(e => e.CourseNameEn)
                    .IsRequired()
                    .HasColumnName("COURSE_NAME_EN")
                    .HasMaxLength(200);

                entity.Property(e => e.CourseNo).HasColumnName("COURSE_NO");

                entity.Property(e => e.CourseScoreId).HasColumnName("COURSE_SCORE_ID");

                entity.Property(e => e.CourseSpecification)
                    .HasColumnName("COURSE_SPECIFICATION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CourseStatus)
                    .HasColumnName("COURSE_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CourseTypeId)
                    .HasColumnName("COURSE_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CourseUnit).HasColumnName("COURSE_UNIT");

                entity.Property(e => e.CourseVer).HasColumnName("COURSE_VER");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DEPARTMENT_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountId).HasColumnName("DISCOUNT_ID");

                entity.Property(e => e.MajorId).HasColumnName("MAJOR_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.HasOne(d => d.CourseScore)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.CourseScoreId)
                    .HasConstraintName("FK_COURSE_COURSE_SCORE");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.MajorId)
                    .HasConstraintName("FK_COURSE_MAJOR");
            });

            modelBuilder.Entity<CourseCorrection>(entity =>
            {
                entity.HasKey(e => e.RequestId);

                entity.ToTable("COURSE_CORRECTION", "ACD");

                entity.Property(e => e.RequestId).HasColumnName("REQUEST_ID");

                entity.Property(e => e.ClassId).HasColumnName("CLASS_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.RequestComments)
                    .HasColumnName("REQUEST_COMMENTS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RequestStatus)
                    .HasColumnName("REQUEST_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.Property(e => e.TeacherIdBy).HasColumnName("TEACHER_ID_BY");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.CourseCorrection)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_COURSE_CORRECTION_CLASSES");

                entity.HasOne(d => d.RequestStatusNavigation)
                    .WithMany(p => p.CourseCorrection)
                    .HasForeignKey(d => d.RequestStatus)
                    .HasConstraintName("FK_COURSE_CORRECTION_LOOKUPS");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.CourseCorrection)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_COURSE_CORRECTION_STUDENTS");
            });

            modelBuilder.Entity<CourseScore>(entity =>
            {
                entity.ToTable("COURSE_SCORE", "ACD");

                entity.Property(e => e.CourseScoreId).HasColumnName("COURSE_SCORE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CalculateIn)
                    .IsRequired()
                    .HasColumnName("CALCULATE_IN")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MinPassScore)
                    .HasColumnName("MIN_PASS_SCORE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OutOf)
                    .HasColumnName("OUT_OF")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");
            });

            modelBuilder.Entity<Courseerp>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("COURSEERP", "HR");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourseDate)
                    .HasColumnName("COURSE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CourseDuration)
                    .HasColumnName("COURSE_DURATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourseIssuer).HasColumnName("COURSE_ISSUER");

                entity.Property(e => e.CourseName)
                    .HasColumnName("COURSE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourseType)
                    .HasColumnName("COURSE_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<CreditNotes>(entity =>
            {
                entity.HasKey(e => e.CreditNoteId);

                entity.ToTable("CREDIT_NOTES", "AR");

                entity.Property(e => e.CreditNoteId).HasColumnName("CREDIT_NOTE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreditNoteDate)
                    .HasColumnName("CREDIT_NOTE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.CreditNoteNo)
                    .HasColumnName("CREDIT_NOTE_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.DiscountPer)
                    .HasColumnName("DISCOUNT_PER")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DueDate)
                    .HasColumnName("DUE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.GlBatchId)
                    .HasColumnName("GL_BATCH_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsPosted).HasColumnName("IS_POSTED");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(1000);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PostedBy).HasColumnName("POSTED_BY");

                entity.Property(e => e.PostedDate)
                    .HasColumnName("POSTED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RefNo)
                    .HasColumnName("REF_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.SubTotal)
                    .HasColumnName("SUB_TOTAL")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRateId).HasColumnName("TAX_RATE_ID");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalDiscount)
                    .HasColumnName("TOTAL_DISCOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalTax)
                    .HasColumnName("TOTAL_TAX")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.CreditNotes)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_CREDIT_NOTES_BRANCH");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CreditNotes)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CREDIT_NOTES_CUSTOMERS");

                entity.HasOne(d => d.TaxRate)
                    .WithMany(p => p.CreditNotes)
                    .HasForeignKey(d => d.TaxRateId)
                    .HasConstraintName("FK_CREDIT_NOTES_TAX_RATES");
            });

            modelBuilder.Entity<CreditNotesLines>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("CREDIT_NOTES_LINES", "AR");

                entity.Property(e => e.LineId).HasColumnName("LINE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreditNoteId).HasColumnName("CREDIT_NOTE_ID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountAmount)
                    .HasColumnName("DISCOUNT_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountPercent)
                    .HasColumnName("DISCOUNT_PERCENT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.ItemPrice)
                    .HasColumnName("ITEM_PRICE")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineAmount)
                    .HasColumnName("LINE_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxAmount)
                    .HasColumnName("TAX_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRate)
                    .HasColumnName("TAX_RATE")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRateId).HasColumnName("TAX_RATE_ID");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("UNIT_PRICE")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.CreditNotesLines)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_CREDIT_NOTES_LINES_BRANCH");

                entity.HasOne(d => d.CreditNote)
                    .WithMany(p => p.CreditNotesLines)
                    .HasForeignKey(d => d.CreditNoteId)
                    .HasConstraintName("FK_CREDIT_NOTES_LINES_CREDIT_NOTES");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.CreditNotesLines)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_CREDIT_NOTES_LINES_ITEMS");

                entity.HasOne(d => d.TaxRateNavigation)
                    .WithMany(p => p.CreditNotesLines)
                    .HasForeignKey(d => d.TaxRateId)
                    .HasConstraintName("FK_CREDIT_NOTES_LINES_TAX_RATES");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("CUSTOMERS", "AR");

                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");

                entity.Property(e => e.ActiveStatus)
                    .HasColumnName("ACTIVE_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(250);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CompanyRegistrationNo)
                    .HasColumnName("COMPANY_REGISTRATION_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerNameAr)
                    .HasColumnName("CUSTOMER_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerNameEn)
                    .HasColumnName("CUSTOMER_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.GstNo)
                    .HasColumnName("GST_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.NtnNo)
                    .HasColumnName("NTN_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PrimaryPerson)
                    .HasColumnName("PRIMARY_PERSON")
                    .HasMaxLength(50);

                entity.Property(e => e.Skype)
                    .HasColumnName("SKYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasColumnName("WEBSITE")
                    .HasMaxLength(50);

                entity.Property(e => e.ZipCode)
                    .HasColumnName("ZIP_CODE")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_CUSTOMERS_ACCOUNTS");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_CUSTOMERS_BRANCH");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("DEPARTMENTS", "HR");

                entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentCode)
                    .HasColumnName("DEPARTMENT_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentHeadUid).HasColumnName("DEPARTMENT_HEAD_UID");

                entity.Property(e => e.DepartmentNameAr)
                    .HasColumnName("DEPARTMENT_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.DepartmentNameEn)
                    .IsRequired()
                    .HasColumnName("DEPARTMENT_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.DivisionId).HasColumnName("DIVISION_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ReportingToUid).HasColumnName("REPORTING_TO_UID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DEPARTMENTS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DEPARTMENTS_COMPANY");

                entity.HasOne(d => d.DepartmentHeadU)
                    .WithMany(p => p.DepartmentsDepartmentHeadU)
                    .HasForeignKey(d => d.DepartmentHeadUid)
                    .HasConstraintName("FK_DEPARTMENTS_HEAD");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DEPARTMENTS_DIVISIONS");

                entity.HasOne(d => d.ReportingToU)
                    .WithMany(p => p.DepartmentsReportingToU)
                    .HasForeignKey(d => d.ReportingToUid)
                    .HasConstraintName("FK_DEPARTMENTS_REPORTING_TO");
            });

            modelBuilder.Entity<Divisions>(entity =>
            {
                entity.HasKey(e => e.DivisionId);

                entity.ToTable("DIVISIONS", "HR");

                entity.Property(e => e.DivisionId).HasColumnName("DIVISION_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DivisionCode)
                    .HasColumnName("DIVISION_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionHeadUid).HasColumnName("DIVISION_HEAD_UID");

                entity.Property(e => e.DivisionNameAr)
                    .HasColumnName("DIVISION_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.DivisionNameEn)
                    .IsRequired()
                    .HasColumnName("DIVISION_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ReportingToUid).HasColumnName("REPORTING_TO_UID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Divisions)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_DIVISIONS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Divisions)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DIVISIONS_COMPANY");

                entity.HasOne(d => d.DivisionHeadU)
                    .WithMany(p => p.DivisionsDivisionHeadU)
                    .HasForeignKey(d => d.DivisionHeadUid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DIVISIONS_HEAD");

                entity.HasOne(d => d.ReportingToU)
                    .WithMany(p => p.DivisionsReportingToU)
                    .HasForeignKey(d => d.ReportingToUid)
                    .HasConstraintName("FK_DIVISIONS_REPORTING_TO");
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.HasKey(e => e.DocId);

                entity.ToTable("DOCUMENTS");

                entity.Property(e => e.DocId).HasColumnName("DOC_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocDesc)
                    .HasColumnName("DOC_DESC")
                    .HasMaxLength(150);

                entity.Property(e => e.DocEndDate)
                    .HasColumnName("DOC_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocEndDateH)
                    .HasColumnName("DOC_END_DATE_H")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocFile)
                    .HasColumnName("DOC_FILE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocIssuedDate)
                    .HasColumnName("DOC_ISSUED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocIssuedDateH)
                    .HasColumnName("DOC_ISSUED_DATE_H")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocIssuedFrom)
                    .HasColumnName("DOC_ISSUED_FROM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DocNameAr)
                    .HasColumnName("DOC_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.DocNameEn)
                    .HasColumnName("DOC_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.DocOwnerId).HasColumnName("DOC_OWNER_ID");

                entity.Property(e => e.DocOwnerType)
                    .HasColumnName("DOC_OWNER_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DocType)
                    .HasColumnName("DOC_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.RefId).HasColumnName("REF_ID");

                entity.Property(e => e.TitleArInDoc)
                    .HasColumnName("TITLE_AR_IN_DOC")
                    .HasMaxLength(50);

                entity.Property(e => e.TitleEnInDoc)
                    .HasColumnName("TITLE_EN_IN_DOC")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_DOCUMENTS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_DOCUMENTS_COMPANY");

                entity.HasOne(d => d.DocIssuedFromNavigation)
                    .WithMany(p => p.DocumentsDocIssuedFromNavigation)
                    .HasForeignKey(d => d.DocIssuedFrom)
                    .HasConstraintName("FK_DOCUMENTS_DOC_ISSUE_FROM");

                entity.HasOne(d => d.DocOwnerTypeNavigation)
                    .WithMany(p => p.DocumentsDocOwnerTypeNavigation)
                    .HasForeignKey(d => d.DocOwnerType)
                    .HasConstraintName("FK_DOCUMENTS_DOC_OWNER_TYPE");

                entity.HasOne(d => d.DocTypeNavigation)
                    .WithMany(p => p.DocumentsDocTypeNavigation)
                    .HasForeignKey(d => d.DocType)
                    .HasConstraintName("FK_DOCUMENTS_DOC_TYPE");
            });

            modelBuilder.Entity<EmailLog>(entity =>
            {
                entity.HasKey(e => e.EmailId);

                entity.ToTable("EMAIL_LOG", "ACD");

                entity.Property(e => e.EmailId).HasColumnName("EMAIL_ID");

                entity.Property(e => e.BranhcId).HasColumnName("BRANHC_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmailDate)
                    .HasColumnName("EMAIL_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.FromEmail)
                    .HasColumnName("FROM_EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToEmailMandaotry)
                    .HasColumnName("TO_EMAIL_MANDAOTRY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToEmailOptional)
                    .HasColumnName("TO_EMAIL_OPTIONAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToUserId).HasColumnName("TO_USER_ID");
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.ToTable("EMP", "HR");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.ActiveStatus)
                    .HasColumnName("ACTIVE_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.BirthPlaceId)
                    .HasColumnName("BIRTH_PLACE_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesignationPositionId).HasColumnName("DESIGNATION_POSITION_ID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.DobH)
                    .HasColumnName("DOB_H")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpCnic)
                    .HasColumnName("EMP_CNIC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmpCode)
                    .HasColumnName("EMP_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNtn)
                    .HasColumnName("EMP_NTN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpOfficeLaborCode)
                    .HasColumnName("EMP_OFFICE_LABOR_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpPosition)
                    .HasColumnName("EMP_POSITION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpType)
                    .HasColumnName("EMP_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FamilyNameAr)
                    .HasColumnName("FAMILY_NAME_AR")
                    .HasMaxLength(30);

                entity.Property(e => e.FamilyNameEn)
                    .HasColumnName("FAMILY_NAME_EN")
                    .HasMaxLength(30);

                entity.Property(e => e.FatherNameAr)
                    .HasColumnName("FATHER_NAME_AR")
                    .HasMaxLength(30);

                entity.Property(e => e.FatherNameEn)
                    .HasColumnName("FATHER_NAME_EN")
                    .HasMaxLength(30);

                entity.Property(e => e.FirstNameAr)
                    .HasColumnName("FIRST_NAME_AR")
                    .HasMaxLength(30);

                entity.Property(e => e.FirstNameEn)
                    .HasColumnName("FIRST_NAME_EN")
                    .HasMaxLength(30);

                entity.Property(e => e.GenderId)
                    .HasColumnName("GENDER_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GrandNameAr)
                    .HasColumnName("GRAND_NAME_AR")
                    .HasMaxLength(30);

                entity.Property(e => e.GrandNameEn)
                    .HasColumnName("GRAND_NAME_EN")
                    .HasMaxLength(30);

                entity.Property(e => e.IdExpiryDate)
                    .HasColumnName("ID_EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.IdExpiryDateH)
                    .HasColumnName("ID_EXPIRY_DATE_H")
                    .HasColumnType("date");

                entity.Property(e => e.IdIssueDate)
                    .HasColumnName("ID_ISSUE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.IdIssueDateH)
                    .HasColumnName("ID_ISSUE_DATE_H")
                    .HasColumnType("date");

                entity.Property(e => e.IdtypeId)
                    .HasColumnName("IDTYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatusId)
                    .HasColumnName("MARITAL_STATUS_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.NationalityId)
                    .HasColumnName("NATIONALITY_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PassCode)
                    .HasColumnName("PASS_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.PassDate)
                    .HasColumnName("PASS_DATE")
                    .HasMaxLength(20);

                entity.Property(e => e.PassPort)
                    .HasColumnName("PASS_PORT")
                    .HasMaxLength(50);

                entity.Property(e => e.PassportAttachment)
                    .HasColumnName("PASSPORT_ATTACHMENT")
                    .HasMaxLength(50);

                entity.Property(e => e.PassportExpiryDate)
                    .HasColumnName("PASSPORT_EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.PassportExpiryDateH)
                    .HasColumnName("PASSPORT_EXPIRY_DATE_H")
                    .HasMaxLength(20);

                entity.Property(e => e.PassportIssuedDate)
                    .HasColumnName("PASSPORT_ISSUED_DATE")
                    .HasMaxLength(20);

                entity.Property(e => e.PassportIssuedDateH)
                    .HasColumnName("PASSPORT_ISSUED_DATE_H")
                    .HasMaxLength(20);

                entity.Property(e => e.PassportIssuedFrom)
                    .HasColumnName("PASSPORT_ISSUED_FROM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PassportNo)
                    .HasColumnName("PASSPORT_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ProfilePic)
                    .HasColumnName("PROFILE_PIC")
                    .HasMaxLength(200);

                entity.Property(e => e.ReligionId)
                    .HasColumnName("RELIGION_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorId)
                    .HasColumnName("SPONSOR_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StayingWithFamily).HasColumnName("STAYING_WITH_FAMILY");

                entity.Property(e => e.VisaCode)
                    .HasColumnName("VISA_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.VisaDate)
                    .HasColumnName("VISA_DATE")
                    .HasMaxLength(20);

                entity.Property(e => e.VisaJob)
                    .HasColumnName("VISA_JOB")
                    .HasMaxLength(200);

                entity.HasOne(d => d.DesignationPosition)
                    .WithMany(p => p.Emp)
                    .HasForeignKey(d => d.DesignationPositionId)
                    .HasConstraintName("FK_EMP_POSITIONS");
            });

            modelBuilder.Entity<EmpAddresses>(entity =>
            {
                entity.HasKey(e => e.EmpAddressId);

                entity.ToTable("EMP_ADDRESSES", "HR");

                entity.Property(e => e.EmpAddressId).HasColumnName("EMP_ADDRESS_ID");

                entity.Property(e => e.AdditionalNo)
                    .HasColumnName("ADDITIONAL_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddressDetail)
                    .HasColumnName("ADDRESS_DETAIL")
                    .HasMaxLength(200);

                entity.Property(e => e.AppartmentNo)
                    .HasColumnName("APPARTMENT_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.BuildingNo)
                    .HasColumnName("BUILDING_NO")
                    .HasMaxLength(10);

                entity.Property(e => e.CityId)
                    .HasColumnName("CITY_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasColumnName("CITY_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CountryId)
                    .HasColumnName("COUNTRY_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DistrictName)
                    .HasColumnName("DISTRICT_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeCountryIdentity)
                    .HasColumnName("HOME_COUNTRY_IDENTITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasColumnName("HOME_PHONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPrimary).HasColumnName("IS_PRIMARY");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PoBox)
                    .HasColumnName("PO_BOX")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("POSTAL_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.StreetName)
                    .HasColumnName("STREET_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkPhone)
                    .HasColumnName("WORK_PHONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPhoneEx)
                    .HasColumnName("WORK_PHONE_EX")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasColumnName("ZIP_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpAddresses)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_EMP_ADDRESSES_EMP");
            });

            modelBuilder.Entity<EmpAttendance>(entity =>
            {
                entity.ToTable("EMP_ATTENDANCE", "HR");

                entity.Property(e => e.EmpAttendanceId).HasColumnName("EMP_ATTENDANCE_ID");

                entity.Property(e => e.AttendanceDate)
                    .HasColumnName("ATTENDANCE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.IsPaidLeave).HasColumnName("IS_PAID_LEAVE");

                entity.Property(e => e.IsPresent).HasColumnName("IS_PRESENT");

                entity.Property(e => e.IsSaved).HasColumnName("IS_SAVED");

                entity.Property(e => e.IsShortLeave).HasColumnName("IS_SHORT_LEAVE");

                entity.Property(e => e.IsUnpaidLeave).HasColumnName("IS_UNPAID_LEAVE");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(300);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.TimeIn)
                    .HasColumnName("TIME_IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeOut)
                    .HasColumnName("TIME_OUT")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpAttendance)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_EMP_ATTENDANCE_EMP");
            });

            modelBuilder.Entity<EmpBanks>(entity =>
            {
                entity.HasKey(e => e.EmpBankId);

                entity.ToTable("EMP_BANKS", "HR");

                entity.Property(e => e.EmpBankId).HasColumnName("EMP_BANK_ID");

                entity.Property(e => e.BankAccountNo)
                    .HasColumnName("BANK_ACCOUNT_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.BankAccountTitle)
                    .HasColumnName("BANK_ACCOUNT_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.BankIban)
                    .HasColumnName("BANK_IBAN")
                    .HasMaxLength(50);

                entity.Property(e => e.BankId)
                    .HasColumnName("BANK_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(300);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpBanks)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_EMP_BANKS_EMP");
            });

            modelBuilder.Entity<EmpContracts>(entity =>
            {
                entity.HasKey(e => e.EmpContractId);

                entity.ToTable("EMP_CONTRACTS", "HR");

                entity.Property(e => e.EmpContractId).HasColumnName("EMP_CONTRACT_ID");

                entity.Property(e => e.AbsentProfileId).HasColumnName("ABSENT_PROFILE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.ContactInactiveDate)
                    .HasColumnName("CONTACT_INACTIVE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ContractPeriodMonths).HasColumnName("CONTRACT_PERIOD_MONTHS");

                entity.Property(e => e.ContractStartDate)
                    .HasColumnName("CONTRACT_START_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ContractStatus)
                    .HasColumnName("CONTRACT_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.DivisionId).HasColumnName("DIVISION_ID");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ExpiryDateHijri)
                    .HasColumnName("EXPIRY_DATE_HIJRI")
                    .HasColumnType("date");

                entity.Property(e => e.GosiId).HasColumnName("GOSI_ID");

                entity.Property(e => e.GradeId).HasColumnName("GRADE_ID");

                entity.Property(e => e.HousingAllowanceId).HasColumnName("HOUSING_ALLOWANCE_ID");

                entity.Property(e => e.JoiningDate)
                    .HasColumnName("JOINING_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.JoiningDateHijri)
                    .HasColumnName("JOINING_DATE_HIJRI")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasMaxLength(500);

                entity.Property(e => e.PayGroupId).HasColumnName("PAY_GROUP_ID");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.SectionId).HasColumnName("SECTION_ID");

                entity.Property(e => e.SubSectionId).HasColumnName("SUB_SECTION_ID");

                entity.Property(e => e.TaxAlreadyDeduct)
                    .HasColumnName("TAX_ALREADY_DEDUCT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TeamId).HasColumnName("TEAM_ID");

                entity.Property(e => e.ThreshHoldSalary).HasColumnName("THRESH_HOLD_SALARY");

                entity.Property(e => e.TicketProfileId).HasColumnName("TICKET_PROFILE_ID");

                entity.Property(e => e.TotalAnnualLeavesPerYear).HasColumnName("TOTAL_ANNUAL_LEAVES_PER_YEAR");

                entity.Property(e => e.TotalExamptSalaryFromPreviousEmployer)
                    .HasColumnName("TOTAL_EXAMPT_SALARY_FROM_PREVIOUS_EMPLOYER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalHalfLeavesPerMonth).HasColumnName("TOTAL_HALF_LEAVES_PER_MONTH");

                entity.Property(e => e.TotalPaidLeavesPerMonth).HasColumnName("TOTAL_PAID_LEAVES_PER_MONTH");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");

                entity.Property(e => e.VacationProfileId).HasColumnName("VACATION_PROFILE_ID");

                entity.HasOne(d => d.AbsentProfile)
                    .WithMany(p => p.EmpContracts)
                    .HasForeignKey(d => d.AbsentProfileId)
                    .HasConstraintName("FK_EMP_CONTRACTS_ABSENT_PROFILES");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmpContracts)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_EMP_CONTRACTS_DEPARTMENTS");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.EmpContracts)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_EMP_CONTRACTS_DIVISIONS");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpContracts)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_EMP_CONTRACTS_EMP");

                entity.HasOne(d => d.Gosi)
                    .WithMany(p => p.EmpContracts)
                    .HasForeignKey(d => d.GosiId)
                    .HasConstraintName("FK_EMP_CONTRACTS_GOSI_SETTINGS");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.EmpContracts)
                    .HasForeignKey(d => d.GradeId)
                    .HasConstraintName("FK_EMP_CONTRACTS_GRADES");

                entity.HasOne(d => d.HousingAllowance)
                    .WithMany(p => p.EmpContracts)
                    .HasForeignKey(d => d.HousingAllowanceId)
                    .HasConstraintName("FK_EMP_CONTRACTS_HOUSING_ALLOWANCES");

                entity.HasOne(d => d.PayGroup)
                    .WithMany(p => p.EmpContracts)
                    .HasForeignKey(d => d.PayGroupId)
                    .HasConstraintName("FK_EMP_CONTRACTS_PAY_GROUPS");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.EmpContracts)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_EMP_CONTRACTS_SECTIONS");

                entity.HasOne(d => d.SubSection)
                    .WithMany(p => p.EmpContracts)
                    .HasForeignKey(d => d.SubSectionId)
                    .HasConstraintName("FK_EMP_CONTRACTS_SUB_SECTIONS");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.EmpContracts)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_EMP_CONTRACTS_TEAMS");

                entity.HasOne(d => d.TicketProfile)
                    .WithMany(p => p.EmpContracts)
                    .HasForeignKey(d => d.TicketProfileId)
                    .HasConstraintName("FK_EMP_CONTRACTS_AIR_TICKET_PROFILES");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.EmpContracts)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_EMP_CONTRACTS_UNITS");
            });

            modelBuilder.Entity<EmpContractsPackage>(entity =>
            {
                entity.ToTable("EMP_CONTRACTS_PACKAGE", "HR");

                entity.Property(e => e.EmpContractsPackageId).HasColumnName("EMP_CONTRACTS_PACKAGE_ID");

                entity.Property(e => e.AllowanceTypeId)
                    .IsRequired()
                    .HasColumnName("ALLOWANCE_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("Basic Salary, Housing, Transport Allowance, Food Allowance, Other Allowance, Leave Pay, Other, Indemnity");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmpContractId).HasColumnName("EMP_CONTRACT_ID");

                entity.HasOne(d => d.EmpContract)
                    .WithMany(p => p.EmpContractsPackage)
                    .HasForeignKey(d => d.EmpContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMP_CONTRACTS_PACKAGE_EMP_CONTRACTS");
            });

            modelBuilder.Entity<EmpDependents>(entity =>
            {
                entity.HasKey(e => e.DependentId);

                entity.ToTable("EMP_DEPENDENTS", "HR");

                entity.Property(e => e.DependentId).HasColumnName("DEPENDENT_ID");

                entity.Property(e => e.Attachments)
                    .HasColumnName("ATTACHMENTS")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DependentNameAr)
                    .HasColumnName("DEPENDENT_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.DependentNameEn)
                    .HasColumnName("DEPENDENT_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(20);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.GenderId)
                    .HasColumnName("GENDER_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdAttachment)
                    .HasColumnName("ID_ATTACHMENT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdEndDate)
                    .HasColumnName("ID_END_DATE")
                    .HasMaxLength(20);

                entity.Property(e => e.IdEndDateH)
                    .HasColumnName("ID_END_DATE_H")
                    .HasMaxLength(20);

                entity.Property(e => e.IdIssuedDate)
                    .HasColumnName("ID_ISSUED_DATE")
                    .HasMaxLength(20);

                entity.Property(e => e.IdIssuedDateH)
                    .HasColumnName("ID_ISSUED_DATE_H")
                    .HasMaxLength(20);

                entity.Property(e => e.IdIssuedFrom)
                    .HasColumnName("ID_ISSUED_FROM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdNo)
                    .HasColumnName("ID_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.NationalityId)
                    .HasColumnName("NATIONALITY_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PassportAttachment)
                    .HasColumnName("PASSPORT_ATTACHMENT")
                    .HasMaxLength(50);

                entity.Property(e => e.PassportExpiryDate)
                    .HasColumnName("PASSPORT_EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.PassportExpiryDateH)
                    .HasColumnName("PASSPORT_EXPIRY_DATE_H")
                    .HasMaxLength(20);

                entity.Property(e => e.PassportIssuedDate)
                    .HasColumnName("PASSPORT_ISSUED_DATE")
                    .HasMaxLength(20);

                entity.Property(e => e.PassportIssuedDateH)
                    .HasColumnName("PASSPORT_ISSUED_DATE_H")
                    .HasMaxLength(20);

                entity.Property(e => e.PassportIssuedFrom)
                    .HasColumnName("PASSPORT_ISSUED_FROM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PassportNo)
                    .HasColumnName("PASSPORT_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.RelationTypeId)
                    .HasColumnName("RELATION_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpDependents)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_EMP_DEPENDENTS_EMP");
            });

            modelBuilder.Entity<EmpEducation>(entity =>
            {
                entity.ToTable("EMP_EDUCATION", "HR");

                entity.Property(e => e.EmpEducationId).HasColumnName("EMP_EDUCATION_ID");

                entity.Property(e => e.AssessmentAssignmentId)
                    .HasColumnName("ASSESSMENT_ASSIGNMENT_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Attachments)
                    .HasColumnName("ATTACHMENTS")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CityId)
                    .HasColumnName("CITY_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.College)
                    .HasColumnName("COLLEGE")
                    .HasMaxLength(200);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CountryId)
                    .HasColumnName("COUNTRY_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CulturalAttache).HasColumnName("CULTURAL_ATTACHE");

                entity.Property(e => e.DegreeId)
                    .HasColumnName("DEGREE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DegreeName)
                    .HasColumnName("DEGREE_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Detail)
                    .HasColumnName("DETAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasMaxLength(20);

                entity.Property(e => e.GpaTypeCodeId)
                    .HasColumnName("GPA_TYPE_CODE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GraduateYear)
                    .HasColumnName("GRADUATE_YEAR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ScientificDegreeDate)
                    .HasColumnName("SCIENTIFIC_DEGREE_DATE")
                    .HasMaxLength(40);

                entity.Property(e => e.StudyTypeCodeId)
                    .HasColumnName("STUDY_TYPE_CODE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasMaxLength(20);

                entity.Property(e => e.UniversityName)
                    .HasColumnName("UNIVERSITY_NAME")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Degree)
                    .WithMany(p => p.EmpEducation)
                    .HasForeignKey(d => d.DegreeId)
                    .HasConstraintName("FK_EMP_EDUCATION_EMP");
            });

            modelBuilder.Entity<EmpExperience>(entity =>
            {
                entity.ToTable("EMP_EXPERIENCE", "HR");

                entity.Property(e => e.EmpExperienceId).HasColumnName("EMP_EXPERIENCE_ID");

                entity.Property(e => e.AcademicRank)
                    .HasColumnName("ACADEMIC_RANK")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AcademicSection)
                    .HasColumnName("ACADEMIC_SECTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.College)
                    .HasColumnName("COLLEGE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateOfBeginningWork)
                    .HasColumnName("DATE_OF_BEGINNING_WORK")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateOfEndWork)
                    .HasColumnName("DATE_OF_END_WORK")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateOfRank)
                    .HasColumnName("DATE_OF_RANK")
                    .HasColumnType("datetime");

                entity.Property(e => e.EducationalInstitue)
                    .HasColumnName("EDUCATIONAL_INSTITUE")
                    .HasMaxLength(100);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.FunctionalStatus)
                    .HasColumnName("FUNCTIONAL_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionalType)
                    .HasColumnName("FUNCTIONAL_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralSpecialization)
                    .HasColumnName("GENERAL_SPECIALIZATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobRank)
                    .HasColumnName("JOB_RANK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Subspecialty)
                    .HasColumnName("SUBSPECIALTY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfContract)
                    .HasColumnName("TYPE_OF_CONTRACT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.WorkLocation)
                    .HasColumnName("WORK_LOCATION")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpExperience)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMP_EXPERIENCE_EMP");
            });

            modelBuilder.Entity<EmpGosiSettings>(entity =>
            {
                entity.HasKey(e => e.GosiSettingsId);

                entity.ToTable("EMP_GOSI_SETTINGS", "HR");

                entity.Property(e => e.GosiSettingsId).HasColumnName("GOSI_SETTINGS_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.GosiSettingCode)
                    .HasColumnName("GOSI_SETTING_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GosiSettingNameAr)
                    .HasColumnName("GOSI_SETTING_NAME_AR")
                    .HasMaxLength(100);

                entity.Property(e => e.GosiSettingNameEn)
                    .HasColumnName("GOSI_SETTING_NAME_EN")
                    .HasMaxLength(100);

                entity.Property(e => e.JoiningDate)
                    .HasColumnName("JOINING_DATE")
                    .HasMaxLength(40);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpGosiSettings)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_EMP_GOSI_SETTINGS_EMP");
            });

            modelBuilder.Entity<EmpMedicals>(entity =>
            {
                entity.HasKey(e => e.EmpMedicalId);

                entity.ToTable("EMP_MEDICALS", "HR");

                entity.Property(e => e.EmpMedicalId).HasColumnName("EMP_MEDICAL_ID");

                entity.Property(e => e.BloodGroupId)
                    .HasColumnName("BLOOD_GROUP_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("EXPIRY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("ISSUE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.MedicalCardNo)
                    .HasColumnName("MEDICAL_CARD_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalClassId)
                    .HasColumnName("MEDICAL_CLASS_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalCompanyId)
                    .HasColumnName("MEDICAL_COMPANY_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(300);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.SpecialNeed)
                    .HasColumnName("SPECIAL_NEED")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialNeeds).HasColumnName("SPECIAL_NEEDS");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpMedicals)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_EMP_MEDICALS_EMP");
            });

            modelBuilder.Entity<EmpPreviousexperience>(entity =>
            {
                entity.HasKey(e => e.EmpPrevExperienceId);

                entity.ToTable("EMP_PREVIOUSEXPERIENCE", "HR");

                entity.Property(e => e.EmpPrevExperienceId).HasColumnName("EMP_PREV_EXPERIENCE_ID");

                entity.Property(e => e.College)
                    .HasColumnName("COLLEGE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EducationalInstitute)
                    .HasColumnName("EDUCATIONAL_INSTITUTE")
                    .HasMaxLength(100);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.FunctionalTask)
                    .HasColumnName("FUNCTIONAL_TASK")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkEndDate)
                    .HasColumnName("WORK_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkStartDate)
                    .HasColumnName("WORK_START_DATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpPreviousexperience)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMP_PREVIOUSEXPERIENCE_EMP");
            });

            modelBuilder.Entity<EmpShifts>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("EMP_SHIFTS", "HR");

                entity.Property(e => e.RecId).HasColumnName("REC_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ShiftId).HasColumnName("SHIFT_ID");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpShifts)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_EMP_SHIFTS_EMP");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.EmpShifts)
                    .HasForeignKey(d => d.ShiftId)
                    .HasConstraintName("FK_EMP_SHIFTS_SHIFTS");
            });

            modelBuilder.Entity<EmpVehicles>(entity =>
            {
                entity.HasKey(e => e.EmpVehicleId);

                entity.ToTable("EMP_VEHICLES", "HR");

                entity.Property(e => e.EmpVehicleId).HasColumnName("EMP_VEHICLE_ID");

                entity.Property(e => e.AssetNo)
                    .HasColumnName("ASSET_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(300);

                entity.Property(e => e.PlateNo)
                    .HasColumnName("PLATE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.RegistrationEndDate)
                    .HasColumnName("REGISTRATION_END_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.RegistrationIssueDate)
                    .HasColumnName("REGISTRATION_ISSUE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.VehicleDescription)
                    .HasColumnName("VEHICLE_DESCRIPTION")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpVehicles)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_EMP_VEHICLES_EMP");
            });

            modelBuilder.Entity<Evaluation>(entity =>
            {
                entity.ToTable("EVALUATION", "ACD");

                entity.Property(e => e.EvaluationId).HasColumnName("EVALUATION_ID");

                entity.Property(e => e.AcademicYearId).HasColumnName("ACADEMIC_YEAR_ID");

                entity.Property(e => e.ClassId).HasColumnName("CLASS_ID");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.MajorId).HasColumnName("MAJOR_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.TeacherId).HasColumnName("TEACHER_ID");

                entity.HasOne(d => d.AcademicYear)
                    .WithMany(p => p.Evaluation)
                    .HasForeignKey(d => d.AcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVALUATION_ACADEMIC_YEARS");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Evaluation)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_EVALUATION_COURSE");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.Evaluation)
                    .HasForeignKey(d => d.MajorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVALUATION_MAJOR");
            });

            modelBuilder.Entity<ExamSchedule>(entity =>
            {
                entity.ToTable("EXAM_SCHEDULE", "ACD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcademicYearId).HasColumnName("ACADEMIC_YEAR_ID");

                entity.Property(e => e.CampusId).HasColumnName("CAMPUS_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ExamType)
                    .HasColumnName("EXAM_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LevelId).HasColumnName("LEVEL_ID");

                entity.Property(e => e.MajorId).HasColumnName("MAJOR_ID");

                entity.Property(e => e.MajorTypeId).HasColumnName("MAJOR_TYPE_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<ExamScheduleLines>(entity =>
            {
                entity.ToTable("EXAM_SCHEDULE_LINES", "ACD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Day)
                    .IsRequired()
                    .HasColumnName("DAY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExamScheduleId).HasColumnName("EXAM_SCHEDULE_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.ExamSchedule)
                    .WithMany(p => p.ExamScheduleLines)
                    .HasForeignKey(d => d.ExamScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EXAM_SCHEDULE_LINES_EXAM_SCHEDULE");
            });

            modelBuilder.Entity<ExceptionsClassCapacity>(entity =>
            {
                entity.HasKey(e => e.ExceptionId);

                entity.ToTable("EXCEPTIONS_CLASS_CAPACITY", "ACD");

                entity.Property(e => e.ExceptionId).HasColumnName("EXCEPTION_ID");

                entity.Property(e => e.AcademicYearId).HasColumnName("ACADEMIC_YEAR_ID");

                entity.Property(e => e.ApprovalStatusDate)
                    .HasColumnName("APPROVAL_STATUS_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovalStatusId)
                    .HasColumnName("APPROVAL_STATUS_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(200);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.ClassId).HasColumnName("CLASS_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExceptionTypeId)
                    .IsRequired()
                    .HasColumnName("EXCEPTION_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("PRE REQUISITE / CO REQUISITE / PLAN LEVEL");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(500);

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.HasOne(d => d.AcademicYear)
                    .WithMany(p => p.ExceptionsClassCapacity)
                    .HasForeignKey(d => d.AcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EXCEPTIONS_CLASS_CAPACITY_ACADEMIC_YEARS");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ExceptionsClassCapacity)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EXCEPTIONS_CLASS_CAPACITY_CLASSES");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ExceptionsClassCapacity)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EXCEPTIONS_CLASS_CAPACITY_STUDENTS");
            });

            modelBuilder.Entity<ExceptionsCourses>(entity =>
            {
                entity.HasKey(e => e.ExceptionId);

                entity.ToTable("EXCEPTIONS_COURSES", "ACD");

                entity.Property(e => e.ExceptionId).HasColumnName("EXCEPTION_ID");

                entity.Property(e => e.AcademicYearId).HasColumnName("ACADEMIC_YEAR_ID");

                entity.Property(e => e.ApprovalStatusDate)
                    .HasColumnName("APPROVAL_STATUS_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovalStatusId)
                    .HasColumnName("APPROVAL_STATUS_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(200);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExceptionTypeId)
                    .IsRequired()
                    .HasColumnName("EXCEPTION_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("PRE REQUISITE / CO REQUISITE / PLAN LEVEL");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(500);

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.HasOne(d => d.AcademicYear)
                    .WithMany(p => p.ExceptionsCourses)
                    .HasForeignKey(d => d.AcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EXCEPTIONS_COURSES_ACADEMIC_YEARS");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ExceptionsCourses)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EXCEPTIONS_COURSES_STUDENTS");
            });

            modelBuilder.Entity<ExpClaims>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("EXP_CLAIMS", "HR");

                entity.Property(e => e.RecId).HasColumnName("REC_ID");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(100);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.EngagementId).HasColumnName("ENGAGEMENT_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.RequestStatus)
                    .HasColumnName("REQUEST_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SpentAt)
                    .HasColumnName("SPENT_AT")
                    .HasMaxLength(50);

                entity.Property(e => e.SpentOn)
                    .HasColumnName("SPENT_ON")
                    .HasMaxLength(20);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.ExpClaims)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_EXP_CLAIMS_EMP");

                entity.HasOne(d => d.RequestStatusNavigation)
                    .WithMany(p => p.ExpClaims)
                    .HasForeignKey(d => d.RequestStatus)
                    .HasConstraintName("FK_EXP_CLAIMS_LOOKUPS");
            });

            modelBuilder.Entity<FeeVouchers>(entity =>
            {
                entity.HasKey(e => e.FeeVoucherId);

                entity.ToTable("FEE_VOUCHERS", "ACD");

                entity.Property(e => e.FeeVoucherId).HasColumnName("FEE_VOUCHER_ID");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BankAccountNo)
                    .HasColumnName("BANK_ACCOUNT_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankId).HasColumnName("BANK_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.ChequeNo)
                    .HasColumnName("CHEQUE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPer)
                    .HasColumnName("DISCOUNT_PER")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FeeVoucherDate)
                    .HasColumnName("FEE_VOUCHER_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.FeeVoucherNo)
                    .HasColumnName("FEE_VOUCHER_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GlBatchId)
                    .HasColumnName("GL_BATCH_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsPosted).HasColumnName("IS_POSTED");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(1000);

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("PAYMENT_MODE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PostedBy).HasColumnName("POSTED_BY");

                entity.Property(e => e.PostedDate)
                    .HasColumnName("POSTED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RefNo)
                    .HasColumnName("REF_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.StdFeeType)
                    .HasColumnName("STD_FEE_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.Property(e => e.SubTotal)
                    .HasColumnName("SUB_TOTAL")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRateId).HasColumnName("TAX_RATE_ID");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalDiscount)
                    .HasColumnName("TOTAL_DISCOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalTax)
                    .HasColumnName("TOTAL_TAX")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.FeeVouchers)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_FEE_VOUCHERS_BANKS");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.FeeVouchers)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_FEE_VOUCHERS_BRANCH");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.FeeVouchers)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_FEE_VOUCHERS_STUDENTS");
            });

            modelBuilder.Entity<FeeVouchersLines>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("FEE_VOUCHERS_LINES", "ACD");

                entity.Property(e => e.LineId).HasColumnName("LINE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.CoursePrice)
                    .HasColumnName("COURSE_PRICE")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountAmount)
                    .HasColumnName("DISCOUNT_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountPercent)
                    .HasColumnName("DISCOUNT_PERCENT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FeeVoucherId).HasColumnName("FEE_VOUCHER_ID");

                entity.Property(e => e.LineAmount)
                    .HasColumnName("LINE_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxAmount)
                    .HasColumnName("TAX_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRate)
                    .HasColumnName("TAX_RATE")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRateId).HasColumnName("TAX_RATE_ID");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("UNIT_PRICE")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.FeeVouchersLines)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_FEE_VOUCHERS_LINES_BRANCH");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.FeeVouchersLines)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_FEE_VOUCHERS_LINES_COURSE");

                entity.HasOne(d => d.FeeVoucher)
                    .WithMany(p => p.FeeVouchersLines)
                    .HasForeignKey(d => d.FeeVoucherId)
                    .HasConstraintName("FK_FEE_VOUCHERS_LINES_FEE_VOUCHERS");

                entity.HasOne(d => d.TaxRateNavigation)
                    .WithMany(p => p.FeeVouchersLines)
                    .HasForeignKey(d => d.TaxRateId)
                    .HasConstraintName("FK_FEE_VOUCHERS_LINES_TAX_RATES");
            });

            modelBuilder.Entity<FixedAsset>(entity =>
            {
                entity.ToTable("FIXED_ASSET", "FN");

                entity.Property(e => e.FixedAssetId).HasColumnName("FIXED_ASSET_ID");

                entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");

                entity.Property(e => e.ActiveStatus)
                    .HasColumnName("ACTIVE_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AssetTypeId)
                    .HasColumnName("ASSET_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AverageMethodId)
                    .HasColumnName("AVERAGE_METHOD_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CostLimit)
                    .HasColumnName("COST_LIMIT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepreciationMethodId)
                    .HasColumnName("DEPRECIATION_METHOD_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DepreciationStartDate)
                    .HasColumnName("DEPRECIATION_START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.EffectiveLifeYears).HasColumnName("EFFECTIVE_LIFE_YEARS");

                entity.Property(e => e.FixedAssetAr)
                    .HasColumnName("FIXED_ASSET_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.FixedAssetEn)
                    .HasColumnName("FIXED_ASSET_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.FixedAssetNo)
                    .HasColumnName("FIXED_ASSET_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnName("PURCHASE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchasePrice)
                    .HasColumnName("PURCHASE_PRICE")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Rate)
                    .HasColumnName("RATE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ResidualValue)
                    .HasColumnName("RESIDUAL_VALUE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SerialNo)
                    .HasColumnName("SERIAL_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WarrantyExpiry)
                    .HasColumnName("WARRANTY_EXPIRY")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.FixedAsset)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_FIXED_ASSET_ACCOUNTS");

                entity.HasOne(d => d.AssetType)
                    .WithMany(p => p.FixedAssetAssetType)
                    .HasForeignKey(d => d.AssetTypeId)
                    .HasConstraintName("FK_FIXED_ASSET_ASSET_TYPE");

                entity.HasOne(d => d.AverageMethod)
                    .WithMany(p => p.FixedAssetAverageMethod)
                    .HasForeignKey(d => d.AverageMethodId)
                    .HasConstraintName("FK_FIXED_ASSET_AVG_METHOD");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.FixedAsset)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_FIXED_ASSET_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.FixedAsset)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_FIXED_ASSET_COMPANY");

                entity.HasOne(d => d.DepreciationMethod)
                    .WithMany(p => p.FixedAssetDepreciationMethod)
                    .HasForeignKey(d => d.DepreciationMethodId)
                    .HasConstraintName("FK_FIXED_ASSET_DEP_METHOD");
            });

            modelBuilder.Entity<GeneralEntries>(entity =>
            {
                entity.HasKey(e => e.GeneralEntryId);

                entity.ToTable("GENERAL_ENTRIES", "FN");

                entity.Property(e => e.GeneralEntryId).HasColumnName("GENERAL_ENTRY_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralEntryDate)
                    .HasColumnName("GENERAL_ENTRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.GeneralEntryNo)
                    .HasColumnName("GENERAL_ENTRY_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsPosted).HasColumnName("IS_POSTED");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(1000);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PostedBy).HasColumnName("POSTED_BY");

                entity.Property(e => e.PostedDate)
                    .HasColumnName("POSTED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalCredit)
                    .HasColumnName("TOTAL_CREDIT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalDebit)
                    .HasColumnName("TOTAL_DEBIT")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.GeneralEntries)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_GENERAL_ENTRIES_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.GeneralEntries)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_GENERAL_ENTRIES_COMPANY");
            });

            modelBuilder.Entity<GeneralEntriesLines>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("GENERAL_ENTRIES_LINES", "FN");

                entity.Property(e => e.LineId).HasColumnName("LINE_ID");

                entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Credit)
                    .HasColumnName("CREDIT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Debit)
                    .HasColumnName("DEBIT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.GeneralEntryId).HasColumnName("GENERAL_ENTRY_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.GeneralEntriesLines)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_GENERAL_ENTRIES_LINES_ACCOUNTS");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.GeneralEntriesLines)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_GENERAL_ENTRIES_LINES_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.GeneralEntriesLines)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_GENERAL_ENTRIES_LINES_COMPANY");

                entity.HasOne(d => d.GeneralEntry)
                    .WithMany(p => p.GeneralEntriesLines)
                    .HasForeignKey(d => d.GeneralEntryId)
                    .HasConstraintName("FK_GENERAL_ENTRIES_LINES_GENERAL_ENTRIES");
            });

            modelBuilder.Entity<GosiSettings>(entity =>
            {
                entity.HasKey(e => e.GosiSettingId);

                entity.ToTable("GOSI_SETTINGS", "HR");

                entity.Property(e => e.GosiSettingId).HasColumnName("GOSI_SETTING_ID");

                entity.Property(e => e.AllowanceTypeIds)
                    .IsRequired()
                    .HasColumnName("ALLOWANCE_TYPE_IDs")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CompanyShareMaxValue)
                    .HasColumnName("COMPANY_SHARE_MAX_VALUE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanySharePercent)
                    .HasColumnName("COMPANY_SHARE_PERCENT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpShareMaxValue)
                    .HasColumnName("EMP_SHARE_MAX_VALUE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EmpSharePercent)
                    .HasColumnName("EMP_SHARE_PERCENT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GosiSettingCode)
                    .HasColumnName("GOSI_SETTING_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GosiSettingNameAr)
                    .HasColumnName("GOSI_SETTING_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.GosiSettingNameEn)
                    .IsRequired()
                    .HasColumnName("GOSI_SETTING_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");
            });

            modelBuilder.Entity<Grades>(entity =>
            {
                entity.ToTable("GRADES", "ACD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcademicYearId).HasColumnName("ACADEMIC_YEAR_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.F10GMarks)
                    .HasColumnName("F10_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F10Per)
                    .HasColumnName("F10_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F10Title)
                    .HasColumnName("F10_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F1GMarks)
                    .HasColumnName("F1_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F1Per)
                    .HasColumnName("F1_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F1Title)
                    .HasColumnName("F1_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F2GMarks)
                    .HasColumnName("F2_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F2Per)
                    .HasColumnName("F2_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F2Title)
                    .HasColumnName("F2_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F3GMarks)
                    .HasColumnName("F3_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F3Per)
                    .HasColumnName("F3_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F3Title)
                    .HasColumnName("F3_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F4GMarks)
                    .HasColumnName("F4_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F4Per)
                    .HasColumnName("F4_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F4Title)
                    .HasColumnName("F4_TITLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F5GMarks)
                    .HasColumnName("F5_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F5Per)
                    .HasColumnName("F5_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F5Title)
                    .HasColumnName("F5_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F6GMarks)
                    .HasColumnName("F6_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F6Per)
                    .HasColumnName("F6_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F6Title)
                    .HasColumnName("F6_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F7GMarks)
                    .HasColumnName("F7_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F7Per)
                    .HasColumnName("F7_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F7Title)
                    .HasColumnName("F7_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F8GMarks)
                    .HasColumnName("F8_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F8Per)
                    .HasColumnName("F8_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F8Title)
                    .HasColumnName("F8_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.F9GMarks)
                    .HasColumnName("F9_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F9Per)
                    .HasColumnName("F9_PER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.F9Title)
                    .HasColumnName("F9_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.Grade)
                    .HasColumnName("GRADE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GradePoints).HasColumnName("GRADE_POINTS");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PendingGradeTypeId)
                    .HasColumnName("PENDING_GRADE_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(500);

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.Property(e => e.TotalGMarks)
                    .HasColumnName("TOTAL_G_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalPer)
                    .HasColumnName("TOTAL_PER")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Grades1>(entity =>
            {
                entity.HasKey(e => e.GradeId);

                entity.ToTable("GRADES", "HR");

                entity.Property(e => e.GradeId).HasColumnName("GRADE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.BusinessTripExternal).HasColumnName("BUSINESS_TRIP_EXTERNAL");

                entity.Property(e => e.BusinessTripInternal).HasColumnName("BUSINESS_TRIP_INTERNAL");

                entity.Property(e => e.ComissionEligibility).HasColumnName("COMISSION_ELIGIBILITY");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.ContractDurationMonths).HasColumnName("CONTRACT_DURATION_MONTHS");

                entity.Property(e => e.ContractStatus)
                    .HasColumnName("CONTRACT_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("Single, Family");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FamilyDependencies).HasColumnName("FAMILY_DEPENDENCIES");

                entity.Property(e => e.GradeCode)
                    .HasColumnName("GRADE_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GradeNameAr)
                    .HasColumnName("GRADE_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.GradeNameEn)
                    .IsRequired()
                    .HasColumnName("GRADE_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.IncrementPercentage)
                    .HasColumnName("INCREMENT_PERCENTAGE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LoanEligibility).HasColumnName("LOAN_ELIGIBILITY");

                entity.Property(e => e.MedicalInsuranceCategory).HasColumnName("MEDICAL_INSURANCE_CATEGORY");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OtEligibility).HasColumnName("OT_ELIGIBILITY");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.VehicleEligibility).HasColumnName("VEHICLE_ELIGIBILITY");

                entity.Property(e => e.YearlyVacationDays).HasColumnName("YEARLY_VACATION_DAYS");
            });

            modelBuilder.Entity<GradesDetail>(entity =>
            {
                entity.HasKey(e => e.GradeDetailId);

                entity.ToTable("GRADES_DETAIL", "HR");

                entity.Property(e => e.GradeDetailId).HasColumnName("GRADE_DETAIL_ID");

                entity.Property(e => e.AllowanceTypeId)
                    .IsRequired()
                    .HasColumnName("ALLOWANCE_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.GradeId).HasColumnName("GRADE_ID");

                entity.Property(e => e.IsEnable).HasColumnName("IS_ENABLE");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.RangeFrom)
                    .HasColumnName("RANGE_FROM")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RangeTo)
                    .HasColumnName("RANGE_TO")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.GradesDetail)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRADES_DETAIL_GRADES");
            });

            modelBuilder.Entity<HospitalDept>(entity =>
            {
                entity.HasKey(e => e.DeptId);

                entity.ToTable("HOSPITAL_DEPT", "ACD");

                entity.Property(e => e.DeptId).HasColumnName("DEPT_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.DeptName)
                    .HasColumnName("DEPT_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalId).HasColumnName("HOSPITAL_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.HospitalDept)
                    .HasForeignKey(d => d.HospitalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOSPITAL_DEPT_HOSPITALS");
            });

            modelBuilder.Entity<HospitalSeats>(entity =>
            {
                entity.ToTable("HOSPITAL_SEATS", "ACD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AvailableSeats).HasColumnName("AVAILABLE_SEATS");

                entity.Property(e => e.ClassId).HasColumnName("CLASS_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.DeptId).HasColumnName("DEPT_ID");

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.HospitalId).HasColumnName("HOSPITAL_ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalSeats).HasColumnName("TOTAL_SEATS");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.HospitalSeats)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_HOSPITAL_SEATS_CLASSES");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.HospitalSeats)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOSPITAL_SEATS_HOSPITAL_DEPT");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.HospitalSeats)
                    .HasForeignKey(d => d.HospitalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOSPITAL_SEATS_HOSPITALS");
            });

            modelBuilder.Entity<Hospitals>(entity =>
            {
                entity.HasKey(e => e.HospitalId);

                entity.ToTable("HOSPITALS", "ACD");

                entity.Property(e => e.HospitalId).HasColumnName("HOSPITAL_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionAr)
                    .HasColumnName("DESCRIPTION_AR")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalName)
                    .HasColumnName("HOSPITAL_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HosptialNameAr)
                    .HasColumnName("HOSPTIAL_NAME_AR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<HousingAllowances>(entity =>
            {
                entity.HasKey(e => e.HousingAllowanceId);

                entity.ToTable("HOUSING_ALLOWANCES", "HR");

                entity.Property(e => e.HousingAllowanceId).HasColumnName("HOUSING_ALLOWANCE_ID");

                entity.Property(e => e.AllowanceRate)
                    .HasColumnName("ALLOWANCE_RATE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AllowanceTypeIds)
                    .IsRequired()
                    .HasColumnName("ALLOWANCE_TYPE_IDs")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DistributeWithSalary).HasColumnName("DISTRIBUTE_WITH_SALARY");

                entity.Property(e => e.FixedAmount)
                    .HasColumnName("FIXED_AMOUNT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HousingAllowanceCode)
                    .HasColumnName("HOUSING_ALLOWANCE_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HousingAllowanceNameAr)
                    .HasColumnName("HOUSING_ALLOWANCE_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.HousingAllowanceNameEn)
                    .IsRequired()
                    .HasColumnName("HOUSING_ALLOWANCE_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.HousingPaymentTypeId)
                    .HasColumnName("HOUSING_PAYMENT_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment(@"Pay Every Month,
Pay Quaterly,
Pay Half Yearly,
Pay Yearly
");

                entity.Property(e => e.IsFixedAmount).HasColumnName("IS_FIXED_AMOUNT");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.ToTable("INVOICES", "AR");

                entity.Property(e => e.InvoiceId).HasColumnName("INVOICE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.DiscountPer)
                    .HasColumnName("DISCOUNT_PER")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DueDate)
                    .HasColumnName("DUE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.GlBatchId)
                    .HasColumnName("GL_BATCH_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsPosted).HasColumnName("IS_POSTED");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(1000);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PostedBy).HasColumnName("POSTED_BY");

                entity.Property(e => e.PostedDate)
                    .HasColumnName("POSTED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RefNo)
                    .HasColumnName("REF_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.SubTotal)
                    .HasColumnName("SUB_TOTAL")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRateId).HasColumnName("TAX_RATE_ID");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalDiscount)
                    .HasColumnName("TOTAL_DISCOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalTax)
                    .HasColumnName("TOTAL_TAX")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_INVOICES_BRANCH");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_INVOICES_CUSTOMERS");

                entity.HasOne(d => d.TaxRate)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.TaxRateId)
                    .HasConstraintName("FK_INVOICES_TAX_RATES");
            });

            modelBuilder.Entity<InvoicesLines>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("INVOICES_LINES", "AR");

                entity.Property(e => e.LineId).HasColumnName("LINE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountAmount)
                    .HasColumnName("DISCOUNT_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountPercent)
                    .HasColumnName("DISCOUNT_PERCENT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.InvoiceId).HasColumnName("INVOICE_ID");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.ItemPrice)
                    .HasColumnName("ITEM_PRICE")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineAmount)
                    .HasColumnName("LINE_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxAmount)
                    .HasColumnName("TAX_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRate)
                    .HasColumnName("TAX_RATE")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRateId).HasColumnName("TAX_RATE_ID");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("UNIT_PRICE")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.InvoicesLines)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_INVOICES_LINES_BRANCH");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoicesLines)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_INVOICES_LINES_INVOICES");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvoicesLines)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_INVOICES_LINES_ITEMS");

                entity.HasOne(d => d.TaxRateNavigation)
                    .WithMany(p => p.InvoicesLines)
                    .HasForeignKey(d => d.TaxRateId)
                    .HasConstraintName("FK_INVOICES_LINES_TAX_RATES");
            });

            modelBuilder.Entity<ItemCategories>(entity =>
            {
                entity.HasKey(e => e.ItemCategoryId);

                entity.ToTable("ITEM_CATEGORIES", "INV");

                entity.Property(e => e.ItemCategoryId).HasColumnName("ITEM_CATEGORY_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItemCategoryCode)
                    .HasColumnName("ITEM_CATEGORY_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategoryNameAr)
                    .HasColumnName("ITEM_CATEGORY_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.ItemCategoryNameEn)
                    .IsRequired()
                    .HasColumnName("ITEM_CATEGORY_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentCategoryId).HasColumnName("PARENT_CATEGORY_ID");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("ITEMS", "INV");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.Barcode)
                    .HasColumnName("BARCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItemCategoryId).HasColumnName("ITEM_CATEGORY_ID");

                entity.Property(e => e.ItemCode)
                    .HasColumnName("ITEM_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNameAr)
                    .HasColumnName("ITEM_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.ItemNameEn)
                    .IsRequired()
                    .HasColumnName("ITEM_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tags)
                    .HasColumnName("TAGS")
                    .HasMaxLength(50);

                entity.HasOne(d => d.ItemCategory)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ItemCategoryId)
                    .HasConstraintName("FK_ITEMS_ITEM_CATEGORIES");
            });

            modelBuilder.Entity<JobOffers>(entity =>
            {
                entity.HasKey(e => e.JobOfferId);

                entity.ToTable("JOB_OFFERS", "HR");

                entity.Property(e => e.JobOfferId).HasColumnName("JOB_OFFER_ID");

                entity.Property(e => e.BasicSalary)
                    .HasColumnName("BASIC_SALARY")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Bonus)
                    .HasColumnName("BONUS")
                    .HasMaxLength(100);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .HasColumnName("DEPARTMENT")
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployementType)
                    .HasColumnName("EMPLOYEMENT_TYPE")
                    .HasMaxLength(100);

                entity.Property(e => e.ExpectingJoiningDate)
                    .HasColumnName("EXPECTING_JOINING_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.FamilyNameAr)
                    .HasColumnName("FAMILY_NAME_AR")
                    .HasMaxLength(30);

                entity.Property(e => e.FamilyNameEn)
                    .HasColumnName("FAMILY_NAME_EN")
                    .HasMaxLength(30);

                entity.Property(e => e.FatherNameAr)
                    .HasColumnName("FATHER_NAME_AR")
                    .HasMaxLength(30);

                entity.Property(e => e.FatherNameEn)
                    .HasColumnName("FATHER_NAME_EN")
                    .HasMaxLength(30);

                entity.Property(e => e.FirstNameAr)
                    .HasColumnName("FIRST_NAME_AR")
                    .HasMaxLength(30);

                entity.Property(e => e.FirstNameEn)
                    .HasColumnName("FIRST_NAME_EN")
                    .HasMaxLength(30);

                entity.Property(e => e.GenderId)
                    .HasColumnName("GENDER_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GosiDeduction)
                    .HasColumnName("GOSI_DEDUCTION")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GrandNameAr)
                    .HasColumnName("GRAND_NAME_AR")
                    .HasMaxLength(30);

                entity.Property(e => e.GrandNameEn)
                    .HasColumnName("GRAND_NAME_EN")
                    .HasMaxLength(30);

                entity.Property(e => e.HousingAllowance)
                    .HasColumnName("HOUSING_ALLOWANCE")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(100);

                entity.Property(e => e.MaritalStatusId)
                    .HasColumnName("MARITAL_STATUS_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.NationalityId)
                    .HasColumnName("NATIONALITY_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ProbationPeriod).HasColumnName("PROBATION_PERIOD");

                entity.Property(e => e.ReportingManager)
                    .HasColumnName("REPORTING_MANAGER")
                    .HasMaxLength(100);

                entity.Property(e => e.SanedDeduction)
                    .HasColumnName("SANED_DEDUCTION")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TicketAllowance)
                    .HasColumnName("TICKET_ALLOWANCE")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalSalary)
                    .HasColumnName("TOTAL_SALARY")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransportationAllowance)
                    .HasColumnName("TRANSPORTATION_ALLOWANCE")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<JobPortalUsers>(entity =>
            {
                entity.HasKey(e => e.JobPortalUserId)
                    .HasName("PK_STUDENT_ACCOUNTS");

                entity.ToTable("JOB_PORTAL_USERS", "HR");

                entity.Property(e => e.JobPortalUserId).HasColumnName("JOB_PORTAL_USER_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(50);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Leaves>(entity =>
            {
                entity.HasKey(e => e.LeaveId);

                entity.ToTable("LEAVES", "HR");

                entity.Property(e => e.LeaveId).HasColumnName("LEAVE_ID");

                entity.Property(e => e.AirTicket).HasColumnName("AIR_TICKET");

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(50);

                entity.Property(e => e.AttachmentType)
                    .HasColumnName("ATTACHMENT_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BalDaysAfter).HasColumnName("BAL_DAYS_AFTER");

                entity.Property(e => e.BalDaysBefore).HasColumnName("BAL_DAYS_BEFORE");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateFrom)
                    .HasColumnName("DATE_FROM")
                    .HasColumnType("date");

                entity.Property(e => e.DateTo)
                    .HasColumnName("DATE_TO")
                    .HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.LeaveStatus)
                    .HasColumnName("LEAVE_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveTypeId)
                    .HasColumnName("LEAVE_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaidDays).HasColumnName("PAID_DAYS");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.ResumeDate)
                    .HasColumnName("RESUME_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Substitute).HasColumnName("SUBSTITUTE");

                entity.Property(e => e.UnpaidDays).HasColumnName("UNPAID_DAYS");

                entity.HasOne(d => d.AttachmentTypeNavigation)
                    .WithMany(p => p.LeavesAttachmentTypeNavigation)
                    .HasForeignKey(d => d.AttachmentType)
                    .HasConstraintName("FK_LEAVES_ATTACHMENT_TYPE");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Leaves)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_LEAVES_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Leaves)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_LEAVES_COMPANY");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.Leaves)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_LEAVES_EMP");

                entity.HasOne(d => d.LeaveStatusNavigation)
                    .WithMany(p => p.LeavesLeaveStatusNavigation)
                    .HasForeignKey(d => d.LeaveStatus)
                    .HasConstraintName("FK_LEAVES_LEAVE_STATUS");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.LeavesLeaveType)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .HasConstraintName("FK_LEAVES_LEAVE_TYPE");
            });

            modelBuilder.Entity<LeavesProfile>(entity =>
            {
                entity.ToTable("LEAVES_PROFILE", "HR");

                entity.Property(e => e.LeavesProfileId).HasColumnName("LEAVES_PROFILE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.TotalBusinessLeaves).HasColumnName("TOTAL_BUSINESS_LEAVES");

                entity.Property(e => e.TotalEducationalLeaves).HasColumnName("TOTAL_EDUCATIONAL_LEAVES");

                entity.Property(e => e.TotalEmergencyLeaves).HasColumnName("TOTAL_EMERGENCY_LEAVES");

                entity.Property(e => e.TotalExaminationLeaves).HasColumnName("TOTAL_EXAMINATION_LEAVES");

                entity.Property(e => e.TotalMarriageLeaves).HasColumnName("TOTAL_MARRIAGE_LEAVES");

                entity.Property(e => e.TotalMaternityLeaves).HasColumnName("TOTAL_MATERNITY_LEAVES");

                entity.Property(e => e.TotalPaternityLeaves).HasColumnName("TOTAL_PATERNITY_LEAVES");

                entity.Property(e => e.TotalSickLeaves).HasColumnName("TOTAL_SICK_LEAVES");

                entity.Property(e => e.TotalSpecialLeaves).HasColumnName("TOTAL_SPECIAL_LEAVES");
            });

            modelBuilder.Entity<LeavesReturn>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("LEAVES_RETURN", "HR");

                entity.Property(e => e.RecId).HasColumnName("REC_ID");

                entity.Property(e => e.Balance).HasColumnName("BALANCE");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EarlyDays).HasColumnName("EARLY_DAYS");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.JoiningDate)
                    .HasColumnName("JOINING_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.JoiningDateActual)
                    .HasColumnName("JOINING_DATE_ACTUAL")
                    .HasColumnType("date");

                entity.Property(e => e.LateDays).HasColumnName("LATE_DAYS");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaidDays).HasColumnName("PAID_DAYS");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(500);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.LeavesReturn)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_LEAVES_RETURN_EMP");
            });

            modelBuilder.Entity<Loans>(entity =>
            {
                entity.HasKey(e => e.LoanId);

                entity.ToTable("LOANS", "HR");

                entity.Property(e => e.LoanId).HasColumnName("LOAN_ID");

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(50);

                entity.Property(e => e.AttachmentType)
                    .HasColumnName("ATTACHMENT_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStart)
                    .HasColumnName("DATE_START")
                    .HasColumnType("date");

                entity.Property(e => e.DeductAmount)
                    .HasColumnName("DEDUCT_AMOUNT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.LoanAmount)
                    .HasColumnName("LOAN_AMOUNT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LoanStatus)
                    .HasColumnName("LOAN_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LoanTypeId)
                    .HasColumnName("LOAN_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoOfInstallments).HasColumnName("NO_OF_INSTALLMENTS");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(500);

                entity.HasOne(d => d.AttachmentTypeNavigation)
                    .WithMany(p => p.LoansAttachmentTypeNavigation)
                    .HasForeignKey(d => d.AttachmentType)
                    .HasConstraintName("FK_LOANS_ATTACHMENT_TYPE");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Loans)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_LOANS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Loans)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_LOANS_COMPANY");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.Loans)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_LOANS_EMP");

                entity.HasOne(d => d.LoanStatusNavigation)
                    .WithMany(p => p.LoansLoanStatusNavigation)
                    .HasForeignKey(d => d.LoanStatus)
                    .HasConstraintName("FK_LOANS_LOAN_STATUS");

                entity.HasOne(d => d.LoanType)
                    .WithMany(p => p.LoansLoanType)
                    .HasForeignKey(d => d.LoanTypeId)
                    .HasConstraintName("FK_LOANS_LOAN_TYPE");
            });

            modelBuilder.Entity<LookupTypes>(entity =>
            {
                entity.HasKey(e => e.LookupTypeId)
                    .HasName("PK_CODE_TYPES");

                entity.ToTable("LOOKUP_TYPES");

                entity.Property(e => e.LookupTypeId)
                    .HasColumnName("LOOKUP_TYPE_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ActiveStatus).HasColumnName("ACTIVE_STATUS");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Locked).HasColumnName("LOCKED");

                entity.Property(e => e.LookupTypeNameAr)
                    .HasColumnName("LOOKUP_TYPE_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.LookupTypeNameEn)
                    .HasColumnName("LOOKUP_TYPE_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.LookupTypes)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_LOOKUP_TYPES_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.LookupTypes)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_LOOKUP_TYPES_COMPANY");
            });

            modelBuilder.Entity<Lookups>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_CODES_1");

                entity.ToTable("LOOKUPS");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Abbreviation)
                    .HasColumnName("ABBREVIATION")
                    .HasMaxLength(20);

                entity.Property(e => e.ActiveStatus).HasColumnName("ACTIVE_STATUS");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LookupId)
                    .IsRequired()
                    .HasColumnName("LOOKUP_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LookupNameAr)
                    .HasColumnName("LOOKUP__NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.LookupNameEn)
                    .HasColumnName("LOOKUP__NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.LookupTypeId)
                    .IsRequired()
                    .HasColumnName("LOOKUP_TYPE_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentCode)
                    .HasColumnName("PARENT_CODE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Value).HasColumnName("VALUE");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Lookups)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_LOOKUPS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Lookups)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_LOOKUPS_COMPANY");

                entity.HasOne(d => d.LookupType)
                    .WithMany(p => p.Lookups)
                    .HasForeignKey(d => d.LookupTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CODES_CODE_TYPES");
            });

            modelBuilder.Entity<Major>(entity =>
            {
                entity.ToTable("MAJOR", "ACD");

                entity.Property(e => e.MajorId).HasColumnName("MAJOR_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CampusId).HasColumnName("CAMPUS_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MajorCode)
                    .HasColumnName("MAJOR_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MajorNameAr)
                    .HasColumnName("MAJOR_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.MajorNameEn)
                    .IsRequired()
                    .HasColumnName("MAJOR_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.MajorTypeId).HasColumnName("MAJOR_TYPE_ID");

                entity.Property(e => e.MaxCoreCourses).HasColumnName("MAX_CORE_COURSES");

                entity.Property(e => e.MaxGeneralCourses).HasColumnName("MAX_GENERAL_COURSES");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlanLevels).HasColumnName("PLAN_LEVELS");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.HasOne(d => d.MajorType)
                    .WithMany(p => p.Major)
                    .HasForeignKey(d => d.MajorTypeId)
                    .HasConstraintName("FK_MAJOR_MAJOR_TYPE");
            });

            modelBuilder.Entity<MajorType>(entity =>
            {
                entity.ToTable("MAJOR_TYPE", "ACD");

                entity.Property(e => e.MajorTypeId).HasColumnName("MAJOR_TYPE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CampusId).HasColumnName("CAMPUS_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MajorTypeCode)
                    .HasColumnName("MAJOR_TYPE_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MajorTypeNameAr)
                    .HasColumnName("MAJOR_TYPE_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.MajorTypeNameEn)
                    .IsRequired()
                    .HasColumnName("MAJOR_TYPE_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.HasOne(d => d.Campus)
                    .WithMany(p => p.MajorType)
                    .HasForeignKey(d => d.CampusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MAJOR_TYPE_CAMPUS");
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.ConversationId).HasColumnName("ConversationID");

                entity.Property(e => e.MessageDate).HasColumnType("datetime");

                entity.Property(e => e.MessageFrom)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MessageUserId).HasColumnName("MessageUserID");
            });

            modelBuilder.Entity<Modules>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PK_MODULE");

                entity.ToTable("MODULES", "AUTH");

                entity.Property(e => e.ModuleId).HasColumnName("MODULE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisplayOrder).HasColumnName("DISPLAY_ORDER");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("IS_DELETED")
                    .HasMaxLength(50);

                entity.Property(e => e.IsDisable).HasColumnName("IS_DISABLE");

                entity.Property(e => e.IsVisible).HasColumnName("IS_VISIBLE");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("MODULE_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleIcon)
                    .HasColumnName("MODULE_ICON")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleNameAr)
                    .HasColumnName("MODULE_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleNameEn)
                    .IsRequired()
                    .HasColumnName("MODULE_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleUrl)
                    .HasColumnName("MODULE_URL")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentModuleId).HasColumnName("PARENT_MODULE_ID");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");
            });

            modelBuilder.Entity<NationalHolidays>(entity =>
            {
                entity.HasKey(e => e.NationalHolidayId);

                entity.ToTable("NATIONAL_HOLIDAYS", "HR");

                entity.Property(e => e.NationalHolidayId).HasColumnName("NATIONAL_HOLIDAY_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.NationalHolidayCode)
                    .HasColumnName("NATIONAL_HOLIDAY_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NationalHolidayNameAr)
                    .HasColumnName("NATIONAL_HOLIDAY_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.NationalHolidayNameEn)
                    .IsRequired()
                    .HasColumnName("NATIONAL_HOLIDAY_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.OvertimeSettingId).HasColumnName("OVERTIME_SETTING_ID");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.TotalDays).HasColumnName("TOTAL_DAYS");

                entity.HasOne(d => d.OvertimeSetting)
                    .WithMany(p => p.NationalHolidays)
                    .HasForeignKey(d => d.OvertimeSettingId)
                    .HasConstraintName("FK_NATIONAL_HOLIDAYS_OVERTIME_SETTINGS");
            });

            modelBuilder.Entity<Navigations>(entity =>
            {
                entity.HasKey(e => e.NavigationId)
                    .HasName("PK_NAVIGATION");

                entity.ToTable("NAVIGATIONS", "AUTH");

                entity.Property(e => e.NavigationId).HasColumnName("NAVIGATION_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisplayOrder).HasColumnName("DISPLAY_ORDER");

                entity.Property(e => e.HasChild).HasColumnName("HAS_CHILD");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("IS_DELETED")
                    .HasMaxLength(50);

                entity.Property(e => e.IsDisable).HasColumnName("IS_DISABLE");

                entity.Property(e => e.IsVisible).HasColumnName("IS_VISIBLE");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModuleId).HasColumnName("MODULE_ID");

                entity.Property(e => e.NavIcon)
                    .HasColumnName("NAV_ICON")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NavUrl)
                    .HasColumnName("NAV_URL")
                    .HasMaxLength(100);

                entity.Property(e => e.NavigationNameAr)
                    .HasColumnName("NAVIGATION_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.NavigationNameEn)
                    .IsRequired()
                    .HasColumnName("NAVIGATION_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentNavigationId).HasColumnName("PARENT_NAVIGATION_ID");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ShowInAnotherWindow)
                    .HasColumnName("SHOW_IN_ANOTHER_WINDOW")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Navigations)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_NAVIGATIONS_MODULES");
            });

            modelBuilder.Entity<Notes>(entity =>
            {
                entity.HasKey(e => e.NoteId)
                    .HasName("PK_NOTES_1");

                entity.ToTable("NOTES", "FN");

                entity.Property(e => e.NoteId).HasColumnName("Note_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoteCode)
                    .HasColumnName("Note_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoteDescription)
                    .HasColumnName("Note_Description")
                    .IsUnicode(false);

                entity.Property(e => e.NoteLevel).HasColumnName("Note_Level");

                entity.Property(e => e.NoteTitle)
                    .HasColumnName("Note_Title")
                    .IsUnicode(false);

                entity.Property(e => e.ParentNoteId).HasColumnName("Parent_Note_Id");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.NotesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Notes_USERS");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.NotesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Notes_USERS1");

                entity.HasOne(d => d.ParentNote)
                    .WithMany(p => p.InverseParentNote)
                    .HasForeignKey(d => d.ParentNoteId)
                    .HasConstraintName("FK_Notes_Notes1");
            });

            modelBuilder.Entity<Operator>(entity =>
            {
                entity.Property(e => e.OperatorId).HasColumnName("OperatorID");

                entity.Property(e => e.Email)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OvertimeRequests>(entity =>
            {
                entity.HasKey(e => e.OvertimeRequestId);

                entity.ToTable("OVERTIME_REQUESTS", "HR");

                entity.Property(e => e.OvertimeRequestId).HasColumnName("OVERTIME_REQUEST_ID");

                entity.Property(e => e.ApprovalDate)
                    .HasColumnName("APPROVAL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovalStatus).HasColumnName("APPROVAL_STATUS");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(1000);

                entity.Property(e => e.OvertimeDate)
                    .HasColumnName("OVERTIME_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.OvertimeRequestNo)
                    .HasColumnName("OVERTIME_REQUEST_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.RequestStatus)
                    .HasColumnName("REQUEST_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.OvertimeRequests)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_OVERTIME_REQUESTS_BRANCH");

                entity.HasOne(d => d.RequestStatusNavigation)
                    .WithMany(p => p.OvertimeRequests)
                    .HasForeignKey(d => d.RequestStatus)
                    .HasConstraintName("FK_OVERTIME_REQUESTS_LOOKUPS");
            });

            modelBuilder.Entity<OvertimeRequestsLines>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("OVERTIME_REQUESTS_LINES", "HR");

                entity.Property(e => e.LineId).HasColumnName("LINE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OtAmount)
                    .HasColumnName("OT_AMOUNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OtHours).HasColumnName("OT_HOURS");

                entity.Property(e => e.OvertimeRequestId).HasColumnName("OVERTIME_REQUEST_ID");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeFrom).HasColumnName("TIME_FROM");

                entity.Property(e => e.TimeTo).HasColumnName("TIME_TO");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.OvertimeRequestsLines)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_OVERTIME_REQUESTS_LINES_BRANCH");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.OvertimeRequestsLines)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_OVERTIME_REQUESTS_LINES_EMP");

                entity.HasOne(d => d.OvertimeRequest)
                    .WithMany(p => p.OvertimeRequestsLines)
                    .HasForeignKey(d => d.OvertimeRequestId)
                    .HasConstraintName("FK_OVERTIME_REQUESTS_LINES_OVERTIME_REQUESTS");
            });

            modelBuilder.Entity<OvertimeSettings>(entity =>
            {
                entity.HasKey(e => e.OvertimeSettingId);

                entity.ToTable("OVERTIME_SETTINGS", "HR");

                entity.Property(e => e.OvertimeSettingId).HasColumnName("OVERTIME_SETTING_ID");

                entity.Property(e => e.AllowanceTypeIds)
                    .IsRequired()
                    .HasColumnName("ALLOWANCE_TYPE_IDs")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CalculationPercentage)
                    .HasColumnName("CALCULATION_PERCENTAGE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OvertimeSettingCode)
                    .HasColumnName("OVERTIME_SETTING_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OvertimeSettingNameAr)
                    .HasColumnName("OVERTIME_SETTING_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.OvertimeSettingNameEn)
                    .IsRequired()
                    .HasColumnName("OVERTIME_SETTING_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.ToTable("OWNER", "ACD");

                entity.Property(e => e.OwnerId).HasColumnName("OWNER_ID");

                entity.Property(e => e.BrancId).HasColumnName("BRANC_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.OwnerName)
                    .IsRequired()
                    .HasColumnName("OWNER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerPosition)
                    .HasColumnName("OWNER_POSITION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerShares).HasColumnName("OWNER_SHARES");
            });

            modelBuilder.Entity<Parents>(entity =>
            {
                entity.HasKey(e => e.ParentId);

                entity.ToTable("PARENTS", "ACD");

                entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(150);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("BIRTH_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.BirthPlaceId)
                    .HasColumnName("BIRTH_PLACE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BloodGroup)
                    .HasColumnName("BLOOD_GROUP")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployerName)
                    .HasColumnName("EMPLOYER_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.GenderId)
                    .HasColumnName("GENDER_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.NationalIdentity)
                    .HasColumnName("NATIONAL_IDENTITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NationalIdentityExpiryDate)
                    .HasColumnName("NATIONAL_IDENTITY_EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.NationalIdentityExpiryDateHijri)
                    .HasColumnName("NATIONAL_IDENTITY_EXPIRY_DATE_HIJRI")
                    .HasColumnType("date");

                entity.Property(e => e.NationalIdentityIssuedDate)
                    .HasColumnName("NATIONAL_IDENTITY_ISSUED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.NationalIdentityIssuedDateHijri)
                    .HasColumnName("NATIONAL_IDENTITY_ISSUED_DATE_HIJRI")
                    .HasColumnType("date");

                entity.Property(e => e.NationalityId)
                    .HasColumnName("NATIONALITY_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ParentNameAr)
                    .HasColumnName("PARENT_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentNameEn)
                    .HasColumnName("PARENT_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.PassportExpiryDate)
                    .HasColumnName("PASSPORT_EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.PassportExpiryDateHijri)
                    .HasColumnName("PASSPORT_EXPIRY_DATE_HIJRI")
                    .HasColumnType("date");

                entity.Property(e => e.PassportIssuedDate)
                    .HasColumnName("PASSPORT_ISSUED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.PassportIssuedDateHijri)
                    .HasColumnName("PASSPORT_ISSUED_DATE_HIJRI")
                    .HasColumnType("date");

                entity.Property(e => e.PassportIssuedFrom)
                    .HasColumnName("PASSPORT_ISSUED_FROM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PassportNo)
                    .HasColumnName("PASSPORT_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ProfileSummary)
                    .HasColumnName("PROFILE_SUMMARY")
                    .HasMaxLength(300);

                entity.Property(e => e.RelationshipId)
                    .HasColumnName("RELATIONSHIP_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.Property(e => e.UserName)
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Parents)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_PARENTS_COMPANY");
            });

            modelBuilder.Entity<PayGroups>(entity =>
            {
                entity.HasKey(e => e.PayGroupId);

                entity.ToTable("PAY_GROUPS", "HR");

                entity.Property(e => e.PayGroupId).HasColumnName("PAY_GROUP_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayGroupCode)
                    .HasColumnName("PAY_GROUP_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PayGroupNameAr)
                    .HasColumnName("PAY_GROUP_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.PayGroupNameEn)
                    .IsRequired()
                    .HasColumnName("PAY_GROUP_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");
            });

            modelBuilder.Entity<Payments>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("PAYMENTS", "AP");

                entity.Property(e => e.PaymentId).HasColumnName("PAYMENT_ID");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAccount).HasColumnName("DESTINATION_ACCOUNT");

                entity.Property(e => e.GlBatchId)
                    .HasColumnName("GL_BATCH_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsPosted).HasColumnName("IS_POSTED");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(1000);

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("PAYMENT_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.PaymentNo)
                    .HasColumnName("PAYMENT_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PostedBy).HasColumnName("POSTED_BY");

                entity.Property(e => e.PostedDate)
                    .HasColumnName("POSTED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecipientAccount).HasColumnName("RECIPIENT_ACCOUNT");

                entity.Property(e => e.RefNo)
                    .HasColumnName("REF_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.VendorId).HasColumnName("VENDOR_ID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_PAYMENTS_BRANCH");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_PAYMENTS_VENDORS");
            });

            modelBuilder.Entity<PayrunD>(entity =>
            {
                entity.HasKey(e => e.EmpPayrunId);

                entity.ToTable("PAYRUN_D", "HR");

                entity.Property(e => e.EmpPayrunId).HasColumnName("EMP_PAYRUN_ID");

                entity.Property(e => e.AbscentFine)
                    .HasColumnName("ABSCENT_FINE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Absents).HasColumnName("ABSENTS");

                entity.Property(e => e.Additions)
                    .HasColumnName("ADDITIONS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AmountPaid)
                    .HasColumnName("AMOUNT_PAID")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AnnualTaxLiability)
                    .HasColumnName("ANNUAL_TAX_LIABILITY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AnnualTaxableSalary)
                    .HasColumnName("ANNUAL_TAXABLE_SALARY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BankAccount)
                    .HasColumnName("BANK_ACCOUNT")
                    .HasMaxLength(50);

                entity.Property(e => e.BasicSalary)
                    .HasColumnName("BASIC_SALARY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeductedDays).HasColumnName("DEDUCTED_DAYS");

                entity.Property(e => e.Deduction)
                    .HasColumnName("DEDUCTION")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DemoCommission)
                    .HasColumnName("DEMO_COMMISSION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DifferAmount)
                    .HasColumnName("DIFFER_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EarnedSalary)
                    .HasColumnName("EARNED_SALARY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Earning)
                    .HasColumnName("EARNING")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.EmpName)
                    .HasColumnName("EMP_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.EobiEmployerContribution)
                    .HasColumnName("EOBI_EMPLOYER_CONTRIBUTION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ExemptSalaryFromPrviousEmplopyer)
                    .HasColumnName("EXEMPT_SALARY_FROM_PRVIOUS_EMPLOPYER")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FinalPaymentForThisMonth)
                    .HasColumnName("FINAL_PAYMENT_FOR_THIS_MONTH")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FoodAllowance)
                    .HasColumnName("FOOD_ALLOWANCE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GiftAmount)
                    .HasColumnName("GIFT_AMOUNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GrossSalary)
                    .HasColumnName("GROSS_SALARY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GroupInsuranceEmployerContribution)
                    .HasColumnName("GROUP_INSURANCE_EMPLOYER_CONTRIBUTION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HousingAllowance)
                    .HasColumnName("HOUSING_ALLOWANCE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IncrementAllowance)
                    .HasColumnName("INCREMENT_ALLOWANCE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IndemnityAllowance)
                    .HasColumnName("INDEMNITY_ALLOWANCE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LeavePayAllowance)
                    .HasColumnName("LEAVE_PAY_ALLOWANCE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LoanDeduction)
                    .HasColumnName("LOAN_DEDUCTION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MedicalAllowance)
                    .HasColumnName("MEDICAL_ALLOWANCE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MonthlyBonus)
                    .HasColumnName("MONTHLY_BONUS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NetPayableSalaryAfterTax)
                    .HasColumnName("NET_PAYABLE_SALARY_AFTER_TAX")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NetPayableSalaryAfterTaxAndStatuaryDeduction)
                    .HasColumnName("NET_PAYABLE_SALARY_AFTER_TAX_AND_STATUARY_DEDUCTION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NetSalary)
                    .HasColumnName("NET_SALARY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NetSalaryPaBeforeTax)
                    .HasColumnName("NET_SALARY_PA_BEFORE_TAX")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NoOfMonthRemaining)
                    .HasColumnName("NO_OF_MONTH_REMAINING")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OtherAllowance)
                    .HasColumnName("OTHER_ALLOWANCE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OtherDeductions)
                    .HasColumnName("OTHER_DEDUCTIONS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OvertimeAmount)
                    .HasColumnName("OVERTIME_AMOUNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PaidLeaves).HasColumnName("PAID_LEAVES");

                entity.Property(e => e.PayrunId).HasColumnName("PAYRUN_ID");

                entity.Property(e => e.PerDay)
                    .HasColumnName("PER_DAY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PessiEmployerContribution)
                    .HasColumnName("PESSI_EMPLOYER _CONTRIBUTION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Presents).HasColumnName("PRESENTS");

                entity.Property(e => e.PreviousPayableSalary)
                    .HasColumnName("PREVIOUS_PAYABLE_SALARY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PreviouslyEarnedSalaryCommulative)
                    .HasColumnName("PREVIOUSLY_EARNED_SALARY_COMMULATIVE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RecurringCommision)
                    .HasColumnName("RECURRING_COMMISION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReferenceCommision)
                    .HasColumnName("REFERENCE_COMMISION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RemainingTaxLiability)
                    .HasColumnName("REMAINING_TAX_LIABILITY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalaryCheck)
                    .HasColumnName("SALARY_CHECK")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalaryDate)
                    .HasColumnName("SALARY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.SalaryDedeuction)
                    .HasColumnName("SALARY_DEDEUCTION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalaryHeldThisMonth)
                    .HasColumnName("SALARY_HELD_THIS_MONTH")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalaryMonth).HasColumnName("SALARY_MONTH");

                entity.Property(e => e.SalaryPerDayCalculation)
                    .HasColumnName("SALARY_PER_DAY_CALCULATION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalaryYear).HasColumnName("SALARY_YEAR");

                entity.Property(e => e.SaleCommision)
                    .HasColumnName("SALE_COMMISION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Shortleaves).HasColumnName("SHORTLEAVES");

                entity.Property(e => e.Tardies).HasColumnName("TARDIES");

                entity.Property(e => e.TaxAlreadyDeduct)
                    .HasColumnName("TAX_ALREADY_DEDUCT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TaxPaForTheMonth)
                    .HasColumnName("TAX_PA_FOR_THE_MONTH")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThresholdSalary)
                    .HasColumnName("THRESHOLD_SALARY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalBasicSalary)
                    .HasColumnName("TOTAL_BASIC_SALARY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalDays).HasColumnName("TOTAL_DAYS");

                entity.Property(e => e.TotalDeduction)
                    .HasColumnName("TOTAL_DEDUCTION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalEstimatedExamptSalary)
                    .HasColumnName("TOTAL_ESTIMATED_EXAMPT_SALARY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalEstimatedSalaryFty)
                    .HasColumnName("TOTAL_ESTIMATED_SALARY_FTY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalPayableThisMonthAndPrevious)
                    .HasColumnName("TOTAL_PAYABLE_THIS_MONTH_AND_PREVIOUS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransportAllowance)
                    .HasColumnName("TRANSPORT_ALLOWANCE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnpaidDays).HasColumnName("UNPAID_DAYS");

                entity.Property(e => e.UnpaidLeaves).HasColumnName("UNPAID_LEAVES");

                entity.Property(e => e.Vat15)
                    .HasColumnName("VAT_15")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ZeroPaid)
                    .HasColumnName("ZERO_PAID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e._500Commision)
                    .HasColumnName("500_COMMISION")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.PayrunD)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAYRUN_D_EMP");

                entity.HasOne(d => d.Payrun)
                    .WithMany(p => p.PayrunD)
                    .HasForeignKey(d => d.PayrunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAYRUN_D_PAYRUN_M");
            });

            modelBuilder.Entity<PayrunM>(entity =>
            {
                entity.HasKey(e => e.PayrunId)
                    .HasName("PK_PAYRUN_M_1");

                entity.ToTable("PAYRUN_M", "HR");

                entity.Property(e => e.PayrunId).HasColumnName("PAYRUN_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.GlBatchId)
                    .HasColumnName("GL_BATCH_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsPosted).HasColumnName("IS_POSTED");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MonthId).HasColumnName("MONTH_ID");

                entity.Property(e => e.NetTotal)
                    .HasColumnName("NET_TOTAL")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(1000);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PostedBy).HasColumnName("POSTED_BY");

                entity.Property(e => e.PostedDate)
                    .HasColumnName("POSTED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalDeduction)
                    .HasColumnName("TOTAL_DEDUCTION")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalEarning)
                    .HasColumnName("TOTAL_EARNING")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.YearId).HasColumnName("YEAR_ID");
            });

            modelBuilder.Entity<PayrunPayslip>(entity =>
            {
                entity.HasKey(e => e.PayslipId);

                entity.ToTable("PAYRUN_PAYSLIP", "HR");

                entity.Property(e => e.PayslipId).HasColumnName("PAYSLIP_ID");

                entity.Property(e => e.AllowanceTypeId)
                    .IsRequired()
                    .HasColumnName("ALLOWANCE_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deduction)
                    .HasColumnName("DEDUCTION")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.Earning)
                    .HasColumnName("EARNING")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmpPayrunId).HasColumnName("EMP_PAYRUN_ID");

                entity.Property(e => e.IsPosted).HasColumnName("IS_POSTED");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(150);

                entity.HasOne(d => d.AllowanceType)
                    .WithMany(p => p.PayrunPayslip)
                    .HasForeignKey(d => d.AllowanceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAYRUN_PAYSLIP_ALLOWANCE_TYPE");
            });

            modelBuilder.Entity<PerformanceBaseSalary>(entity =>
            {
                entity.ToTable("PERFORMANCE_BASE_SALARY", "HR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.DemoCommission)
                    .HasColumnName("DEMO_COMMISSION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EarnedSalary)
                    .HasColumnName("EARNED_SALARY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.GiftAmount)
                    .HasColumnName("GIFT_AMOUNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.MonthlyBonus)
                    .HasColumnName("MONTHLY_BONUS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OvertimeHours).HasColumnName("OVERTIME_HOURS");

                entity.Property(e => e.OvertimeTotalMoney)
                    .HasColumnName("OVERTIME_TOTAL_MONEY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RecurringAmount)
                    .HasColumnName("RECURRING_AMOUNT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReferenceBasedCommission)
                    .HasColumnName("REFERENCE_BASED_COMMISSION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalaryMonth).HasColumnName("SALARY_MONTH");

                entity.Property(e => e.SalaryYear).HasColumnName("SALARY_YEAR");

                entity.Property(e => e.SaleCommision)
                    .HasColumnName("SALE_COMMISION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ZeroPaid)
                    .HasColumnName("ZERO_PAID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e._500Commission)
                    .HasColumnName("500_Commission")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.PerformanceBaseSalary)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_PERFORMANCE_BASE_SALARY_EMP");
            });

            modelBuilder.Entity<PlanCourses>(entity =>
            {
                entity.HasKey(e => e.PlanCourseId);

                entity.ToTable("PLAN_COURSES", "ACD");

                entity.Property(e => e.PlanCourseId).HasColumnName("PLAN_COURSE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.CourseType)
                    .HasColumnName("COURSE_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("Core, General Elective, Major Elective");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DEPARTMENT_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MajorId).HasColumnName("MAJOR_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlanLevel).HasColumnName("PLAN_LEVEL");

                entity.Property(e => e.PlanMainId).HasColumnName("PLAN_MAIN_ID");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Seq).HasColumnName("SEQ");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.PlanCourses)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PLAN_COURSES_COURSE");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.PlanCourses)
                    .HasForeignKey(d => d.MajorId)
                    .HasConstraintName("FK_PLAN_COURSES_MAJOR");

                entity.HasOne(d => d.PlanMain)
                    .WithMany(p => p.PlanCourses)
                    .HasForeignKey(d => d.PlanMainId)
                    .HasConstraintName("FK_PLAN_COURSES_PLAN_MAIN");
            });

            modelBuilder.Entity<PlanMain>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("PLAN_MAIN", "ACD");

                entity.Property(e => e.PlanId).HasColumnName("PLAN_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.MajorId).HasColumnName("MAJOR_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.PlanDescriptionAr)
                    .HasColumnName("PLAN_DESCRIPTION_AR")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PlanDescriptionEn)
                    .HasColumnName("PLAN_DESCRIPTION_EN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PlanTitleAr)
                    .HasColumnName("PLAN_TITLE_AR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanTitleEn)
                    .HasColumnName("PLAN_TITLE_EN")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlanPrerequisites>(entity =>
            {
                entity.HasKey(e => e.PlanPrerequisiteId);

                entity.ToTable("PLAN_PREREQUISITES", "ACD");

                entity.Property(e => e.PlanPrerequisiteId).HasColumnName("PLAN_PREREQUISITE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DEPARTMENT_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MajorId).HasColumnName("MAJOR_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlanCourseId).HasColumnName("PLAN_COURSE_ID");

                entity.Property(e => e.PlanLevel).HasColumnName("PLAN_LEVEL");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Seq).HasColumnName("SEQ");

                entity.HasOne(d => d.PlanCourse)
                    .WithMany(p => p.PlanPrerequisites)
                    .HasForeignKey(d => d.PlanCourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PLAN_PREREQUISITES_PLAN_COURSES");
            });

            modelBuilder.Entity<Positions>(entity =>
            {
                entity.HasKey(e => e.PositionId);

                entity.ToTable("POSITIONS", "HR");

                entity.Property(e => e.PositionId).HasColumnName("POSITION_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobDescription)
                    .HasColumnName("JOB_DESCRIPTION")
                    .HasMaxLength(2000);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentPositionId).HasColumnName("PARENT_POSITION_ID");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PositionCode)
                    .HasColumnName("POSITION_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PositionNameAr)
                    .HasColumnName("POSITION_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.PositionNameEn)
                    .IsRequired()
                    .HasColumnName("POSITION_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.PositionTypeId)
                    .HasColumnName("POSITION_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("Entry Level, Mid-Level, High Level, Managerial");

                entity.Property(e => e.Responsibilities)
                    .HasColumnName("RESPONSIBILITIES")
                    .HasMaxLength(2000);

                entity.Property(e => e.SkillsRequired)
                    .HasColumnName("SKILLS_REQUIRED")
                    .HasMaxLength(2000);

                entity.HasOne(d => d.ParentPosition)
                    .WithMany(p => p.InverseParentPosition)
                    .HasForeignKey(d => d.ParentPositionId)
                    .HasConstraintName("FK_POSITIONS_POSITIONS");
            });

            modelBuilder.Entity<Privileges>(entity =>
            {
                entity.HasKey(e => e.PrivilegeId)
                    .HasName("PK_PRIVILEGE");

                entity.ToTable("PRIVILEGES", "AUTH");

                entity.Property(e => e.PrivilegeId).HasColumnName("PRIVILEGE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModuleId).HasColumnName("MODULE_ID");

                entity.Property(e => e.NavigationId).HasColumnName("NAVIGATION_ID");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PrivilegeCode)
                    .HasColumnName("PRIVILEGE_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrivilegeDescriptionAr)
                    .HasColumnName("PRIVILEGE_DESCRIPTION_AR")
                    .HasMaxLength(200);

                entity.Property(e => e.PrivilegeDescriptionEn)
                    .IsRequired()
                    .HasColumnName("PRIVILEGE_DESCRIPTION_EN")
                    .HasMaxLength(200);

                entity.Property(e => e.PrivilegeNameAr)
                    .HasColumnName("PRIVILEGE_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.PrivilegeNameEn)
                    .IsRequired()
                    .HasColumnName("PRIVILEGE_NAME_EN")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Navigation)
                    .WithMany(p => p.Privileges)
                    .HasForeignKey(d => d.NavigationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRIVILEGES_NAVIGATIONS");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("PROJECTS", "PRJ");

                entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentProjectId).HasColumnName("PARENT_PROJECT_ID");

                entity.Property(e => e.PlanDateFrom)
                    .HasColumnName("PLAN_DATE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlanDateTo)
                    .HasColumnName("PLAN_DATE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ProjectDetail).HasColumnName("PROJECT_DETAIL");

                entity.Property(e => e.ProjectEndDate)
                    .HasColumnName("PROJECT_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjectManagerEmpId).HasColumnName("PROJECT_MANAGER_EMP_ID");

                entity.Property(e => e.ProjectProgressPercent).HasColumnName("PROJECT_PROGRESS_PERCENT");

                entity.Property(e => e.ProjectStartDate)
                    .HasColumnName("PROJECT_START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjectStatusId)
                    .HasColumnName("PROJECT_STATUS_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectTitle)
                    .HasColumnName("PROJECT_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectTypeId)
                    .HasColumnName("PROJECT_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RelatedProjectId).HasColumnName("RELATED_PROJECT_ID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_PROJECTS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_PROJECTS_COMPANY");

                entity.HasOne(d => d.ProjectManagerEmp)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ProjectManagerEmpId)
                    .HasConstraintName("FK_PROJECTS_EMP");

                entity.HasOne(d => d.ProjectStatus)
                    .WithMany(p => p.ProjectsProjectStatus)
                    .HasForeignKey(d => d.ProjectStatusId)
                    .HasConstraintName("FK_PROJECTS_STATUS");

                entity.HasOne(d => d.ProjectType)
                    .WithMany(p => p.ProjectsProjectType)
                    .HasForeignKey(d => d.ProjectTypeId)
                    .HasConstraintName("FK_PROJECTS_TYPE");
            });

            modelBuilder.Entity<QuestionOptions>(entity =>
            {
                entity.HasKey(e => e.OptionId);

                entity.ToTable("QUESTION_OPTIONS", "ACD");

                entity.Property(e => e.OptionId).HasColumnName("OPTION_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.DescriptionAr)
                    .HasColumnName("DESCRIPTION_AR")
                    .HasMaxLength(250);

                entity.Property(e => e.DescriptionEn)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION_EN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.OptionSeq).HasColumnName("OPTION_SEQ");

                entity.Property(e => e.QuestionId).HasColumnName("QUESTION_ID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionOptions)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QUESTION_OPTIONS_QUESTIONS");
            });

            modelBuilder.Entity<Questions>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.ToTable("QUESTIONS", "ACD");

                entity.Property(e => e.QuestionId).HasColumnName("QUESTION_ID");

                entity.Property(e => e.CategoryId)
                    .IsRequired()
                    .HasColumnName("CATEGORY_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .HasColumnName("CATEGORY_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.QuestionAr)
                    .HasColumnName("QUESTION_AR")
                    .HasMaxLength(250);

                entity.Property(e => e.QuestionEn)
                    .IsRequired()
                    .HasColumnName("QUESTION_EN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionType)
                    .HasColumnName("QUESTION_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Quiz>(entity =>
            {
                entity.ToTable("QUIZ", "ACD");

                entity.Property(e => e.QuizId).HasColumnName("QUIZ_ID");

                entity.Property(e => e.ClassId).HasColumnName("CLASS_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.QuizNumber).HasColumnName("QUIZ_NUMBER");

                entity.Property(e => e.QuizTitle)
                    .HasColumnName("QUIZ_TITLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuizType)
                    .HasColumnName("QUIZ_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.TeacherId).HasColumnName("TEACHER_ID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Quiz)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QUIZ_CLASSES");

                entity.HasOne(d => d.QuizTypeNavigation)
                    .WithMany(p => p.Quiz)
                    .HasForeignKey(d => d.QuizType)
                    .HasConstraintName("FK_QUIZ_LOOKUPS");
            });

            modelBuilder.Entity<Receipts>(entity =>
            {
                entity.HasKey(e => e.ReceiptId);

                entity.ToTable("RECEIPTS", "AR");

                entity.Property(e => e.ReceiptId).HasColumnName("RECEIPT_ID");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.DestinationAccount).HasColumnName("DESTINATION_ACCOUNT");

                entity.Property(e => e.GlBatchId)
                    .HasColumnName("GL_BATCH_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsPosted).HasColumnName("IS_POSTED");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(1000);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PostedBy).HasColumnName("POSTED_BY");

                entity.Property(e => e.PostedDate)
                    .HasColumnName("POSTED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReceiptDate)
                    .HasColumnName("RECEIPT_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ReceiptNo)
                    .HasColumnName("RECEIPT_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientAccount).HasColumnName("RECIPIENT_ACCOUNT");

                entity.Property(e => e.RefNo)
                    .HasColumnName("REF_NO")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Receipts)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_RECEIPTS_BRANCH");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Receipts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_RECEIPTS_CUSTOMERS");
            });

            modelBuilder.Entity<Refunds>(entity =>
            {
                entity.HasKey(e => e.RefundId);

                entity.ToTable("REFUNDS", "AP");

                entity.Property(e => e.RefundId).HasColumnName("REFUND_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPer)
                    .HasColumnName("DISCOUNT_PER")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DueDate)
                    .HasColumnName("DUE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.GlBatchId)
                    .HasColumnName("GL_BATCH_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsPosted).HasColumnName("IS_POSTED");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(1000);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PostedBy).HasColumnName("POSTED_BY");

                entity.Property(e => e.PostedDate)
                    .HasColumnName("POSTED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RefNo)
                    .HasColumnName("REF_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.RefundDate)
                    .HasColumnName("REFUND_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.RefundNo)
                    .HasColumnName("REFUND_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal)
                    .HasColumnName("SUB_TOTAL")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRateId).HasColumnName("TAX_RATE_ID");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalDiscount)
                    .HasColumnName("TOTAL_DISCOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalTax)
                    .HasColumnName("TOTAL_TAX")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId).HasColumnName("VENDOR_ID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Refunds)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_REFUNDS_BRANCH");

                entity.HasOne(d => d.TaxRate)
                    .WithMany(p => p.Refunds)
                    .HasForeignKey(d => d.TaxRateId)
                    .HasConstraintName("FK_REFUNDS_TAX_RATES");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.Refunds)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_REFUNDS_VENDORS");
            });

            modelBuilder.Entity<RefundsLines>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("REFUNDS_LINES", "AP");

                entity.Property(e => e.LineId).HasColumnName("LINE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountAmount)
                    .HasColumnName("DISCOUNT_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountPercent)
                    .HasColumnName("DISCOUNT_PERCENT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.ItemPrice)
                    .HasColumnName("ITEM_PRICE")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LineAmount)
                    .HasColumnName("LINE_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RefundId).HasColumnName("REFUND_ID");

                entity.Property(e => e.TaxAmount)
                    .HasColumnName("TAX_AMOUNT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRate)
                    .HasColumnName("TAX_RATE")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRateId).HasColumnName("TAX_RATE_ID");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("UNIT_PRICE")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.RefundsLines)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_REFUNDS_LINES_BRANCH");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.RefundsLines)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_REFUNDS_LINES_ITEMS");

                entity.HasOne(d => d.Refund)
                    .WithMany(p => p.RefundsLines)
                    .HasForeignKey(d => d.RefundId)
                    .HasConstraintName("FK_REFUNDS_LINES_REFUNDS");

                entity.HasOne(d => d.TaxRateNavigation)
                    .WithMany(p => p.RefundsLines)
                    .HasForeignKey(d => d.TaxRateId)
                    .HasConstraintName("FK_REFUNDS_LINES_TAX_RATES");
            });

            modelBuilder.Entity<Requests>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("REQUESTS", "HR");

                entity.Property(e => e.RecId).HasColumnName("REC_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.RequestStatus)
                    .HasColumnName("REQUEST_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RequestTypeId)
                    .HasColumnName("REQUEST_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_REQUESTS_EMP");

                entity.HasOne(d => d.RequestStatusNavigation)
                    .WithMany(p => p.RequestsRequestStatusNavigation)
                    .HasForeignKey(d => d.RequestStatus)
                    .HasConstraintName("FK_REQUESTS_REQUEST_STATUS");

                entity.HasOne(d => d.RequestType)
                    .WithMany(p => p.RequestsRequestType)
                    .HasForeignKey(d => d.RequestTypeId)
                    .HasConstraintName("FK_REQUESTS_REQUEST_TYPE");
            });

            modelBuilder.Entity<Research>(entity =>
            {
                entity.ToTable("RESEARCH", "HR");

                entity.Property(e => e.ResearchId).HasColumnName("RESEARCH_ID");

                entity.Property(e => e.ClassificationScientific)
                    .HasColumnName("CLASSIFICATION_SCIENTIFIC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryResearch)
                    .HasColumnName("COUNTRY_RESEARCH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.DataAuthority)
                    .HasColumnName("DATA_AUTHORITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldScientific)
                    .HasColumnName("FIELD_SCIENTIFIC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InternationalStandardBook)
                    .HasColumnName("INTERNATIONAL_STANDARD_BOOK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Journal)
                    .HasColumnName("JOURNAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Keywords)
                    .HasColumnName("KEYWORDS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageResearch)
                    .HasColumnName("LANGUAGE_RESEARCH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.NatureScientific)
                    .HasColumnName("NATURE_SCIENTIFIC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberJournal)
                    .HasColumnName("NUMBER_JOURNAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfPagesPublication)
                    .HasColumnName("NUMBER_OF_PAGES_PUBLICATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionScientific)
                    .HasColumnName("PRODUCTION_SCIENTIFIC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionStatusScientific)
                    .HasColumnName("PRODUCTION_STATUS_SCIENTIFIC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublicationLink)
                    .HasColumnName("PUBLICATION_LINK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishingAuthority)
                    .HasColumnName("PUBLISHING_AUTHORITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SummeryResearch)
                    .HasColumnName("SUMMERY_RESEARCH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleScientificProuctionPublication)
                    .HasColumnName("TITLE_SCIENTIFIC_PROUCTION_PUBLICATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeScientific)
                    .HasColumnName("TYPE_SCIENTIFIC")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolePrivileges>(entity =>
            {
                entity.HasKey(e => e.RolePrivilegeId)
                    .HasName("PK_ROLE_PRIVILEGE");

                entity.ToTable("ROLE_PRIVILEGES", "AUTH");

                entity.Property(e => e.RolePrivilegeId).HasColumnName("ROLE_PRIVILEGE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PrivilegeId).HasColumnName("PRIVILEGE_ID");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.HasOne(d => d.Privilege)
                    .WithMany(p => p.RolePrivileges)
                    .HasForeignKey(d => d.PrivilegeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ROLE_PRIVILEGES_PRIVILEGES");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePrivileges)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_ROLE_PRIVILEGES_ROLES");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_ROLE");

                entity.ToTable("ROLES", "AUTH");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.RoleCode)
                    .HasColumnName("ROLE_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoleDescriptionAr)
                    .HasColumnName("ROLE_DESCRIPTION_AR")
                    .HasMaxLength(200);

                entity.Property(e => e.RoleDescriptionEn)
                    .IsRequired()
                    .HasColumnName("ROLE_DESCRIPTION_EN")
                    .HasMaxLength(200);

                entity.Property(e => e.RoleNameAr)
                    .HasColumnName("ROLE_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleNameEn)
                    .IsRequired()
                    .HasColumnName("ROLE_NAME_EN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Rooms>(entity =>
            {
                entity.HasKey(e => e.RoomId)
                    .HasName("PK_ROOM");

                entity.ToTable("ROOMS");

                entity.Property(e => e.RoomId).HasColumnName("ROOM_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.BuildingId).HasColumnName("BUILDING_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FloorNumber).HasColumnName("FLOOR_NUMBER");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.RoomCapacity).HasColumnName("ROOM_CAPACITY");

                entity.Property(e => e.RoomCode)
                    .HasColumnName("ROOM_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoomNameAr)
                    .HasColumnName("ROOM_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.RoomNameEn)
                    .IsRequired()
                    .HasColumnName("ROOM_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.RoomTypeId)
                    .HasColumnName("ROOM_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ROOMS_BUILDINGS");
            });

            modelBuilder.Entity<RuleAndRegulations>(entity =>
            {
                entity.HasKey(e => e.RuleId);

                entity.ToTable("RULE_AND_REGULATIONS", "ACD");

                entity.Property(e => e.RuleId).HasColumnName("RULE_ID");

                entity.Property(e => e.BramchId).HasColumnName("BRAMCH_ID");

                entity.Property(e => e.CampusId).HasColumnName("CAMPUS_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.RuleFineAmount).HasColumnName("RULE_FINE_AMOUNT");

                entity.Property(e => e.RuleTitle)
                    .IsRequired()
                    .HasColumnName("RULE_TITLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RuleTitleAr)
                    .IsRequired()
                    .HasColumnName("RULE_TITLE_AR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Campus)
                    .WithMany(p => p.RuleAndRegulations)
                    .HasForeignKey(d => d.CampusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RULE_AND_REGULATIONS_CAMPUS1");
            });

            modelBuilder.Entity<SalaryPayablesPerMonth>(entity =>
            {
                entity.HasKey(e => e.PayableId);

                entity.ToTable("SALARY_PAYABLES_PER_MONTH", "HR");

                entity.Property(e => e.PayableId).HasColumnName("PAYABLE_ID");

                entity.Property(e => e.AbsentFine)
                    .HasColumnName("ABSENT_FINE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Additions)
                    .HasColumnName("ADDITIONS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.GrossSalary)
                    .HasColumnName("GROSS_SALARY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LoadDeductionThisMonth)
                    .HasColumnName("LOAD_DEDUCTION_THIS_MONTH")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.NetSalary)
                    .HasColumnName("NET_SALARY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OtherDeduction)
                    .HasColumnName("OTHER_DEDUCTION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PerDay)
                    .HasColumnName("PER_DAY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalaryDate)
                    .HasColumnName("SALARY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.SalaryMonth).HasColumnName("SALARY_MONTH");

                entity.Property(e => e.SalaryPerDayCalculation)
                    .HasColumnName("SALARY_PER_DAY_CALCULATION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalaryYear).HasColumnName("SALARY_YEAR");

                entity.Property(e => e.ThreshHoldSalary)
                    .HasColumnName("THRESH_HOLD_SALARY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalDeduction)
                    .HasColumnName("TOTAL_DEDUCTION")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnpaidDays).HasColumnName("UNPAID_DAYS");

                entity.Property(e => e.UnpaidDaysDeduction)
                    .HasColumnName("UNPAID_DAYS_DEDUCTION")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.SalaryPayablesPerMonth)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_SALARY_PAYABLES_PER_MONTH_EMP");
            });

            modelBuilder.Entity<SeatEnroll>(entity =>
            {
                entity.HasKey(e => e.SeatEnrolId);

                entity.ToTable("SEAT_ENROLL", "ACD");

                entity.Property(e => e.SeatEnrolId).HasColumnName("SEAT_ENROL_ID");

                entity.Property(e => e.ClassId).HasColumnName("CLASS_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.DeptId).HasColumnName("DEPT_ID");

                entity.Property(e => e.EnrolStatus)
                    .HasColumnName("ENROL_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalId).HasColumnName("HOSPITAL_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.SeatId).HasColumnName("SEAT_ID");

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.SeatEnroll)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_SEAT_ENROLL_CLASSES");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.SeatEnroll)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK_SEAT_ENROLL_HOSPITAL_DEPT");

                entity.HasOne(d => d.EnrolStatusNavigation)
                    .WithMany(p => p.SeatEnroll)
                    .HasForeignKey(d => d.EnrolStatus)
                    .HasConstraintName("FK_SEAT_ENROLL_LOOKUPS");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.SeatEnroll)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_SEAT_ENROLL_HOSPITALS");

                entity.HasOne(d => d.Seat)
                    .WithMany(p => p.SeatEnroll)
                    .HasForeignKey(d => d.SeatId)
                    .HasConstraintName("FK_SEAT_ENROLL_HOSPITAL_SEATS");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.SeatEnroll)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_SEAT_ENROLL_STUDENTS");
            });

            modelBuilder.Entity<Sections>(entity =>
            {
                entity.HasKey(e => e.SectionId);

                entity.ToTable("SECTIONS", "HR");

                entity.Property(e => e.SectionId).HasColumnName("SECTION_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.DivisionId).HasColumnName("DIVISION_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ReportingToUid).HasColumnName("REPORTING_TO_UID");

                entity.Property(e => e.SectionCode)
                    .HasColumnName("SECTION_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SectionHeadUid).HasColumnName("SECTION_HEAD_UID");

                entity.Property(e => e.SectionNameAr)
                    .HasColumnName("SECTION_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.SectionNameEn)
                    .IsRequired()
                    .HasColumnName("SECTION_NAME_EN")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SECTIONS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SECTIONS_COMPANY");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SECTIONS_DEPARTMENTS");

                entity.HasOne(d => d.ReportingToU)
                    .WithMany(p => p.SectionsReportingToU)
                    .HasForeignKey(d => d.ReportingToUid)
                    .HasConstraintName("FK_SECTIONS_REPORTING_TO");

                entity.HasOne(d => d.SectionHeadU)
                    .WithMany(p => p.SectionsSectionHeadU)
                    .HasForeignKey(d => d.SectionHeadUid)
                    .HasConstraintName("FK_SECTIONS_HEAD");
            });

            modelBuilder.Entity<Semesters>(entity =>
            {
                entity.HasKey(e => e.SemesterId)
                    .HasName("PK_SEMESTER");

                entity.ToTable("SEMESTERS", "ACD");

                entity.Property(e => e.SemesterId).HasColumnName("SEMESTER_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.SemesterCode)
                    .HasColumnName("SEMESTER_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SemesterNameAr)
                    .HasColumnName("SEMESTER_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.SemesterNameEn)
                    .IsRequired()
                    .HasColumnName("SEMESTER_NAME_EN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Shifts>(entity =>
            {
                entity.HasKey(e => e.ShiftId);

                entity.ToTable("SHIFTS", "HR");

                entity.Property(e => e.ShiftId).HasColumnName("SHIFT_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeductionPerMinute)
                    .HasColumnName("DEDUCTION_PER_MINUTE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FromTime)
                    .HasColumnName("FROM_TIME")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LateDeductionStartFrom).HasColumnName("LATE_DEDUCTION_START_FROM");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(50);

                entity.Property(e => e.MarkAbsentAfter).HasColumnName("MARK_ABSENT_AFTER");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ShiftNameAr)
                    .HasColumnName("SHIFT_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.ShiftNameEn)
                    .HasColumnName("SHIFT_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.ToTime)
                    .HasColumnName("TO_TIME")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpecialOccasions>(entity =>
            {
                entity.HasKey(e => e.SpecialOccasionId);

                entity.ToTable("SPECIAL_OCCASIONS", "HR");

                entity.Property(e => e.SpecialOccasionId).HasColumnName("SPECIAL_OCCASION_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OvertimeSettingId).HasColumnName("OVERTIME_SETTING_ID");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.SpecialOccasionCode)
                    .HasColumnName("SPECIAL_OCCASION_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialOccasionNameAr)
                    .HasColumnName("SPECIAL_OCCASION_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.SpecialOccasionNameEn)
                    .IsRequired()
                    .HasColumnName("SPECIAL_OCCASION_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.TotalDays).HasColumnName("TOTAL_DAYS");

                entity.HasOne(d => d.OvertimeSetting)
                    .WithMany(p => p.SpecialOccasions)
                    .HasForeignKey(d => d.OvertimeSettingId)
                    .HasConstraintName("FK_SPECIAL_OCCASIONS_OVERTIME_SETTINGS");
            });

            modelBuilder.Entity<StdEnroll>(entity =>
            {
                entity.ToTable("STD_ENROLL", "ACD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcademicYearId).HasColumnName("ACADEMIC_YEAR_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.ClassId).HasColumnName("CLASS_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CourseEnrollStatusId)
                    .HasColumnName("COURSE_ENROLL_STATUS_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CourseFee)
                    .HasColumnName("COURSE_FEE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiscountId).HasColumnName("DISCOUNT_ID");

                entity.Property(e => e.GradeLetter)
                    .HasColumnName("GRADE_LETTER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.Property(e => e.TotalCreditsEarned).HasColumnName("TOTAL_CREDITS_EARNED");

                entity.Property(e => e.TotalObtainedMarks)
                    .HasColumnName("TOTAL_OBTAINED_MARKS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalPercentageEarned)
                    .HasColumnName("TOTAL_PERCENTAGE_EARNED")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.AcademicYear)
                    .WithMany(p => p.StdEnroll)
                    .HasForeignKey(d => d.AcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STD_ENROL_ACADEMIC_YEARS");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.StdEnroll)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_STD_ENROLL_CLASSES");

                entity.HasOne(d => d.CourseEnrollStatus)
                    .WithMany(p => p.StdEnroll)
                    .HasForeignKey(d => d.CourseEnrollStatusId)
                    .HasConstraintName("FK_STD_ENROLL_LOOKUPS");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.StdEnroll)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STD_ENROL_COURSE");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StdEnroll)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STD_ENROL_STUDENTS");
            });

            modelBuilder.Entity<StdGpa>(entity =>
            {
                entity.ToTable("STD_GPA", "ACD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcademicCalenderId).HasColumnName("ACADEMIC_CALENDER_ID");

                entity.Property(e => e.CDeficiency).HasColumnName("C_DEFICIENCY");

                entity.Property(e => e.CEarned).HasColumnName("C_EARNED");

                entity.Property(e => e.CampusId).HasColumnName("CAMPUS_ID");

                entity.Property(e => e.Cgpa).HasColumnName("CGPA");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.MajorId).HasColumnName("MAJOR_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.SStatus)
                    .HasColumnName("S_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Semester).HasColumnName("SEMESTER");

                entity.Property(e => e.SeqNo).HasColumnName("SEQ_NO");

                entity.Property(e => e.Sgpa).HasColumnName("SGPA");

                entity.Property(e => e.ShowGpa).HasColumnName("SHOW_GPA");

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.Property(e => e.TStatus)
                    .HasColumnName("T_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TermDeficiency).HasColumnName("TERM_DEFICIENCY");

                entity.Property(e => e.TermEarned).HasColumnName("TERM_EARNED");

                entity.Property(e => e.TermGradePoint).HasColumnName("TERM_GRADE_POINT");
            });

            modelBuilder.Entity<StdLetters>(entity =>
            {
                entity.ToTable("STD_LETTERS", "ACD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcademicYearId).HasColumnName("ACADEMIC_YEAR_ID");

                entity.Property(e => e.ApprovalStatusDate)
                    .HasColumnName("APPROVAL_STATUS_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovalStatusId)
                    .HasColumnName("APPROVAL_STATUS_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(200);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LetterDate)
                    .HasColumnName("LETTER_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(500);

                entity.Property(e => e.StdLetterTypeId)
                    .IsRequired()
                    .HasColumnName("STD_LETTER_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.Property(e => e.WarningName)
                    .HasColumnName("WARNING_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AcademicYear)
                    .WithMany(p => p.StdLetters)
                    .HasForeignKey(d => d.AcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STD_LETTER_ACADEMIC_YEARS");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.StdLetters)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STD_LETTERS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.StdLetters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STD_LETTERS_COMPANY");

                entity.HasOne(d => d.StdLetterType)
                    .WithMany(p => p.StdLetters)
                    .HasForeignKey(d => d.StdLetterTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STD_LETTERS_TYPE");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StdLetters)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STD_LETTER_STUDENTS");
            });

            modelBuilder.Entity<StdSemesters>(entity =>
            {
                entity.ToTable("STD_SEMESTERS", "ACD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcademicYearId).HasColumnName("ACADEMIC_YEAR_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.Property(e => e.StudentStatus)
                    .IsRequired()
                    .HasColumnName("STUDENT_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.AcademicYear)
                    .WithMany(p => p.StdSemesters)
                    .HasForeignKey(d => d.AcademicYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STD_SEMESTERS_ACADEMIC_YEARS");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StdSemesters)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STD_SEMESTERS_STUDENTS");

                entity.HasOne(d => d.StudentStatusNavigation)
                    .WithMany(p => p.StdSemesters)
                    .HasForeignKey(d => d.StudentStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STD_SEMESTERS_STUDENT_STATUS");
            });

            modelBuilder.Entity<StudentAccountDues>(entity =>
            {
                entity.ToTable("Student_Account_Dues", "ACD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcademicYear).HasColumnName("ACADEMIC_YEAR");

                entity.Property(e => e.AmountPaid).HasColumnName("AMOUNT_PAID");

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.CreditHoursPerTermThisAcademicYear).HasColumnName("CREDIT_HOURS_PER_TERM_THIS_ACADEMIC_YEAR");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.PaidStatus).HasColumnName("PAID_STATUS");

                entity.Property(e => e.PaidType)
                    .HasColumnName("PAID_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingAmount).HasColumnName("REMAINING_AMOUNT");

                entity.Property(e => e.StdId).HasColumnName("STD_ID");

                entity.HasOne(d => d.Std)
                    .WithMany(p => p.StudentAccountDues)
                    .HasForeignKey(d => d.StdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Account_Dues_STUDENTS");
            });

            modelBuilder.Entity<StudentAttachments>(entity =>
            {
                entity.HasKey(e => e.StudentAttachmentId);

                entity.ToTable("STUDENT_ATTACHMENTS", "ACD");

                entity.Property(e => e.StudentAttachmentId).HasColumnName("STUDENT_ATTACHMENT_ID");

                entity.Property(e => e.AdmissionDocumentId)
                    .HasColumnName("ADMISSION_DOCUMENT_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentDetail)
                    .HasColumnName("DOCUMENT_DETAIL")
                    .HasMaxLength(250);

                entity.Property(e => e.DocumentName)
                    .HasColumnName("DOCUMENT_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("ISSUE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.Property(e => e.StudentUserId).HasColumnName("STUDENT_USER_ID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentAttachments)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENT_ATTACHMENTS_STUDENT");

                entity.HasOne(d => d.StudentUser)
                    .WithMany(p => p.StudentAttachments)
                    .HasForeignKey(d => d.StudentUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENT_ATTACHMENTS_STUDENT_USERS");
            });

            modelBuilder.Entity<StudentAttendance>(entity =>
            {
                entity.ToTable("STUDENT_ATTENDANCE", "ACD");

                entity.Property(e => e.StudentAttendanceId).HasColumnName("STUDENT_ATTENDANCE_ID");

                entity.Property(e => e.AbsentWithexcuse).HasColumnName("ABSENT_WITHEXCUSE");

                entity.Property(e => e.AbsentWithoutexcuse).HasColumnName("ABSENT_WITHOUTEXCUSE");

                entity.Property(e => e.AttendanceDate)
                    .HasColumnName("ATTENDANCE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.AttendancePercent).HasColumnName("ATTENDANCE_PERCENT");

                entity.Property(e => e.AttendanceType)
                    .IsRequired()
                    .HasColumnName("ATTENDANCE_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment(@"Present,
Late,
Absent,
Absent With Excuse");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.ClassId).HasColumnName("CLASS_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Islate).HasColumnName("ISLATE");

                entity.Property(e => e.Ispresent).HasColumnName("ISPRESENT");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(300);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.HasOne(d => d.AttendanceTypeNavigation)
                    .WithMany(p => p.StudentAttendance)
                    .HasForeignKey(d => d.AttendanceType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENT_ATTENDANCE_TYPE");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.StudentAttendance)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENT_ATTENDANCE_CLASSES");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentAttendance)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENT_ATTENDANCE_STUDENTS");
            });

            modelBuilder.Entity<StudentDiscountType>(entity =>
            {
                entity.ToTable("STUDENT_DISCOUNT_TYPE", "ACD");

                entity.Property(e => e.StudentDiscountTypeId).HasColumnName("STUDENT_DISCOUNT_TYPE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsPercentage).HasColumnName("IS_PERCENTAGE");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.StudentDiscountTypeCode)
                    .HasColumnName("STUDENT_DISCOUNT_TYPE_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StudentDiscountTypeNameAr)
                    .HasColumnName("STUDENT_DISCOUNT_TYPE_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.StudentDiscountTypeNameEn)
                    .IsRequired()
                    .HasColumnName("STUDENT_DISCOUNT_TYPE_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.ValidTill)
                    .HasColumnName("VALID_TILL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<StudentEducations>(entity =>
            {
                entity.HasKey(e => e.StudentEducationId);

                entity.ToTable("STUDENT_EDUCATIONS", "ACD");

                entity.Property(e => e.StudentEducationId).HasColumnName("STUDENT_EDUCATION_ID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(250);

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrentQualificationId)
                    .HasColumnName("CURRENT_QUALIFICATION_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfGraduate)
                    .HasColumnName("DATE_OF_GRADUATE")
                    .HasColumnType("date");

                entity.Property(e => e.DegreeName)
                    .HasColumnName("DEGREE_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.DiplomaGrade)
                    .HasColumnName("DIPLOMA_GRADE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DiplomaMajor)
                    .HasColumnName("DIPLOMA_MAJOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiplomaUniversityName)
                    .HasColumnName("DIPLOMA_UNIVERSITY_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndMonth).HasColumnName("END_MONTH");

                entity.Property(e => e.EndYear).HasColumnName("END_YEAR");

                entity.Property(e => e.Grade)
                    .HasColumnName("GRADE")
                    .HasMaxLength(50);

                entity.Property(e => e.GradeInHighSchool)
                    .HasColumnName("GRADE_IN_HIGH_SCHOOL")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GradeTransfer)
                    .HasColumnName("GRADE_TRANSFER")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HighSchoolMajor)
                    .HasColumnName("HIGH_SCHOOL_MAJOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionName)
                    .HasColumnName("INSTITUTION_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Major)
                    .HasColumnName("MAJOR")
                    .HasMaxLength(50);

                entity.Property(e => e.MajorTransfer)
                    .HasColumnName("MAJOR_TRANSFER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.NameOfHighSchool)
                    .HasColumnName("NAME_OF_HIGH_SCHOOL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassedYear).HasColumnName("PASSED_YEAR");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.QudaratGrade)
                    .HasColumnName("QUDARAT_GRADE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StartMonth).HasColumnName("START_MONTH");

                entity.Property(e => e.StartYear).HasColumnName("START_YEAR");

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.Property(e => e.StudentUserId).HasColumnName("STUDENT_USER_ID");

                entity.Property(e => e.TahsiliGrade)
                    .HasColumnName("TAHSILI_GRADE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UniversityNameTransfer)
                    .HasColumnName("UNIVERSITY_NAME_TRANSFER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentEducations)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENT_EDUCATIONS_STUDENT");

                entity.HasOne(d => d.StudentUser)
                    .WithMany(p => p.StudentEducations)
                    .HasForeignKey(d => d.StudentUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENT_EDUCATIONS_STUDENT_USERS");
            });

            modelBuilder.Entity<StudentGpa>(entity =>
            {
                entity.ToTable("STUDENT_GPA", "ACD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcademicCalenderId).HasColumnName("ACADEMIC_CALENDER_ID");

                entity.Property(e => e.Cgpa).HasColumnName("CGPA");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.MajorId).HasColumnName("MAJOR_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Semester).HasColumnName("SEMESTER");

                entity.Property(e => e.Sgpa).HasColumnName("SGPA");

                entity.Property(e => e.ShowGpa).HasColumnName("SHOW_GPA");

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");
            });

            modelBuilder.Entity<StudentSeat>(entity =>
            {
                entity.ToTable("STUDENT_SEAT", "ACD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DEPARTMENT_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HosptialId).HasColumnName("HOSPTIAL_ID");

                entity.Property(e => e.SeatId).HasColumnName("SEAT_ID");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.HasOne(d => d.Seat)
                    .WithMany(p => p.StudentSeat)
                    .HasForeignKey(d => d.SeatId)
                    .HasConstraintName("FK_STUDENT_SEAT_HOSPITAL_SEATS");
            });

            modelBuilder.Entity<StudentSponsor>(entity =>
            {
                entity.HasKey(e => e.SponsorId);

                entity.ToTable("STUDENT_SPONSOR", "ACD");

                entity.Property(e => e.SponsorId).HasColumnName("SPONSOR_ID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BranhId).HasColumnName("BRANH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.ContactNo).HasColumnName("CONTACT_NO");

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.OrganisationName)
                    .HasColumnName("ORGANISATION_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorName)
                    .IsRequired()
                    .HasColumnName("SPONSOR_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentUsers>(entity =>
            {
                entity.HasKey(e => e.StudentUserId)
                    .HasName("PK_STUDENT_ACCOUNTS");

                entity.ToTable("STUDENT_USERS", "ACD");

                entity.Property(e => e.StudentUserId).HasColumnName("STUDENT_USER_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(50);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.StudentCode)
                    .HasColumnName("STUDENT_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e._2facode).HasColumnName("2FACODE");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.ToTable("STUDENTS", "ACD");

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.Property(e => e.AcademicYearId).HasColumnName("ACADEMIC_YEAR_ID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(150);

                entity.Property(e => e.AdmissionFormId).HasColumnName("ADMISSION_FORM_ID");

                entity.Property(e => e.AdmissionFormStatus)
                    .HasColumnName("ADMISSION_FORM_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AdvisorId).HasColumnName("ADVISOR_ID");

                entity.Property(e => e.AnySpecialCaseForCommittee)
                    .HasColumnName("ANY_SPECIAL_CASE_FOR_COMMITTEE")
                    .HasMaxLength(30);

                entity.Property(e => e.BatchNo).HasColumnName("BATCH_NO");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("BIRTH_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.BirthDateHijgri)
                    .HasColumnName("BIRTH_DATE_HIJGRI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BirthPlaceId)
                    .HasColumnName("BIRTH_PLACE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BloodGroup)
                    .HasColumnName("BLOOD_GROUP")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CampusId).HasColumnName("CAMPUS_ID");

                entity.Property(e => e.ChronicDieses)
                    .HasColumnName("CHRONIC_DIESES")
                    .HasMaxLength(30);

                entity.Property(e => e.ChronicDiesesFamilyHistory)
                    .HasColumnName("CHRONIC_DIESES_FAMILY_HISTORY")
                    .HasMaxLength(30);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrentQualificationId)
                    .HasColumnName("CURRENT_QUALIFICATION_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DEPARTMENT_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DoesFatherWork).HasColumnName("DOES_FATHER_WORK");

                entity.Property(e => e.DoesMotherWork).HasColumnName("DOES_MOTHER_WORK");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyMobileNo)
                    .HasColumnName("EMERGENCY_MOBILE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyName)
                    .HasColumnName("EMERGENCY_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.EmergencyPhoneNo)
                    .HasColumnName("EMERGENCY_PHONE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyRelationship)
                    .HasColumnName("EMERGENCY_RELATIONSHIP")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FahterWorkingSector)
                    .HasColumnName("FAHTER_WORKING_SECTOR")
                    .HasMaxLength(50);

                entity.Property(e => e.FamilyMembersNo)
                    .HasColumnName("FAMILY_MEMBERS_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.FamilyMonthlyIncomeRange)
                    .HasColumnName("FAMILY_MONTHLY_INCOME_RANGE")
                    .HasMaxLength(50);

                entity.Property(e => e.FamilyName)
                    .HasColumnName("FAMILY_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FamilyNameAr)
                    .HasColumnName("FAMILY_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.FatherAlive).HasColumnName("FATHER_ALIVE");

                entity.Property(e => e.FatherIncomeSource)
                    .HasColumnName("FATHER_INCOME_SOURCE")
                    .HasMaxLength(50);

                entity.Property(e => e.FatherName)
                    .HasColumnName("FATHER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FatherNameAr)
                    .HasColumnName("FATHER_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.FatherQualification)
                    .HasColumnName("FATHER_QUALIFICATION")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstNameAr)
                    .HasColumnName("FIRST_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.GenderId)
                    .HasColumnName("GENDER_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GrandFatherName)
                    .HasColumnName("GRAND_FATHER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrandFatherNameAr)
                    .HasColumnName("GRAND_FATHER_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.HasFatherIncome).HasColumnName("HAS_FATHER_INCOME");

                entity.Property(e => e.HasParentSocialCase)
                    .HasColumnName("HAS_PARENT_SOCIAL_CASE")
                    .HasMaxLength(50);

                entity.Property(e => e.HousingType)
                    .HasColumnName("HOUSING_TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.HowDoYouKnowAboutCollege)
                    .HasColumnName("HOW_DO_YOU_KNOW_ABOUT_COLLEGE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdType)
                    .HasColumnName("ID_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.JobDate)
                    .HasColumnName("JOB_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(30);

                entity.Property(e => e.LastJob)
                    .HasColumnName("LAST_JOB")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastNameAr)
                    .HasColumnName("LAST_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.MajorId).HasColumnName("MAJOR_ID");

                entity.Property(e => e.MajorTypeId).HasColumnName("MAJOR_TYPE_ID");

                entity.Property(e => e.MiddleName)
                    .HasColumnName("MIDDLE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleNameAr)
                    .HasColumnName("MIDDLE_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MotherAlive).HasColumnName("MOTHER_ALIVE");

                entity.Property(e => e.MotherMobileNo)
                    .HasColumnName("MOTHER_MOBILE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MotherName)
                    .HasColumnName("MOTHER_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.MotherQualification)
                    .HasColumnName("MOTHER_QUALIFICATION")
                    .HasMaxLength(50);

                entity.Property(e => e.MotherWorkingSector)
                    .HasColumnName("MOTHER_WORKING_SECTOR")
                    .HasMaxLength(50);

                entity.Property(e => e.NationalIdentity)
                    .HasColumnName("NATIONAL_IDENTITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NationalIdentityExpiryDate)
                    .HasColumnName("NATIONAL_IDENTITY_EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.NationalIdentityExpiryDateHijri)
                    .HasColumnName("NATIONAL_IDENTITY_EXPIRY_DATE_HIJRI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NationalIdentityIssuedDate)
                    .HasColumnName("NATIONAL_IDENTITY_ISSUED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.NationalIdentityIssuedDateHijri)
                    .HasColumnName("NATIONAL_IDENTITY_ISSUED_DATE_HIJRI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityId)
                    .HasColumnName("NATIONALITY_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PassportExpiryDate)
                    .HasColumnName("PASSPORT_EXPIRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.PassportExpiryDateHijri)
                    .HasColumnName("PASSPORT_EXPIRY_DATE_HIJRI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PassportIssuedDate)
                    .HasColumnName("PASSPORT_ISSUED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.PassportIssuedDateHijri)
                    .HasColumnName("PASSPORT_ISSUED_DATE_HIJRI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PassportIssuedFrom)
                    .HasColumnName("PASSPORT_ISSUED_FROM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PassportNo)
                    .HasColumnName("PASSPORT_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfIssue)
                    .HasColumnName("PLACE_OF_ISSUE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ProfilePic)
                    .HasColumnName("PROFILE_PIC")
                    .HasMaxLength(200);

                entity.Property(e => e.ProfileSummary)
                    .HasColumnName("PROFILE_SUMMARY")
                    .HasMaxLength(300);

                entity.Property(e => e.Sector)
                    .HasColumnName("SECTOR")
                    .HasMaxLength(30);

                entity.Property(e => e.SponsorEmail)
                    .HasColumnName("SPONSOR_EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorMobileNo)
                    .HasColumnName("SPONSOR_MOBILE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorName)
                    .HasColumnName("SPONSOR_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.SponsorNotes)
                    .HasColumnName("SPONSOR_NOTES")
                    .HasMaxLength(50);

                entity.Property(e => e.SponsorPhoneNo)
                    .HasColumnName("SPONSOR_PHONE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorRelationship)
                    .HasColumnName("SPONSOR_RELATIONSHIP")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StdOrderAmongSiblings)
                    .HasColumnName("STD_ORDER_AMONG_SIBLINGS")
                    .HasMaxLength(20);

                entity.Property(e => e.StudentCode)
                    .HasColumnName("STUDENT_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentStatus)
                    .HasColumnName("STUDENT_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StudentUserId).HasColumnName("STUDENT_USER_ID");

                entity.Property(e => e.ThirdName)
                    .HasColumnName("THIRD_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdNameAr)
                    .HasColumnName("THIRD_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.Transportation)
                    .HasColumnName("TRANSPORTATION")
                    .HasMaxLength(30);

                entity.Property(e => e.WithWhomStudentsLive)
                    .HasColumnName("WITH_WHOM_STUDENTS_LIVE")
                    .HasMaxLength(20);

                entity.Property(e => e.WorkingPlace)
                    .HasColumnName("WORKING_PLACE")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<SubSections>(entity =>
            {
                entity.HasKey(e => e.SubSectionId);

                entity.ToTable("SUB_SECTIONS", "HR");

                entity.Property(e => e.SubSectionId).HasColumnName("SUB_SECTION_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.DivisionId).HasColumnName("DIVISION_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ReportingToUid).HasColumnName("REPORTING_TO_UID");

                entity.Property(e => e.SectionId).HasColumnName("SECTION_ID");

                entity.Property(e => e.SubSectionCode)
                    .HasColumnName("SUB_SECTION_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubSectionHeadUid).HasColumnName("SUB_SECTION_HEAD_UID");

                entity.Property(e => e.SubSectionNameAr)
                    .HasColumnName("SUB_SECTION_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.SubSectionNameEn)
                    .IsRequired()
                    .HasColumnName("SUB_SECTION_NAME_EN")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.SubSections)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SUB_SECTIONS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SubSections)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SUB_SECTIONS_COMPANY");

                entity.HasOne(d => d.ReportingToU)
                    .WithMany(p => p.SubSectionsReportingToU)
                    .HasForeignKey(d => d.ReportingToUid)
                    .HasConstraintName("FK_SUB_SECTIONS_REPORTING_TO");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.SubSections)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SUB_SECTIONS_SECTIONS");

                entity.HasOne(d => d.SubSectionHeadU)
                    .WithMany(p => p.SubSectionsSubSectionHeadU)
                    .HasForeignKey(d => d.SubSectionHeadUid)
                    .HasConstraintName("FK_SUB_SECTIONS_HEAD");
            });

            modelBuilder.Entity<Submissions>(entity =>
            {
                entity.HasKey(e => e.SubmissionId);

                entity.ToTable("SUBMISSIONS", "ACD");

                entity.Property(e => e.SubmissionId).HasColumnName("SUBMISSION_ID");

                entity.Property(e => e.AssignmentStatus)
                    .HasColumnName("ASSIGNMENT_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AssingmentId).HasColumnName("ASSINGMENT_ID");

                entity.Property(e => e.Attachment)
                    .IsRequired()
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.QuizId).HasColumnName("QUIZ_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");

                entity.Property(e => e.SubmissionDate)
                    .HasColumnName("SUBMISSION_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.SubmissionStatus)
                    .HasColumnName("SUBMISSION_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.Assingment)
                    .WithMany(p => p.Submissions)
                    .HasForeignKey(d => d.AssingmentId)
                    .HasConstraintName("FK_SUBMISSIONS_ASSIGNMENT");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("TASKS", "PRJ");

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.Property(e => e.AssignedToEmpId).HasColumnName("ASSIGNED_TO_EMP_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentTaskId).HasColumnName("PARENT_TASK_ID");

                entity.Property(e => e.PlanDateFrom)
                    .HasColumnName("PLAN_DATE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlanDateTo)
                    .HasColumnName("PLAN_DATE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");

                entity.Property(e => e.RelatedTaskId).HasColumnName("RELATED_TASK_ID");

                entity.Property(e => e.TaskDetail).HasColumnName("TASK_DETAIL");

                entity.Property(e => e.TaskEndDate)
                    .HasColumnName("TASK_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskProgressPercent).HasColumnName("TASK_PROGRESS_PERCENT");

                entity.Property(e => e.TaskStartDate)
                    .HasColumnName("TASK_START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskStatusId)
                    .HasColumnName("TASK_STATUS_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TaskTitle)
                    .HasColumnName("TASK_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.TaskTypeId)
                    .HasColumnName("TASK_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.AssignedToEmp)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.AssignedToEmpId)
                    .HasConstraintName("FK_TASKS_EMP");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_TASKS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_TASKS_COMPANY");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_TASKS_PROJECTS");

                entity.HasOne(d => d.TaskStatus)
                    .WithMany(p => p.TasksTaskStatus)
                    .HasForeignKey(d => d.TaskStatusId)
                    .HasConstraintName("FK_TASKS_STATUS");

                entity.HasOne(d => d.TaskType)
                    .WithMany(p => p.TasksTaskType)
                    .HasForeignKey(d => d.TaskTypeId)
                    .HasConstraintName("FK_TASKS_TYPE");
            });

            modelBuilder.Entity<TaxRates>(entity =>
            {
                entity.HasKey(e => e.TaxRateId);

                entity.ToTable("TAX_RATES");

                entity.Property(e => e.TaxRateId).HasColumnName("TAX_RATE_ID");

                entity.Property(e => e.ActiveStatus)
                    .HasColumnName("ACTIVE_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.TaxPercent)
                    .HasColumnName("TAX_PERCENT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxRateNameAr)
                    .HasColumnName("TAX_RATE_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.TaxRateNameEn)
                    .HasColumnName("TAX_RATE_NAME_EN")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TaxRates)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_TAX_RATES_BRANCH");
            });

            modelBuilder.Entity<TeamMembers>(entity =>
            {
                entity.HasKey(e => e.TeamMemberId);

                entity.ToTable("TEAM_MEMBERS", "PRJ");

                entity.Property(e => e.TeamMemberId).HasColumnName("TEAM_MEMBER_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.Comments).HasColumnName("COMMENTS");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ProgressPercent).HasColumnName("PROGRESS_PERCENT");

                entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusId)
                    .HasColumnName("STATUS_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TeamMembers)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_TEAM_MEMBERS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TeamMembers)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_TEAM_MEMBERS_COMPANY");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.TeamMembers)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_TEAM_MEMBERS_EMP");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TeamMembers)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_TEAM_MEMBERS_PROJECTS");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TeamMembers)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_TEAM_MEMBERS_STATUS");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TeamMembers)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TEAM_MEMBERS_TASKS");
            });

            modelBuilder.Entity<Teams>(entity =>
            {
                entity.HasKey(e => e.TeamId)
                    .HasName("PK_SUB_UNITS");

                entity.ToTable("TEAMS", "HR");

                entity.Property(e => e.TeamId).HasColumnName("TEAM_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.DivisionId).HasColumnName("DIVISION_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ReportingToUid).HasColumnName("REPORTING_TO_UID");

                entity.Property(e => e.SectionId).HasColumnName("SECTION_ID");

                entity.Property(e => e.SubSectionId).HasColumnName("SUB_SECTION_ID");

                entity.Property(e => e.TeamAr)
                    .HasColumnName("TEAM_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.TeamCode)
                    .HasColumnName("TEAM_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TeamEn)
                    .IsRequired()
                    .HasColumnName("TEAM_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.TeamHeadUid).HasColumnName("TEAM_HEAD_UID");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TEAMS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TEAMS_COMPANY");

                entity.HasOne(d => d.ReportingToU)
                    .WithMany(p => p.TeamsReportingToU)
                    .HasForeignKey(d => d.ReportingToUid)
                    .HasConstraintName("FK_TEAMS_REPORTING_TO");

                entity.HasOne(d => d.TeamHeadU)
                    .WithMany(p => p.TeamsTeamHeadU)
                    .HasForeignKey(d => d.TeamHeadUid)
                    .HasConstraintName("FK_TEAMS_HEAD");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SUB_UNITS_UNITS");
            });

            modelBuilder.Entity<TimeInOutCorrection>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("TIME_IN_OUT_CORRECTION", "HR");

                entity.Property(e => e.RecId).HasColumnName("REC_ID");

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(100);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OldTimeFrom).HasColumnName("OLD_TIME_FROM");

                entity.Property(e => e.OldTimeTo).HasColumnName("OLD_TIME_TO");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(500);

                entity.Property(e => e.RequestDate)
                    .HasColumnName("REQUEST_DATE")
                    .HasMaxLength(6);

                entity.Property(e => e.RequestStatus)
                    .HasColumnName("REQUEST_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedDate)
                    .HasColumnName("REQUESTED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.TimeFrom).HasColumnName("TIME_FROM");

                entity.Property(e => e.TimeTo).HasColumnName("TIME_TO");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.TimeInOutCorrection)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_TIME_IN_OUT_CORRECTION_EMP");

                entity.HasOne(d => d.RequestStatusNavigation)
                    .WithMany(p => p.TimeInOutCorrection)
                    .HasForeignKey(d => d.RequestStatus)
                    .HasConstraintName("FK_TIME_IN_OUT_CORRECTION_LOOKUPS");
            });

            modelBuilder.Entity<Trusties>(entity =>
            {
                entity.HasKey(e => e.TrustId);

                entity.ToTable("TRUSTIES", "ACD");

                entity.Property(e => e.TrustId).HasColumnName("TRUST_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModfiedBy).HasColumnName("MODFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.TrustName)
                    .IsRequired()
                    .HasColumnName("TRUST_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Units>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("UNITS", "HR");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.DivisionId).HasColumnName("DIVISION_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.ReportingToUid).HasColumnName("REPORTING_TO_UID");

                entity.Property(e => e.SectionId).HasColumnName("SECTION_ID");

                entity.Property(e => e.SubSectionId).HasColumnName("SUB_SECTION_ID");

                entity.Property(e => e.UnitCode)
                    .HasColumnName("UNIT_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitHeadUid).HasColumnName("UNIT_HEAD_UID");

                entity.Property(e => e.UnitNameAr)
                    .HasColumnName("UNIT_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.UnitNameEn)
                    .IsRequired()
                    .HasColumnName("UNIT_NAME_EN")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UNITS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UNITS_COMPANY");

                entity.HasOne(d => d.ReportingToU)
                    .WithMany(p => p.UnitsReportingToU)
                    .HasForeignKey(d => d.ReportingToUid)
                    .HasConstraintName("FK_UNITS_REPORTING_TO");

                entity.HasOne(d => d.SubSection)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.SubSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UNITS_SUB_SECTIONS");

                entity.HasOne(d => d.UnitHeadU)
                    .WithMany(p => p.UnitsUnitHeadU)
                    .HasForeignKey(d => d.UnitHeadUid)
                    .HasConstraintName("FK_UNITS_HEAD");
            });

            modelBuilder.Entity<UserPrivileges>(entity =>
            {
                entity.HasKey(e => e.UserPrivilegeId)
                    .HasName("PK_USER_PRIVILEGE");

                entity.ToTable("USER_PRIVILEGES", "AUTH");

                entity.Property(e => e.UserPrivilegeId).HasColumnName("USER_PRIVILEGE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PrivilegeId).HasColumnName("PRIVILEGE_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.Privilege)
                    .WithMany(p => p.UserPrivileges)
                    .HasForeignKey(d => d.PrivilegeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USER_PRIVILEGES_PRIVILEGES");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPrivileges)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_USER_PRIVILEGES_USERS");
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => e.UserRoleId)
                    .HasName("PK_USER_ROLE");

                entity.ToTable("USER_ROLES", "AUTH");

                entity.Property(e => e.UserRoleId).HasColumnName("USER_ROLE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USER_ROLES_ROLES");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_USER_ROLES_USERS");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_USER");

                entity.ToTable("USERS", "AUTH");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.AllowTwoFactorAuth).HasColumnName("ALLOW_TWO_FACTOR_AUTH");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DEPARTMENT_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayNameAr)
                    .HasColumnName("DISPLAY_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayNameEn)
                    .IsRequired()
                    .HasColumnName("DISPLAY_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.IsEmailConfirmed).HasColumnName("IS_EMAIL_CONFIRMED");

                entity.Property(e => e.IsLocked).HasColumnName("IS_LOCKED");

                entity.Property(e => e.IsPhoneNoConfirmed).HasColumnName("IS_PHONE_NO_CONFIRMED");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.UserName)
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_USERS_EMPID");
            });

            modelBuilder.Entity<VacantJobs>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.ToTable("VACANT_JOBS", "HR");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CityId)
                    .HasColumnName("CITY_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CountryId)
                    .HasColumnName("COUNTRY_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailTo)
                    .HasColumnName("EMAIL_TO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobDepartmentId)
                    .HasColumnName("JOB_DEPARTMENT_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.JobDescription)
                    .HasColumnName("JOB_DESCRIPTION")
                    .HasMaxLength(1000);

                entity.Property(e => e.JobEndDate)
                    .HasColumnName("JOB_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobStartDate)
                    .HasColumnName("JOB_START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobStatusId)
                    .HasColumnName("JOB_STATUS_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.JobTypeId)
                    .HasColumnName("JOB_TYPE_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Publish).HasColumnName("PUBLISH");

                entity.Property(e => e.SalaryRangeEnd).HasColumnName("SALARY_RANGE_END");

                entity.Property(e => e.SalaryRangeStart).HasColumnName("SALARY_RANGE_START");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.VacantJobs)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_VACANT_JOBS_BRANCH");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.VacantJobs)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_VACANT_JOBS_COMPANY");

                entity.HasOne(d => d.JobDepartment)
                    .WithMany(p => p.VacantJobsJobDepartment)
                    .HasForeignKey(d => d.JobDepartmentId)
                    .HasConstraintName("FK_VACANT_JOBS_DEPT_ID");

                entity.HasOne(d => d.JobStatus)
                    .WithMany(p => p.VacantJobsJobStatus)
                    .HasForeignKey(d => d.JobStatusId)
                    .HasConstraintName("FK_VACANT_JOBS_STATUS_ID");

                entity.HasOne(d => d.JobType)
                    .WithMany(p => p.VacantJobsJobType)
                    .HasForeignKey(d => d.JobTypeId)
                    .HasConstraintName("FK_VACANT_JOBS_TYPE_ID");
            });

            modelBuilder.Entity<VacationProfiles>(entity =>
            {
                entity.HasKey(e => e.VacationProfileId);

                entity.ToTable("VACATION_PROFILES", "HR");

                entity.Property(e => e.VacationProfileId).HasColumnName("VACATION_PROFILE_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.VacationProfileCode)
                    .HasColumnName("VACATION_PROFILE_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VacationProfileNameAr)
                    .HasColumnName("VACATION_PROFILE_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.VacationProfileNameEn)
                    .IsRequired()
                    .HasColumnName("VACATION_PROFILE_NAME_EN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Vendors>(entity =>
            {
                entity.HasKey(e => e.VendorId);

                entity.ToTable("VENDORS", "AP");

                entity.Property(e => e.VendorId).HasColumnName("VENDOR_ID");

                entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");

                entity.Property(e => e.ActiveStatus)
                    .HasColumnName("ACTIVE_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(250);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CompanyRegistrationNo)
                    .HasColumnName("COMPANY_REGISTRATION_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.GstNo)
                    .HasColumnName("GST_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.NtnNo)
                    .HasColumnName("NTN_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasMaxLength(30);

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PrimaryPerson)
                    .HasColumnName("PRIMARY_PERSON")
                    .HasMaxLength(50);

                entity.Property(e => e.Skype)
                    .HasColumnName("SKYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNameAr)
                    .HasColumnName("VENDOR_NAME_AR")
                    .HasMaxLength(50);

                entity.Property(e => e.VendorNameEn)
                    .HasColumnName("VENDOR_NAME_EN")
                    .HasMaxLength(50);

                entity.Property(e => e.Website)
                    .HasColumnName("WEBSITE")
                    .HasMaxLength(50);

                entity.Property(e => e.ZipCode)
                    .HasColumnName("ZIP_CODE")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Vendors)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_VENDORS_ACCOUNTS");
            });

            modelBuilder.Entity<Visitor>(entity =>
            {
                entity.Property(e => e.VisitorId).HasColumnName("VisitorID");

                entity.Property(e => e.Browser)
                    .HasMaxLength(900)
                    .IsUnicode(false);

                entity.Property(e => e.Device)
                    .HasMaxLength(980)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(890)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.ToTable("VOUCHER", "FN");

                entity.Property(e => e.VoucherId).HasColumnName("VOUCHER_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1000);

                entity.Property(e => e.IsPosted).HasColumnName("IS_POSTED");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.PostedBy).HasColumnName("POSTED_BY");

                entity.Property(e => e.PostedDate)
                    .HasColumnName("POSTED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalCredit)
                    .HasColumnName("TOTAL_CREDIT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalDebit)
                    .HasColumnName("TOTAL_DEBIT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId).HasColumnName("VENDOR_ID");

                entity.Property(e => e.VoucherCode)
                    .HasColumnName("VOUCHER_CODE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherEntryDate)
                    .HasColumnName("VOUCHER_ENTRY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.VoucherType)
                    .IsRequired()
                    .HasColumnName("VOUCHER_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Voucher)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_VOUCHER_CUSTOMERS");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.Voucher)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_VOUCHER_VENDORS");

                entity.HasOne(d => d.VoucherTypeNavigation)
                    .WithMany(p => p.Voucher)
                    .HasForeignKey(d => d.VoucherType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VOUCHER_LOOKUPS");
            });

            modelBuilder.Entity<VoucherLines>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("VOUCHER_LINES", "FN");

                entity.Property(e => e.LineId).HasColumnName("LINE_ID");

                entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Credit)
                    .HasColumnName("CREDIT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Debit)
                    .HasColumnName("DEBIT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1000);

                entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.Refno1)
                    .HasColumnName("REFNO1")
                    .HasMaxLength(100);

                entity.Property(e => e.Refno2)
                    .HasColumnName("REFNO2")
                    .HasMaxLength(100);

                entity.Property(e => e.Refno3)
                    .HasColumnName("REFNO3")
                    .HasMaxLength(100);

                entity.Property(e => e.VoucherId).HasColumnName("VOUCHER_ID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.VoucherLines)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_VOUCHER_LINES_ACCOUNTS");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.VoucherLines)
                    .HasForeignKey(d => d.VoucherId)
                    .HasConstraintName("FK_VOUCHER_LINES_VOUCHER");
            });

            modelBuilder.Entity<WeekendOvertime>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("WEEKEND_OVERTIME", "HR");

                entity.Property(e => e.RecId).HasColumnName("REC_ID");

                entity.Property(e => e.ApprovalDate)
                    .HasColumnName("APPROVAL_DATE")
                    .HasMaxLength(6);

                entity.Property(e => e.ApprovalStatus)
                    .HasColumnName("APPROVAL_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedBy).HasColumnName("ASSIGNED_BY");

                entity.Property(e => e.Assignment)
                    .HasColumnName("ASSIGNMENT")
                    .HasMaxLength(500);

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateFrom)
                    .HasColumnName("DATE_FROM")
                    .HasColumnType("date");

                entity.Property(e => e.DateTo)
                    .HasColumnName("DATE_TO")
                    .HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PORTAL_ID");

                entity.Property(e => e.TotalDays).HasColumnName("TOTAL_DAYS");

                entity.Property(e => e.TotalHours).HasColumnName("TOTAL_HOURS");

                entity.HasOne(d => d.ApprovalStatusNavigation)
                    .WithMany(p => p.WeekendOvertime)
                    .HasForeignKey(d => d.ApprovalStatus)
                    .HasConstraintName("FK_WEEKEND_OVERTIME_LOOKUPS");

                entity.HasOne(d => d.AssignedByNavigation)
                    .WithMany(p => p.WeekendOvertimeAssignedByNavigation)
                    .HasForeignKey(d => d.AssignedBy)
                    .HasConstraintName("FK_WEEKEND_OVERTIME_ASSIGNEDBY");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.WeekendOvertimeEmp)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_WEEKEND_OVERTIME_EMP");
            });

            modelBuilder.Entity<Zoom>(entity =>
            {
                entity.ToTable("ZOOM", "ACD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Agenda)
                    .HasColumnName("AGENDA")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalType).HasColumnName("APPROVAL_TYPE");

                entity.Property(e => e.AutoRecording).HasColumnName("AUTO_RECORDING");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.EnableForceLogin).HasColumnName("ENABLE_FORCE_LOGIN");

                entity.Property(e => e.EnableHostVideo).HasColumnName("ENABLE_HOST_VIDEO");

                entity.Property(e => e.EnableJoinBeforeHost).HasColumnName("ENABLE_JOIN_BEFORE_HOST");

                entity.Property(e => e.EnableMuteOnEntry).HasColumnName("ENABLE_MUTE_ON_ENTRY");

                entity.Property(e => e.EnableParticipantVideo).HasColumnName("ENABLE_PARTICIPANT_VIDEO");

                entity.Property(e => e.FacultyId).HasColumnName("FACULTY_ID");

                entity.Property(e => e.JoinUrl)
                    .HasColumnName("JOIN_URL")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MeetindDate)
                    .HasColumnName("MEETIND_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.MeetingStartTime)
                    .HasColumnName("MEETING_START_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingType).HasColumnName("MEETING_TYPE");

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StartUrl)
                    .HasColumnName("START_URL")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasColumnName("TIME_ZONE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Topic)
                    .HasColumnName("TOPIC")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.ZoomMeetingId)
                    .HasColumnName("ZOOM_MEETING_ID")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZoomMeeting>(entity =>
            {
                entity.ToTable("ZOOM_MEETING", "ACD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Agenda)
                    .HasColumnName("AGENDA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalTyoe).HasColumnName("APPROVAL_TYOE");

                entity.Property(e => e.AutoRecording).HasColumnName("AUTO_RECORDING");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.EnableChinaHost).HasColumnName("ENABLE_CHINA_HOST");

                entity.Property(e => e.EnableForceLogin).HasColumnName("ENABLE_FORCE_LOGIN");

                entity.Property(e => e.EnableHostVideo).HasColumnName("ENABLE_HOST_VIDEO");

                entity.Property(e => e.EnableIndiaHost).HasColumnName("ENABLE_INDIA_HOST");

                entity.Property(e => e.EnableJoinBeforeHost).HasColumnName("ENABLE_JOIN_BEFORE_HOST");

                entity.Property(e => e.EnableMuteOnEntry).HasColumnName("ENABLE_MUTE_ON_ENTRY");

                entity.Property(e => e.EnablePartiipantVideo).HasColumnName("ENABLE_PARTIIPANT_VIDEO");

                entity.Property(e => e.FacultyId).HasColumnName("FACULTY_ID");

                entity.Property(e => e.JoinUrl)
                    .HasColumnName("JOIN_URL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDate)
                    .HasColumnName("MEETING_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.MeetingStartTime)
                    .HasColumnName("MEETING_START_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.MeetingType).HasColumnName("MEETING_TYPE");

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartUrl)
                    .HasColumnName("START_URL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Timezone)
                    .HasColumnName("TIMEZONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Topic)
                    .HasColumnName("TOPIC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.ZoomMeetingId)
                    .HasColumnName("ZOOM_MEETING_ID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.ZoomMeeting)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ZOOM_MEETINGS_COURSE");

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.ZoomMeeting)
                    .HasForeignKey(d => d.FacultyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ZOOM_MEETINGS_USERS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
