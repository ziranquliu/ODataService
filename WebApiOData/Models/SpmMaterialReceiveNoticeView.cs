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
    
    public partial class SpmMaterialReceiveNoticeView
    {
        public string SupplierName { get; set; }
        public Nullable<System.DateTime> ArrivalDate { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public long Id { get; set; }
        public string SupplierCode { get; set; }
        public string OrderNo { get; set; }
        public Nullable<System.DateTime> EstimateArrivalTime { get; set; }
        public Nullable<System.DateTime> ArrivalTime { get; set; }
        public Nullable<long> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public string StatusName { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
