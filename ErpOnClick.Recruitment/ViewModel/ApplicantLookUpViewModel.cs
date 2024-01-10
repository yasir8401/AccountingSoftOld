using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.Recruitment.ViewModel
{
    public class ApplicantLookUpViewModel
    {
        public ErpOnClick.DAL.Models.Applications Application { get; set; }
        public ErpOnClick.DAL.Models.Lookups Lookup { get; set; }
    }
}
