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
    
    public partial class SpmAssembleView
    {
        public long TransId { get; set; }
        public string TransNo { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string ZoneNo { get; set; }
        public string TargetWmNo { get; set; }
        public string TargetZoneNo { get; set; }
        public Nullable<System.DateTime> TransTime { get; set; }
        public Nullable<System.DateTime> PublishTime { get; set; }
        public int TransType { get; set; }
        public Nullable<long> TransKeeper { get; set; }
        public Nullable<int> Status { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string Comments { get; set; }
        public string TransDepartment { get; set; }
        public string Picker { get; set; }
        public string ContactTel { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string BusinessNo { get; set; }
        public Nullable<long> ItemNo { get; set; }
        public string UserName { get; set; }
        public string AssembleStatus { get; set; }
    }
}
