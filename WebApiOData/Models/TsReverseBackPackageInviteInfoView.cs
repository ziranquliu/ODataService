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
    
    public partial class TsReverseBackPackageInviteInfoView
    {
        public long Id { get; set; }
        public Nullable<long> ReportId { get; set; }
        public string BaseNumber { get; set; }
        public string WarrantyClaim { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Province { get; set; }
        public string Distributor { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string CodeVIN { get; set; }
        public string CarModel { get; set; }
        public string PlateNumber { get; set; }
        public string CodeCSC { get; set; }
        public Nullable<System.DateTime> ArrivalTime { get; set; }
        public Nullable<bool> ThreeStatus { get; set; }
        public Nullable<bool> CustomerServiceStatus { get; set; }
        public string CaseQualityStatus { get; set; }
        public string ReverseStatus { get; set; }
        public string DealerCode { get; set; }
        public string OtherOrderId { get; set; }
        public Nullable<bool> CarIsInShop { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<long> CarInfoId { get; set; }
        public Nullable<long> otherId { get; set; }
        public string otherOrderId1 { get; set; }
        public Nullable<int> OrderType { get; set; }
        public string dealerStatus { get; set; }
        public string maintenanceStatus { get; set; }
    }
}