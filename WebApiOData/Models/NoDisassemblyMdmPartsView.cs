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
    
    public partial class NoDisassemblyMdmPartsView
    {
        public long ID { get; set; }
        public string PartsCode { get; set; }
        public string NameCn { get; set; }
        public string NameEn { get; set; }
        public string Position { get; set; }
        public string PositionEn { get; set; }
        public string Quantity { get; set; }
        public Nullable<int> Amount { get; set; }
        public long ChildId { get; set; }
        public Nullable<long> ParentId { get; set; }
        public string SonCode { get; set; }
        public string SonName { get; set; }
        public decimal Stocks { get; set; }
        public Nullable<decimal> AllocateNum { get; set; }
        public Nullable<decimal> UsableStocks { get; set; }
        public Nullable<decimal> FrozenStocks { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string ZoneNo { get; set; }
        public string Dloc { get; set; }
    }
}
