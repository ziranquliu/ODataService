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
    
    public partial class SpmWarehouseView
    {
        public long Id { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string WmName { get; set; }
        public string Country { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string WmAddress { get; set; }
        public bool IsDeleted { get; set; }
        public string Comments { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string UserName { get; set; }
    }
}
