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
    
    public partial class VehStoreLocationRemindRuleView
    {
        public long Id { get; set; }
        public int NumberType { get; set; }
        public decimal Number { get; set; }
        public Nullable<long> WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedUserName { get; set; }
        public bool IsDeleted { get; set; }
        public string NumberTypeStr { get; set; }
    }
}
