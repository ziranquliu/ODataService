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
    
    public partial class ClmReturnInfoView
    {
        public long Id { get; set; }
        public string ShipperExpressCompany { get; set; }
        public string Shipper { get; set; }
        public string ShipperContact { get; set; }
        public string ShipperAddress { get; set; }
        public Nullable<System.DateTime> ShipperTime { get; set; }
        public string ShipperCourierNumber { get; set; }
        public string ReceivingParty { get; set; }
        public string ReceivingPartyName { get; set; }
        public string Consignee { get; set; }
        public string ConsigneeContact { get; set; }
        public string ReceivingAddress { get; set; }
        public Nullable<System.DateTime> ReceivingTime { get; set; }
        public string WorkOrderNo { get; set; }
        public string AuthorizationKey { get; set; }
        public string WarrantyNo { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public string VIN { get; set; }
        public Nullable<int> StockStatus { get; set; }
    }
}
