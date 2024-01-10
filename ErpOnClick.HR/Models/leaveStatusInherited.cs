using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models
{
    public class leaveStatusInherited:Leaves
    {
        [NotMapped]
        public IFormFile AttachmentFile { get; set; }
    }
}
