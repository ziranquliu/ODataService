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
    
    public partial class SpmTransDetailDView
    {
        public long TransDetailId { get; set; }
        public long TransId { get; set; }
        public string TransNo { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string ZoneNo { get; set; }
        public string Dloc { get; set; }
        public string PartNo { get; set; }
        public Nullable<decimal> ActualPartCount { get; set; }
        public string NameCn { get; set; }
        public string NameEn { get; set; }
        public Nullable<int> Status { get; set; }
        public string StatusName { get; set; }
        public int PartNum { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string Comments { get; set; }
        public Nullable<long> BusinessNo { get; set; }
        public Nullable<long> ParentId { get; set; }
        public string StorageTypeName { get; set; }
    }
}