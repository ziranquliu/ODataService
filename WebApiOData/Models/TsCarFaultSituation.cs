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
    
    public partial class TsCarFaultSituation
    {
        public long Id { get; set; }
        public Nullable<long> OrderId { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<System.DateTime> DrivingTime { get; set; }
        public Nullable<System.DateTime> StopTime { get; set; }
        public Nullable<decimal> DrivingKM { get; set; }
        public Nullable<System.DateTime> FirstTime { get; set; }
        public Nullable<decimal> FirstKM { get; set; }
        public Nullable<System.DateTime> HappenTime { get; set; }
        public Nullable<decimal> HappenKM { get; set; }
        public Nullable<bool> IsChange { get; set; }
        public string ChangeDescribe { get; set; }
        public string Unit7 { get; set; }
        public string Unit8 { get; set; }
        public string Unit9 { get; set; }
        public Nullable<bool> Status1 { get; set; }
        public Nullable<bool> Status2 { get; set; }
        public Nullable<bool> Status3 { get; set; }
        public Nullable<bool> Status4 { get; set; }
        public Nullable<bool> Status5 { get; set; }
        public Nullable<bool> Status6 { get; set; }
        public Nullable<bool> Status7 { get; set; }
        public Nullable<bool> Status8 { get; set; }
        public Nullable<bool> Status9 { get; set; }
        public Nullable<bool> Status10 { get; set; }
        public string OtherComment { get; set; }
        public Nullable<bool> Status11 { get; set; }
        public Nullable<decimal> Gasoline { get; set; }
        public string Unit10 { get; set; }
        public string GasolineType { get; set; }
        public Nullable<bool> Status12 { get; set; }
        public Nullable<decimal> InfoCNG { get; set; }
        public string Unit11 { get; set; }
        public Nullable<bool> Status13 { get; set; }
        public Nullable<decimal> InfoLPG { get; set; }
        public string Unit12 { get; set; }
        public Nullable<System.DateTime> LastTime { get; set; }
        public Nullable<decimal> FuelRest { get; set; }
        public string Unit13 { get; set; }
        public string History { get; set; }
    }
}
