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
    
    public partial class ClmPartsScrapDetailView
    {
        public long Id { get; set; }
        public long DealerId { get; set; }
        public string WarrantyNo { get; set; }
        public string VIN { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public decimal PartQuantity { get; set; }
        public string SupplierNo { get; set; }
        public Nullable<System.DateTime> PartInStock { get; set; }
        public bool IsDeleted { get; set; }
        public int Status { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public Nullable<long> OldPartStockId { get; set; }
        public Nullable<long> PartsScrapId { get; set; }
        public Nullable<decimal> TravelMileage { get; set; }
        public Nullable<System.DateTime> WarrantyStart { get; set; }
        public Nullable<System.DateTime> RepairEnd { get; set; }
        public string OriginPartNo { get; set; }
        public string OriginPartName { get; set; }
    }
}
