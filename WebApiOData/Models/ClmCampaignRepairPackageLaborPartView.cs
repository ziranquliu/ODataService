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
    
    public partial class ClmCampaignRepairPackageLaborPartView
    {
        public long Id { get; set; }
        public long RepairPackageId { get; set; }
        public Nullable<bool> IsMain { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public int Type { get; set; }
        public bool IsDeleted { get; set; }
        public string TypeName { get; set; }
    }
}
