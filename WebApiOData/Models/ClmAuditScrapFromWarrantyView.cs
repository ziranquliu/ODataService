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
    
    public partial class ClmAuditScrapFromWarrantyView
    {
        public string ScrapNo { get; set; }
        public string WarrantyNo { get; set; }
        public string VIN { get; set; }
        public Nullable<decimal> TravelMileage { get; set; }
        public Nullable<System.DateTime> WarrantyStart { get; set; }
        public Nullable<System.DateTime> RepairEnd { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public decimal PartQuantity { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Comments { get; set; }
        public bool Cutable { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public Nullable<long> Id { get; set; }
        public long PartId { get; set; }
        public Nullable<System.DateTime> BalanceOn { get; set; }
        public Nullable<int> IsBalance { get; set; }
    }
}
