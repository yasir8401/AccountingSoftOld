using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class AddmissionFormsRemarks
    {
        public int Id { get; set; }
        public int? AdmissionFormId { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual AdmissionForms AdmissionForm { get; set; }
    }
}
