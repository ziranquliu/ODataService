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
    
    public partial class TsWarrantyPartsView
    {
        public string warrantyNo { get; set; }
        public Nullable<bool> isMain { get; set; }
        public string partNo { get; set; }
        public string partName { get; set; }
        public string oldPartNo { get; set; }
        public string oldPartName { get; set; }
        public Nullable<decimal> quanlity { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> percents { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
        public Nullable<decimal> replyQuanlity { get; set; }
        public Nullable<decimal> replyPrice { get; set; }
        public Nullable<decimal> partsHandingCosts { get; set; }
        public Nullable<decimal> replyPercent { get; set; }
        public Nullable<decimal> replyTotalAmount { get; set; }
        public string currency { get; set; }
        public Nullable<int> hasReturned { get; set; }
        public Nullable<int> returnNoticeStatus { get; set; }
        public Nullable<int> hasReplied { get; set; }
    }
}
