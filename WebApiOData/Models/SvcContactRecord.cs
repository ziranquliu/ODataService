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
    
    public partial class SvcContactRecord
    {
        public long Id { get; set; }
        public Nullable<long> TaskId { get; set; }
        public Nullable<int> ContactType { get; set; }
        public Nullable<long> ContactPerformId { get; set; }
        public string ContactPerformName { get; set; }
        public Nullable<System.DateTime> PlanAttractAt { get; set; }
        public Nullable<System.DateTime> AttractAt { get; set; }
        public Nullable<System.DateTime> CompleteAt { get; set; }
        public Nullable<bool> IsExpiry { get; set; }
        public Nullable<bool> IsReply { get; set; }
        public Nullable<long> ContactResultId { get; set; }
        public string ContactResult { get; set; }
        public string ContactCurrentLabel { get; set; }
        public Nullable<bool> IsRepair { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<int> ContactResultStatus { get; set; }
        public string ContactSequence { get; set; }
    }
}
