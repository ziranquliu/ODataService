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
    
    public partial class DspOEMOutOrderView
    {
        public string OEMOutOrderCode { get; set; }
        public string ShippingOrderCode { get; set; }
        public string ShippingSuppler { get; set; }
        public Nullable<System.DateTime> SendDate { get; set; }
        public string ShippingType { get; set; }
        public string ShippingSpace { get; set; }
        public string ShippingWay { get; set; }
        public Nullable<int> AvdDate { get; set; }
        public string ExpressContact { get; set; }
        public string ExpressPlate { get; set; }
        public string EntryStockCode { get; set; }
        public Nullable<long> CheckOn { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
