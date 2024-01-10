using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Users
    {
        public Users()
        {
            ActivityLog = new HashSet<ActivityLog>();
            ApprovalRoutes = new HashSet<ApprovalRoutes>();
            Classes = new HashSet<Classes>();
            NotesCreatedByNavigation = new HashSet<Notes>();
            NotesModifiedByNavigation = new HashSet<Notes>();
            UserPrivileges = new HashSet<UserPrivileges>();
            UserRoles = new HashSet<UserRoles>();
            ZoomMeeting = new HashSet<ZoomMeeting>();
        }

        public int UserId { get; set; }
        public string DisplayNameEn { get; set; }
        public string DisplayNameAr { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? EmpId { get; set; }
        public bool? IsEmailConfirmed { get; set; }
        public string PhoneNo { get; set; }
        public bool? IsPhoneNoConfirmed { get; set; }
        public bool? AllowTwoFactorAuth { get; set; }
        public bool? IsLocked { get; set; }
        public bool? IsActive { get; set; }
        public string DepartmentId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Emp Emp { get; set; }
        public virtual ICollection<ActivityLog> ActivityLog { get; set; }
        public virtual ICollection<ApprovalRoutes> ApprovalRoutes { get; set; }
        public virtual ICollection<Classes> Classes { get; set; }
        public virtual ICollection<Notes> NotesCreatedByNavigation { get; set; }
        public virtual ICollection<Notes> NotesModifiedByNavigation { get; set; }
        public virtual ICollection<UserPrivileges> UserPrivileges { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
        public virtual ICollection<ZoomMeeting> ZoomMeeting { get; set; }
    }
}
