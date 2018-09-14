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
    
    public partial class CrCase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CrCase()
        {
            this.CrCaseTasks = new HashSet<CrCaseTask>();
        }
    
        public long Id { get; set; }
        public string Code { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<int> CaseChannel { get; set; }
        public string ContactPhone { get; set; }
        public Nullable<long> Contact { get; set; }
        public Nullable<long> Vehicle { get; set; }
        public Nullable<long> Dealer { get; set; }
        public Nullable<long> Class1 { get; set; }
        public Nullable<long> Class2 { get; set; }
        public Nullable<long> Class3 { get; set; }
        public Nullable<long> Class4 { get; set; }
        public Nullable<int> ComplaintLevel { get; set; }
        public string Question { get; set; }
        public string ConsultAnswer { get; set; }
        public Nullable<int> CaseResolveStatus { get; set; }
        public Nullable<System.DateTime> CaseSolutionSubTime { get; set; }
        public string CaseSolution { get; set; }
        public Nullable<System.DateTime> ComplaintDistributionTime { get; set; }
        public Nullable<System.DateTime> DealerReceiveTime { get; set; }
        public Nullable<bool> DealerReceiveStatus { get; set; }
        public string DealerUnacceptComments { get; set; }
        public Nullable<System.DateTime> Dealer1stResponseTime { get; set; }
        public Nullable<int> ComplaintEscalationStatus { get; set; }
        public Nullable<System.DateTime> ComplaintEscalationTime { get; set; }
        public Nullable<int> ComplaintCloseStatus { get; set; }
        public Nullable<System.DateTime> ComplaintCloseTime { get; set; }
        public Nullable<int> ComplaintForceCloseStatus { get; set; }
        public Nullable<System.DateTime> ComplaintForceCloseTime { get; set; }
        public Nullable<int> ContactReceive { get; set; }
        public Nullable<int> ContactObCounter { get; set; }
        public Nullable<bool> IsParts { get; set; }
        public string PartsComments { get; set; }
        public Nullable<bool> IsTsno { get; set; }
        public string Tsno { get; set; }
        public string ReplacementCarComments { get; set; }
        public Nullable<decimal> CustomerCareAmount { get; set; }
        public Nullable<bool> IsApplyCare { get; set; }
        public Nullable<int> GoodwillApproval { get; set; }
        public Nullable<System.DateTime> CustomerCareApprovalTime { get; set; }
        public string BusinessApplyCode { get; set; }
        public Nullable<int> ProcessDepartment { get; set; }
        public string ContactBaseInfo { get; set; }
        public string ApprovalComments { get; set; }
        public Nullable<long> CurrentStage { get; set; }
        public string DealerQuestion { get; set; }
        public Nullable<int> CurrentApprovalProcess { get; set; }
        public Nullable<long> OwnerId { get; set; }
        public Nullable<bool> IsForceClose { get; set; }
        public string ProgramApprovalStatus { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public string CaseTag { get; set; }
        public Nullable<System.DateTime> BuyCarOn { get; set; }
        public Nullable<System.DateTime> ExpectedEndDate { get; set; }
        public string OwnerName { get; set; }
        public string Topic { get; set; }
        public Nullable<int> CallTimes { get; set; }
        public string ProcessDesc { get; set; }
        public string VisitResults { get; set; }
        public string OrderNumber { get; set; }
        public string Licenseno { get; set; }
        public bool IsCreateImprovementItem { get; set; }
        public Nullable<System.DateTime> ShipmentOn { get; set; }
        public Nullable<System.DateTime> ArriveOn { get; set; }
        public Nullable<System.DateTime> ExpectedCloseOn { get; set; }
        public Nullable<int> IsTimeout { get; set; }
        public Nullable<int> IsWarning { get; set; }
        public Nullable<int> IsOwnerCall { get; set; }
        public Nullable<int> ContactRelationShip { get; set; }
        public string Complainant { get; set; }
        public string ComplainantTel { get; set; }
        public Nullable<int> ComplainantSex { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CrCaseTask> CrCaseTasks { get; set; }
    }
}
