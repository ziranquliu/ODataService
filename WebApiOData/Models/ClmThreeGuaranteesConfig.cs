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
    
    public partial class ClmThreeGuaranteesConfig
    {
        public long Id { get; set; }
        public string ClauseId { get; set; }
        public short WarningLevel { get; set; }
        public string WarmingTitle { get; set; }
        public string WarmingDesc { get; set; }
        public bool HasYellowWarming { get; set; }
        public Nullable<int> YellowValueStart { get; set; }
        public Nullable<int> YellowValueEnd { get; set; }
        public bool HasOrangeWarming { get; set; }
        public Nullable<int> OrangeValueStart { get; set; }
        public Nullable<int> OrangeValueEnd { get; set; }
        public bool HasRedWarming { get; set; }
        public Nullable<int> RedValueStart { get; set; }
        public Nullable<int> RedValueEnd { get; set; }
        public string JudgmentBasis { get; set; }
        public Nullable<int> WarmingVehicleAge_F { get; set; }
        public Nullable<int> WarmingVehicleAge_T { get; set; }
        public Nullable<int> WarmingMileage_F { get; set; }
        public Nullable<int> WarmingMileage_T { get; set; }
        public string AdoptedMeasures { get; set; }
        public string PreWarningContent { get; set; }
        public string WarningContent { get; set; }
        public string ApplicateRange { get; set; }
        public string UnitType { get; set; }
        public string UnitRuleType { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public int IsManualTrigger { get; set; }
        public Nullable<System.DateTime> ValidityPeriodFrom { get; set; }
        public Nullable<System.DateTime> ValidityPeriodTo { get; set; }
        public string VehicleAttr { get; set; }
        public Nullable<int> IsMajorPart { get; set; }
        public Nullable<System.DateTime> PublishTime { get; set; }
        public int WarrantyType { get; set; }
        public Nullable<long> LinkId { get; set; }
        public string AddMethod { get; set; }
    }
}