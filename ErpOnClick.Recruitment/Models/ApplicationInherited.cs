using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.Recruitment.Models
{
    public class ApplicationInherited : Applications
    {
        [NotMapped]
        public IFormFile CVFile { get; set; }
        [NotMapped]
        public IFormFile CoverLetterFile { get; set; }
    }
}
