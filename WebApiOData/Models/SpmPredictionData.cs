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
    
    public partial class SpmPredictionData
    {
        public long Id { get; set; }
        public string ForecastNum { get; set; }
        public int Status { get; set; }
        public Nullable<int> ForcastType { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public string Purchaser { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string PartNo { get; set; }
        public string PartCName { get; set; }
        public string PartEName { get; set; }
        public Nullable<decimal> ForcastQuan1 { get; set; }
        public Nullable<decimal> ForcastQuan2 { get; set; }
        public Nullable<decimal> ForcastQuan3 { get; set; }
        public Nullable<decimal> ForcastQuan4 { get; set; }
        public Nullable<decimal> ForcastQuan5 { get; set; }
        public Nullable<decimal> ForcastQuan6 { get; set; }
        public Nullable<decimal> ForcastQuan12 { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
    }
}
