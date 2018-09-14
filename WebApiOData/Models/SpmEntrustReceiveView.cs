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
    
    public partial class SpmEntrustReceiveView
    {
        public long ReceiveId { get; set; }
        public string ReceiveNo { get; set; }
        public string AsnNo { get; set; }
        public string OrderNo { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string ZoneNo { get; set; }
        public string TargetCompanyNo { get; set; }
        public string TargetWmNo { get; set; }
        public string TargetZoneNo { get; set; }
        public Nullable<int> ReceiveType { get; set; }
        public Nullable<System.DateTime> ExpectTime { get; set; }
        public Nullable<System.DateTime> SendTime { get; set; }
        public Nullable<System.DateTime> TransTime { get; set; }
        public Nullable<System.DateTime> ActualDeliveryTime { get; set; }
        public string SupplierNum { get; set; }
        public string SupplierName { get; set; }
        public string TransSupplierNum { get; set; }
        public Nullable<long> SupplierType { get; set; }
        public Nullable<int> ConfirmFlag { get; set; }
        public Nullable<long> BookKeeper { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string StatusStr { get; set; }
        public string CompanyName { get; set; }
        public string WmName { get; set; }
        public string ZoneName { get; set; }
        public int DetailCount { get; set; }
    }
}