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
    
    public partial class RgmImprovementDetailView
    {
        public string ImprovementItem { get; set; }
        public string FullName { get; set; }
        public Nullable<long> DealerId { get; set; }
        public long PlanTaskTypeId { get; set; }
        public long BaseId { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public long Id { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<long> OwnerId { get; set; }
        public string UserId { get; set; }
        public string StatusName { get; set; }
        public string Comments1 { get; set; }
        public string Comments2 { get; set; }
        public string UserName { get; set; }
    }
}