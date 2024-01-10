using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class EmpPreviousexperience
    {
        public int EmpPrevExperienceId { get; set; }
        public int EmpId { get; set; }
        public string JobTitle { get; set; }
        public string EducationalInstitute { get; set; }
        public string Country { get; set; }
        public string College { get; set; }
        public DateTime? WorkStartDate { get; set; }
        public DateTime? WorkEndDate { get; set; }
        public string FunctionalTask { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Emp Emp { get; set; }
    }
}
