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
    
    public partial class ClmDealerReturnView
    {
        public long Id { get; set; }
        public string ReturnCode { get; set; }
        public long Country { get; set; }
        public string CountryName { get; set; }
        public string Dealer { get; set; }
        public string DealerCode { get; set; }
        public string DealerName { get; set; }
        public string DemandSide { get; set; }
        public string DemandSideName { get; set; }
        public string ReceivingParty { get; set; }
        public string ReceivingPartyName { get; set; }
        public string ReturnReason { get; set; }
        public string ReturnReasonName { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string AllReturn { get; set; }
        public string AllReturnName { get; set; }
        public bool IsDeleted { get; set; }
        public string Culture { get; set; }
    }
}
