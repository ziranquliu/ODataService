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
    
    public partial class SpmZCDBoxInfo
    {
        public long Id { get; set; }
        public string BoxNum { get; set; }
        public string PackingOrderCode { get; set; }
        public long SOId { get; set; }
        public string DealerCode { get; set; }
        public string POCode { get; set; }
        public Nullable<long> POId { get; set; }
        public bool IsDeleted { get; set; }
        public string ShippingOrderCode { get; set; }
    }
}
