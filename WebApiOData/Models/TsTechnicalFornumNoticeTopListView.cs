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
    
    public partial class TsTechnicalFornumNoticeTopListView
    {
        public long id { get; set; }
        public string theme { get; set; }
        public string content { get; set; }
        public Nullable<bool> otherStatus { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<int> sequnece { get; set; }
        public string comments { get; set; }
        public Nullable<long> createdBy { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<long> modifiedBy { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public string labels { get; set; }
        public Nullable<long> viewer { get; set; }
        public Nullable<System.DateTime> viewTime { get; set; }
    }
}