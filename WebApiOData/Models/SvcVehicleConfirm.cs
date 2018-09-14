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
    
    public partial class SvcVehicleConfirm
    {
        public long Id { get; set; }
        public Nullable<long> VehicleDeliveryId { get; set; }
        public Nullable<long> OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerTel { get; set; }
        public string OwnerPhone { get; set; }
        public string Plate { get; set; }
        public string VinCode { get; set; }
        public string VehicleType { get; set; }
        public Nullable<long> ServiceAdvisorId { get; set; }
        public string ServiceName { get; set; }
        public Nullable<System.DateTime> VehicleDeliveryAt { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string DealerId { get; set; }
        public string ServerDealerName { get; set; }
        public string OriginalDealerId { get; set; }
        public string OriginalDealerName { get; set; }
        public string ReplaceDealerReason { get; set; }
        public Nullable<System.DateTime> ReplaceDealerDate { get; set; }
    }
}
