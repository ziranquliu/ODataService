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
    
    public partial class VehCarrierSceneRepresentView
    {
        public long Id { get; set; }
        public long CarrierId { get; set; }
        public long WarehouseId { get; set; }
        public Nullable<int> Status { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string SupplierSName { get; set; }
        public string WarehouseName { get; set; }
    }
}
