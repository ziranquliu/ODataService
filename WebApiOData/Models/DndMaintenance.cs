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
    
    public partial class DndMaintenance
    {
        public long Id { get; set; }
        public string Brand { get; set; }
        public string Cohr { get; set; }
        public Nullable<int> ShopId { get; set; }
        public Nullable<int> SaleOf2014 { get; set; }
        public Nullable<decimal> ShareOf2014 { get; set; }
        public Nullable<int> BatchOf2014 { get; set; }
        public Nullable<int> SaleOf2015 { get; set; }
        public Nullable<decimal> ShareOf2015 { get; set; }
        public Nullable<int> BatchOf2015 { get; set; }
        public Nullable<int> SaleOf2016 { get; set; }
        public Nullable<decimal> ShareOf2016 { get; set; }
        public Nullable<int> BatchOf2016 { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> OrgId { get; set; }
        public string AgentNo { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public byte[] DateTimeStamp { get; set; }
    }
}