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

namespace ErpOnClick.EmpContract.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class EmpContractsController : Controller
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


        [Route("{area}/{controller}/edit/emp/{empId}/{id=0}")]
        public IActionResult edit(int empId, int id)
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


        [HttpPost]
        public ActionResult save(EmpContractAndPackagesViewModel postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _EmpContractService.GetById(postedData.EmpContract.EmpContractId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "EmpContractId " + postedData.EmpContract.EmpContractId + " is already exists !";
                }
                else
                {
                    var EmpId = Convert.ToInt32(User.Identity.Name);
                    var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                    postedData.EmpContract.CompanyId = user.CompanyId;
                    postedData.EmpContract.BranchId = user.BranchId;
                    postedData.EmpContract.CreatedDate = System.DateTime.Now;
                    postedData.EmpContract.CreatedBy = 0;
                    postedData.EmpContract.PortalId = 0;
                    if (postedData.EmpContract.ContractStatus == "027002")//For Active Status
                    {
                        var empContracts = _EmpContractService.GetAll();
                        foreach (var contractEmp in empContracts)
                        {
                            contractEmp.ContractStatus = "027001";//InActive Code i.e Inactivating all contracts except new one
                        }
                        _EmpContractService.dbset().UpdateRange(empContracts);
                    }

                    result.msg = _EmpContractService.Insert(postedData.EmpContract);
                    if (result.msg == "")
                    {
                        result.msg = _EmpContractService.SaveChanges();

                        try
                        {

                            if (postedData.EmpContractPackagesList != null && postedData.EmpContractPackagesList.Count() !=0)
                            {
                                foreach (var contractPackage in postedData.EmpContractPackagesList)
                                {
                                    contractPackage.EmpContractId = postedData.EmpContract.EmpContractId;

                                    var package = _EmpContractsPackageService.GetById(contractPackage.EmpContractsPackageId);
                                    if (package != null)
                                    {
                                        result.isError = true;
                                        result.msg = "EmpContractsPackageId " + contractPackage.EmpContractsPackageId + " is already exists !";
                                    }
                                    else
                                    {
                                        result.msg = _EmpContractsPackageService.Insert(contractPackage);
                                    }

                                }
                            }
                        
                            result.msg = _EmpContractsPackageService.SaveChanges();



                        }
                        catch (Exception ex)
                        {

                            result.msg = ex.ToString();
                        }
                      

                        result.scalerVal = postedData.EmpContract.EmpContractId;

                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(EmpContractAndPackagesViewModel postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.EmpContract.ModifiedDate = System.DateTime.Now;
                postedData.EmpContract.ModifiedBy = 1;


                result.msg = _EmpContractService.Update(postedData.EmpContract);
                if (postedData.EmpContract.ContractStatus == "027002")//For Active Status
                {
                    var empContracts = _EmpContractService.Find(x => x.EmpContractId != postedData.EmpContract.EmpContractId && x.EmpId ==postedData.EmpContract.EmpId).ToList();
                    foreach (var contractEmp in empContracts)
                    {
                        contractEmp.ContractStatus = "027001";//InActive Code i.e Inactivating all contracts except new one
                    }
                    _EmpContractService.dbset().UpdateRange(empContracts);
                }
                if (result.msg == "")
                {
                    result.msg = _EmpContractService.SaveChanges();
                    try
                    {
                        _EmpContractsPackageService.dbset().UpdateRange(postedData.EmpContractPackagesList);
                        result.msg = _EmpContractsPackageService.SaveChanges();


                        foreach (var itemTwo in postedData.EmpContractPackagesList)
                        {
                            if (itemTwo.IsDeleted == "true")
                            {
                                _EmpContractsPackageService.Delete(itemTwo.EmpContractsPackageId);
                            }
                        }
                        _EmpContractsPackageService.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        result.msg = ex.ToString();
                    }

                    result.scalerVal = postedData.EmpContract.EmpContractId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            var contractId = Int32.Parse(id);
            var empContractPackages = _EmpContractsPackageService.Find(x => x.EmpContractId == contractId).ToList();

            foreach (var item in empContractPackages)
            {
                _EmpContractsPackageService.Delete(item.EmpContractsPackageId);
            }
            _EmpContractsPackageService.SaveChanges();
            _EmpContractService.Delete(Int32.Parse(id));
            result.msg = _EmpContractService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }
     
    }
}
