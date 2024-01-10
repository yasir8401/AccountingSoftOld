using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Books
    {
        public Books()
        {
            BookBorrow = new HashSet<BookBorrow>();
            BookReturn = new HashSet<BookReturn>();
        }

        public int BookId { get; set; }
        public string BookNameEn { get; set; }
        public string BookNameAr { get; set; }
        public string BookCode { get; set; }
        public int CourseId { get; set; }
        public string AuthorName { get; set; }
        public int? BookLastEditionYear { get; set; }
        public int? TeachingEditionYear { get; set; }
        public string TextbookBoardId { get; set; }
        public string BookLanguageId { get; set; }
        public int? TotalPages { get; set; }
        public DateTime? BookImplementationDate { get; set; }
        public decimal? BookFee { get; set; }
        public int? DiscountId { get; set; }
        public string BookPictureUrl { get; set; }
        public string SoftVersionUrl { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? Quantity { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<BookBorrow> BookBorrow { get; set; }
        public virtual ICollection<BookReturn> BookReturn { get; set; }
    }
}
