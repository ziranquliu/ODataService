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
    
    public partial class MdmFaq
    {
        public long Id { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public string Answer { get; set; }
        public Nullable<long> Brand { get; set; }
        public Nullable<long> Caselevel1 { get; set; }
        public Nullable<long> Caselevel2 { get; set; }
        public Nullable<long> Caselevel3 { get; set; }
        public Nullable<int> Category { get; set; }
        public Nullable<System.DateTime> ExpirationTime { get; set; }
        public Nullable<bool> ForcedExpiration { get; set; }
        public Nullable<bool> IsPublish { get; set; }
        public string Question { get; set; }
        public Nullable<System.DateTime> SoonExpirationTime { get; set; }
        public string Title { get; set; }
        public string UpdateKey { get; set; }
        public Nullable<long> Vehicletype { get; set; }
        public Nullable<long> VerhicleClass { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Commons { get; set; }
        public long CreatedBy { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
    }
}
