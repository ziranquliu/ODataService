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
    
    public partial class CrLeadClientFollowArea
    {
        public long Id { get; set; }
        public Nullable<long> ClientId { get; set; }
        public string ClientName { get; set; }
        public Nullable<short> Level { get; set; }
        public Nullable<short> ClientStatus { get; set; }
        public Nullable<long> ConsultantId { get; set; }
        public string ConsultantName { get; set; }
        public Nullable<long> ManagerId { get; set; }
        public string ManagerName { get; set; }
        public Nullable<long> DealerId { get; set; }
        public string DealerName { get; set; }
        public Nullable<short> Type { get; set; }
        public Nullable<short> Status { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<System.DateTime> Deadline { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public Nullable<System.DateTime> ModifyOn { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
