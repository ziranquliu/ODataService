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
    
    public partial class SpmOutsideCommissionedPlanView
    {
        public long Id { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string CompanyNo { get; set; }
        public string CompanyName { get; set; }
        public string WmNo { get; set; }
        public string WmName { get; set; }
        public string OutsideTypeName { get; set; }
        public string StatusName { get; set; }
        public string OutsideCommissionedTitle { get; set; }
        public string OutsideCommissionedType { get; set; }
        public string OutsideCommissionedCode { get; set; }
        public string IsEmergencyName { get; set; }
        public Nullable<bool> IsEmergency { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string Currency { get; set; }
        public Nullable<long> ApprovalUserId { get; set; }
        public string ApprovalUserName { get; set; }
    }
}