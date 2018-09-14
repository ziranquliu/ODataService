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
    
    public partial class VehSO_20180420_1
    {
        public long Id { get; set; }
        public string SONO { get; set; }
        public long DealerId { get; set; }
        public Nullable<long> DealerWareHouseId { get; set; }
        public string PNO { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public bool IsEmergency { get; set; }
        public bool IsScheduled { get; set; }
        public Nullable<int> PriorityLevel { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<decimal> Price { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<int> CapitalType { get; set; }
        public Nullable<int> From { get; set; }
        public Nullable<long> OemPlace { get; set; }
        public Nullable<bool> PreMatch { get; set; }
        public Nullable<long> VehicleMaterialId { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public Nullable<long> Period { get; set; }
        public Nullable<int> LockStatus { get; set; }
        public string ShippingInStruction { get; set; }
        public Nullable<long> Vehicleuse { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> ReceiptDate { get; set; }
        public Nullable<System.DateTime> SettlementDate { get; set; }
        public Nullable<decimal> SettlementPrice { get; set; }
        public Nullable<long> Bank { get; set; }
        public string BankAcceptance { get; set; }
        public Nullable<int> SoreviewStatus { get; set; }
        public Nullable<int> WSOrderType { get; set; }
        public Nullable<bool> IsHold { get; set; }
        public Nullable<System.DateTime> InstockTime { get; set; }
        public Nullable<System.DateTime> SubmitSuccessfulTime { get; set; }
    }
}
