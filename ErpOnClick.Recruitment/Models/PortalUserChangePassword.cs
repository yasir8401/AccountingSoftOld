using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.Recruitment.Models
{
    public class PortalUserChangePassword:JobPortalUsers
    {
        [NotMapped]
        public string OldPassword { get; set; }
    }
}
