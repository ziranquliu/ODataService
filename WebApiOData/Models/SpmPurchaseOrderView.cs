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
    
    public partial class SpmPurchaseOrderView
    {
        public long Id { get; set; }
        public string PurchaseCode { get; set; }
        public string PurchaseType { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public Nullable<System.DateTime> ArrivalDate { get; set; }
        public string Unit { get; set; }
        public string ModelSize { get; set; }
        public decimal TotalQuantity { get; set; }
        public string SupplierNo { get; set; }
        public string PartCname { get; set; }
        public string PartNo { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Quota { get; set; }
        public string VIN { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string Currency { get; set; }
        public string ItemNote { get; set; }
    }
}
