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
    
    public partial class VehChariotCarView
    {
        public long Id { get; set; }
        public string LicensePlateNumber { get; set; }
        public Nullable<byte> TransportCapacity { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public long CarrierBillId { get; set; }
        public string CarrierBillCode { get; set; }
        public string CarrierCode { get; set; }
        public Nullable<int> CarrierBillStatus { get; set; }
        public Nullable<long> WarehouseId { get; set; }
        public bool IsTwoTransit { get; set; }
        public long DeliveryOrderId { get; set; }
        public string DeliveryOrderCode { get; set; }
        public bool IsCarriering { get; set; }
        public bool IsTwoTransitConfirm { get; set; }
        public string VIN { get; set; }
        public string ShipmentLineCode { get; set; }
        public long ShipmentLineId { get; set; }
        public Nullable<int> ProfileWarehouseStatus { get; set; }
        public string PONO { get; set; }
        public string DriverMobileNo { get; set; }
        public string DriverName { get; set; }
        public int DriverConfirm { get; set; }
        public int CertificationConfirm { get; set; }
        public int Loading { get; set; }
        public int SceneConfirm { get; set; }
        public int Pickup { get; set; }
        public int OutFactoryConfirm { get; set; }
        public string ProfileWarehouseStatusName { get; set; }
    }
}
