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
    
    public partial class TsServiceNotification
    {
        public long Id { get; set; }
        public Nullable<long> CarId { get; set; }
        public string Theme { get; set; }
        public Nullable<int> Type { get; set; }
        public string Position { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public Nullable<int> FaultType { get; set; }
        public Nullable<int> Language { get; set; }
        public string IsBack { get; set; }
        public string Describe { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string ReportNo { get; set; }
    }
}
