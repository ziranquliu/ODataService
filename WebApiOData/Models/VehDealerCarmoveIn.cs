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
    
    public partial class VehDealerCarmoveIn
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> MoveinDate { get; set; }
        public Nullable<bool> MasslossCar { get; set; }
        public Nullable<int> MoveinType { get; set; }
        public Nullable<long> Dealer { get; set; }
        public Nullable<long> Warehouse { get; set; }
        public string WarehouseLocation { get; set; }
        public Nullable<long> CarStock { get; set; }
        public Nullable<long> InStock { get; set; }
        public Nullable<int> Status { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string VIN { get; set; }
    }
}
