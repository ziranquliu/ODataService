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
    
    public partial class SpmRepackageSeoView
    {
        public long Id { get; set; }
        public string TrayNo { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string ZoneNo { get; set; }
        public string Dloc { get; set; }
        public Nullable<int> Status { get; set; }
        public string StatusName { get; set; }
        public Nullable<long> BookKeeper { get; set; }
        public Nullable<System.DateTime> RepackageCompleteTime { get; set; }
        public string RepackageDetailNo { get; set; }
        public string PartNo { get; set; }
        public string BarcodeData { get; set; }
        public Nullable<decimal> Num { get; set; }
        public Nullable<decimal> ActualNum { get; set; }
        public string ReceiveNo { get; set; }
        public string AsnNo { get; set; }
        public string OrderNo { get; set; }
        public string NameCn { get; set; }
        public string UserName { get; set; }
    }
}
