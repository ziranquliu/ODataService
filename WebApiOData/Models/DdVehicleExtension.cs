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
    
    public partial class DdVehicleExtension
    {
        public long ID { get; set; }
        public string ParmaId { get; set; }
        public string PartnerId { get; set; }
        public string DeviceId { get; set; }
        public string UserId { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
        public string LocalReadOutDateAndTimeStamp { get; set; }
        public string UTCReadOutDateAndTimeStamp { get; set; }
        public string OdometerValue { get; set; }
        public string PowerMode { get; set; }
        public string VehicleGlobalTime { get; set; }
        public string CarcomDbVersion { get; set; }
        public Nullable<long> VehicleInformationID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<System.Guid> Guid { get; set; }
    
        public virtual DdVehicleInformation DdVehicleInformation { get; set; }
    }
}