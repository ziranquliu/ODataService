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
    
    public partial class SpmPartsGroupProfitExtendListView
    {
        public string PartNo { get; set; }
        public Nullable<long> Id { get; set; }
        public string PriceGroup { get; set; }
        public string NameCn { get; set; }
        public Nullable<int> PurchAseproperty { get; set; }
        public string PurchAsepropertyName { get; set; }
        public Nullable<decimal> PurchasePrice { get; set; }
        public Nullable<decimal> PlusProfit { get; set; }
        public Nullable<decimal> BasicPrice { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string Comments { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string PriceGroupName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string StatusName { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
