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
    
    public partial class TsArrivalInformation
    {
        public long Id { get; set; }
        public Nullable<long> OrderId { get; set; }
        public Nullable<System.DateTime> ArrivalTime { get; set; }
        public Nullable<System.DateTime> FaultDate { get; set; }
        public Nullable<decimal> Mileage { get; set; }
        public Nullable<decimal> FaultProcess { get; set; }
        public string FaultPhenomenon { get; set; }
        public Nullable<int> FaultType { get; set; }
        public string SuspiciousPartsNo { get; set; }
        public Nullable<bool> CarStatus { get; set; }
        public string SameFaultId { get; set; }
        public Nullable<bool> Similar { get; set; }
        public Nullable<bool> CanReappear { get; set; }
        public Nullable<System.DateTime> LastArrivalTime { get; set; }
        public Nullable<System.DateTime> LastLeaveTime { get; set; }
        public Nullable<decimal> LastMileage { get; set; }
        public Nullable<decimal> LastLeaveMileage { get; set; }
        public string CarModification { get; set; }
        public string FunctionGroup { get; set; }
        public string InfoCSC { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string RunningUnit { get; set; }
        public string FaultUnit { get; set; }
        public string LastUnit { get; set; }
        public string LastLeaveUnit { get; set; }
        public string Company { get; set; }
        public string PartsName { get; set; }
        public string CscFg1 { get; set; }
        public string CscFg2 { get; set; }
        public string CscCom { get; set; }
        public string CscType { get; set; }
    }
}
