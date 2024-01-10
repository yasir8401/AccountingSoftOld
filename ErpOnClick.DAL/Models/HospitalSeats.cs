using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class HospitalSeats
    {
        public HospitalSeats()
        {
            SeatEnroll = new HashSet<SeatEnroll>();
            StudentSeat = new HashSet<StudentSeat>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
        public int HospitalId { get; set; }
        public int TotalSeats { get; set; }
        public int? AvailableSeats { get; set; }
        public DateTime? Date { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? ClassId { get; set; }

        public virtual Classes Class { get; set; }
        public virtual HospitalDept Dept { get; set; }
        public virtual Hospitals Hospital { get; set; }
        public virtual ICollection<SeatEnroll> SeatEnroll { get; set; }
        public virtual ICollection<StudentSeat> StudentSeat { get; set; }
    }
}
