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
    
    public partial class MdmPartsHasContractView
    {
        public Nullable<long> RN { get; set; }
        public long Id { get; set; }
        public string PartsCode { get; set; }
        public string NameCn { get; set; }
        public string NameEn { get; set; }
        public string PartUnits { get; set; }
        public string Specification { get; set; }
        public Nullable<long> MaterialType1 { get; set; }
        public string MaterialCode1 { get; set; }
        public Nullable<long> MaterialType2 { get; set; }
        public string MaterialCode2 { get; set; }
        public Nullable<long> MaterialType3 { get; set; }
        public string MaterialCode3 { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string ContractNo { get; set; }
        public Nullable<decimal> AveragePrice { get; set; }
        public string PartUnit { get; set; }
        public string Currency { get; set; }
        public Nullable<int> PurchaseStatus { get; set; }
        public string PurchaseStatusStr { get; set; }
        public int IsChild { get; set; }
    }
}