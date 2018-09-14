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
    
    public partial class MdmVehicleDocument
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Carproperty { get; set; }
        public string Certification { get; set; }
        public Nullable<long> Consultant { get; set; }
        public string Enginenumber { get; set; }
        public Nullable<System.DateTime> Gadate { get; set; }
        public string Gearnumber { get; set; }
        public Nullable<System.DateTime> Guaranteeenddate { get; set; }
        public Nullable<System.DateTime> Instock { get; set; }
        public Nullable<long> Insurancecompanyid { get; set; }
        public Nullable<System.DateTime> Insuranceenddate { get; set; }
        public Nullable<bool> Isopra { get; set; }
        public string Licenseno { get; set; }
        public Nullable<System.DateTime> Manufacturingdate { get; set; }
        public Nullable<long> Originplace { get; set; }
        public string Photourl { get; set; }
        public Nullable<long> Pno18 { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> Salesdate { get; set; }
        public Nullable<long> Salesdealerid { get; set; }
        public Nullable<int> Salesmileage { get; set; }
        public Nullable<long> Servicedealerid { get; set; }
        public string Vin { get; set; }
        public Nullable<long> Warehouse { get; set; }
        public string Warrantybook { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public Nullable<long> Brandid { get; set; }
        public Nullable<decimal> Lastrepairmile { get; set; }
        public Nullable<decimal> Lastkeepmile { get; set; }
        public Nullable<decimal> Latestmile { get; set; }
        public Nullable<System.DateTime> Lastrepairdate { get; set; }
        public Nullable<System.DateTime> Lastkeepdate { get; set; }
        public Nullable<System.DateTime> Latestkeepdate { get; set; }
        public Nullable<bool> Is3r { get; set; }
        public Nullable<System.DateTime> Insurancestartdate { get; set; }
        public string Chassismodel { get; set; }
        public Nullable<long> Carmaster { get; set; }
        public Nullable<int> SaleStatus { get; set; }
        public Nullable<int> PDIStatus { get; set; }
        public Nullable<System.DateTime> Guaranteestartdate { get; set; }
        public Nullable<bool> IsTransfer { get; set; }
        public Nullable<long> DealerID { get; set; }
        public Nullable<long> OwnerID { get; set; }
        public string PONO { get; set; }
        public Nullable<decimal> DailyAvgMileage { get; set; }
        public Nullable<System.DateTime> ShipmentOn { get; set; }
        public Nullable<System.DateTime> ArriveOn { get; set; }
    }
}
