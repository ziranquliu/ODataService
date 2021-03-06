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
    
    public partial class SpmStockTransDetailLog
    {
        public long TransId { get; set; }
        public string TransNo { get; set; }
        public string BatchNo { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string ZoneNo { get; set; }
        public string Dloc { get; set; }
        public string TargetCompanyNo { get; set; }
        public string TargetWmNo { get; set; }
        public string TargetZoneNo { get; set; }
        public string TargetDloc { get; set; }
        public Nullable<int> Units { get; set; }
        public Nullable<decimal> PackCount { get; set; }
        public Nullable<decimal> PartCount { get; set; }
        public Nullable<decimal> ActualPartCount { get; set; }
        public string PartNo { get; set; }
        public string PartCname { get; set; }
        public string PartEname { get; set; }
        public Nullable<int> TransState { get; set; }
        public Nullable<System.DateTime> TransDate { get; set; }
        public string SupplierNum { get; set; }
        public Nullable<System.DateTime> ExpectTime { get; set; }
        public Nullable<System.DateTime> SendTime { get; set; }
        public Nullable<System.DateTime> TransTime { get; set; }
        public Nullable<System.DateTime> ActualDeliveryTime { get; set; }
        public string OrderNo { get; set; }
        public string SupplierName { get; set; }
        public string SupplierSname { get; set; }
        public int TransType { get; set; }
        public string BarcodeData { get; set; }
        public string ItemNo { get; set; }
        public string PartType { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string EntryNo { get; set; }
    }
}
