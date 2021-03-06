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
    
    public partial class SpmDPurchaseOrderDetailView
    {
        public Nullable<decimal> SoTotalDemandQuantity { get; set; }
        public Nullable<decimal> BoTotalDemandQuantity { get; set; }
        public Nullable<decimal> OutputQuantity { get; set; }
        public Nullable<decimal> TotalDemandQuantity { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public long Id { get; set; }
        public long POId { get; set; }
        public string PartNo { get; set; }
        public string Currency { get; set; }
        public decimal Price { get; set; }
        public decimal DemandQuantity { get; set; }
        public decimal AllocationQuantity { get; set; }
        public int Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string PartCname { get; set; }
        public string CodeVIN { get; set; }
        public string QueCode { get; set; }
        public string EngCode { get; set; }
        public string Attachment { get; set; }
        public string WrongPartNo { get; set; }
        public string WrongPartName { get; set; }
    }
}
