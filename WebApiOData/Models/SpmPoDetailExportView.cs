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
    
    public partial class SpmPoDetailExportView
    {
        public Nullable<long> Id { get; set; }
        public long POId { get; set; }
        public string POCode { get; set; }
        public string DealerCode { get; set; }
        public string DealerName { get; set; }
        public Nullable<decimal> TotalDemandQuantity { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string StatusName { get; set; }
        public string Comments { get; set; }
        public string VerifyCommons { get; set; }
        public string PoTypeName { get; set; }
        public string GreenPathAuditName { get; set; }
        public string CustomAuditName { get; set; }
        public Nullable<bool> replaceFlag { get; set; }
        public string PartNo { get; set; }
        public string PartCname { get; set; }
        public Nullable<decimal> DemandQuantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> SoTotalDemandQuantity { get; set; }
        public Nullable<decimal> BoTotalDemandQuantity { get; set; }
        public string CodeVIN { get; set; }
        public string QueCode { get; set; }
        public string EngCode { get; set; }
        public string Attachment { get; set; }
        public Nullable<decimal> OutputQuantity { get; set; }
        public bool IsDeleted { get; set; }
        public int Status { get; set; }
        public Nullable<int> GreenPathAudit { get; set; }
        public Nullable<int> CustomAudit { get; set; }
        public int PoType { get; set; }
    }
}
