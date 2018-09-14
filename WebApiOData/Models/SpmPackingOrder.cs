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
    
    public partial class SpmPackingOrder
    {
        public long Id { get; set; }
        public string PackingOrderCode { get; set; }
        public string SupplierNo { get; set; }
        public string CarrierName { get; set; }
        public string CarrierAddress { get; set; }
        public string CarrierPhone { get; set; }
        public string Plate { get; set; }
        public string DriverName { get; set; }
        public string DriverPhone { get; set; }
        public string DealerCode { get; set; }
        public string VehType { get; set; }
        public int Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string DriverIdNum { get; set; }
        public string SendPersonName { get; set; }
        public string SendPersonPhone { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public Nullable<int> LoadType { get; set; }
    }
}
