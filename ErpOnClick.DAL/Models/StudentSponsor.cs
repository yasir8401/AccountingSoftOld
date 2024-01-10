using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class StudentSponsor
    {
        public int SponsorId { get; set; }
        public string SponsorName { get; set; }
        public string OrganisationName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public int? ContactNo { get; set; }
        public string Email { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CompanyId { get; set; }
        public int? BranhId { get; set; }
    }
}
