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
    
    public partial class ClmInvoiceNotice
    {
        public long Id { get; set; }
        public long PayId { get; set; }
        public string PayMonth { get; set; }
        public long DealerId { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal InvoiceTaxAmount { get; set; }
        public decimal InvoiceTotalAmount { get; set; }
        public string Currency { get; set; }
        public string InvoiceNo { get; set; }
        public Nullable<int> Status { get; set; }
        public string HostInfo { get; set; }
        public Nullable<System.DateTime> AuditDate { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public int IsPaid { get; set; }
        public Nullable<System.DateTime> PaidOn { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
        public int InvoiceQty { get; set; }
        public decimal TariffRate { get; set; }
    }
}
