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
    
    public partial class ClmAuditPlanView
    {
        public long Id { get; set; }
        public string AuditCode { get; set; }
        public byte AuditType { get; set; }
        public long DealerId { get; set; }
        public System.DateTime EstimatedAuditDate { get; set; }
        public Nullable<System.DateTime> LastAuditDate { get; set; }
        public System.DateTime AuditScopeDeadline { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Status { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public Nullable<long> Auditor { get; set; }
        public string DealerName { get; set; }
        public string DealerCode { get; set; }
        public int TotalWarrantyCount { get; set; }
        public decimal TotalWarrantyTotalAmount { get; set; }
        public Nullable<decimal> FilterWarrantyTotalAmount { get; set; }
        public Nullable<int> FilterWarrantyCount { get; set; }
        public string Currency1 { get; set; }
        public int AuditWarrantyCount { get; set; }
        public decimal AuditWarrantyTotalAmount { get; set; }
        public string Currency2 { get; set; }
        public string AuditTypeStr { get; set; }
        public string Culture { get; set; }
        public string AuditorName { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public Nullable<long> ReportId { get; set; }
        public string StatusName { get; set; }
        public Nullable<int> FilterCount { get; set; }
    }
}
