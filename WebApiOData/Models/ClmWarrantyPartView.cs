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
    
    public partial class ClmWarrantyPartView
    {
        public long Id { get; set; }
        public long DealerId { get; set; }
        public string WarrantyNo { get; set; }
        public string VIN { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public Nullable<System.DateTime> PaidOn { get; set; }
        public Nullable<decimal> TravelMileage { get; set; }
        public Nullable<decimal> TravelMileageEnd { get; set; }
        public Nullable<System.DateTime> WarrantyStart { get; set; }
        public Nullable<System.DateTime> RepairEnd { get; set; }
        public string SupplierNo { get; set; }
        public int IsPaid { get; set; }
        public Nullable<decimal> RestQuantity { get; set; }
        public int StockStatus { get; set; }
        public int HasReturned { get; set; }
    }
}
