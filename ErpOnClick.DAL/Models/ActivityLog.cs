using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class ActivityLog
    {
        public int ActivityLogId { get; set; }
        public DateTime? LogDate { get; set; }
        public int UserId { get; set; }
        public string UserIp { get; set; }
        public int? ModuleId { get; set; }
        public int? NavigationId { get; set; }
        public int? RefId { get; set; }
        public string LogType { get; set; }
        public string LogDetail { get; set; }
        public string Remarks { get; set; }

        public virtual Lookups LogTypeNavigation { get; set; }
        public virtual Modules Module { get; set; }
        public virtual Navigations Navigation { get; set; }
        public virtual Users User { get; set; }
    }
}
