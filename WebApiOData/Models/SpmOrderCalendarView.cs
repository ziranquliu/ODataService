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
    
    public partial class SpmOrderCalendarView
    {
        public Nullable<long> Id { get; set; }
        public string DealerNum { get; set; }
        public string DealerName { get; set; }
        public Nullable<int> SupplyType { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string SupplyMorning { get; set; }
        public string SupplyAfterNoon { get; set; }
        public string GreenOrderStopTime { get; set; }
        public string SupplyCycle { get; set; }
        public int IsCreated { get; set; }
    }
}
