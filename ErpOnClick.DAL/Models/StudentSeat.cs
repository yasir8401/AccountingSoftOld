using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class StudentSeat
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? SeatId { get; set; }
        public string Status { get; set; }
        public DateTime? Date { get; set; }
        public string DepartmentId { get; set; }
        public int? HosptialId { get; set; }

        public virtual HospitalSeats Seat { get; set; }
    }
}
