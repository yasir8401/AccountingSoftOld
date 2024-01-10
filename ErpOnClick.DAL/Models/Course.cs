using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Course
    {
        public Course()
        {
            Books = new HashSet<Books>();
            Classes = new HashSet<Classes>();
            Evaluation = new HashSet<Evaluation>();
            FeeVouchersLines = new HashSet<FeeVouchersLines>();
            PlanCourses = new HashSet<PlanCourses>();
            StdEnroll = new HashSet<StdEnroll>();
            ZoomMeeting = new HashSet<ZoomMeeting>();
        }

        public int CourseId { get; set; }
        public string CourseDept { get; set; }
        public int? CourseNo { get; set; }
        public int? CourseVer { get; set; }
        public string CourseCode { get; set; }
        public string CourseNameEn { get; set; }
        public string CourseNameAr { get; set; }
        public string CourseDescEn { get; set; }
        public string CourseDescAr { get; set; }
        public int? CourseUnit { get; set; }
        public string CourseStatus { get; set; }
        public int? CampusId { get; set; }
        public int? MajorId { get; set; }
        public decimal? CourseFee { get; set; }
        public int? DiscountId { get; set; }
        public int? CourseScoreId { get; set; }
        public DateTime? CourseImplementationDate { get; set; }
        public string CourseTypeId { get; set; }
        public string CourseSpecification { get; set; }
        public string DepartmentId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string CourseDetailId { get; set; }

        public virtual CourseScore CourseScore { get; set; }
        public virtual Major Major { get; set; }
        public virtual ICollection<Books> Books { get; set; }
        public virtual ICollection<Classes> Classes { get; set; }
        public virtual ICollection<Evaluation> Evaluation { get; set; }
        public virtual ICollection<FeeVouchersLines> FeeVouchersLines { get; set; }
        public virtual ICollection<PlanCourses> PlanCourses { get; set; }
        public virtual ICollection<StdEnroll> StdEnroll { get; set; }
        public virtual ICollection<ZoomMeeting> ZoomMeeting { get; set; }
    }
}
