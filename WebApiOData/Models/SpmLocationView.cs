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
    
    public partial class SpmLocationView
    {
        public long Id { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string ZoneNo { get; set; }
        public string Dloc { get; set; }
        public string DlocName { get; set; }
        public Nullable<int> SpeedType { get; set; }
        public string SpeedTypeName { get; set; }
        public Nullable<int> IsUsed { get; set; }
        public string IsUsedName { get; set; }
        public Nullable<int> StockCode { get; set; }
        public string StockCodeName { get; set; }
        public Nullable<decimal> Capacity { get; set; }
        public Nullable<decimal> Volume { get; set; }
        public Nullable<decimal> MaxWeight { get; set; }
        public Nullable<int> Useage { get; set; }
        public string UseageName { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string Comments { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> ZoneType { get; set; }
        public Nullable<long> ZoneId { get; set; }
        public Nullable<long> WmId { get; set; }
        public Nullable<decimal> Length { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Width { get; set; }
        public string UserName { get; set; }
        public Nullable<int> LocId { get; set; }
        public string LocIdName { get; set; }
    }
}