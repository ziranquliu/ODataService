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
    
    public partial class FrRptSluggishPiece
    {
        public string DealerId { get; set; }
        public string SpCode { get; set; }
        public string Month { get; set; }
        public Nullable<int> Days { get; set; }
        public Nullable<decimal> StockQ { get; set; }
        public Nullable<decimal> AvailableQ { get; set; }
        public Nullable<decimal> FreezeQ { get; set; }
        public Nullable<decimal> EntryP { get; set; }
        public Nullable<decimal> EntryA { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}
