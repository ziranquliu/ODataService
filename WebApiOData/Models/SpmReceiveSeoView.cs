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
    
    public partial class SpmReceiveSeoView
    {
        public long ReceiveId { get; set; }
        public string ReceiveNo { get; set; }
        public string AsnNo { get; set; }
        public string OrderNo { get; set; }
        public string TargetCompanyNo { get; set; }
        public string TargetWmNo { get; set; }
        public string SupplierNum { get; set; }
        public Nullable<System.DateTime> ActualDeliveryTime { get; set; }
        public Nullable<int> ConfirmFlag { get; set; }
        public Nullable<System.DateTime> TransTime { get; set; }
        public Nullable<System.DateTime> ExpectTime { get; set; }
        public string PartNo { get; set; }
        public Nullable<decimal> PartCount { get; set; }
        public Nullable<decimal> ActualPartCount { get; set; }
        public string ConfirmFlagName { get; set; }
        public string NameCn { get; set; }
        public string SupplierName { get; set; }
        public string SupplierType { get; set; }
        public string SupplierTypeName { get; set; }
        public string OrderType { get; set; }
        public string OrderTypeName { get; set; }
    }
}
