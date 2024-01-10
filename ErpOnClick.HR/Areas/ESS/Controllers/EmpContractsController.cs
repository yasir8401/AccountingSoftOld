using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ErpOnClick.ErpMain.ViewModel;
using ErpOnClick.ErpMain.Models;
using System.Security.Cryptography.X509Certificates;

namespace ErpOnClick.ErpMain.Areas.ESS.Controllers
{
    public class EmpContractsController : BaseController
    {
        private readonly ILogger<EmpContractsController> _logger;
        private IEmpContractsService _EmpContractService;
        private IEmpsService _EmpService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IDivisionsService _DivisionService;
        private IDepartmentService _DepartmentService;
        private ISubSectionService _SubSectionService;
        private ISectionService _SectionService;
        private IUnitService _UnitService;
        private ITeamService _TeamService;
        private IGradesService _GradeService;
        private IGosiSettingsService _GosiSettingService;
        private IAbsentProfilesService _AbsentProfileService;
        private IAirTicketProfilesService _AirTicketProfileService;
        private IHousingAllowancesService _HousingAllowanceService;
        private IPayGroupsService _PayGroupService;
        private IEmpContractsPackageService _EmpContractsPackageService;
        private IUserService _UserService;

        private dynamic expObj;
        public EmpContractsController(IUserService UserService,ILogger<EmpContractsController> logger, IEmpContractsPackageService EmpContractsPackageService, IPayGroupsService PayGroupService, IHousingAllowancesService HousingAllowanceService, IAirTicketProfilesService AirTicketProfileService, IAbsentProfilesService AbsentProfileService, IGradesService GradeService, IGosiSettingsService GosiSettingService, ITeamService TeamService, ISubSectionService SubSectionService, ISectionService SectionService, IUnitService UnitService, IDepartmentService DepartmentService, IDivisionsService DivisionService, IEmpsService EmpService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IEmpContractsService EmpContractService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _UserService = UserService;
            _logger = logger;
            _EmpContractService = EmpContractService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _EmpService = EmpService;
            _DivisionService = DivisionService;
            _DepartmentService = DepartmentService;
            _SectionService = SectionService;
            _SubSectionService = SubSectionService;
            _UnitService = UnitService;
            _TeamService = TeamService;
            _GradeService = GradeService;
            _GosiSettingService = GosiSettingService;
            _AbsentProfileService = AbsentProfileService;
            _AirTicketProfileService = AirTicketProfileService;
            _HousingAllowanceService = HousingAllowanceService;
            _PayGroupService = PayGroupService;
            _EmpContractsPackageService = EmpContractsPackageService;

            expObj = new ExpandoObject();
        }

        [Route("{area}/{controller}/emp/{empId}")]
        public IActionResult Index(int empId = 0)
        {
            
            expObj.empId = empId;
            expObj.empDetails = _EmpService.GetById(empId);

            return View(expObj);
        }

        public IActionResult _list(int empId)
        {
            expObj.empId = empId;
            var empContracts = _EmpContractService.dbset().Include(x => x.Division).Include(x => x.Department).Include(x => x.Section).Include(x => x.SubSection).Include(x => x.Team);
            expObj.EmpContractList = empContracts.Where(x => x.EmpId == empId).ToList();
          
            return PartialView(expObj);
        }


        [Route("{area}/{controller}/view/emp/{empId}/{id=0}")]
        public IActionResult view(int empId, int id)
        {
            var lookupList = _LookupService.GetAll();
            
            expObj.EmpList = _EmpService.Find(c => c.EmpId == empId).ToList();
            expObj.ContractStatusList = lookupList.Where(x => x.LookupTypeId == LookupTypList.CONTRACT_STATUS_027).ToList();
            expObj.divisionList = _DivisionService.GetAll();
            expObj.departmentList = _DepartmentService.GetAll();
            expObj.sectionsList = _SectionService.GetAll();
            expObj.subSectionsList = _SubSectionService.GetAll();
            expObj.unitList = _UnitService.GetAll();
            expObj.teamList = _TeamService.GetAll();
            expObj.gradeList = _GradeService.GetAll();
            expObj.gosiList = _GosiSettingService.GetAll();
            expObj.ticketProfleList = _AirTicketProfileService.GetAll();
            expObj.housingAllocanceList = _HousingAllowanceService.GetAll();
            expObj.payGroupList = _PayGroupService.GetAll();
            expObj.absentProfileList = _AbsentProfileService.GetAll();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            expObj.AllowanceTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.ALLOWANCE_TYPE_026).ToList();
            expObj.EmpContractDetails = _EmpContractService.GetById(id);
      
            expObj.EmpContractPackageDetailsList = _EmpContractsPackageService.Find(x => x.EmpContractId == id).ToList();

            expObj.empDetails = _EmpService.GetById(empId);
            expObj.empId = empId;



            return View(expObj);
        }

    }
}
