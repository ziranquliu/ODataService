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
    
    public partial class MdmSmallServicePackage
    {
        public long Id { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public string Name { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<long> MdmServicePackageSmall { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<long> ServicePackageBigPackage { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Commons { get; set; }
        public long CreatedBy { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string AliNo { get; set; }
        public Nullable<int> Count { get; set; }
    }
}
