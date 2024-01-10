using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Positions
    {
        public Positions()
        {
            Emp = new HashSet<Emp>();
            InverseParentPosition = new HashSet<Positions>();
        }

        public int PositionId { get; set; }
        public string PositionNameEn { get; set; }
        public string PositionNameAr { get; set; }
        public string PositionCode { get; set; }
        public int? ParentPositionId { get; set; }
        public string PositionTypeId { get; set; }
        public string JobDescription { get; set; }
        public string Responsibilities { get; set; }
        public string SkillsRequired { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Positions ParentPosition { get; set; }
        public virtual ICollection<Emp> Emp { get; set; }
        public virtual ICollection<Positions> InverseParentPosition { get; set; }
    }
}
