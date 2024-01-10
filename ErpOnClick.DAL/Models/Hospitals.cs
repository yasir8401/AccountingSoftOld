using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Hospitals
    {
        public Hospitals()
        {
            HospitalDept = new HashSet<HospitalDept>();
            HospitalSeats = new HashSet<HospitalSeats>();
            SeatEnroll = new HashSet<SeatEnroll>();
        }

        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string HosptialNameAr { get; set; }
        public string Description { get; set; }
        public string DescriptionAr { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<HospitalDept> HospitalDept { get; set; }
        public virtual ICollection<HospitalSeats> HospitalSeats { get; set; }
        public virtual ICollection<SeatEnroll> SeatEnroll { get; set; }
    }
}
