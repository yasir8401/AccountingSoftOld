using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Models
{
    public class AdmissionAttachmentLookupJoin
    {
        public AdmissionFormsAttachments Attach { get; set; }
        public ExceptionsClassCapacity ClassCapacityData { get; set; }
        public ExceptionsCourses ExpCoursesData { get; set; }
        public StudentAttachments StdAttach { get; set; }
        public Students StudentData { get; set; }
        public Lookups User { get; set; }
        public Lookups Nationality { get; set; }
        public Lookups Gender { get; set; }
        public Lookups MaritalStatus { get; set; }
        public Lookups PassportIssued { get; set; }
        public Lookups BloodGroup { get; set; }
        public PlanCourses Plancourse { get; set; }
        public Submissions SubmissionsData { get; set; }
        public Major MajorData { get; set; }
        public MajorType MajorTypeData { get; set; }
        public Course CourseData { get; set; }
        public PlanPrerequisites PlanPre { get; set; }
        public Campus CampusData { get; set; }
        public CourseScore CourseScoreData { get; set; }
        public AcademicYears AcademicYearsData { get; set; }
        public AdmissionForms AdmissionFormsData { get; set; }
        public Semesters SemesterData { get; set; }
        public Classes ClassesData { get; set; }
        public ClassesSchedule ClassesScheduleData { get; set; }
        public Grades GradesData { get; set; }
        public Zoom ZoomData { get; set; }
        public Users UserData { get; set; }
        public StdLetters StdLettersData { get; set; }
        public ExamSchedule ExamScheduleData { get; set; }
        public ExamScheduleLines ExamScheduleLinesData { get; set; }
    }
}
