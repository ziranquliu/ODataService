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
    
    public partial class VehDeliveryOrderCarOutFactoryConfirmView
    {
        public long CarrierBillId { get; set; }
        public long DeliveryOrderId { get; set; }
        public string VIN { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public int IsConfirm { get; set; }
        public string DeliveryOrderCode { get; set; }
        public string CarrierBillCode { get; set; }
    }
}
