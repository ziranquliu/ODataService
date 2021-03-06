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
    
    public partial class SpmShipmentLineView
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Distance { get; set; }
        public string Unit { get; set; }
        public string WHCode { get; set; }
        public Nullable<long> EndProvinceId { get; set; }
        public Nullable<long> EndCityId { get; set; }
        public Nullable<long> EndAreaId { get; set; }
        public string EndProvince { get; set; }
        public string EndCity { get; set; }
        public string EndArea { get; set; }
        public decimal TransitTime { get; set; }
        public decimal TransportationLeadTime { get; set; }
        public int ShippingType { get; set; }
        public bool IsStopped { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<decimal> ShipPriceUnit { get; set; }
        public Nullable<decimal> ReturnPriceUnit { get; set; }
        public string CarrierCode { get; set; }
        public string CarrierName { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string StartAreaName { get; set; }
        public Nullable<int> UseSide { get; set; }
        public string ShippingTypeName { get; set; }
    }
}
