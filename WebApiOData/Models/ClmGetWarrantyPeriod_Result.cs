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
    
    public partial class ClmGetWarrantyPeriod_Result
    {
        public string VIN { get; set; }
        public string PeriodDesc { get; set; }
        public Nullable<int> PeriodMonth { get; set; }
        public Nullable<decimal> PeriodMileage { get; set; }
        public string PeriodMileageUnit { get; set; }
        public string WarrantyStart { get; set; }
        public string EndDateResult { get; set; }
        public Nullable<decimal> EndMileageResult { get; set; }
    }
}
