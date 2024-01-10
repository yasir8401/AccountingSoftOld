using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Notes
    {
        public Notes()
        {
            InverseParentNote = new HashSet<Notes>();
        }

        public int NoteId { get; set; }
        public string NoteTitle { get; set; }
        public string NoteDescription { get; set; }
        public int? ParentNoteId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string NoteCode { get; set; }
        public int NoteLevel { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
        public virtual Notes ParentNote { get; set; }
        public virtual ICollection<Notes> InverseParentNote { get; set; }
    }
}
