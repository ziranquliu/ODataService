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
    
    public partial class TsSystemSetting
    {
        public long Id { get; set; }
        public string Category { get; set; }
        public string CategoryDesc { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Culture { get; set; }
        public Nullable<int> Type { get; set; }
        public string StringValue { get; set; }
        public Nullable<decimal> DoubleValue { get; set; }
        public Nullable<decimal> MinValue { get; set; }
        public Nullable<decimal> MaxValue { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> MinTime { get; set; }
        public Nullable<System.DateTime> MaxTime { get; set; }
        public string DataType { get; set; }
        public Nullable<bool> BitValue { get; set; }
        public Nullable<long> ParentId { get; set; }
        public Nullable<int> Sequnece { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Status { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
    }
}
