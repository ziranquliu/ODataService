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
    
    public partial class SysOrg
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SysOrg()
        {
            this.SysOrg1 = new HashSet<SysOrg>();
            this.SysUserOrgs = new HashSet<SysUserOrg>();
        }
    
        public long Id { get; set; }
        public Nullable<long> Pid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }
        public Nullable<long> AreaId { get; set; }
        public Nullable<long> AdminAreaId { get; set; }
        public int Level { get; set; }
        public int Status { get; set; }
        public bool Root { get; set; }
        public string DealerCode { get; set; }
    
        public virtual SysAdminArea SysAdminArea { get; set; }
        public virtual SysArea SysArea { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SysOrg> SysOrg1 { get; set; }
        public virtual SysOrg SysOrg2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SysUserOrg> SysUserOrgs { get; set; }
    }
}
