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
    
    public partial class VehBodyInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehBodyInfo()
        {
            this.VehPointInfoes = new HashSet<VehPointInfo>();
        }
    
        public long Id { get; set; }
        public Nullable<long> OrderId { get; set; }
        public string Record_Type { get; set; }
        public string TransmissionType { get; set; }
        public string PreproductionFlag { get; set; }
        public string FactoryOrderNumber { get; set; }
        public string PNO34 { get; set; }
        public string CarType { get; set; }
        public string BodyNumber { get; set; }
        public string BodyType { get; set; }
        public string Plant { get; set; }
        public string PosSerial { get; set; }
        public string PosId { get; set; }
        public string ModelYear { get; set; }
        public string TransactionDate { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Commons { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
    
        public virtual VehOrderInfo VehOrderInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehPointInfo> VehPointInfoes { get; set; }
    }
}
