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
    
    public partial class SpmMaterialReceiveNoticeDetailView
    {
        public long Id { get; set; }
        public Nullable<long> MaterialReceiveId { get; set; }
        public string PartsCode { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public decimal RemovedQuantity { get; set; }
        public Nullable<decimal> Take { get; set; }
        public string Units { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string NameCn { get; set; }
        public string NameEn { get; set; }
        public string OrderNo { get; set; }
        public string ReceiveNoticeCode { get; set; }
    }
}
