using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Owner
    {
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string Description { get; set; }
        public string OwnerPosition { get; set; }
        public int? OwnerShares { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CompanyId { get; set; }
        public int? BrancId { get; set; }
    }
}
