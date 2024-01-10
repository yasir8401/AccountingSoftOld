using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Research
    {
        public int ResearchId { get; set; }
        public string TypeScientific { get; set; }
        public string ProductionScientific { get; set; }
        public string ProductionStatusScientific { get; set; }
        public string NatureScientific { get; set; }
        public string FieldScientific { get; set; }
        public string ClassificationScientific { get; set; }
        public string TitleScientificProuctionPublication { get; set; }
        public string DataAuthority { get; set; }
        public string PublishingAuthority { get; set; }
        public string InternationalStandardBook { get; set; }
        public string Journal { get; set; }
        public string NumberJournal { get; set; }
        public string NumberOfPagesPublication { get; set; }
        public string CountryResearch { get; set; }
        public string SummeryResearch { get; set; }
        public string LanguageResearch { get; set; }
        public string PublicationLink { get; set; }
        public string Keywords { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
