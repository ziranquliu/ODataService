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
    
    public partial class CrIncidentV
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> ActualsolveTime { get; set; }
        public Nullable<System.DateTime> CloseTime { get; set; }
        public Nullable<System.DateTime> ComplaintsSendTime { get; set; }
        public string MobilePhone { get; set; }
        public Nullable<System.DateTime> Dealer1stResponseTime { get; set; }
        public string DealerFeedBack { get; set; }
        public Nullable<System.DateTime> ExpectSolveTime { get; set; }
        public string PgradeInterActiveRemarks { get; set; }
        public string ProblemDescription { get; set; }
        public string Solution { get; set; }
        public Nullable<System.DateTime> UpgradeTime { get; set; }
        public Nullable<long> DealerId { get; set; }
        public string DealerCode { get; set; }
        public string DealerName { get; set; }
        public string ShortName { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCode { get; set; }
        public string OwnerName { get; set; }
        public string OwnerTel { get; set; }
        public string IsBuyIntention { get; set; }
        public string IsUpgrade { get; set; }
        public string Channel { get; set; }
        public string CaseOriginCode { get; set; }
        public string IncidentStatus { get; set; }
        public string SeverityCode { get; set; }
        public string CaseLevel1Name { get; set; }
        public string CaseLevel2Name { get; set; }
        public string CaseLevel3Name { get; set; }
        public string CaseLevel4Name { get; set; }
        public string VisitResults { get; set; }
        public string OrderNumber { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public long ModifiedBy { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
    }
}
