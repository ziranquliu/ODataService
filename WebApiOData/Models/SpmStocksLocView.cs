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
    
    public partial class SpmStocksLocView
    {
        public long Id { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string ZoneNo { get; set; }
        public string Dloc { get; set; }
        public string PartNo { get; set; }
        public decimal Stocks { get; set; }
        public Nullable<int> StorageType { get; set; }
        public Nullable<int> ZoneType { get; set; }
        public string ZoneTypeName { get; set; }
        public string NameCn { get; set; }
        public string NameEn { get; set; }
        public int LocId { get; set; }
    }
}
