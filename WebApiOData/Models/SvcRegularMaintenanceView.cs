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
    
    public partial class SvcRegularMaintenanceView
    {
        public long VehicleId { get; set; }
        public string Vin { get; set; }
        public string Licenseno { get; set; }
        public Nullable<long> Carmaster { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhone { get; set; }
        public string OwnerTel { get; set; }
        public string VehicleTypeName { get; set; }
        public string DealerCode { get; set; }
        public string DealerName { get; set; }
        public Nullable<long> ServiceAdvisorId { get; set; }
        public string ServiceAdvisorName { get; set; }
        public Nullable<decimal> Mileage { get; set; }
        public Nullable<System.DateTime> VehicleAge { get; set; }
    }
}
