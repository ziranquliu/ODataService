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
    
    public partial class NoMatchView
    {
        public string SONO { get; set; }
        public string PNO { get; set; }
        public bool IsEmergency { get; set; }
        public bool IsScheduled { get; set; }
        public Nullable<int> PriorityLevel { get; set; }
        public long DealerId { get; set; }
        public Nullable<bool> PreMatch { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string PONO { get; set; }
        public string VehicleTypeName { get; set; }
        public string EngineName { get; set; }
        public string StyleName { get; set; }
        public string GearboxName { get; set; }
        public string VehicleDisplacement { get; set; }
        public string ConfigurationName { get; set; }
        public string ColorName { get; set; }
        public Nullable<System.DateTime> ReceiptDate { get; set; }
        public Nullable<int> WSOrderType { get; set; }
        public Nullable<long> Period { get; set; }
    }
}
