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
    
    public partial class VehCarTransferView
    {
        public long Id { get; set; }
        public string VIN { get; set; }
        public Nullable<int> Reason { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> Status { get; set; }
        public string StatusName { get; set; }
        public string ReasonName { get; set; }
        public string InStoreLocationCode { get; set; }
        public string OutStoreLocationCode { get; set; }
        public long WarehouseId { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public Nullable<byte> WarehouseType { get; set; }
        public Nullable<long> OemPlaceId { get; set; }
    }
}
