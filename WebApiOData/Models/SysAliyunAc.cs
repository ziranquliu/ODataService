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
    
    public partial class SysAliyunAc
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string BodyParameters { get; set; }
        public string Target { get; set; }
        public string TargetValue { get; set; }
        public bool IsSend { get; set; }
        public Nullable<System.DateTime> SendTime { get; set; }
        public bool IsFailed { get; set; }
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
