using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Rooms
    {
        public Rooms()
        {
            ClassesSchedule = new HashSet<ClassesSchedule>();
        }

        public int RoomId { get; set; }
        public string RoomNameEn { get; set; }
        public string RoomNameAr { get; set; }
        public string RoomCode { get; set; }
        public string RoomTypeId { get; set; }
        public int? RoomCapacity { get; set; }
        public int? FloorNumber { get; set; }
        public int BuildingId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Buildings Building { get; set; }
        public virtual ICollection<ClassesSchedule> ClassesSchedule { get; set; }
    }
}
