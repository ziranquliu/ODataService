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
    
    public partial class ClmAuditScrapItemView
    {
        public string ScrapNo { get; set; }
        public string FullName { get; set; }
        public System.DateTime ScrapApplyDate { get; set; }
        public string Country { get; set; }
        public Nullable<int> Status { get; set; }
        public decimal Quantity { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string ScrapStatement { get; set; }
        public string ApprovalComments { get; set; }
        public Nullable<System.DateTime> ArrivalDate { get; set; }
        public int ScrapMode { get; set; }
        public string Comments { get; set; }
    }
}