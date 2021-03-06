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
    
    public partial class MdmSupplierContract
    {
        public long Id { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string SupplierNo { get; set; }
        public string SupplierCName { get; set; }
        public string SupplierEName { get; set; }
        public string PartNo { get; set; }
        public string PartCName { get; set; }
        public string ContractNo { get; set; }
        public Nullable<decimal> Price { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string FlowId { get; set; }
        public string IsHaveImportParts { get; set; }
        public string BuyerName { get; set; }
        public string Models { get; set; }
        public string ShippingMode { get; set; }
        public string ShippingLocation { get; set; }
        public int DeliveryAhead { get; set; }
        public Nullable<decimal> MinimumPacking { get; set; }
        public Nullable<decimal> MinimumOrderQuantity { get; set; }
        public string OriginCountry { get; set; }
        public decimal PriceUnit { get; set; }
        public string SpecialPurchaseType { get; set; }
        public string TaxClassification { get; set; }
        public string Currency { get; set; }
        public string OemCode { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<decimal> ContractPrice { get; set; }
        public string ZMUnit { get; set; }
        public string Action { get; set; }
        public string JGLX { get; set; }
        public string XISHU { get; set; }
        public Nullable<decimal> RESERVE1 { get; set; }
        public string CURRENCY1 { get; set; }
        public Nullable<decimal> RESERVE2 { get; set; }
        public string CURRENCY2 { get; set; }
        public Nullable<decimal> RESERVE3 { get; set; }
        public string CURRENCY3 { get; set; }
        public Nullable<decimal> ZRSPRICE { get; set; }
        public string CURRENCY4 { get; set; }
        public Nullable<decimal> STGE_LOC { get; set; }
        public int Source { get; set; }
        public bool SAPCreated { get; set; }
        public Nullable<System.Guid> SapId { get; set; }
    }
}
