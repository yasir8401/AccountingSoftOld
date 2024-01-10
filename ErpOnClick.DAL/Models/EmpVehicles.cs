using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class EmpVehicles
    {
        public int EmpVehicleId { get; set; }
        public int? EmpId { get; set; }
        public string PlateNo { get; set; }
        public string AssetNo { get; set; }
        public string VehicleDescription { get; set; }
        public DateTime? RegistrationIssueDate { get; set; }
        public DateTime? RegistrationEndDate { get; set; }
        public string Note { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Emp Emp { get; set; }
    }
}
