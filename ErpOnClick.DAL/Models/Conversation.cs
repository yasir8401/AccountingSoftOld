using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Conversation
    {
        public int ConversationId { get; set; }
        public int? VisitorId { get; set; }
        public int? OperatorId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Website { get; set; }
        public string PageName { get; set; }
        public string PageUrl { get; set; }
    }
}
