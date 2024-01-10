using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class FixedAsset
    {
        public int FixedAssetId { get; set; }
        public string FixedAssetNo { get; set; }
        public string FixedAssetEn { get; set; }
        public string FixedAssetAr { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public DateTime? WarrantyExpiry { get; set; }
        public string SerialNo { get; set; }
        public string AssetTypeId { get; set; }
        public string Description { get; set; }
        public DateTime? DepreciationStartDate { get; set; }
        public decimal? CostLimit { get; set; }
        public decimal? ResidualValue { get; set; }
        public string DepreciationMethodId { get; set; }
        public string AverageMethodId { get; set; }
        public decimal? Rate { get; set; }
        public int? EffectiveLifeYears { get; set; }
        public int? AccountId { get; set; }
        public string ActiveStatus { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual Lookups AssetType { get; set; }
        public virtual Lookups AverageMethod { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Lookups DepreciationMethod { get; set; }
    }
}
