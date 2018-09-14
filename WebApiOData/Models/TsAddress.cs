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
    
    public partial class TsAddress
    {
        public long Id { get; set; }
        public Nullable<long> OrderId { get; set; }
        public string Sender { get; set; }
        public string SenderTelephone { get; set; }
        public string ZipCode { get; set; }
        public Nullable<System.DateTime> SendTime { get; set; }
        public Nullable<int> PayType { get; set; }
        public Nullable<decimal> Money { get; set; }
        public string SendAddress { get; set; }
        public string Company { get; set; }
        public string Num { get; set; }
        public string Comments { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<long> Sequence { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string Currency { get; set; }
        public Nullable<bool> PartsOtherStatus { get; set; }
        public string MaintenanceNO { get; set; }
        public Nullable<bool> PackageStatus { get; set; }
        public Nullable<bool> PartsStatus { get; set; }
        public Nullable<int> AddressType { get; set; }
        public Nullable<System.DateTime> ReceiveTime { get; set; }
        public string ReceiveComment { get; set; }
        public Nullable<int> Type { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Consignee { get; set; }
        public string ConsigneeCode { get; set; }
    }
}