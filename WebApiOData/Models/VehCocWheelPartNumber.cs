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
    
    public partial class VehCocWheelPartNumber
    {
        public long Id { get; set; }
        public Nullable<long> CocOrderInfoId { get; set; }
        public string RecordType { get; set; }
        public string FileCreationDate { get; set; }
        public string FileCreationTime { get; set; }
        public string FactoryId { get; set; }
        public string FactoryOrderNumber { get; set; }
        public string WheelPartNumber { get; set; }
        public string WheelPartNumberCode { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Commons { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
    
        public virtual VehCocOrderInfo VehCocOrderInfo { get; set; }
    }
}
