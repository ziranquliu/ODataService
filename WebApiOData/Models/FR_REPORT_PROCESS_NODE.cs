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
    
    public partial class FR_REPORT_PROCESS_NODE
    {
        public decimal id { get; set; }
        public decimal processId { get; set; }
        public string name { get; set; }
        public string describe { get; set; }
        public string authority { get; set; }
        public string reportControl { get; set; }
        public Nullable<bool> needAllComplete { get; set; }
        public string alertControl { get; set; }
        public Nullable<bool> needOfflineReport { get; set; }
    }
}
