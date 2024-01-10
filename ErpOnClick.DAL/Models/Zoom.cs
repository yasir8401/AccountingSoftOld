using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Zoom
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string ZoomMeetingId { get; set; }
        public int FacultyId { get; set; }
        public string StartUrl { get; set; }
        public DateTime? MeetingStartTime { get; set; }
        public DateTime? MeetindDate { get; set; }
        public string Topic { get; set; }
        public int? Type { get; set; }
        public int? Duration { get; set; }
        public string TimeZone { get; set; }
        public string Password { get; set; }
        public string Agenda { get; set; }
        public string JoinUrl { get; set; }
        public bool? EnableHostVideo { get; set; }
        public bool? EnableParticipantVideo { get; set; }
        public bool? EnableJoinBeforeHost { get; set; }
        public bool? EnableMuteOnEntry { get; set; }
        public int? ApprovalType { get; set; }
        public int? AutoRecording { get; set; }
        public bool? EnableForceLogin { get; set; }
        public int? MeetingType { get; set; }
    }
}
