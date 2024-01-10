using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models
{
    public class EmpDependentInheritied : ErpOnClick.DAL.Models.EmpDependents
    {
        [NotMapped]
        public IFormFile AttachmentFile { get; set; }

        [NotMapped]
        public IFormFile PassportFile { get; set; }
    }
}
