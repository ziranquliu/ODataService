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
    
    public partial class ACT_RU_EXECUTION
    {
        public string ID_ { get; set; }
        public Nullable<int> REV_ { get; set; }
        public string PROC_INST_ID_ { get; set; }
        public string BUSINESS_KEY_ { get; set; }
        public string PARENT_ID_ { get; set; }
        public string PROC_DEF_ID_ { get; set; }
        public string SUPER_EXEC_ { get; set; }
        public string ACT_ID_ { get; set; }
        public Nullable<byte> IS_ACTIVE_ { get; set; }
        public Nullable<byte> IS_CONCURRENT_ { get; set; }
        public Nullable<byte> IS_SCOPE_ { get; set; }
        public Nullable<byte> IS_EVENT_SCOPE_ { get; set; }
        public Nullable<byte> SUSPENSION_STATE_ { get; set; }
        public Nullable<int> CACHED_ENT_STATE_ { get; set; }
        public string TENANT_ID_ { get; set; }
        public string NAME_ { get; set; }
        public Nullable<System.DateTime> LOCK_TIME_ { get; set; }
    }
}