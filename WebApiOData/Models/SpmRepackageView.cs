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
    
    public partial class SpmRepackageView
    {
        public long Id { get; set; }
        public string RepackageNo { get; set; }
        public string TrayNo { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string ZoneNo { get; set; }
        public string Dloc { get; set; }
        public Nullable<long> BookKeeper { get; set; }
        public Nullable<System.DateTime> RepackageTime { get; set; }
        public Nullable<System.DateTime> RepackageCompleteTime { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string CompanyName { get; set; }
        public string WmName { get; set; }
        public string ZoneName { get; set; }
        public string DlocName { get; set; }
        public Nullable<long> DlocId { get; set; }
        public Nullable<long> ZoneId { get; set; }
        public Nullable<long> WmId { get; set; }
        public string StatusStr { get; set; }
        public string AsnNo { get; set; }
        public string UserName { get; set; }
        public string OutLocReason { get; set; }
    }
}
