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
    
    public partial class SpmNotificationHead
    {
        public long Id { get; set; }
        public string NotificationNo { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string ZoneNo { get; set; }
        public Nullable<int> CountType { get; set; }
        public Nullable<System.DateTime> CountTime { get; set; }
        public string ApplyKeeper { get; set; }
        public string BookKeeper { get; set; }
        public string PublishKeeper { get; set; }
        public Nullable<System.DateTime> PublishTime { get; set; }
        public Nullable<int> CountStatus { get; set; }
        public Nullable<int> EmergencyType { get; set; }
        public string CountReason { get; set; }
        public int ErpFlag { get; set; }
        public Nullable<int> ConfirmFlag { get; set; }
        public Nullable<int> CountClass { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
    }
}
