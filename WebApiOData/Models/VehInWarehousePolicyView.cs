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
    
    public partial class VehInWarehousePolicyView
    {
        public Nullable<long> WarehouseId { get; set; }
        public long Id { get; set; }
        public Nullable<int> Status { get; set; }
        public string StatusName { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string WarehouseName { get; set; }
        public Nullable<int> FirstPriority { get; set; }
        public Nullable<int> SecondPriority { get; set; }
        public Nullable<int> ThirdPriority { get; set; }
        public Nullable<int> FourthPriority { get; set; }
        public Nullable<int> FifthPriority { get; set; }
        public Nullable<int> SixPriority { get; set; }
        public string FirstPriorityName { get; set; }
        public string SecondPriorityName { get; set; }
        public string ThirdPriorityName { get; set; }
        public string FourthPriorityName { get; set; }
        public string FifthPriorityName { get; set; }
        public string SixPriorityName { get; set; }
    }
}
