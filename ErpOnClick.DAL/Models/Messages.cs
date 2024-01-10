using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Messages
    {
        public int MessageId { get; set; }
        public int? ConversationId { get; set; }
        public string Message { get; set; }
        public string MessageFrom { get; set; }
        public int? MessageUserId { get; set; }
        public DateTime? MessageDate { get; set; }
    }
}
