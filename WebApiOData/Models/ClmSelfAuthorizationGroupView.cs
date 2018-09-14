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
    
    public partial class ClmSelfAuthorizationGroupView
    {
        public long Id { get; set; }
        public string PolicyCode { get; set; }
        public long CountryId { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public decimal Mileage { get; set; }
        public string MileageUnit { get; set; }
        public decimal AgeLimit { get; set; }
        public string DealerNames { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> Deadline { get; set; }
        public decimal LaborSupplierRatio { get; set; }
        public decimal LaborDealerRatio { get; set; }
        public decimal LaborCustomerRatio { get; set; }
        public decimal MaterialSupplierRatio { get; set; }
        public decimal MaterialDealerRatio { get; set; }
        public decimal MaterialCustomerRatio { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string Culture { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
        public int IsValid { get; set; }
    }
}
