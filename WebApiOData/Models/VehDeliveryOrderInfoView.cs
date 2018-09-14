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
    
    public partial class VehDeliveryOrderInfoView
    {
        public long Id { get; set; }
        public Nullable<long> DealerId { get; set; }
        public string Code { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string ReferOrderCode { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<byte> ReferOrderType { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public long CurrentWarehouseId { get; set; }
        public string VIN { get; set; }
        public string PONO { get; set; }
        public string PNO18 { get; set; }
        public Nullable<int> VehicleStatus { get; set; }
        public string FullName { get; set; }
        public string DealerCode { get; set; }
        public Nullable<int> CapitalType { get; set; }
        public string CapitalTypeName { get; set; }
        public string CurrentWarehouseName { get; set; }
        public string VehicleTypeName { get; set; }
        public string EngineName { get; set; }
        public string VehicleDisplacement { get; set; }
        public string ConfigurationName { get; set; }
        public string ColorName { get; set; }
        public Nullable<System.DateTime> SettlementDate { get; set; }
        public Nullable<decimal> SettlementPrice { get; set; }
        public string BankAcceptance { get; set; }
        public string ProvinceName { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string StatusName { get; set; }
        public string ReferOrderTypeName { get; set; }
        public string VehicleStatusName { get; set; }
        public string StoreLocationCode { get; set; }
        public int OrderNum { get; set; }
        public int InventoryQuantity { get; set; }
        public string CarrierBillCode { get; set; }
        public Nullable<System.DateTime> DeliveryTime { get; set; }
        public string CarrierName { get; set; }
        public string Destination { get; set; }
        public string ExpressNo { get; set; }
        public Nullable<System.DateTime> MatchesModifiedOn { get; set; }
        public Nullable<System.DateTime> Salesdate { get; set; }
    }
}
