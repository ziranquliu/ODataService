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
    
    public partial class SvcStatementPart
    {
        public long Id { get; set; }
        public string StatementNo { get; set; }
        public Nullable<long> StatementOrderId { get; set; }
        public string ServiceType { get; set; }
        public string SystemOrder { get; set; }
        public string SpCode { get; set; }
        public string SpName { get; set; }
        public Nullable<decimal> SpNums { get; set; }
        public Nullable<decimal> EnterPrice { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> RealSpNums { get; set; }
        public Nullable<int> DiscountType { get; set; }
        public string RelateDiscountId { get; set; }
        public string RelateDiscountName { get; set; }
        public string CscValue { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string Unit { get; set; }
        public Nullable<int> RepairType { get; set; }
        public Nullable<decimal> DegreeOfDifficulty { get; set; }
        public string CscCode { get; set; }
        public Nullable<long> ServicePackageId { get; set; }
        public Nullable<int> ApplyType { get; set; }
        public Nullable<decimal> ClaimPrice { get; set; }
        public string FreezCode { get; set; }
        public string SerierCode { get; set; }
        public string GuaranteeType { get; set; }
        public string CouponCode { get; set; }
        public Nullable<int> SpReturnStatus { get; set; }
        public Nullable<System.DateTime> SpReturnTime { get; set; }
    }
}