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
    
    public partial class ClmWarrantyManHourPriceSettingGroup
    {
        public long Id { get; set; }
        public string PolicyCode { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> Deadline { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public int Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<System.DateTime> PublishTime { get; set; }
        public string PolicyType { get; set; }
        public Nullable<long> LinkId { get; set; }
        public string DealerIds { get; set; }
        public string DealerNames { get; set; }
        public string VehicleModelCodes { get; set; }
        public string VehicleModelNames { get; set; }
        public Nullable<long> CountryId { get; set; }
    }
}
