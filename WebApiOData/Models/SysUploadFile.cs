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
    
    public partial class SysUploadFile
    {
        public System.Guid Id { get; set; }
        public string DisplayName { get; set; }
        public string UniqueName { get; set; }
        public string Suffix { get; set; }
        public long Size { get; set; }
        public string RegardingType { get; set; }
        public string RegardingKey { get; set; }
        public int Status { get; set; }
        public System.DateTime CreateTime { get; set; }
        public byte[] RowVersion { get; set; }
        public string EndpointName { get; set; }
    }
}
