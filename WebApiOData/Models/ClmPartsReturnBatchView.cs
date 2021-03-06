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
    
    public partial class ClmPartsReturnBatchView
    {
        public long Id { get; set; }
        public string BatchNo { get; set; }
        public Nullable<decimal> PartQuantity { get; set; }
        public string ReturnType { get; set; }
        public string ReturnTypeName { get; set; }
        public long DealerId { get; set; }
        public string DealerCode { get; set; }
        public string Dealer { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string ReceivingParty { get; set; }
        public string ReceivingPartyName { get; set; }
        public bool IsReceipt { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Status { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string StatusName { get; set; }
        public string Culture { get; set; }
        public Nullable<int> ExpressType { get; set; }
        public Nullable<long> ReferID { get; set; }
        public string ShipperExpressCompany { get; set; }
        public string ShipperCourierNumber { get; set; }
        public string Shipper { get; set; }
        public string ShipperContact { get; set; }
        public string ShipperAddress { get; set; }
        public Nullable<System.DateTime> ShipperTime { get; set; }
        public string ShipperComment { get; set; }
        public Nullable<int> ShipperBoxNumber { get; set; }
        public string ReceivingExpressCompany { get; set; }
        public string ReceivingCourierNumber { get; set; }
        public string Consignee { get; set; }
        public string ConsigneeContact { get; set; }
        public string ReceivingAddress { get; set; }
        public Nullable<System.DateTime> ReceivingTime { get; set; }
        public string ReceivingComment { get; set; }
        public Nullable<int> ReceivingBoxNumber { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> Volume { get; set; }
        public string GoodsNos { get; set; }
        public string BoxNo { get; set; }
        public string Remark1 { get; set; }
        public string RelReceivingPartyName { get; set; }
        public string Remark2 { get; set; }
        public string VINs { get; set; }
        public string PartNos { get; set; }
        public string WarrantyNos { get; set; }
        public string DemandSides { get; set; }
        public string ReturnReasons { get; set; }
        public string SupplierNos { get; set; }
        public Nullable<long> PackageQty { get; set; }
        public Nullable<System.DateTime> PackageTime { get; set; }
        public Nullable<System.DateTime> PreReceiveTime { get; set; }
        public string ReceiveStatus { get; set; }
        public string CarrierName { get; set; }
        public string CarrierCode { get; set; }
    }
}
