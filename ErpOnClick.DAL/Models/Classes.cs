using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Classes
    {
        public Classes()
        {
            ClassesSchedule = new HashSet<ClassesSchedule>();
            CourseCorrection = new HashSet<CourseCorrection>();
            ExceptionsClassCapacity = new HashSet<ExceptionsClassCapacity>();
            HospitalSeats = new HashSet<HospitalSeats>();
            Quiz = new HashSet<Quiz>();
            SeatEnroll = new HashSet<SeatEnroll>();
            StdEnroll = new HashSet<StdEnroll>();
            StudentAttendance = new HashSet<StudentAttendance>();
        }

        public int ClassId { get; set; }
        public string ClassCode { get; set; }
        public int AcademicYearId { get; set; }
        public int CourseId { get; set; }
        public int? FacultyEmpId { get; set; }
        public int? StudentCapacity { get; set; }
        public string GenderId { get; set; }
        public string Remarks { get; set; }
        public int? AttendanceCount { get; set; }
        public string ClassStatusId { get; set; }
        public string GradeStatusId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? F1Show { get; set; }
        public string F1Title { get; set; }
        public decimal? F1Per { get; set; }
        public decimal? F1GMarks { get; set; }
        public bool? F2Show { get; set; }
        public string F2Title { get; set; }
        public decimal? F2Per { get; set; }
        public decimal? F2GMarks { get; set; }
        public bool? F3Show { get; set; }
        public string F3Title { get; set; }
        public decimal? F3Per { get; set; }
        public decimal? F3GMarks { get; set; }
        public bool? F4Show { get; set; }
        public string F4Title { get; set; }
        public decimal? F4Per { get; set; }
        public decimal? F4GMarks { get; set; }
        public bool? F5Show { get; set; }
        public string F5Title { get; set; }
        public decimal? F5Per { get; set; }
        public decimal? F5GMarks { get; set; }
        public bool? F6Show { get; set; }
        public string F6Title { get; set; }
        public decimal? F6Per { get; set; }
        public decimal? F6GMarks { get; set; }
        public bool? F7Show { get; set; }
        public string F7Title { get; set; }
        public decimal? F7Per { get; set; }
        public decimal? F7GMarks { get; set; }
        public bool? F8Show { get; set; }
        public string F8Title { get; set; }
        public decimal? F8Per { get; set; }
        public decimal? F8GMarks { get; set; }
        public bool? F9Show { get; set; }
        public string F9Title { get; set; }
        public decimal? F9Per { get; set; }
        public decimal? F9GMarks { get; set; }
        public bool? F10Show { get; set; }
        public string F10Title { get; set; }
        public decimal? F10Per { get; set; }
        public decimal? F10GMarks { get; set; }
        public decimal? TotalPer { get; set; }
        public decimal? TotalGMarks { get; set; }
        public int? UserIdFaculty { get; set; }
        public int? AttendanePercentage { get; set; }
        public string DepartmentId { get; set; }
        public string CourseSpecification { get; set; }
        public string CourseDesc { get; set; }

        public virtual AcademicYears AcademicYear { get; set; }
        public virtual Course Course { get; set; }
        public virtual Users UserIdFacultyNavigation { get; set; }
        public virtual ICollection<ClassesSchedule> ClassesSchedule { get; set; }
        public virtual ICollection<CourseCorrection> CourseCorrection { get; set; }
        public virtual ICollection<ExceptionsClassCapacity> ExceptionsClassCapacity { get; set; }
        public virtual ICollection<HospitalSeats> HospitalSeats { get; set; }
        public virtual ICollection<Quiz> Quiz { get; set; }
        public virtual ICollection<SeatEnroll> SeatEnroll { get; set; }
        public virtual ICollection<StdEnroll> StdEnroll { get; set; }
        public virtual ICollection<StudentAttendance> StudentAttendance { get; set; }
    }
}
