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
    
    public partial class MdmVehicleProfileView
    {
        public long Id { get; set; }
        public string VIN { get; set; }
        public string PNO18 { get; set; }
        public string PONO { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<long> WarehouseId { get; set; }
        public Nullable<int> VehicleStatus { get; set; }
        public Nullable<long> DealerID { get; set; }
        public Nullable<long> StoreLocationId { get; set; }
        public Nullable<System.DateTime> InStock { get; set; }
        public string VehicleStatusName { get; set; }
        public string ProfileWarehouseStatusName { get; set; }
        public string StoreLocationCode { get; set; }
        public string WarehouseName { get; set; }
        public Nullable<int> WarehouseStatus { get; set; }
        public Nullable<byte> WarehouseType { get; set; }
        public Nullable<long> OemPlaceId { get; set; }
        public string VehicleTypeName { get; set; }
        public string VehicleYear { get; set; }
        public string EngineName { get; set; }
        public string StyleName { get; set; }
        public string GearboxName { get; set; }
        public string VehicleDisplacement { get; set; }
        public string ColorName { get; set; }
        public string ConfigurationName { get; set; }
        public string OptionsName { get; set; }
        public string FullName { get; set; }
        public Nullable<long> ProvinceId { get; set; }
        public string DealerCode { get; set; }
        public Nullable<long> AreaID { get; set; }
        public string AreaName { get; set; }
        public string OemPlaceCode { get; set; }
        public string OemPlaceName { get; set; }
        public string TransferOrderCode { get; set; }
        public Nullable<long> ToWarehouseId { get; set; }
        public string DeliveryOrderCode { get; set; }
        public Nullable<int> CapitalType { get; set; }
        public string CapitalTypeName { get; set; }
    }
}
