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
    
    public partial class ClmSupplierRecoveryDetail
    {
        public long Id { get; set; }
        public long WarrantyId { get; set; }
        public decimal ReplyWorksHoursTotalAmount { get; set; }
        public decimal ReplyPartsTotalAmount { get; set; }
        public decimal ReplyOtherTotalAmount { get; set; }
        public decimal ReplyApplyTotalAmount { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> SupplierAmount { get; set; }
        public Nullable<decimal> SupplierPercent { get; set; }
        public Nullable<decimal> FactoryPercent { get; set; }
        public Nullable<decimal> DesignPercent { get; set; }
        public Nullable<decimal> DealerPercent { get; set; }
        public Nullable<decimal> NTFPercent { get; set; }
        public Nullable<decimal> OtherPercent { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string SupplierRecoveryCode { get; set; }
        public decimal FactoryAmount { get; set; }
        public decimal DesignAmount { get; set; }
        public decimal DealerAmount { get; set; }
        public decimal NTFAmount { get; set; }
        public decimal OtherAmount { get; set; }
        public int PercentType { get; set; }
        public int IsBalance { get; set; }
        public Nullable<System.DateTime> BalanceOn { get; set; }
        public Nullable<decimal> ReplyQuanlity { get; set; }
        public Nullable<decimal> ReceiveMoney { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
    }
}