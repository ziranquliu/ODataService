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
    
    public partial class TsHotlineTraffic
    {
        public long Id { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequnece { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string Numbers { get; set; }
        public Nullable<int> Type { get; set; }
        public string CallPeople { get; set; }
        public string CalledPeople { get; set; }
        public string Dealer { get; set; }
        public string CustomerService { get; set; }
        public string CallPhone { get; set; }
        public string CalledPhone { get; set; }
        public Nullable<System.DateTime> CallTime { get; set; }
        public string CallStatus { get; set; }
        public Nullable<int> MatterType { get; set; }
        public string FunctionRange { get; set; }
        public string ChassisNo { get; set; }
        public string ManufacturingBase { get; set; }
        public string InfoCSC { get; set; }
        public string FaultType { get; set; }
        public string Vin { get; set; }
        public string AdvTheme { get; set; }
        public string TrackStatus { get; set; }
        public string FaulDescribe { get; set; }
        public string Solution { get; set; }
        public string RevisitStatus { get; set; }
        public string Path { get; set; }
        public string OrderStatus { get; set; }
        public string Appraise { get; set; }
        public Nullable<long> DealerId { get; set; }
    }
}