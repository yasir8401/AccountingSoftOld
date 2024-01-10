using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Models
{
    public class SeedInitalData
    {

        public static void SeedData(ILookupTypesService _LookupTypeService, ILookupsService _LookUpService, IBranchService _branService, ICompanyService _companyService)
        {
            SeedLookTypes(_LookupTypeService);
            SeedLookUps(_LookUpService);
            SeedCompany(_companyService);
            SeedBranch(_branService);
        }

        public static void SeedCompany(ICompanyService _companyService)
        {
            if (_companyService.GetAll().Count() == 0)
            {
                try
                {
                    var company = new Company()
                    {
                        CoNameEn = "Nayel Solutions",
                        CreatedDate = DateTime.UtcNow,
                        PortalId = 1,
                        IsEnable = true,

                    };
                    _companyService.Insert(company);
                    _companyService.SaveChanges();
                }
                catch (Exception ex)
                {


                }

            }
        }
        public static void SeedBranch(IBranchService _branchService)
        {
            if (_branchService.GetAll().Count() == 0)
            {
                var branch = new Branch()
                {
                    CompanyId = 1,
                    BranchNameEn = "SaidPur",
                    IsEnable = true,


                    CreatedDate = DateTime.UtcNow,
                    PortalId = 1,
                };
                _branchService.Insert(branch);
                _branchService.SaveChanges();
            }
        }
        public static void SeedLookUps(ILookupsService _LookupService)
        {
            var lookUps = _LookupService.GetAll();

            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.Departments_001).Count() == 0)
            {
                Lookups lookupDept = new Lookups()
                {
                    Code = string.Concat("001", "001"),
                    LookupTypeId = "001",
                    LookupId = "001",
                    LookupNameEn = "IT",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                var result = _LookupService.Insert(lookupDept);
                if (result == "")
                {
                    result = _LookupService.SaveChanges();
                }
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.RecruitmentJobStatus_002).Count() == 0)
            {
                Lookups lookupJobStatusActive = new Lookups()
                {
                    Code = string.Concat("002", "001"),
                    LookupTypeId = "002",
                    LookupId = "001",
                    LookupNameEn = "Active",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupJobStatusDeactive = new Lookups()
                {
                    Code = string.Concat("002", "002"),
                    LookupTypeId = "002",
                    LookupId = "002",
                    LookupNameEn = "DeActive",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                _LookupService.Insert(lookupJobStatusActive);
                _LookupService.Insert(lookupJobStatusDeactive);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.RecruitmentJobTypes_003).Count() == 0)
            {
                Lookups lookupJobType = new Lookups()
                {
                    Code = string.Concat("003", "001"),
                    LookupTypeId = "003",
                    LookupId = "001",
                    LookupNameEn = "Full time",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupJobType);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.Country_004).Count() == 0)
            {
                Lookups lookupCountry = new Lookups()
                {
                    Code = string.Concat("004", "001"),
                    LookupTypeId = "004",
                    LookupId = "001",
                    LookupNameEn = "Pakistan",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                _LookupService.Insert(lookupCountry);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.City_005).Count() == 0)
            {
                Lookups lookupCity = new Lookups()
                {
                    Code = string.Concat("005", "001"),
                    LookupTypeId = "005",
                    LookupId = "001",
                    LookupNameEn = "Islamabad",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                _LookupService.Insert(lookupCity);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.ApplicationSourceType_006).Count() == 0)
            {
                Lookups lookupApplicationSourceType = new Lookups()
                {
                    Code = string.Concat("006", "001"),
                    LookupTypeId = "006",
                    LookupId = "001",
                    LookupNameEn = "test",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                _LookupService.Insert(lookupApplicationSourceType);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.ApplicationStatus_007).Count() == 0)
            {
                Lookups lookupApplicationStatusPending = new Lookups()
                {
                    Code = string.Concat("007", "001"),
                    LookupTypeId = "007",
                    LookupId = "001",
                    LookupNameEn = "Pending",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupApplicationStatusApproved = new Lookups()
                {
                    Code = string.Concat("007", "002"),
                    LookupTypeId = "007",
                    LookupId = "002",
                    LookupNameEn = "Approved",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                _LookupService.Insert(lookupApplicationStatusPending);
                _LookupService.Insert(lookupApplicationStatusApproved);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.Degree_008).Count() == 0)
            {
                Lookups lookupDegree = new Lookups()
                {
                    Code = string.Concat("008", "001"),
                    LookupTypeId = "008",
                    LookupId = "001",
                    LookupNameEn = "Bachelors In Computer Science",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                _LookupService.Insert(lookupDegree);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.OwnerType_009).Count() == 0)
            {
                Lookups lookupOwnerTypeEmployees = new Lookups()
                {
                    Code = string.Concat("009", "001"),
                    LookupTypeId = "009",
                    LookupId = "001",
                    LookupNameEn = "Employees",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupOwnerTypeCustomers = new Lookups()
                {
                    Code = string.Concat("009", "002"),
                    LookupTypeId = "009",
                    LookupId = "002",
                    LookupNameEn = "Customers",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupOwnerTypeSuppliers = new Lookups()
                {
                    Code = string.Concat("009", "003"),
                    LookupTypeId = "009",
                    LookupId = "003",
                    LookupNameEn = "Suppliers",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                _LookupService.Insert(lookupOwnerTypeEmployees);
                _LookupService.Insert(lookupOwnerTypeCustomers);
                _LookupService.Insert(lookupOwnerTypeSuppliers);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.DocumentTypes_010).Count() == 0)
            {
                Lookups lookupDocumentTypePhoto = new Lookups()
                {
                    Code = string.Concat("010", "001"),
                    LookupTypeId = "010",
                    LookupId = "001",
                    LookupNameEn = "Photo",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupDocumentTypeIDCard = new Lookups()
                {
                    Code = string.Concat("010", "002"),
                    LookupTypeId = "010",
                    LookupId = "002",
                    LookupNameEn = "ID Card",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupDocumentTypePassport = new Lookups()
                {
                    Code = string.Concat("010", "003"),
                    LookupTypeId = "010",
                    LookupId = "003",
                    LookupNameEn = "Passport",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupDocumentTypeInsurance = new Lookups()
                {
                    Code = string.Concat("010", "004"),
                    LookupTypeId = "010",
                    LookupId = "004",
                    LookupNameEn = "Insurance",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupDocumentTypeIdentityLetter = new Lookups()
                {
                    Code = string.Concat("010", "005"),
                    LookupTypeId = "010",
                    LookupId = "005",
                    LookupNameEn = "Identity Letter",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupDocumentTypeMedicalReport = new Lookups()
                {
                    Code = string.Concat("010", "006"),
                    LookupTypeId = "010",
                    LookupId = "006",
                    LookupNameEn = "Medical Report",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupDocumentTypeContract = new Lookups()
                {
                    Code = string.Concat("010", "007"),
                    LookupTypeId = "010",
                    LookupId = "007",
                    LookupNameEn = "Contract",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupDocumentTypeDeathCertificate = new Lookups()
                {
                    Code = string.Concat("010", "008"),
                    LookupTypeId = "010",
                    LookupId = "008",
                    LookupNameEn = "Death Certificate",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupDocumentTypeExamSchedule = new Lookups()
                {
                    Code = string.Concat("010", "009"),
                    LookupTypeId = "010",
                    LookupId = "009",
                    LookupNameEn = "Exam Schedule",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupDocumentTypeMarriedCertificate = new Lookups()
                {
                    Code = string.Concat("010", "010"),
                    LookupTypeId = "010",
                    LookupId = "010",
                    LookupNameEn = "Married Certificate",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupDocumentTypeBirthCertificate = new Lookups()
                {
                    Code = string.Concat("010", "011"),
                    LookupTypeId = "010",
                    LookupId = "011",
                    LookupNameEn = "Birth Certificate",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupDocumentTypeBirthReport = new Lookups()
                {
                    Code = string.Concat("010", "012"),
                    LookupTypeId = "010",
                    LookupId = "012",
                    LookupNameEn = "Birth Report",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };


                _LookupService.Insert(lookupDocumentTypePhoto);
                _LookupService.Insert(lookupDocumentTypeIDCard);
                _LookupService.Insert(lookupDocumentTypePassport);

                _LookupService.Insert(lookupDocumentTypeInsurance);
                _LookupService.Insert(lookupDocumentTypeIdentityLetter);
                _LookupService.Insert(lookupDocumentTypeMedicalReport);

                _LookupService.Insert(lookupDocumentTypeContract);
                _LookupService.Insert(lookupDocumentTypeDeathCertificate);
                _LookupService.Insert(lookupDocumentTypeExamSchedule);

                _LookupService.Insert(lookupDocumentTypeMarriedCertificate);
                _LookupService.Insert(lookupDocumentTypeBirthCertificate);
                _LookupService.Insert(lookupDocumentTypeBirthReport);

            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.MaritalStatus_011).Count() == 0)
            {
                Lookups lookupSingle = new Lookups()
                {
                    Code = string.Concat("011", "001"),
                    LookupTypeId = "011",
                    LookupId = "001",
                    LookupNameEn = "Single",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupMarried = new Lookups()
                {
                    Code = string.Concat("011", "002"),
                    LookupTypeId = "011",
                    LookupId = "002",
                    LookupNameEn = "Married",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupwidowed = new Lookups()
                {
                    Code = string.Concat("011", "003"),
                    LookupTypeId = "011",
                    LookupId = "003",
                    LookupNameEn = "widowed",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupDivorced = new Lookups()
                {
                    Code = string.Concat("011", "004"),
                    LookupTypeId = "011",
                    LookupId = "004",
                    LookupNameEn = "Divorced",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupseparated = new Lookups()
                {
                    Code = string.Concat("011", "005"),
                    LookupTypeId = "011",
                    LookupId = "005",
                    LookupNameEn = "separated ",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupSingle);
                _LookupService.Insert(lookupMarried);
                _LookupService.Insert(lookupwidowed);
                _LookupService.Insert(lookupDivorced);
                _LookupService.Insert(lookupseparated);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.Nationality_012).Count() == 0)
            {
                Lookups lookupNationality = new Lookups()
                {
                    Code = string.Concat("012", "001"),
                    LookupTypeId = "012",
                    LookupId = "001",
                    LookupNameEn = "Pakistani",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                _LookupService.Insert(lookupNationality);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.Religion_013).Count() == 0)
            {
                Lookups lookupReligionyIslam = new Lookups()
                {
                    Code = string.Concat("013", "001"),
                    LookupTypeId = "013",
                    LookupId = "001",
                    LookupNameEn = "Muslim",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupReligionyIslam);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.Gende_014).Count() == 0)
            {
                Lookups lookupGendeMale = new Lookups()
                {
                    Code = string.Concat("014", "001"),
                    LookupTypeId = "014",
                    LookupId = "001",
                    LookupNameEn = "Male",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupGendeFeMale = new Lookups()
                {
                    Code = string.Concat("014", "002"),
                    LookupTypeId = "014",
                    LookupId = "002",
                    LookupNameEn = "FeMale",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                
               

                _LookupService.Insert(lookupGendeMale);
                _LookupService.Insert(lookupGendeFeMale);
              
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.ActiveStatus_015).Count() == 0)
            {
                Lookups lookupActiveStatusActive = new Lookups()
                {
                    Code = string.Concat("015", "001"),
                    LookupTypeId = "015",
                    LookupId = "001",
                    LookupNameEn = "Active",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupActiveStatusInActive = new Lookups()
                {
                    Code = string.Concat("015", "002"),
                    LookupTypeId = "015",
                    LookupId = "002",
                    LookupNameEn = "InActive",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupActiveStatusActive);
                _LookupService.Insert(lookupActiveStatusInActive);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.Banks_016).Count() == 0)
            {
                Lookups lookupBanksIslami = new Lookups()
                {
                    Code = string.Concat("016", "001"),
                    LookupTypeId = "016",
                    LookupId = "001",
                    LookupNameEn = "Bank Islami",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupBanksIslami);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.MedicalCompany_017).Count() == 0)
            {
                Lookups lookupMedicalCompanyShifa = new Lookups()
                {
                    Code = string.Concat("017", "001"),
                    LookupTypeId = "017",
                    LookupId = "001",
                    LookupNameEn = "Shifa Pharma",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupMedicalCompanyShifa);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.MedicalClass_018).Count() == 0)
            {
                Lookups lookupMedicalClassClassOne = new Lookups()
                {
                    Code = string.Concat("018", "001"),
                    LookupTypeId = "018",
                    LookupId = "001",
                    LookupNameEn = "Class One",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupMedicalClassClassOne);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.BloodGroup_019).Count() == 0)
            {
                Lookups lookupBloodGroupBPositive = new Lookups()
                {
                    Code = string.Concat("019", "001"),
                    LookupTypeId = "019",
                    LookupId = "001",
                    LookupNameEn = "B+",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupBloodGroupBPositive);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.CalculateIn_020).Count() == 0)
            {
                Lookups lookupCalculate_IN = new Lookups()
                {
                    Code = string.Concat("020", "001"),
                    LookupTypeId = "020",
                    LookupId = "001",
                    LookupNameEn = "Calculate_IN",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupCalculate_IN);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.Languages_021).Count() == 0)
            {
                Lookups lookupLanguages = new Lookups()
                {
                    Code = string.Concat("021", "001"),
                    LookupTypeId = "021",
                    LookupId = "001",
                    LookupNameEn = "Languages",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupLanguages);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.Board_022).Count() == 0)
            {
                Lookups lookupBoard = new Lookups()
                {
                    Code = string.Concat("022", "001"),
                    LookupTypeId = "022",
                    LookupId = "001",
                    LookupNameEn = "Federal",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupBoard);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.RoomsType_023).Count() == 0)
            {
                Lookups lookupRoomsType = new Lookups()
                {
                    Code = string.Concat("023", "001"),
                    LookupTypeId = "023",
                    LookupId = "001",
                    LookupNameEn = "Furnished",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupRoomsType);
            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.CourseType_024).Count() == 0)
            {
                Lookups lookupCourseType = new Lookups()
                {
                    Code = string.Concat("024", "001"),
                    LookupTypeId = "024",
                    LookupId = "001",
                    LookupNameEn = "General Elective",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupMajor = new Lookups()
                {
                    Code = string.Concat("024", "002"),
                    LookupTypeId = "024",
                    LookupId = "002",
                    LookupNameEn = "Major Elective",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                

                _LookupService.Insert(lookupCourseType);
                _LookupService.Insert(lookupMajor);
                

            }
           

            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.POSITION_TYPE_025).Count() == 0)
            {
                Lookups lookupEntryLevel = new Lookups()
                {
                    Code = string.Concat("025", "001"),
                    LookupTypeId = "025",
                    LookupId = "001",
                    LookupNameEn = "Entry Level",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupMidLevel = new Lookups()
                {
                    Code = string.Concat("025", "002"),
                    LookupTypeId = "025",
                    LookupId = "002",
                    LookupNameEn = "Mid-Level",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupHighLevel = new Lookups()
                {
                    Code = string.Concat("025", "003"),
                    LookupTypeId = "025",
                    LookupId = "003",
                    LookupNameEn = "High Level",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupManagerial = new Lookups()
                {
                    Code = string.Concat("025", "004"),
                    LookupTypeId = "025",
                    LookupId = "004",
                    LookupNameEn = "Managerial",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                _LookupService.Insert(lookupEntryLevel);
                _LookupService.Insert(lookupMidLevel);
                _LookupService.Insert(lookupHighLevel);
                _LookupService.Insert(lookupManagerial);

            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.ALLOWANCE_TYPE_026).Count() == 0)
            {
                Lookups lookupBasicSalary = new Lookups()
                {
                    Code = string.Concat("026", "001"),
                    LookupTypeId = "026",
                    LookupId = "001",
                    LookupNameEn = "Basic Salary",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupHousing = new Lookups()
                {
                    Code = string.Concat("026", "002"),
                    LookupTypeId = "026",
                    LookupId = "002",
                    LookupNameEn = "Housing",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupTransportAllowance = new Lookups()
                {
                    Code = string.Concat("026", "003"),
                    LookupTypeId = "026",
                    LookupId = "003",
                    LookupNameEn = "Transport Allowance",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupFoodAllowance = new Lookups()
                {
                    Code = string.Concat("026", "004"),
                    LookupTypeId = "026",
                    LookupId = "004",
                    LookupNameEn = "Food Allowance",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupOtherAllowance = new Lookups()
                {
                    Code = string.Concat("026", "005"),
                    LookupTypeId = "026",
                    LookupId = "005",
                    LookupNameEn = "Other Allowance",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupLeavePay = new Lookups()
                {
                    Code = string.Concat("026", "006"),
                    LookupTypeId = "026",
                    LookupId = "006",
                    LookupNameEn = " Leave Pay",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupIndemnity = new Lookups()
                {
                    Code = string.Concat("026", "007"),
                    LookupTypeId = "026",
                    LookupId = "007",
                    LookupNameEn = "Indemnity",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupBasicSalary);
                _LookupService.Insert(lookupHousing);
                _LookupService.Insert(lookupTransportAllowance);
                _LookupService.Insert(lookupFoodAllowance);
                _LookupService.Insert(lookupOtherAllowance);
                _LookupService.Insert(lookupLeavePay);
                _LookupService.Insert(lookupIndemnity);

            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.CONTRACT_STATUS_027).Count() == 0)
            {
                Lookups lookupSingle = new Lookups()
                {
                    Code = string.Concat("027", "001"),
                    LookupTypeId = "027",
                    LookupId = "001",
                    LookupNameEn = " Single",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupFamily = new Lookups()
                {
                    Code = string.Concat("027", "002"),
                    LookupTypeId = "027",
                    LookupId = "002",
                    LookupNameEn = "Family",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupSingle);
                _LookupService.Insert(lookupFamily);

            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.State_028).Count() == 0)
            {
                Lookups lookupState = new Lookups()
                {
                    Code = string.Concat("028", "001"),
                    LookupTypeId = "027",
                    LookupId = "001",
                    LookupNameEn = " Federal",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupState);

            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.HousingPaymentType_029).Count() == 0)
            {
                Lookups lookupBank = new Lookups()
                {
                    Code = string.Concat("029", "001"),
                    LookupTypeId = "029",
                    LookupId = "001",
                    LookupNameEn = "Bank",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupBank);

            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.AdmissionDocumentType_030).Count() == 0)
            {
                Lookups lookupIDphoto = new Lookups()
                {
                    Code = string.Concat("030", "001"),
                    LookupTypeId = "030",
                    LookupId = "001",
                    LookupNameEn = "ID photo",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                Lookups lookupOfficialphoto= new Lookups()
                {
                    Code = string.Concat("030", "002"),
                    LookupTypeId = "030",
                    LookupId = "002",
                    LookupNameEn = "Official photo (size 4 * 6)",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookuppassport = new Lookups()
                {
                    Code = string.Concat("030", "003"),
                    LookupTypeId = "030",
                    LookupId = "003",
                    LookupNameEn = "A copy of the passport, if any",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupHighSchoolcertificate= new Lookups()
                {
                    Code = string.Concat("030", "004"),
                    LookupTypeId = "030",
                    LookupId = "004",
                    LookupNameEn = "High School certificate",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupAptitudetestresult = new Lookups()
                {
                    Code = string.Concat("030", "005"),
                    LookupTypeId = "030",
                    LookupId = "005",
                    LookupNameEn = "Aptitude test result",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupAchievementtestresult= new Lookups()
                {
                    Code = string.Concat("030", "006"),
                    LookupTypeId = "030",
                    LookupId = "006",
                    LookupNameEn = "Achievement test result	",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupCertifiedtranscript= new Lookups()
                {
                    Code = string.Concat("030", "007"),
                    LookupTypeId = "030",
                    LookupId = "007",
                    LookupNameEn = "Certified transcript",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupIDphoto);
                _LookupService.Insert(lookupOfficialphoto);
                _LookupService.Insert(lookuppassport);
                _LookupService.Insert(lookupHighSchoolcertificate);
                _LookupService.Insert(lookupAptitudetestresult);
                _LookupService.Insert(lookupAchievementtestresult);
                _LookupService.Insert(lookupCertifiedtranscript);


            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.AdmissionFormStatus_031).Count() == 0)
            {
                Lookups lookupApplied = new Lookups()
                {
                    Code = string.Concat("031", "001"),
                    LookupTypeId = "031",
                    LookupId = "001",
                    LookupNameEn = "Applied",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupInitialAdmit = new Lookups()
                {
                    Code = string.Concat("031", "002"),
                    LookupTypeId = "031",
                    LookupId = "002",
                    LookupNameEn = "Initial Admit",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupFinalAdmit = new Lookups()
                {
                    Code = string.Concat("031", "003"),
                    LookupTypeId = "031",
                    LookupId = "003",
                    LookupNameEn = "Final Admit",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupInitialRejected = new Lookups()
                {
                    Code = string.Concat("031", "004"),
                    LookupTypeId = "031",
                    LookupId = "004",
                    LookupNameEn = "Initial Rejected",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupFinalRejected = new Lookups()
                {
                    Code = string.Concat("031", "005"),
                    LookupTypeId = "031",
                    LookupId = "005",
                    LookupNameEn = "Final Rejected",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupApplied);
                _LookupService.Insert(lookupInitialAdmit);
                _LookupService.Insert(lookupFinalAdmit);
                _LookupService.Insert(lookupInitialRejected);
                _LookupService.Insert(lookupFinalRejected);


            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.LeaveType_032).Count() == 0)
            {
                Lookups lookupStraightLine = new Lookups()
                {
                    Code = string.Concat("032", "001"),
                    LookupTypeId = "032",
                    LookupId = "001",
                    LookupNameEn = "Sick Leave",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupAnnualLeave = new Lookups()
                {
                    Code = string.Concat("032", "002"),
                    LookupTypeId = "032",
                    LookupId = "002",
                    LookupNameEn = "Annual Leave",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupSpecialLeave = new Lookups()
                {
                    Code = string.Concat("032", "003"),
                    LookupTypeId = "032",
                    LookupId = "003",
                    LookupNameEn = "Special Leave",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupEmergencyLeave = new Lookups()
                {
                    Code = string.Concat("032", "004"),
                    LookupTypeId = "032",
                    LookupId = "004",
                    LookupNameEn = "Emergency Leave",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupBusinessLeave = new Lookups()
                {
                    Code = string.Concat("032", "005"),
                    LookupTypeId = "032",
                    LookupId = "005",
                    LookupNameEn = "Business Leave",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                _LookupService.Insert(lookupStraightLine);
                _LookupService.Insert(lookupAnnualLeave);
                _LookupService.Insert(lookupSpecialLeave);
                _LookupService.Insert(lookupEmergencyLeave);
                _LookupService.Insert(lookupBusinessLeave);


            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.Loan_Type_033).Count() == 0)
            {
                Lookups lookupStraightLine = new Lookups()
                {
                    Code = string.Concat("033", "001"),
                    LookupTypeId = "032",
                    LookupId = "001",
                    LookupNameEn = "Car Loan",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                _LookupService.Insert(lookupStraightLine);


            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.DepreciationMethod_034).Count() == 0)
            {
                Lookups lookupStraightLine = new Lookups()
                {
                    Code = string.Concat("034", "001"),
                    LookupTypeId = "034",
                    LookupId = "001",
                    LookupNameEn = "Straight-Line",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupUOP = new Lookups()
                {
                    Code = string.Concat("034", "002"),
                    LookupTypeId = "034",
                    LookupId = "002",
                    LookupNameEn = "Units of Production",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupStraightLine);
                _LookupService.Insert(lookupUOP);


            }


            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.AverageMethod_035).Count() == 0)
            {
                Lookups lookupTestMethod1 = new Lookups()
                {
                    Code = string.Concat("035", "001"),
                    LookupTypeId = "035",
                    LookupId = "001",
                    LookupNameEn = "Test Method 1",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupTestMethod1);


            }

            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.AssetType_036).Count() == 0)
            {
                Lookups lookupVehicles = new Lookups()
                {
                    Code = string.Concat("036", "001"),
                    LookupTypeId = "036",
                    LookupId = "001",
                    LookupNameEn = "Vehicles",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupFurniture = new Lookups()
                {
                    Code = string.Concat("036", "002"),
                    LookupTypeId = "036",
                    LookupId = "002",
                    LookupNameEn = "Furniture",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupVehicles);
                _LookupService.Insert(lookupFurniture);


            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.AssetType_036).Count() == 0)
            {

                Lookups lookupPending = new Lookups()
                {
                    Code = string.Concat("037", "001"),
                    LookupTypeId = "037",
                    LookupId = "001",
                    LookupNameEn = "Pending",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };


                _LookupService.Insert(lookupPending);


            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.Relationship_039).Count() == 0)
            {

                Lookups lookupSibling = new Lookups()
                {
                    Code = string.Concat("039", "001"),
                    LookupTypeId = "039",
                    LookupId = "001",
                    LookupNameEn = "Sibling",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };


                Lookups lookupSon = new Lookups()
                {
                    Code = string.Concat("039", "002"),
                    LookupTypeId = "039",
                    LookupId = "002",
                    LookupNameEn = "Son",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupDaughter = new Lookups()
                {
                    Code = string.Concat("039", "003"),
                    LookupTypeId = "039",
                    LookupId = "003",
                    LookupNameEn = "Daughter",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupSibling);
                _LookupService.Insert(lookupSon);
                _LookupService.Insert(lookupDaughter);

            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.CourseEnrollStatus_040).Count() == 0)
            {

                Lookups lookupCourseRegistered = new Lookups()
                {
                    Code = string.Concat("040", "001"),
                    LookupTypeId = "040",
                    LookupId = "001",
                    LookupNameEn = "Registered",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };


                Lookups lookupWithdrawCourse = new Lookups()
                {
                    Code = string.Concat("040", "002"),
                    LookupTypeId = "040",
                    LookupId = "002",
                    LookupNameEn = "Withdraw",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupDropCourse = new Lookups()
                {
                    Code = string.Concat("040", "003"),
                    LookupTypeId = "040",
                    LookupId = "003",
                    LookupNameEn = "Drop",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupSwapCourse = new Lookups()
                {
                    Code = string.Concat("040", "004"),
                    LookupTypeId = "040",
                    LookupId = "004",
                    LookupNameEn = "Swap",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };

                _LookupService.Insert(lookupCourseRegistered);
                _LookupService.Insert(lookupWithdrawCourse);
                _LookupService.Insert(lookupDropCourse);
                _LookupService.Insert(lookupSwapCourse);

            }
            if (lookUps.Where(x => x.LookupTypeId == LookupTypList.AttendanceTypeNavigation_041).Count() == 0)
            {

                Lookups lookupPresent = new Lookups()
                {
                    Code = string.Concat("041", "001"),
                    LookupTypeId = "041",
                    LookupId = "001",
                    LookupNameEn = "Present",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };


                Lookups lookupAbsent = new Lookups()
                {
                    Code = string.Concat("041", "002"),
                    LookupTypeId = "041",
                    LookupId = "002",
                    LookupNameEn = "Absent",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };
                Lookups lookupLeave = new Lookups()
                {
                    Code = string.Concat("041", "003"),
                    LookupTypeId = "041",
                    LookupId = "003",
                    LookupNameEn = "Leave",
                    LookupNameAr = "",
                    Abbreviation = null,
                    ParentCode = null,
                    ActiveStatus = true,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = null

                };


                _LookupService.Insert(lookupPresent);
                _LookupService.Insert(lookupAbsent);
                _LookupService.Insert(lookupLeave);
                if (lookUps.Where(x => x.LookupTypeId == LookupTypList.RequestType_042).Count() == 0)
                {

                    Lookups lookupLeaveRequest = new Lookups()
                    {
                        Code = string.Concat("042", "001"),
                        LookupTypeId = "042",
                        LookupId = "001",
                        LookupNameEn = "Leave Request",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null

                    };


                    Lookups lookupLoanRequest = new Lookups()
                    {
                        Code = string.Concat("042", "002"),
                        LookupTypeId = "042",
                        LookupId = "002",
                        LookupNameEn = "Loan Request",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null,


                    };


                    _LookupService.Insert(lookupLeaveRequest);
                    _LookupService.Insert(lookupLoanRequest);

                }
                if (lookUps.Where(x => x.LookupTypeId == LookupTypList.Student_Status_046).Count() == 0)
                {

                    Lookups lookupApplicant= new Lookups()
                    {
                        Code = string.Concat("046", "001"),
                        LookupTypeId = "046",
                        LookupId = "001",
                        LookupNameEn = "Applicant",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null

                    };


                    Lookups lookupActive = new Lookups()
                    {
                        Code = string.Concat("046", "002"),
                        LookupTypeId = "046",
                        LookupId = "002",
                        LookupNameEn = "Active",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null,


                    };
                    Lookups lookupPostPoned = new Lookups()
                    {
                        Code = string.Concat("046", "003"),
                        LookupTypeId = "046",
                        LookupId = "003",
                        LookupNameEn = "Postponed",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null,


                    };
                    Lookups lookupGraduate = new Lookups()
                    {
                        Code = string.Concat("046", "004"),
                        LookupTypeId = "046",
                        LookupId = "004",
                        LookupNameEn = "Graduate",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null,


                    };


                    _LookupService.Insert(lookupApplicant);
                    _LookupService.Insert(lookupActive);
                    _LookupService.Insert(lookupPostPoned);
                    _LookupService.Insert(lookupGraduate);

                }

                if (lookUps.Where(x => x.LookupTypeId == LookupTypList.Std_Letter_Type_047).Count() == 0)
                {

                    Lookups lookupWarning = new Lookups()
                    {
                        Code = string.Concat("047", "001"),
                        LookupTypeId = "047",
                        LookupId = "001",
                        LookupNameEn = "Warning",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null

                    };


                    Lookups lookDisciplinaryaction = new Lookups()
                    {
                        Code = string.Concat("047", "002"),
                        LookupTypeId = "047",
                        LookupId = "002",
                        LookupNameEn = "Disciplinary action",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null,


                    };
                    
                    


                    _LookupService.Insert(lookupWarning);
                    _LookupService.Insert(lookDisciplinaryaction);
                  

                }
                if (lookUps.Where(x => x.LookupTypeId == LookupTypList.STD_FEE_TYPE_048).Count() == 0)
                {

                    Lookups lookupAdmission_Fee = new Lookups()
                    {
                        Code = string.Concat("048", "001"),
                        LookupTypeId = "048",
                        LookupId = "001",
                        LookupNameEn = "Admission_Fee",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null

                    };


                    Lookups lookupCourse_Reg_Fee = new Lookups()
                    {
                        Code = string.Concat("048", "002"),
                        LookupTypeId = "048",
                        LookupId = "002",
                        LookupNameEn = "Course_Reg_Fee",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null,


                    };




                    _LookupService.Insert(lookupAdmission_Fee);
                    _LookupService.Insert(lookupCourse_Reg_Fee);



                }

                if (lookUps.Where(x => x.LookupTypeId == LookupTypList.PAYMENT_MODE_049).Count() == 0)
                {

                    Lookups lookupCreditCard = new Lookups()
                    {
                        Code = string.Concat("049", "001"),
                        LookupTypeId = "049",
                        LookupId = "001",
                        LookupNameEn = "CreditCard",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null

                    };


                    Lookups lookupDebitCard = new Lookups()
                    {
                        Code = string.Concat("049", "002"),
                        LookupTypeId = "049",
                        LookupId = "002",
                        LookupNameEn = "DebitCard",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null,


                    };
                    Lookups lookuponline= new Lookups()
                    {
                        Code = string.Concat("049", "003"),
                        LookupTypeId = "049",
                        LookupId = "003",
                        LookupNameEn = "Online",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null,


                    };
                    Lookups lookupcampus= new Lookups()
                    {
                        Code = string.Concat("049", "004"),
                        LookupTypeId = "049",
                        LookupId = "004",
                        LookupNameEn = "Campus",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null,


                    };



                    _LookupService.Insert(lookupCreditCard);
                    _LookupService.Insert(lookupDebitCard);
                    _LookupService.Insert(lookuponline);
                    _LookupService.Insert(lookupcampus);
                    


                }
                if (lookUps.Where(x => x.LookupTypeId == LookupTypList.CurrentQualification_050).Count() == 0)
                {

                    Lookups lookupHighSchool = new Lookups()
                    {
                        Code = string.Concat("050", "001"),
                        LookupTypeId = "050",
                        LookupId = "001",
                        LookupNameEn = "Holding High School",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null

                    };


                    Lookups lookupTransfer = new Lookups()
                    {
                        Code = string.Concat("050", "002"),
                        LookupTypeId = "050",
                        LookupId = "002",
                        LookupNameEn = "Transfer From Another College",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null,


                    };
                    Lookups lookupDiploma = new Lookups()
                    {
                        Code = string.Concat("050", "003"),
                        LookupTypeId = "050",
                        LookupId = "003",
                        LookupNameEn = "Holding Diploma",
                        LookupNameAr = "",
                        Abbreviation = null,
                        ParentCode = null,
                        ActiveStatus = true,
                        CompanyId = null,
                        BranchId = null,
                        PortalId = null,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = null,
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = null,


                    };



                    _LookupService.Insert(lookupHighSchool);
                    _LookupService.Insert(lookupTransfer);
                    _LookupService.Insert(lookupDiploma);



                }

                try
                {
                    _LookupService.SaveChanges();
                }
                catch (Exception ex)
                {


                }

            }
          

        }
        public static void SeedLookTypes(ILookupTypesService _LookupTypeService)
        {
            var lookUpTypeList = _LookupTypeService.GetAll();

            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.Departments_001).Count() == 0)
            {
                LookupTypes lookUpTypeDept = new LookupTypes()
                {
                    LookupTypeId = "001",
                    LookupTypeNameEn = "Departments",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpTypeDept);
            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.RecruitmentJobStatus_002).Count() == 0)
            {
                LookupTypes lookUpTypeJobStatus = new LookupTypes()
                {
                    LookupTypeId = "002",
                    LookupTypeNameEn = "Recruitment Job Status",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpTypeJobStatus);
            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.RecruitmentJobTypes_003).Count() == 0)
            {
                LookupTypes lookUpTypeJobTypes = new LookupTypes()
                {
                    LookupTypeId = "003",
                    LookupTypeNameEn = "Recruitment Job Types",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpTypeJobTypes);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.Country_004).Count() == 0)
            {
                LookupTypes lookUpTypeCountry = new LookupTypes()
                {
                    LookupTypeId = "004",
                    LookupTypeNameEn = "Country",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpTypeCountry);
            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.City_005).Count() == 0)
            {
                LookupTypes lookUpTypeCity = new LookupTypes()
                {
                    LookupTypeId = "005",
                    LookupTypeNameEn = "City",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpTypeCity);
            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.ApplicationSourceType_006).Count() == 0)
            {
                LookupTypes lookUpTypeApplicationSourceType = new LookupTypes()
                {
                    LookupTypeId = "006",
                    LookupTypeNameEn = "ApplicationSourceType",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpTypeApplicationSourceType);
            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.ApplicationStatus_007).Count() == 0)
            {
                LookupTypes lookUpTypeApplicationStatus = new LookupTypes()
                {
                    LookupTypeId = "007",
                    LookupTypeNameEn = "ApplicationStatus",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpTypeApplicationStatus);
            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.Degree_008).Count() == 0)
            {
                LookupTypes lookUpTypeDegree = new LookupTypes()
                {
                    LookupTypeId = "008",
                    LookupTypeNameEn = "Degree",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpTypeDegree);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.OwnerType_009).Count() == 0)
            {
                LookupTypes lookUpTypeOwnerType = new LookupTypes()
                {
                    LookupTypeId = "009",
                    LookupTypeNameEn = "Owner Type",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpTypeOwnerType);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.DocumentTypes_010).Count() == 0)
            {
                LookupTypes lookUpTypeDocumentTypes = new LookupTypes()
                {
                    LookupTypeId = "010",
                    LookupTypeNameEn = "Document Types",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpTypeDocumentTypes);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.MaritalStatus_011).Count() == 0)
            {
                LookupTypes lookUpTypeMaritalStatus = new LookupTypes()
                {
                    LookupTypeId = "011",
                    LookupTypeNameEn = "MaritalStatus",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpTypeMaritalStatus);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.Nationality_012).Count() == 0)
            {
                LookupTypes lookUpTypeNationality = new LookupTypes()
                {
                    LookupTypeId = "012",
                    LookupTypeNameEn = "Nationality",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpTypeNationality);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.Religion_013).Count() == 0)
            {
                LookupTypes lookUpTypeReligion = new LookupTypes()
                {
                    LookupTypeId = "013",
                    LookupTypeNameEn = "Religion",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpTypeReligion);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.Gende_014).Count() == 0)
            {
                LookupTypes lookUpTypeGende = new LookupTypes()
                {
                    LookupTypeId = "014",
                    LookupTypeNameEn = "Gende",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpTypeGende);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.ActiveStatus_015).Count() == 0)
            {
                LookupTypes lookUpActiveStatus = new LookupTypes()
                {
                    LookupTypeId = "015",
                    LookupTypeNameEn = "ActiveStatus",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpActiveStatus);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.Banks_016).Count() == 0)
            {
                LookupTypes lookUpBanks = new LookupTypes()
                {
                    LookupTypeId = "016",
                    LookupTypeNameEn = "Banks",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpBanks);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.MedicalCompany_017).Count() == 0)
            {
                LookupTypes lookUpMedicalCompany = new LookupTypes()
                {
                    LookupTypeId = "017",
                    LookupTypeNameEn = "MedicalCompany",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpMedicalCompany);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.MedicalClass_018).Count() == 0)
            {
                LookupTypes lookUpMedicalClass = new LookupTypes()
                {
                    LookupTypeId = "018",
                    LookupTypeNameEn = "MedicalClass",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpMedicalClass);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.BloodGroup_019).Count() == 0)
            {
                LookupTypes lookUpBloodGroup = new LookupTypes()
                {
                    LookupTypeId = "019",
                    LookupTypeNameEn = "BloodGroup",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpBloodGroup);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.CalculateIn_020).Count() == 0)
            {
                LookupTypes lookUpCalculateIn = new LookupTypes()
                {
                    LookupTypeId = "020",
                    LookupTypeNameEn = "CalculateIn",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpCalculateIn);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.Languages_021).Count() == 0)
            {
                LookupTypes lookUpLanguages = new LookupTypes()
                {
                    LookupTypeId = "021",
                    LookupTypeNameEn = "Languages",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpLanguages);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.Board_022).Count() == 0)
            {
                LookupTypes lookUpBoard = new LookupTypes()
                {
                    LookupTypeId = "022",
                    LookupTypeNameEn = "Board",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpBoard);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.RoomsType_023).Count() == 0)
            {
                LookupTypes lookUpRoomsType = new LookupTypes()
                {
                    LookupTypeId = "023",
                    LookupTypeNameEn = "RoomsType",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpRoomsType);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.CourseType_024).Count() == 0)
            {
                LookupTypes lookUpCourseType = new LookupTypes()
                {
                    LookupTypeId = "024",
                    LookupTypeNameEn = "CourseType",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpCourseType);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.POSITION_TYPE_025).Count() == 0)
            {
                LookupTypes lookUpCourseType = new LookupTypes()
                {
                    LookupTypeId = "025",
                    LookupTypeNameEn = "POSITION_TYPE",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpCourseType);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.ALLOWANCE_TYPE_026).Count() == 0)
            {
                LookupTypes lookUpCourseType = new LookupTypes()
                {
                    LookupTypeId = "026",
                    LookupTypeNameEn = "ALLOWANCE_TYPE",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpCourseType);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.CONTRACT_STATUS_027).Count() == 0)
            {
                LookupTypes lookUpCourseType = new LookupTypes()
                {
                    LookupTypeId = "027",
                    LookupTypeNameEn = "CONTRACT_STATUS",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpCourseType);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.HousingPaymentType_029).Count() == 0)
            {
                LookupTypes HousingPaymentType = new LookupTypes()
                {
                    LookupTypeId = "029",
                    LookupTypeNameEn = "HousingPaymentType",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(HousingPaymentType);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.AdmissionDocumentType_030).Count() == 0)
            {
                LookupTypes AdmissionDocumentType = new LookupTypes()
                {
                    LookupTypeId = "030",
                    LookupTypeNameEn = "AdmissionDocumentType",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(AdmissionDocumentType);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.AdmissionFormStatus_031).Count() == 0)
            {
                LookupTypes AdmissionFormStatus = new LookupTypes()
                {
                    LookupTypeId = "031",
                    LookupTypeNameEn = "AdmissionFormStatus",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(AdmissionFormStatus);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.LeaveType_032).Count() == 0)
            {
                LookupTypes DepreciationMethod = new LookupTypes()
                {
                    LookupTypeId = "032",
                    LookupTypeNameEn = "Leave Type",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(DepreciationMethod);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.Loan_Type_033).Count() == 0)
            {
                LookupTypes DepreciationMethod = new LookupTypes()
                {
                    LookupTypeId = "033",
                    LookupTypeNameEn = "Loan Type",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(DepreciationMethod);

            }

            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.DepreciationMethod_034).Count() == 0)
            {
                LookupTypes DepreciationMethod = new LookupTypes()
                {
                    LookupTypeId = "034",
                    LookupTypeNameEn = "DepreciationMethod",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(DepreciationMethod);

            }


            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.AverageMethod_035).Count() == 0)
            {
                LookupTypes AverageMethod = new LookupTypes()
                {
                    LookupTypeId = "035",
                    LookupTypeNameEn = "AverageMethod",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(AverageMethod);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.AssetType_036).Count() == 0)
            {
                LookupTypes AssetType = new LookupTypes()
                {
                    LookupTypeId = "036",
                    LookupTypeNameEn = "AssetType",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(AssetType);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.Loan_Status_37).Count() == 0)
            {
                LookupTypes AssetType = new LookupTypes()
                {
                    LookupTypeId = "037",
                    LookupTypeNameEn = "Loan Status",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(AssetType);

            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.Relationship_039).Count() == 0)
            {
                LookupTypes lookUpRelationship = new LookupTypes()
                {
                    LookupTypeId = "039",
                    LookupTypeNameEn = "Relationship",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpRelationship);
            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.CourseEnrollStatus_040).Count() == 0)
            {
                LookupTypes lookUpCourseEnrollStatus = new LookupTypes()
                {
                    LookupTypeId = "040",
                    LookupTypeNameEn = "CourseEnrollStatus",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpCourseEnrollStatus);
            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.Student_Status_046).Count() == 0)
            {
                LookupTypes lookUpStudentStatus = new LookupTypes()
                {
                    LookupTypeId = "046",
                    LookupTypeNameEn = "Student Status",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpStudentStatus);
            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.Std_Letter_Type_047).Count() == 0)
            {
                LookupTypes lookUpStudentWarningLetter = new LookupTypes()
                {
                    LookupTypeId = "047",
                    LookupTypeNameEn = "Student Warning Letter",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpStudentWarningLetter);
            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.STD_FEE_TYPE_048).Count() == 0)
            {
                LookupTypes lookUpStudentFeeType = new LookupTypes()
                {
                    LookupTypeId = "048",
                    LookupTypeNameEn = "Student Fee Type",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpStudentFeeType);
            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.PAYMENT_MODE_049).Count() == 0)
            {
                LookupTypes lookUpPaymentMode = new LookupTypes()
                {
                    LookupTypeId = "049",
                    LookupTypeNameEn = "Payment Mode",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpPaymentMode);
            }
            if (lookUpTypeList.Where(x => x.LookupTypeId == LookupTypList.CurrentQualification_050).Count() == 0)
            {
                LookupTypes lookUpCurrentQualification = new LookupTypes()
                {
                    LookupTypeId = "050",
                    LookupTypeNameEn = "Current Qualification",
                    LookupTypeNameAr = "",
                    ActiveStatus = true,
                    Locked = false,
                    CompanyId = null,
                    BranchId = null,
                    PortalId = null,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 0,
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = 0

                };
                _LookupTypeService.Insert(lookUpCurrentQualification);
            }
            try
            {
                _LookupTypeService.SaveChanges();
            }
            catch (Exception ex)
            {

            }


        }
    }
}
