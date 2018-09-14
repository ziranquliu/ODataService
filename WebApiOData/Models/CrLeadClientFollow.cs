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
    
    public partial class CrLeadClientFollow
    {
        public long Id { get; set; }
        public Nullable<long> ClientId { get; set; }
        public Nullable<long> DealerId { get; set; }
        public string DealerName { get; set; }
        public Nullable<long> ConsultantId { get; set; }
        public string ConsultantName { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> Theme { get; set; }
        public string Content { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<byte> FollowType { get; set; }
        public Nullable<byte> FollowWay { get; set; }
        public Nullable<byte> FollowInTime { get; set; }
        public Nullable<long> RelationId { get; set; }
        public Nullable<System.DateTime> NextTime { get; set; }
        public Nullable<System.DateTime> InviteTime { get; set; }
        public string NextTheme { get; set; }
        public Nullable<long> ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public byte[] DateTimeStamp { get; set; }
    }
}
