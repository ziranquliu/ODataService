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
    
    public partial class VehCarrierBill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehCarrierBill()
        {
            this.VehCarrierBillDeliveryOrders = new HashSet<VehCarrierBillDeliveryOrder>();
            this.VehCarrierBillPrintedLogs = new HashSet<VehCarrierBillPrintedLog>();
        }
    
        public long Id { get; set; }
        public string Code { get; set; }
        public Nullable<byte> Type { get; set; }
        public Nullable<long> DealerId { get; set; }
        public Nullable<long> DealerWareHouseId { get; set; }
        public Nullable<long> WarehouseId { get; set; }
        public Nullable<long> OnsiteAdministrator { get; set; }
        public string CarrierCode { get; set; }
        public string OldCarrierCode { get; set; }
        public string Receiver { get; set; }
        public Nullable<System.DateTime> OrderTime { get; set; }
        public Nullable<System.DateTime> DeliveryTime { get; set; }
        public Nullable<System.DateTime> Plandate { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> ShipmentFee { get; set; }
        public Nullable<byte> ShipmentType { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> BeginDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> ArriveDate { get; set; }
        public string EMSNo { get; set; }
        public Nullable<long> ChariotId { get; set; }
        public Nullable<int> PrintCount { get; set; }
        public Nullable<long> DriverId { get; set; }
        public string LicenseNumber { get; set; }
        public string MobileNo { get; set; }
        public Nullable<System.DateTime> InDealerWareHouseTime { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public bool MarkupHelperCarrier { get; set; }
        public bool IsTwoTransit { get; set; }
        public bool TwoTransitConfirm { get; set; }
        public Nullable<long> EndWarehouseId { get; set; }
        public string AssignChariotRemark { get; set; }
        public int SAPCreated { get; set; }
        public long ShipmentLineId { get; set; }
        public string DriverLicense { get; set; }
        public string DriverName { get; set; }
        public string LicensePlateNumber { get; set; }
        public string DriverMobileNo { get; set; }
    
        public virtual VehChariot VehChariot { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehCarrierBillDeliveryOrder> VehCarrierBillDeliveryOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehCarrierBillPrintedLog> VehCarrierBillPrintedLogs { get; set; }
    }
}