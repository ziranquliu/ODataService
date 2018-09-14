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
    
    public partial class VehDeliveryOrderNotView
    {
        public long Id { get; set; }
        public string SONO { get; set; }
        public string PONO { get; set; }
        public long DealerId { get; set; }
        public long CompanyId { get; set; }
        public string PNO { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string RONO { get; set; }
        public Nullable<System.DateTime> LockTime { get; set; }
        public Nullable<int> LockStatus { get; set; }
        public Nullable<int> LockMode { get; set; }
        public string Exinfo { get; set; }
        public string ShortName { get; set; }
        public string DealerCode { get; set; }
        public string FullName { get; set; }
        public string VehicleTypeName { get; set; }
        public string VehicleDisplacement { get; set; }
        public string ConfigurationName { get; set; }
        public string ColorName { get; set; }
        public string VehicleMaterialRemark { get; set; }
        public Nullable<bool> IsEmergency { get; set; }
        public Nullable<bool> IsScheduled { get; set; }
        public Nullable<int> PriorityLevel { get; set; }
        public string VIN { get; set; }
        public Nullable<long> WarehouseId { get; set; }
        public Nullable<int> InventoryQuantity { get; set; }
        public string Code { get; set; }
        public string WarehouseName { get; set; }
        public string OemPlaceCode { get; set; }
        public string DealerWareHouseCode { get; set; }
        public string DealerWareHouseLocation { get; set; }
        public Nullable<System.DateTime> SettlementDate { get; set; }
        public string BankAcceptance { get; set; }
        public string ShippingInStruction { get; set; }
        public Nullable<int> CapitalType { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }
        public string VehicleUseName { get; set; }
        public string ShipmentLineCode { get; set; }
        public string ShipmentLineName { get; set; }
        public string SoreviewStatusCode { get; set; }
        public string SoreviewStatusName { get; set; }
        public string CapitalTypeName { get; set; }
    }
}