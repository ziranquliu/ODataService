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
    
    public partial class SpmZoneView
    {
        public long Id { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string ZoneNo { get; set; }
        public string ZoneName { get; set; }
        public Nullable<int> ZoneType { get; set; }
        public Nullable<int> StorageType { get; set; }
        public string ZoneTypeName { get; set; }
        public string StorageTypeName { get; set; }
        public Nullable<int> IsCount { get; set; }
        public string IsCountName { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string Comments { get; set; }
        public bool IsDeleted { get; set; }
        public string IsEntrustZone { get; set; }
        public string UserName { get; set; }
    }
}