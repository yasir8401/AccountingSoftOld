using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Banks
    {
        public Banks()
        {
            FeeVouchers = new HashSet<FeeVouchers>();
        }

        public int BankId { get; set; }
        public string BankNameEn { get; set; }
        public string BankNameAr { get; set; }
        public int? AccountId { get; set; }
        public string PrimaryPerson { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string MobileNo { get; set; }
        public string Skype { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string CompanyRegistrationNo { get; set; }
        public string NtnNo { get; set; }
        public string GstNo { get; set; }
        public string ActiveStatus { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual ICollection<FeeVouchers> FeeVouchers { get; set; }
    }
}
