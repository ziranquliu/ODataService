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
    
    public partial class CrmCareClientRecord
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public Nullable<short> SendChannel { get; set; }
        public Nullable<System.DateTime> CareDate { get; set; }
        public string Content { get; set; }
        public Nullable<short> Type { get; set; }
        public Nullable<long> Org { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Commons { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public long ID { get; set; }
        public Nullable<long> ClientRecordId { get; set; }
    }
}
