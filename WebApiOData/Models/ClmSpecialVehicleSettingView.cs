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
    
    public partial class ClmSpecialVehicleSettingView
    {
        public long Id { get; set; }
        public string VIN { get; set; }
        public string PolicyCode { get; set; }
        public string PolicyType { get; set; }
        public string Comments { get; set; }
        public string ScrapType { get; set; }
        public string ScrapTypeName { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<long> DealerId { get; set; }
        public Nullable<long> Carmaster { get; set; }
        public string OwnerName { get; set; }
        public string OwnerContact { get; set; }
        public string OwnerAddress { get; set; }
        public Nullable<int> Carproperty { get; set; }
        public string UseProperty { get; set; }
        public Nullable<decimal> Lastkeepmile { get; set; }
        public string Licenseno { get; set; }
        public Nullable<System.DateTime> Manufacturingdate { get; set; }
        public string Enginenumber { get; set; }
        public string CarModel { get; set; }
        public string AttachUploadId { get; set; }
        public string Culture { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
    }
}