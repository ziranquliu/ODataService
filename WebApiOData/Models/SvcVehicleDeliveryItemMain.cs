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
    
    public partial class SvcVehicleDeliveryItemMain
    {
        public long Id { get; set; }
        public Nullable<long> VehicleDeliveryId { get; set; }
        public string OwnerSignName { get; set; }
        public string OwnerSignPicPath { get; set; }
        public string ConsultantSignName { get; set; }
        public Nullable<System.DateTime> OwnerSignDate { get; set; }
        public string ConsultantSignPicPath { get; set; }
        public string ConsultanPhone { get; set; }
        public Nullable<System.DateTime> ConsultantSignDate { get; set; }
    }
}
