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
    
    public partial class DspMissingPart
    {
        public long Id { get; set; }
        public string MissingPartCode { get; set; }
        public string BusinessCode { get; set; }
        public string PurchaseCode { get; set; }
        public Nullable<long> RegisterBy { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
        public Nullable<int> RegisterStyel { get; set; }
        public string DealerId { get; set; }
        public string DealerName { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string SystemOrder { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string PlateCode { get; set; }
        public Nullable<int> PayStatus { get; set; }
        public Nullable<System.DateTime> PayTime { get; set; }
        public string Vin { get; set; }
        public Nullable<int> OutFlag { get; set; }
    }
}
