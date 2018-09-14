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
    
    public partial class CrCaseTask
    {
        public long Id { get; set; }
        public Nullable<long> CaseId { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<int> TaskType { get; set; }
        public Nullable<int> Step { get; set; }
        public Nullable<int> Department { get; set; }
        public Nullable<long> OwnerId { get; set; }
        public string ApprovalComments { get; set; }
        public Nullable<long> SystemuserNext { get; set; }
        public Nullable<int> Approval { get; set; }
        public Nullable<int> CompleteStatus { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> CompleteTime { get; set; }
        public string TaskNo { get; set; }
        public Nullable<int> ResolvedStatus { get; set; }
        public string CaseSolution { get; set; }
        public Nullable<bool> DealerReceiveStatus { get; set; }
        public string DealerUnacceptComments { get; set; }
        public Nullable<long> SupOperator { get; set; }
        public string DealerQuestion { get; set; }
        public Nullable<decimal> GoodwillAmount { get; set; }
        public string GoodwillApplyCode { get; set; }
        public string GoodwillInfo { get; set; }
        public Nullable<long> Dealer { get; set; }
        public Nullable<int> ContactReceiveStatus { get; set; }
        public string ContactUnacceptComments { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
    
        public virtual CrCase CrCase { get; set; }
    }
}