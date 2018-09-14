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
    
    public partial class BOView
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string DPurchaseOrder { get; set; }
        public string OrderCode { get; set; }
        public string OrderStatus { get; set; }
        public string OrderType { get; set; }
        public Nullable<int> PartType { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public int RemainPartType { get; set; }
        public decimal RemainQuantity { get; set; }
        public decimal RemainAmount { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public Nullable<long> CreateBy { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> OrderTypeCode { get; set; }
        public Nullable<int> OrderStatusCode { get; set; }
        public string DealerCode { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<int> Status { get; set; }
        public string BoStatusName { get; set; }
        public Nullable<int> PartStatus { get; set; }
        public int PartCancelStatus { get; set; }
        public string PartNo { get; set; }
    }
}