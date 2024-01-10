using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class ItemCategories
    {
        public ItemCategories()
        {
            Items = new HashSet<Items>();
        }

        public int ItemCategoryId { get; set; }
        public string ItemCategoryNameEn { get; set; }
        public string ItemCategoryNameAr { get; set; }
        public string ItemCategoryCode { get; set; }
        public int? ParentCategoryId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Items> Items { get; set; }
    }
}
