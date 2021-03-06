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
    
    public partial class VehScrewJoint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehScrewJoint()
        {
            this.VehBolts = new HashSet<VehBolt>();
        }
    
        public long Id { get; set; }
        public string Plant { get; set; }
        public string ModelYear { get; set; }
        public string Mix { get; set; }
        public string Type { get; set; }
        public string Chassis { get; set; }
        public string Body { get; set; }
        public string Time { get; set; }
        public string VCCScrewJointControllerId { get; set; }
        public string Line { get; set; }
        public string StationId { get; set; }
        public string EquipmentId { get; set; }
        public string ToolType { get; set; }
        public string PIINo { get; set; }
        public string Specification { get; set; }
        public string LineStopping { get; set; }
        public string JointStatus { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Commons { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehBolt> VehBolts { get; set; }
    }
}
