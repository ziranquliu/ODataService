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
    
    public partial class TsPost
    {
        public long Id { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<long> Sequence { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string Type { get; set; }
        public string ElitePost { get; set; }
        public Nullable<int> AdoptNum { get; set; }
        public string Theme { get; set; }
        public string FirstResw { get; set; }
        public string SecondResw { get; set; }
        public string Content { get; set; }
        public string TopResw { get; set; }
        public string Comment { get; set; }
        public string HomePage { get; set; }
        public string Classification { get; set; }
        public Nullable<bool> NeedPoint { get; set; }
        public Nullable<int> Points { get; set; }
        public Nullable<int> ViewNum { get; set; }
        public Nullable<int> ReplyNum { get; set; }
        public Nullable<int> DownNum { get; set; }
        public Nullable<int> CollectNum { get; set; }
        public Nullable<int> SupportNum { get; set; }
        public Nullable<int> Against { get; set; }
        public Nullable<int> RewardNum { get; set; }
        public Nullable<bool> IsRead { get; set; }
    }
}
