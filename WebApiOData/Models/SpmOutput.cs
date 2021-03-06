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
    
    public partial class SpmOutput
    {
        public long OutputId { get; set; }
        public long SoId { get; set; }
        public string OutputNo { get; set; }
        public string PlanNo { get; set; }
        public string SalesNo { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string ZoneNo { get; set; }
        public string TargetCompanyNo { get; set; }
        public string TargetWmNo { get; set; }
        public string TargetZoneNo { get; set; }
        public long ReceiveType { get; set; }
        public System.DateTime ExpectTime { get; set; }
        public Nullable<System.DateTime> SendTime { get; set; }
        public Nullable<System.DateTime> TransTime { get; set; }
        public Nullable<System.DateTime> ActualDeliveryTime { get; set; }
        public string CustomerNum { get; set; }
        public string TransSupplierNum { get; set; }
        public Nullable<long> PartType { get; set; }
        public long DealerType { get; set; }
        public Nullable<long> ConfirmFlag { get; set; }
        public Nullable<int> ErpFlag { get; set; }
        public string Dock { get; set; }
        public string DeliveryLocationNo { get; set; }
        public string DeliveryLocationName { get; set; }
        public string OutputReason { get; set; }
        public string Keeper { get; set; }
        public Nullable<long> BillingFlag { get; set; }
        public Nullable<long> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
    }
}
