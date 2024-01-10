using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class HospitalDept
    {
        public HospitalDept()
        {
            HospitalSeats = new HashSet<HospitalSeats>();
            SeatEnroll = new HashSet<SeatEnroll>();
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public int HospitalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Hospitals Hospital { get; set; }
        public virtual ICollection<HospitalSeats> HospitalSeats { get; set; }
        public virtual ICollection<SeatEnroll> SeatEnroll { get; set; }
    }
}
