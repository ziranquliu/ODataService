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
    
    public partial class ClmAuditReport
    {
        public long Id { get; set; }
        public long PlanId { get; set; }
        public string ImpOne { get; set; }
        public string ImpTwo { get; set; }
        public string ImpThree { get; set; }
        public string ImpFour { get; set; }
        public string MeasureOne { get; set; }
        public string MeasureTwo { get; set; }
        public string MeasureThree { get; set; }
        public string MeasureFour { get; set; }
        public Nullable<System.DateTime> DeadLineDateOne { get; set; }
        public Nullable<System.DateTime> DeadLineDateTwo { get; set; }
        public Nullable<System.DateTime> DeadLineDateThree { get; set; }
        public Nullable<System.DateTime> DeadLineDateFour { get; set; }
        public string AuditSummary { get; set; }
        public bool SecondAuditNeed { get; set; }
        public Nullable<int> SecondAuditCycle { get; set; }
        public string FileUploadKey { get; set; }
        public bool IsDeleted { get; set; }
        public int Status { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
    }
}