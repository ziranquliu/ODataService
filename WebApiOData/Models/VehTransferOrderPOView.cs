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
    
    public partial class VehTransferOrderPOView
    {
        public long Id { get; set; }
        public long TransferOrderId { get; set; }
        public string TransferOrderCode { get; set; }
        public long POId { get; set; }
        public Nullable<int> Status { get; set; }
        public string PONO { get; set; }
        public string StatusName { get; set; }
        public string VIN { get; set; }
        public string PNO18 { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> VehicleStatus { get; set; }
        public string VehicleStatusName { get; set; }
        public string StoreLocationCode { get; set; }
        public string WarehouseName { get; set; }
        public string VehicleTypeName { get; set; }
        public string VehicleYear { get; set; }
        public string EngineName { get; set; }
        public string StyleName { get; set; }
        public string GearboxName { get; set; }
        public string VehicleDisplacement { get; set; }
        public string ColorName { get; set; }
        public string ConfigurationName { get; set; }
        public string FullName { get; set; }
    }
}