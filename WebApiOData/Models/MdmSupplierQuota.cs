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
    
    public partial class MdmSupplierQuota
    {
        public long Id { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string SupplierNo { get; set; }
        public string PurchaseType { get; set; }
        public string PartNo { get; set; }
        public decimal Quota { get; set; }
        public string ContractCode { get; set; }
        public string ContractNote { get; set; }
        public Nullable<System.DateTime> ContractStart { get; set; }
        public Nullable<System.DateTime> ContractEnd { get; set; }
        public Nullable<long> IsAssembly { get; set; }
        public Nullable<long> CrossDocking { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<int> QuotaContractProject { get; set; }
        public string MaterialCode { get; set; }
        public string SpecialPurchaseType { get; set; }
        public string SupplierCName { get; set; }
        public int SupplyPriority { get; set; }
        public Nullable<decimal> MinimumSplit { get; set; }
        public Nullable<decimal> MaximumQuantity { get; set; }
        public Nullable<decimal> MaximumAmount { get; set; }
        public System.DateTime QuotaStart { get; set; }
        public System.DateTime QuotaEnd { get; set; }
    }
}