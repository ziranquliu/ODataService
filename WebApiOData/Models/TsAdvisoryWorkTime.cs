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
    
    public partial class TsAdvisoryWorkTime
    {
        public long Id { get; set; }
        public Nullable<long> OrderId { get; set; }
        public string WorkTimeCode { get; set; }
        public string WorkTimeDescribe { get; set; }
        public Nullable<decimal> WorkTimeNum { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequnece { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string Unit { get; set; }
        public Nullable<bool> MainComponent { get; set; }
        public string TechnicianLevel { get; set; }
    }
}
