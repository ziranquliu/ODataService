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
    
    public partial class DdVehicleInformation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DdVehicleInformation()
        {
            this.DdECUs = new HashSet<DdECU>();
            this.DdScriptInformations = new HashSet<DdScriptInformation>();
            this.DdVehicleExtensions = new HashSet<DdVehicleExtension>();
        }
    
        public long ID { get; set; }
        public string VIN { get; set; }
        public Nullable<int> Fyon { get; set; }
        public string ChassisNumber { get; set; }
        public string VehicleType { get; set; }
        public Nullable<int> StructureWeek { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string ModelYear { get; set; }
        public string Model { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<System.Guid> Guid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DdECU> DdECUs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DdScriptInformation> DdScriptInformations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DdVehicleExtension> DdVehicleExtensions { get; set; }
    }
}
