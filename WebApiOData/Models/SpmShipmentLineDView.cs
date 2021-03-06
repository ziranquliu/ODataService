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
    
    public partial class SpmShipmentLineDView
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
        public decimal TransitTime { get; set; }
        public decimal TransportationLeadTime { get; set; }
        public int ShippingType { get; set; }
        public bool IsStopped { get; set; }
        public Nullable<decimal> ShipPriceUnit { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public string CarrierCode { get; set; }
        public Nullable<decimal> ReturnPriceUnit { get; set; }
        public Nullable<long> StartProvinceId { get; set; }
        public Nullable<long> StartCityId { get; set; }
        public Nullable<long> StartAreaId { get; set; }
        public Nullable<int> ReturnType { get; set; }
        public Nullable<int> UseSide { get; set; }
        public Nullable<int> TargetWareHouse { get; set; }
    }
}
