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
    
    public partial class VehSalesForecastSumView
    {
        public long Id { get; set; }
        public string ForecastCycle { get; set; }
        public string ForecastWeek { get; set; }
        public string PNO { get; set; }
        public Nullable<int> ForeNumber { get; set; }
        public Nullable<int> AdjustNumber { get; set; }
        public string SubmitYearMonth { get; set; }
        public Nullable<long> VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; }
        public string VehicleTypeCode { get; set; }
        public string EngineName { get; set; }
        public string StyleName { get; set; }
        public string GearboxName { get; set; }
        public string ConfigurationName { get; set; }
        public string VehicleDisplacement { get; set; }
        public string GroupName { get; set; }
    }
}