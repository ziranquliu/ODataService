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
    
    public partial class SvcServiceSummary
    {
        public long Id { get; set; }
        public string SystemOrder { get; set; }
        public string SpCode { get; set; }
        public string SpName { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string VinCode { get; set; }
        public string ServiceProxyCode { get; set; }
        public Nullable<int> RedAlarmTimes { get; set; }
        public Nullable<int> OrangeAlarmTimes { get; set; }
        public Nullable<int> YellowAlarmTimes { get; set; }
        public Nullable<System.DateTime> ReplaceOn { get; set; }
        public Nullable<int> ReplaceTimes { get; set; }
        public Nullable<int> RepairTime { get; set; }
        public Nullable<int> RepairTimes { get; set; }
        public Nullable<int> CurrentType { get; set; }
        public string CscCode { get; set; }
        public string MainSpCode { get; set; }
        public Nullable<long> AlarmId { get; set; }
    }
}