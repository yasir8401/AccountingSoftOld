using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Dependencies
{
    public static class ServicesDependency
    {
        public static void AddServicesDependency(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IApplicationsService, ApplicationsService>();
            services.AddScoped<IBranchService, BranchService>();
            services.AddScoped<IBranchViewService, BranchViewService>();

            services.AddScoped<ICommentsService, CommentsService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IDocumentsService, DocumentsService>();
            services.AddScoped<ILookupTypesService, LookupTypesService>();
            services.AddScoped<ILookupsService, LookupsService>();
            services.AddScoped<IVacantJobsService, VacantJobsService>();
            services.AddScoped<IBuildingsService, BuildingsService>();
            services.AddScoped<IRoomsService, RoomsService>();
            services.AddScoped<IAppConfigService, AppConfigService>();
            services.AddScoped<IOwnerService, OwnerService>();
            services.AddScoped<ITrustiesService, TrustiesService>();


            //For DAL
            services.AddScoped<IActivityLogService, ActivityLogService>();

            //For Academic
            services.AddScoped<IStudentsService, StudentsService>();
            services.AddScoped<IStudentUsersService, StudentUsersService>();
            services.AddScoped<IParentService, ParentService>();
            services.AddScoped<ICampusService, CampusService>();
            services.AddScoped<IMajorTypeService, MajorTypeService>();
            services.AddScoped<IMajorService, MajorService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IBooksService, BooksService>();
            services.AddScoped<ICourseScoreService, CourseScoreService>();
            services.AddScoped<ISemestersService, SemestersService>();
            services.AddScoped<IAcademicYearsService, AcademicYearsService>();
            services.AddScoped<IClassesScheduleService, ClassesScheduleService>();
            services.AddScoped<IClassesService, ClassesService>();
            services.AddScoped<IPlanCoursesService, PlanCoursesService>();
            services.AddScoped<IPlanPrerequisitesService, PlanPrerequisitesService>();
            services.AddScoped<ICalendarService, CalendarService>();
            services.AddScoped<IStudentDiscountTypeService, StudentDiscountTypeService>();
            services.AddScoped<IStudentuserService, StudentuserService>();
            services.AddScoped<IAdmissionFormService, AdmissionFormService>();
            services.AddScoped<IAdmissionFormsEducationsService, AdmissionFormsEducationsService>();
            services.AddScoped<IAdmissionFormsAttachmentsService, AdmissionFormsAttachmentsService>();
            services.AddScoped<IStudentAttachmentsService, StudentAttachmentsService>();

            services.AddScoped<IStudentEducationsService, StudentEducationsService>();
            services.AddScoped<IStdEnrollService, StdEnrollService>();
            services.AddScoped<IStdSemestersService, StdSemestersService>();
            services.AddScoped<IStudentAttendanceService, StudentAttendanceService>();
            services.AddScoped<IStdLettersService, StdLettersService>();
            services.AddScoped<IFeeVouchersService, FeeVouchersService>();
            services.AddScoped<IFeeVouchersLinesService, FeeVouchersLinesService>();
            services.AddScoped<IBanksService, BanksService>();
            services.AddScoped<IRuleAndRegulationsService, RuleAndRegulationsService>();
            services.AddScoped<IZoomMeetingsService , ZoomMeetingsService>();
            services.AddScoped<IAddmissionFormsRemarksService , AddmissionFormsRemarksService>();


            services.AddScoped<IBookBorrowService, BookBorrowService>();
            services.AddScoped<IBookReturnService, BookReturnService>();
            services.AddScoped<IAssignmentService, AssignmentService>();
            services.AddScoped<ISubmissionsService, SubmissionsService>();
            services.AddScoped<IGradeService, GradeService>();
            services.AddScoped<IExceptionsCoursesService, ExceptionsCoursesService>();
            services.AddScoped<IExceptionsClassCapacityService, ExceptionsClassCapacityService>();
            services.AddScoped<IZoomService, ZoomService>();
            services.AddScoped<IExamScheduleLinesService, ExamScheduleLinesService>();
            services.AddScoped<IExamScheduleService, ExamScheduleService>();

            //For Hr Employee
            services.AddScoped<IEmpsService, EmpsService>();
            services.AddScoped<IEmpAddressService, EmpAddressesService>();
            services.AddScoped<IEmpBankService, EmpBankService>();
            services.AddScoped<IEmpDependentsService, EmpDependentService>();
            services.AddScoped<IEmpVehicalService, EmpVehicleService>();
            services.AddScoped<IEmpMedicalService, EmpMedicalService>();
            services.AddScoped<IEmpEducationService, EmpEducationService>();
            services.AddScoped<IEmpGosiSettingsService, EmpGosiSettingsService>();
            services.AddScoped<IGradesService, GradesService>();
            services.AddScoped<IGradesDetailService, GradesDetailService>();
            services.AddScoped<INationalHolidaysService, NationalHolidaysService>();
            services.AddScoped<IOvertimeSettingsService, OvertimeSettingsService>();
            services.AddScoped<IOvertimeSettingsDetailsService, OvertimeSettingsDetailsService>();
            services.AddScoped<IPositionsService, PositionsService>();
            services.AddScoped<ISpecialOccasionsService, SpecialOccasionsService>();

            services.AddScoped<IGosiSettingsService, GosiSettingsService>();
            services.AddScoped<IHousingAllowancesService, HousingAllowancesService>();
            services.AddScoped<IAirTicketProfilesService, AirTicketProfilesService>();
            services.AddScoped<IPayGroupsService, PayGroupsService>();
            services.AddScoped<IAbsentProfilesService, AbsentProfilesService>();
            services.AddScoped<IEmpContractsService, EmpContractsService>();
            services.AddScoped<IEmpContractsPackageService, EmpContractsPackageService>();
            services.AddScoped<ILeaveService, LeaveService>();
            services.AddScoped<ILoansService, LoanService>();
            services.AddScoped<IEmpAttendancesService, EmpAttendancesService>();
            services.AddScoped<IOverTimeRequestService, OverTimeRequestService>();
            services.AddScoped<IOverTimeRequestLineService, OverTimeRequestLineService>();

            services.AddScoped<IPayRunDService, PayRunDService>();
            services.AddScoped<IPayRunMService, PayRunMService>();
            services.AddScoped<IPaySlipSerivce, PaySlipSerivce>();

            services.AddScoped<IApprovalRouteDetailsService, ApprovalRouteDetailsService>();


            services.AddScoped<IEmpShiftsService, EmpShiftsService>();
            services.AddScoped<ILeavesReturnService, LeavesReturnService>();
            services.AddScoped<IRequestsService, RequestsService>();
            services.AddScoped<IExpClaimsService, ExpClaimsService>();
            services.AddScoped<IShiftsService, ShiftsService>();
            services.AddScoped<IPerformanceBaseSalaryService, PerformanceBaseSalaryService>();
            services.AddScoped<ISalaryPayablesPerMonthService, SalaryPayablesPerMonthService>();
            services.AddScoped<IEmpExperienceService, EmpExperienceService>();
            services.AddScoped<IEmpPreviousExperienceService, EmpPreviousExperienceService>();
            services.AddScoped<ICourseERPService, CourseERPService>();
            services.AddScoped<IAchievementService, AchievementService>();
            services.AddScoped<IResearchService, ResearchService>();
            services.AddScoped<ITimeCorrectionService, TimeCorrectionService>();
            services.AddScoped<IWeekendOvertimeService, WeekendOvertimeService>();
            services.AddScoped<ILeavesProfileService, LeavesProfileService>();
            services.AddScoped<IJobOffersService, JobOffersService>();




            //For Recruitments
            services.AddScoped<IJobPortalUserService, JobPortalUserService>();



            //For Organisations
            services.AddScoped<IDivisionsService, DevisionService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<ISectionService, SectionService>();
            services.AddScoped<ISubSectionService, SubSectionService>();
            services.AddScoped<IUnitService, UnitService>();
            services.AddScoped<ITeamService, TeamService>();

            //For Secuirty
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RolesService>();
            services.AddScoped<IUserRolesService, UserRoleService>();
            services.AddScoped<IModuleService, ModuleService>();
            services.AddScoped<IPrivilegesService, PrivilegesService>();
            services.AddScoped<INavigationService, NavigationService>();
            services.AddScoped<IRolesPrivilegesService, RolePrivilegesService>();
            services.AddScoped<IUserPrivilegesService, UserPrivilegesService>();
            services.AddScoped<IApprovalTaskService, ApprovalTaskService>();
            services.AddScoped<IApprovalRouteService, ApprovalRouteService>();


            //For Invoicing
            services.AddScoped<ICustomersService, CustomersService>();
            services.AddScoped<ITaxRatesService, TaxRatesService>();
            services.AddScoped<IItemsService, ItemsService>();
            services.AddScoped<IItemCategoriesService, ItemCategoriesService>();
            services.AddScoped<IInvoicesLinesService, InvoicesLinesService>();
            services.AddScoped<IInvoicesService, InvoicesService>();
            services.AddScoped<IVendorsService, VendorsService>();
            services.AddScoped<IBillsService, BillsService>();
            services.AddScoped<IBillsLinesService, BillsLinesService>();
            services.AddScoped<IPaymentsService, PaymentsService>();
            services.AddScoped<IReceiptsService, ReceiptsService>();
            services.AddScoped<ICreditNotesService, CreditNotesService>();
            services.AddScoped<ICreditNotesLinesService, CreditNotesLinesService>();
            services.AddScoped<IRefundsService, RefundsService>();
            services.AddScoped<IRefundsLinesService, RefundsLinesService>();
            services.AddScoped<IGeneralEntriesLinesService, GeneralEntriesLinesService>();
            services.AddScoped<IGeneralEntriesService, GeneralEntriesService>();
            services.AddScoped<IAccountsService, AccountsService>();
            services.AddScoped<IAccountTypesService, AccountTypesService>();
            services.AddScoped<IAccountGroupsService, AccountGroupsService>();
            services.AddScoped<IFixedAssetService, FixedAssetService>();
            services.AddScoped<IVoucherService, VoucherService>();
            services.AddScoped<IVoucherLinesService, VoucherLinesService>();
            services.AddScoped<INotesService, NotesService>();


            //Projects
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ITeamMemberService, TeamMemberService>();
            services.AddScoped<ITaskService , TaskService>();



        }
    }
}
