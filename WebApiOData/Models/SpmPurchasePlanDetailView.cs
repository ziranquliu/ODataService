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
    
    public partial class SpmPurchasePlanDetailView
    {
        public long Id { get; set; }
        public string PurchaseCode { get; set; }
        public string PartNo { get; set; }
        public string PartCname { get; set; }
        public string ModelSize { get; set; }
        public string Unit { get; set; }
        public decimal Quantity { get; set; }
        public Nullable<System.DateTime> ArrivalDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Currency { get; set; }
        public decimal AveragePrice { get; set; }
        public Nullable<bool> IsValid { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string VIN { get; set; }
        public string ItemNo { get; set; }
        public string ItemNote { get; set; }
    }
}
