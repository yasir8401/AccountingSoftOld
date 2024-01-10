using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class VacationProfiles
    {
        public int VacationProfileId { get; set; }
        public string VacationProfileNameEn { get; set; }
        public string VacationProfileNameAr { get; set; }
        public string VacationProfileCode { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
