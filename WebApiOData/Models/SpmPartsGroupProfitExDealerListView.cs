//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiOData.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SpmPartsGroupProfitExDealerListView
    {
        public long Id { get; set; }
        public string PriceGroup { get; set; }
        public string PartNo { get; set; }
        public Nullable<decimal> BasicPrice { get; set; }
        public Nullable<decimal> DNP { get; set; }
        public Nullable<decimal> MSRP { get; set; }
        public Nullable<decimal> ActualDNP { get; set; }
        public Nullable<decimal> ActualMSRP { get; set; }
        public Nullable<decimal> WDNP { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<long> CustomerGroupId { get; set; }
        public string CustomerGroupName { get; set; }
        public string PartPriceGroupName { get; set; }
        public Nullable<decimal> HostProfit { get; set; }
        public Nullable<decimal> DealerProfit { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string PartName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string VersionNum { get; set; }
        public Nullable<decimal> ARate { get; set; }
        public string TaxRate { get; set; }
    }
}
