using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Annoucment
    {
        public int AnnoucmentId { get; set; }
        public string Title { get; set; }
        public string TitleAr { get; set; }
        public string Description { get; set; }
        public string AnnoucementType { get; set; }
        public DateTime? AnnoucementDate { get; set; }
        public int? AnnoucementFrom { get; set; }
    }
}
