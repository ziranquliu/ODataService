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
    
    public partial class ClmSpecialWarrantyPeriodSettingView
    {
        public long Id { get; set; }
        public string PolicyCode { get; set; }
        public string VINs { get; set; }
        public int WarrantyType { get; set; }
        public int WarrantyPeriod { get; set; }
        public Nullable<decimal> Mileage { get; set; }
        public string MileageUnit { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string WarrantyTypeName { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
        public string Culture { get; set; }
    }
}
