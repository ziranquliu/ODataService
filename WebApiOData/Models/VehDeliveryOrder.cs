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
    
    public partial class VehDeliveryOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehDeliveryOrder()
        {
            this.VehCarrierBillDeliveryOrders = new HashSet<VehCarrierBillDeliveryOrder>();
            this.VehDeliveryOrderCars = new HashSet<VehDeliveryOrderCar>();
        }
    
        public long Id { get; set; }
        public Nullable<long> DealerId { get; set; }
        public string Code { get; set; }
        public Nullable<byte> ReferOrderType { get; set; }
        public string ReferOrderCode { get; set; }
        public string ShipmentAreaCode { get; set; }
        public string WarehouseId { get; set; }
        public bool IsCarriering { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public bool IsTwoTransitConfirm { get; set; }
        public long CurrentWarehouseId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehCarrierBillDeliveryOrder> VehCarrierBillDeliveryOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehDeliveryOrderCar> VehDeliveryOrderCars { get; set; }
    }
}
