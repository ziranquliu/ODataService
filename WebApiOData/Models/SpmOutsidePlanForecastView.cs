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
    
    public partial class SpmOutsidePlanForecastView
    {
        public string CompanyNo { get; set; }
        public string CompanyName { get; set; }
        public string WmNo { get; set; }
        public string WmName { get; set; }
        public string PartsCode { get; set; }
        public string NameCn { get; set; }
        public string NameEn { get; set; }
        public string Lt { get; set; }
        public decimal Stocks { get; set; }
        public decimal OnWayStock { get; set; }
        public string OrderCycle { get; set; }
        public Nullable<decimal> ArrivalCycle { get; set; }
        public decimal SafetyStockDay { get; set; }
        public Nullable<decimal> AverageMonthSales { get; set; }
        public Nullable<decimal> StandardStock { get; set; }
        public Nullable<decimal> Max { get; set; }
        public Nullable<decimal> Min { get; set; }
        public Nullable<decimal> SafeStock { get; set; }
        public Nullable<decimal> ReplenishmentQuantity { get; set; }
        public string Moq { get; set; }
        public string Mpq { get; set; }
        public decimal PackageModule { get; set; }
        public decimal AdditionalOrderQuantity { get; set; }
        public string SpmSaleFrequency { get; set; }
        public string SpmOrderThreshold { get; set; }
        public Nullable<decimal> ProposalOrderQuantity { get; set; }
        public Nullable<System.DateTime> ArrivalDate { get; set; }
        public decimal BOQuantity { get; set; }
        public decimal SOQuantity { get; set; }
        public int POCount { get; set; }
        public Nullable<int> IsNeedStocking { get; set; }
        public Nullable<decimal> DifferenceRatio { get; set; }
        public decimal M1 { get; set; }
        public decimal M2 { get; set; }
        public decimal M3 { get; set; }
        public decimal M4 { get; set; }
        public decimal M5 { get; set; }
        public decimal M6 { get; set; }
        public decimal M7 { get; set; }
        public decimal M8 { get; set; }
        public decimal M9 { get; set; }
        public decimal M10 { get; set; }
        public decimal M11 { get; set; }
        public decimal M12 { get; set; }
        public Nullable<int> MrpType { get; set; }
        public string MrpTypeName { get; set; }
        public Nullable<int> MakeBuy { get; set; }
        public string MakeBuyName { get; set; }
        public string FlowId { get; set; }
        public string MaterialCode2 { get; set; }
    }
}
