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
    
    public partial class VehDeliveryOrderView
    {
        public long Id { get; set; }
        public Nullable<long> DealerId { get; set; }
        public string Code { get; set; }
        public Nullable<byte> ReferOrderType { get; set; }
        public string ReferOrderCode { get; set; }
        public string ShipmentAreaCode { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsCarriering { get; set; }
        public string WarehouseId { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public bool IsTwoTransitConfirm { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public long CurrentWarehouseId { get; set; }
        public string VIN { get; set; }
        public string ColorName { get; set; }
        public string ConfigurationName { get; set; }
        public string VehicleTypeName { get; set; }
        public string DealerCode { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string ShipmentAreaName { get; set; }
        public string ReferOrderTypeName { get; set; }
        public string IsTwoTransitConfirmName { get; set; }
    }
}