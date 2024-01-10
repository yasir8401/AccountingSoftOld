using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class BookReturn
    {
        public int ReturnId { get; set; }
        public int BookId { get; set; }
        public int StudentId { get; set; }
        public string Remarks { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }

        public virtual Books Book { get; set; }
        public virtual Students Student { get; set; }
    }
}
