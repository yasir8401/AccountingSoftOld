using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class PlanMain
    {
        public PlanMain()
        {
            PlanCourses = new HashSet<PlanCourses>();
        }

        public int PlanId { get; set; }
        public string PlanTitleEn { get; set; }
        public string PlanTitleAr { get; set; }
        public string PlanDescriptionEn { get; set; }
        public string PlanDescriptionAr { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? MajorId { get; set; }

        public virtual ICollection<PlanCourses> PlanCourses { get; set; }
    }
}
