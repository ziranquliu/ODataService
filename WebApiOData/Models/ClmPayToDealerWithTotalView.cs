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
    
    public partial class ClmPayToDealerWithTotalView
    {
        public long Id { get; set; }
        public long PayId { get; set; }
        public long WarrantyId { get; set; }
        public string VIN { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string UnitPrice { get; set; }
        public string TotalAmount { get; set; }
        public string ReplyQuantity { get; set; }
        public string ReplyUnitPrice { get; set; }
        public string ReplyRate { get; set; }
        public string PartsHandingCosts { get; set; }
        public string CostType { get; set; }
        public int IsDeleted { get; set; }
        public string Currency { get; set; }
        public Nullable<long> DealerId { get; set; }
        public string DealerCode { get; set; }
        public string DealerName { get; set; }
        public string PayNo { get; set; }
        public Nullable<System.DateTime> PayCreatedOn { get; set; }
        public string WarrantyNo { get; set; }
        public Nullable<int> WarrantyType { get; set; }
        public int type { get; set; }
        public Nullable<decimal> ReplyTotalAmount { get; set; }
        public string Comments { get; set; }
        public long DealerRebateId { get; set; }
        public string Subject { get; set; }
        public Nullable<decimal> Account { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public string Department { get; set; }
        public Nullable<int> PaymentType { get; set; }
        public string PaymentTypeName { get; set; }
        public string Culture { get; set; }
    }
}
