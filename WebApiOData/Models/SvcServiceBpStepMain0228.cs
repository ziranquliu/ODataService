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
    
    public partial class SvcServiceBpStepMain0228
    {
        public long Id { get; set; }
        public string SystemOrder { get; set; }
        public string ServiceProxyCode { get; set; }
        public Nullable<long> StepId { get; set; }
        public string StepName { get; set; }
        public Nullable<int> StepType { get; set; }
        public Nullable<long> TecGroupId { get; set; }
        public string TecGroupName { get; set; }
        public string LaneName { get; set; }
        public Nullable<long> LaneId { get; set; }
        public Nullable<System.DateTime> FirstStartOn { get; set; }
        public Nullable<System.DateTime> LastStartOn { get; set; }
        public Nullable<System.DateTime> FinishOn { get; set; }
        public Nullable<decimal> CurrentHour { get; set; }
        public Nullable<decimal> ExpectFinishHour { get; set; }
        public Nullable<bool> IsTimeout { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
    }
}
