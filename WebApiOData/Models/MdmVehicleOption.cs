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
    
    public partial class MdmVehicleOption
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MdmVehicleOption()
        {
            this.MdmVehicleAndOptionRelations = new HashSet<MdmVehicleAndOptionRelation>();
        }
    
        public string Optioncode { get; set; }
        public string Name { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsStopped { get; set; }
        public string OwnerID { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> Effectiveindate { get; set; }
        public Nullable<System.DateTime> Effectiveoutdate { get; set; }
        public Nullable<long> EngineeringVehicletypeid { get; set; }
        public Nullable<System.DateTime> Updatedtime { get; set; }
        public string Description { get; set; }
        public string Saleable { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public Nullable<System.DateTime> SalesEffectiveInDate { get; set; }
        public Nullable<System.DateTime> SalesEffectiveOutDate { get; set; }
        public string SalesDesc { get; set; }
        public Nullable<bool> IsDefault { get; set; }
        public string FamilyId { get; set; }
        public string FamilyDesc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MdmVehicleAndOptionRelation> MdmVehicleAndOptionRelations { get; set; }
    }
}
