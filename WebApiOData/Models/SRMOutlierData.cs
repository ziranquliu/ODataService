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
    
    public partial class SRMOutlierData
    {
        public long Id { get; set; }
        public string APINo { get; set; }
        public string APIDesc { get; set; }
        public Nullable<long> DataID { get; set; }
        public string OrderNo { get; set; }
        public int ErrNo { get; set; }
        public System.DateTime ErrNewOn { get; set; }
        public string ErrMessage { get; set; }
        public int Status { get; set; }
        public long CreateBy { get; set; }
        public System.DateTime CreateOn { get; set; }
        public bool IsDeleted { get; set; }
        public string Comments { get; set; }
        public byte[] DateTimeStamp { get; set; }
    }
}