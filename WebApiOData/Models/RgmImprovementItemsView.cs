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
    
    public partial class RgmImprovementItemsView
    {
        public long InspectId { get; set; }
        public string InspectItem { get; set; }
        public long PlanTaskTypeId { get; set; }
        public Nullable<double> ScoreAverage { get; set; }
        public Nullable<double> Score { get; set; }
        public Nullable<double> ScoceResult { get; set; }
        public string Comments { get; set; }
        public string DocumentUrl { get; set; }
    }
}