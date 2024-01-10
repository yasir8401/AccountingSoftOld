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
using ErpOnClick.DAL.Utilities;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.AspNetCore.Hosting;
using ErpOnClick.Recruitment.Models;

namespace ErpOnClick.Document.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class DocumentController : Controller
    {
        private readonly ILogger<DocumentController> _logger;
        private IDocumentsService _DocumentService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private readonly IDistributedCache _distributedCache;
        public static IWebHostEnvironment _HostEnvironment;

        private dynamic expObj;
        public DocumentController(ILogger<DocumentController> logger, IWebHostEnvironment HostEnvironment, IDistributedCache distributedCache, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IDocumentsService DocumentService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _DocumentService = DocumentService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _distributedCache = distributedCache;
            _HostEnvironment = HostEnvironment;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            var lookupList = _LookupService.GetAll();
            expObj.documentTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.DocumentTypes_010).ToList();
            expObj.ownerTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.OwnerType_009).ToList();

            return View(expObj);
        }

        public IActionResult _list(DocumentSearchBarModel model)
        {
            if (model.DocOwnerType != null)
            {
                    expObj.documentList = _DocumentService.GetAll().Where(c =>
                         (c.DocOwnerType == model.DocOwnerType || model.DocOwnerType == null) ).ToList();
                return PartialView(expObj);
            }
            expObj.documentList = _DocumentService.GetAll().Where(c =>
                               (c.DocType == model.DocType || model.DocType == null)).ToList();


            return PartialView(expObj);
        }



        public async Task<IActionResult> edit(int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.ownerTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.OwnerType_009).ToList();
            expObj.documentTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.DocumentTypes_010).ToList();
            //expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
           
            expObj.documentDetails = _DocumentService.GetById(id);
            if (expObj.documentDetails != null)
            {
                int compnayid = Convert.ToInt32(expObj.documentDetails.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }

            return View(expObj);
        }

     

        [HttpPost]
        public async Task<ActionResult> save(DocumentInheritied postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                var item = _DocumentService.GetById(postedData.DocId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "JobId " + postedData.DocId + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                    var filePath = await FileHandling.UploadFile(_HostEnvironment, postedData.FileToUpload);
                    if (!String.IsNullOrWhiteSpace(filePath))
                    {
                        postedData.DocFile = filePath;
                    }

                    result.msg = _DocumentService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _DocumentService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public async Task<ActionResult>  update(DocumentInheritied postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;
                var filePath = await FileHandling.UploadFile(_HostEnvironment, postedData.FileToUpload);
                if (!String.IsNullOrWhiteSpace(filePath))
                {
                    postedData.DocFile = filePath;
                }

                result.msg = _DocumentService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _DocumentService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            var document = _DocumentService.GetById(Int32.Parse(id));
            if (!String.IsNullOrWhiteSpace(document.DocFile))
            {
                var res = FileHandling.DeleteFile(_HostEnvironment, document.DocFile);
                if (res)
                {
                    _DocumentService.Delete(Int32.Parse(id));
                    result.msg = _DocumentService.SaveChanges();

                }

            }
            else
            {
                result.msg = "File Path Is empty";
            }

            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
