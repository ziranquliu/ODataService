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
    
    public partial class SvcCouponView
    {
        public long Id { get; set; }
        public Nullable<long> AccountId { get; set; }
        public Nullable<long> CouponId { get; set; }
        public Nullable<int> CurrCnt { get; set; }
        public string CouponSno { get; set; }
        public string CouponName { get; set; }
        public string TypeName { get; set; }
        public string ApplicableRegion { get; set; }
        public string ApplicableRegionCode { get; set; }
        public string Descript { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<System.DateTime> EffectDateStart { get; set; }
        public Nullable<System.DateTime> EffectDateEnd { get; set; }
    }
}
