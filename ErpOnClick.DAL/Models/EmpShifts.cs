using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class EmpShifts
    {
        public int RecId { get; set; }
        public int? EmpId { get; set; }
        public int? ShiftId { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Emp Emp { get; set; }
        public virtual Shifts Shift { get; set; }
    }
}
