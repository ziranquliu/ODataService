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
    
    public partial class CrIncidentView
    {
        public long Id { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> ActualsolveTime { get; set; }
        public Nullable<bool> AddCaseLevel { get; set; }
        public Nullable<int> BeforeQueue { get; set; }
        public Nullable<long> CaseLevel1 { get; set; }
        public Nullable<long> CaseLevel2 { get; set; }
        public Nullable<long> CaseLevel3 { get; set; }
        public Nullable<long> CaseLevel31 { get; set; }
        public Nullable<long> CaseLevel32 { get; set; }
        public Nullable<long> CaseLevel33 { get; set; }
        public Nullable<long> CaseLevel4 { get; set; }
        public Nullable<long> CaseLevel41 { get; set; }
        public Nullable<long> CaseLevel42 { get; set; }
        public Nullable<long> CaseLevel43 { get; set; }
        public Nullable<int> Channel { get; set; }
        public Nullable<System.DateTime> CloseTime { get; set; }
        public Nullable<System.DateTime> ComplaintsSendTime { get; set; }
        public string ContactTel { get; set; }
        public Nullable<int> CurrentQueue { get; set; }
        public Nullable<long> Dealer { get; set; }
        public Nullable<System.DateTime> Dealer1stResponseTime { get; set; }
        public string DealerFeedBack { get; set; }
        public Nullable<System.DateTime> ExpectSolveTime { get; set; }
        public Nullable<long> Faq { get; set; }
        public string Fullname { get; set; }
        public Nullable<bool> Isbuyintention { get; set; }
        public Nullable<bool> IsNeedVisit { get; set; }
        public string PgradeInterActiveRemarks { get; set; }
        public string ProblemDescription { get; set; }
        public Nullable<System.DateTime> QualityCompletedOn { get; set; }
        public Nullable<int> QualityStatus { get; set; }
        public string QualityStatusRemark { get; set; }
        public Nullable<long> ServiceActivityIncident { get; set; }
        public string Solution { get; set; }
        public Nullable<System.DateTime> UpgraDetime { get; set; }
        public string VehicleClass { get; set; }
        public Nullable<long> VisitBy { get; set; }
        public string VisitContent { get; set; }
        public Nullable<System.DateTime> VisitOn { get; set; }
        public Nullable<int> VisitStatus { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Commons { get; set; }
        public long CreatedBy { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string CustomerId { get; set; }
        public Nullable<int> CaseOriginCode { get; set; }
        public Nullable<int> IncidentStatus { get; set; }
        public Nullable<int> SeverityCode { get; set; }
        public string IncidentId { get; set; }
    }
}
