using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class EmpAddresses
    {
        public int EmpAddressId { get; set; }
        public int? EmpId { get; set; }
        public string CountryId { get; set; }
        public string CityId { get; set; }
        public string ZipCode { get; set; }
        public string PoBox { get; set; }
        public string BuildingNo { get; set; }
        public string StreetName { get; set; }
        public string DistrictName { get; set; }
        public string CityName { get; set; }
        public byte[] PostalCode { get; set; }
        public string AdditionalNo { get; set; }
        public string AppartmentNo { get; set; }
        public string AddressDetail { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public bool? IsPrimary { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string WorkPhoneEx { get; set; }
        public string HomeCountryIdentity { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Emp Emp { get; set; }
    }
}
