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
    
    public partial class SpmDiffanalyseReportsView
    {
        public long Id { get; set; }
        public string ReportNo { get; set; }
        public string NotificationNo { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> CountStatus { get; set; }
        public string CountStatusName { get; set; }
        public Nullable<int> CountClass { get; set; }
        public string CountClassName { get; set; }
    }
}
