using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Customers
    {
        public Customers()
        {
            CreditNotes = new HashSet<CreditNotes>();
            Invoices = new HashSet<Invoices>();
            Receipts = new HashSet<Receipts>();
            Voucher = new HashSet<Voucher>();
        }

        public int CustomerId { get; set; }
        public string CustomerNameEn { get; set; }
        public string CustomerNameAr { get; set; }
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
        public virtual Branch Branch { get; set; }
        public virtual ICollection<CreditNotes> CreditNotes { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
        public virtual ICollection<Receipts> Receipts { get; set; }
        public virtual ICollection<Voucher> Voucher { get; set; }
    }
}
