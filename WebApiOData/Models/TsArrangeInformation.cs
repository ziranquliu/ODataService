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
    
    public partial class TsArrangeInformation
    {
        public long Id { get; set; }
        public Nullable<long> AdvisoryOrderId { get; set; }
        public string StartingPoint { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public string Destination { get; set; }
        public Nullable<System.DateTime> ArrivalDate { get; set; }
        public Nullable<int> Transportation { get; set; }
        public string Instruction { get; set; }
        public Nullable<bool> InviteThreeLine { get; set; }
        public string InvitationNote { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<int> Type { get; set; }
    }
}
