using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Buildings
    {
        public Buildings()
        {
            Campus = new HashSet<Campus>();
            Rooms = new HashSet<Rooms>();
        }

        public int BuildingId { get; set; }
        public string BuildingNameEn { get; set; }
        public string BuildingNameAr { get; set; }
        public string BuildingCode { get; set; }
        public string CountryId { get; set; }
        public string CityId { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Campus> Campus { get; set; }
        public virtual ICollection<Rooms> Rooms { get; set; }
    }
}
