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
    
    public partial class ClmBudget
    {
        public long Id { get; set; }
        public string BudgetCode { get; set; }
        public string VehicleTypeCode { get; set; }
        public byte Years { get; set; }
        public byte BudgetType { get; set; }
        public string WarrantyPeriod { get; set; }
        public string Currency { get; set; }
        public Nullable<byte> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<int> ExcuteYear { get; set; }
        public string CountryCode { get; set; }
    }
}
