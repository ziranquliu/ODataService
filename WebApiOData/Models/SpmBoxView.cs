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
    
    public partial class SpmBoxView
    {
        public string StatusName { get; set; }
        public string RegionName { get; set; }
        public string POCode { get; set; }
        public Nullable<int> PoType { get; set; }
        public string PoTypeName { get; set; }
        public string DealerCode { get; set; }
        public string DealerName { get; set; }
        public string SONo { get; set; }
        public long Id { get; set; }
        public string BoxNum { get; set; }
        public long SOId { get; set; }
        public long OutputID { get; set; }
        public int Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string BoxStatus { get; set; }
        public string WmNo { get; set; }
        public string WmName { get; set; }
        public int PackageMethod { get; set; }
        public string PackageMethodName { get; set; }
        public Nullable<System.DateTime> FinishBoxingTime { get; set; }
        public string PartNo { get; set; }
        public Nullable<int> BoxStatusCode { get; set; }
        public string ExpressNo { get; set; }
        public Nullable<System.DateTime> ReceiveTime { get; set; }
        public string UserName { get; set; }
    }
}
