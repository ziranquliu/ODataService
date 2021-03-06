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
    
    public partial class ClmCampaignWithRepairPackageView
    {
        public long Id { get; set; }
        public string CountryIds { get; set; }
        public string CampaignCode { get; set; }
        public string Description { get; set; }
        public string FieldActionType { get; set; }
        public string VehicleModel { get; set; }
        public string VINStart { get; set; }
        public string VINEnd { get; set; }
        public Nullable<System.DateTime> ProductionDateStart { get; set; }
        public Nullable<System.DateTime> ProductionDateEnd { get; set; }
        public System.DateTime FieldActionStartDate { get; set; }
        public Nullable<System.DateTime> FieldActionEndDate { get; set; }
        public decimal TargetCompletionRate { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string VINs { get; set; }
        public string AttachUploadId { get; set; }
        public string RepairPackageName { get; set; }
        public long RepairPackageId { get; set; }
        public string CSC { get; set; }
        public string CC { get; set; }
        public string RepairPackageCode { get; set; }
    }
}
