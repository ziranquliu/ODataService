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
    
    public partial class VehFactoryData
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Vin { get; set; }
        public string EngineCode { get; set; }
        public Nullable<long> OemplaceId { get; set; }
        public Nullable<System.DateTime> CompleteDate { get; set; }
        public string GearboxCode { get; set; }
        public bool IsStopped { get; set; }
        public Nullable<long> OwnerID { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public byte[] DateTimeStamp { get; set; }
    }
}
