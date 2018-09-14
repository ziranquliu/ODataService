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
    
    public partial class SpmPackageStocks_dev
    {
        public long Id { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string ZoneNo { get; set; }
        public string Dloc { get; set; }
        public string PackageNo { get; set; }
        public string PackageCname { get; set; }
        public string PackageEname { get; set; }
        public Nullable<int> PackageUnits { get; set; }
        public Nullable<int> PackageType { get; set; }
        public Nullable<decimal> Max { get; set; }
        public Nullable<decimal> Min { get; set; }
        public Nullable<decimal> SafeStock { get; set; }
        public decimal Stocks { get; set; }
        public Nullable<int> StockStates { get; set; }
        public Nullable<decimal> FrozenStocks { get; set; }
        public Nullable<decimal> AvaliableStocks { get; set; }
        public string SupplierNum { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
    }
}