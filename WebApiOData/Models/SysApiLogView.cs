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
    
    public partial class SysApiLogView
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> OperationTime { get; set; }
        public string Module { get; set; }
        public string APItYPE { get; set; }
        public string Action { get; set; }
        public int Code { get; set; }
        public string Types { get; set; }
        public string Result { get; set; }
    }
}