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
    
    public partial class TsForumOrder
    {
        public long Id { get; set; }
        public Nullable<long> GoodsId { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<long> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<int> ExchangeNum { get; set; }
        public string OrderId { get; set; }
        public string Address { get; set; }
        public string Receiver { get; set; }
        public Nullable<long> Telephone { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string ZipCode { get; set; }
    }
}