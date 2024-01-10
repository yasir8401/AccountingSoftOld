using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class EmailLog
    {
        public int EmailId { get; set; }
        public int? ToUserId { get; set; }
        public string ToEmailOptional { get; set; }
        public string ToEmailMandaotry { get; set; }
        public string FromEmail { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime? EmailDate { get; set; }
        public int? CompanyId { get; set; }
        public int? BranhcId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
