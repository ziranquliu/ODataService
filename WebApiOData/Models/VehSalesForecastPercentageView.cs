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
    
    public partial class VehSalesForecastPercentageView
    {
        public string ForecastCycle { get; set; }
        public string PNO { get; set; }
        public Nullable<int> countPno { get; set; }
        public Nullable<int> countForecastNumber { get; set; }
        public string Optioncode { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public Nullable<long> Id { get; set; }
        public Nullable<long> VehicleTypeId { get; set; }
        public string VehicleTypeCode { get; set; }
        public string VehicleTypeName { get; set; }
        public Nullable<decimal> Percentage { get; set; }
        public string ForecastWeek { get; set; }
    }
}