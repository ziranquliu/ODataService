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
    
    public partial class ClmWearTearPartsConfiguration
    {
        public long Id { get; set; }
        public string PolicyCode { get; set; }
        public long CountryId { get; set; }
        public string WearTearPartNo { get; set; }
        public string WearTearPartName { get; set; }
        public int WarrantyPeriod { get; set; }
        public decimal Mileage { get; set; }
        public string MileageUnit { get; set; }
        public bool IsDeleted { get; set; }
        public int Status { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string PolicyType { get; set; }
        public Nullable<System.DateTime> PublishTime { get; set; }
        public Nullable<long> LinkId { get; set; }
    }
}
