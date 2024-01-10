using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.HumanResource.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class AchievementController : Controller
    {
        private IAchievementService _AchievementService;
        private dynamic expObj;
        public AchievementController(IAchievementService AchievementService)
        {
            _AchievementService = AchievementService;
            expObj = new ExpandoObject();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult _list()
        {
            expObj.AchievementList = _AchievementService.GetAll();

            return PartialView(expObj);
        }
        public IActionResult edit(int id)
        {
            expObj.AchievementDetails = _AchievementService.GetById(id);
            return View(expObj);
        }

        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.Achievement postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                postedData.CreatedDate = System.DateTime.Now;
                postedData.CreatedBy = 0;
                result.msg = _AchievementService.Insert(postedData);
                if (result.msg == "")
                {
                    result.msg = _AchievementService.SaveChanges();

                }
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.Achievement postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;
                result.msg = _AchievementService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _AchievementService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            _AchievementService.Delete(Int32.Parse(id));
            result.msg = _AchievementService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });

        }
    }
}
