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
    
    public partial class ClmPartsHandlingChargeGroupView
    {
        public long Id { get; set; }
        public string PolicyCode { get; set; }
        public long CountryId { get; set; }
        public string CountryName { get; set; }
        public Nullable<decimal> ChargeUpperLimit { get; set; }
        public string Currency { get; set; }
        public string CurrencyName { get; set; }
        public decimal Coefficient { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string DealerIds { get; set; }
        public string DealerNames { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
        public string Culture { get; set; }
    }
}
