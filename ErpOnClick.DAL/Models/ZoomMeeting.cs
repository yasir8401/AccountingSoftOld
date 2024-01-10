using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class ZoomMeeting
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string ZoomMeetingId { get; set; }
        public int FacultyId { get; set; }
        public string StartUrl { get; set; }
        public DateTime? MeetingStartTime { get; set; }
        public DateTime? MeetingDate { get; set; }
        public string Topic { get; set; }
        public int? Type { get; set; }
        public int? Duration { get; set; }
        public string Timezone { get; set; }
        public string Password { get; set; }
        public string Agenda { get; set; }
        public string JoinUrl { get; set; }
        public bool? EnableHostVideo { get; set; }
        public bool? EnablePartiipantVideo { get; set; }
        public bool? EnableChinaHost { get; set; }
        public bool? EnableIndiaHost { get; set; }
        public bool? EnableJoinBeforeHost { get; set; }
        public bool? EnableMuteOnEntry { get; set; }
        public int? ApprovalTyoe { get; set; }
        public int? AutoRecording { get; set; }
        public bool? EnableForceLogin { get; set; }
        public int? MeetingType { get; set; }

        public virtual Course Course { get; set; }
        public virtual Users Faculty { get; set; }
    }
}
