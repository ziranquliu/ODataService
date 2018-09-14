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
    
    public partial class VehStoreLocationQueryView
    {
        public long Id { get; set; }
        public string StoreLocationCode { get; set; }
        public string StoreLocationName { get; set; }
        public long WarehouseId { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
        public string IsLockedName { get; set; }
        public bool IsDeleted { get; set; }
        public string VIN { get; set; }
        public Nullable<System.DateTime> InStock { get; set; }
        public Nullable<int> VehicleStatus { get; set; }
        public Nullable<System.DateTime> DealerInStock { get; set; }
        public Nullable<int> ProfileWarehouseStatus { get; set; }
        public string VehicleTypeName { get; set; }
        public string ConfigurationName { get; set; }
        public string ColorName { get; set; }
        public string Pno18 { get; set; }
        public Nullable<long> DealerId { get; set; }
        public string DealerName { get; set; }
        public Nullable<long> ProvinceId { get; set; }
        public Nullable<long> CityID { get; set; }
        public string VehicleStatusStr { get; set; }
        public Nullable<long> AreaId { get; set; }
        public string ProfileWarehouseStatusName { get; set; }
    }
}