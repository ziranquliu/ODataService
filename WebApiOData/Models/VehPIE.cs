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
    
    public partial class VehPIE
    {
        public long Id { get; set; }
        public string VIN { get; set; }
        public string VDN { get; set; }
        public string TU_ID { get; set; }
        public string ICCID { get; set; }
        public string IMSI { get; set; }
        public string MSISDN { get; set; }
        public string FC_Code { get; set; }
        public string IHU_ID { get; set; }
        public string RECORD_TIME { get; set; }
        public string IHU_Version { get; set; }
        public string TEM_Version { get; set; }
        public string IHU_System_Version { get; set; }
        public string TEM_System_Version { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
    }
}