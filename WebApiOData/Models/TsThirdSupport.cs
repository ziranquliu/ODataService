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
    
    public partial class TsThirdSupport
    {
        public long Id { get; set; }
        public Nullable<long> ForeignId { get; set; }
        public string Engineer { get; set; }
        public string Content { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<long> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<int> Type { get; set; }
    }
}
