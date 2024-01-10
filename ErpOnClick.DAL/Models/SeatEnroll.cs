using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class SeatEnroll
    {
        public int SeatEnrolId { get; set; }
        public int? StudentId { get; set; }
        public int? SeatId { get; set; }
        public int? DeptId { get; set; }
        public int? HospitalId { get; set; }
        public DateTime? Date { get; set; }
        public string EnrolStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? ClassId { get; set; }

        public virtual Classes Class { get; set; }
        public virtual HospitalDept Dept { get; set; }
        public virtual Lookups EnrolStatusNavigation { get; set; }
        public virtual Hospitals Hospital { get; set; }
        public virtual HospitalSeats Seat { get; set; }
        public virtual Students Student { get; set; }
    }
}
