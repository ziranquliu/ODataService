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
    
    public partial class ClmSupplierRecoveryDetailViewBySupplier
    {
        public string SupplierRecoveryCode { get; set; }
        public string SupplierNo { get; set; }
        public string SupplierName { get; set; }
        public Nullable<System.DateTime> ClaimsDate { get; set; }
        public Nullable<decimal> SupplierAmount { get; set; }
        public string Currency { get; set; }
        public string Comments { get; set; }
        public string StatusStr { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string Culture { get; set; }
        public Nullable<long> Mid { get; set; }
        public Nullable<long> CountryId { get; set; }
        public Nullable<int> RecoveryStatus { get; set; }
        public Nullable<System.DateTime> InputOnBengin { get; set; }
        public Nullable<System.DateTime> InputOnEnd { get; set; }
    }
}