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
    
    public partial class DspRequisitionDetailLog
    {
        public long Id { get; set; }
        public string RequisitionCode { get; set; }
        public string SpCode { get; set; }
        public string SpName { get; set; }
        public string WarehouseCode { get; set; }
        public string StorageCode { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> Q { get; set; }
        public Nullable<decimal> P { get; set; }
        public Nullable<decimal> A { get; set; }
        public Nullable<int> ReturnBy { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string Currency { get; set; }
    }
}
