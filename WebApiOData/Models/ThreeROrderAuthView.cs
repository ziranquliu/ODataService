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
    
    public partial class ThreeROrderAuthView
    {
        public long Id { get; set; }
        public string DealerName { get; set; }
        public string ServiceProxyCode { get; set; }
        public string SystemOrder { get; set; }
        public Nullable<System.DateTime> ArrivalOn { get; set; }
        public Nullable<int> FrozenStatus { get; set; }
        public string CustomerComment { get; set; }
        public string ReturnReason { get; set; }
        public Nullable<long> ReturnId { get; set; }
        public string ReturnName { get; set; }
        public string FrozenStatusName { get; set; }
        public Nullable<long> DealerId { get; set; }
        public string MaintainDealerId { get; set; }
        public string InquiryOrder { get; set; }
        public Nullable<int> CurrentType { get; set; }
        public string AlarmLevel { get; set; }
        public Nullable<int> AreamanagerReturnTimes { get; set; }
        public Nullable<int> ServicemanagerReturnTimes { get; set; }
        public string ProvinceName { get; set; }
        public Nullable<long> ProvinceId { get; set; }
        public string SmalAreaName { get; set; }
        public Nullable<long> SmalAreaId { get; set; }
        public string BigAreaName { get; set; }
        public Nullable<long> BigAreaId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    }
}
