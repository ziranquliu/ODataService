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
    
    public partial class CrmCareTemplate
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string OssKey { get; set; }
        public Nullable<short> Type { get; set; }
        public string SmsCode { get; set; }
        public string SmsSignature { get; set; }
        public string EmailNickname { get; set; }
        public string TopicName { get; set; }
        public Nullable<long> TopicId { get; set; }
        public Nullable<long> ActivityId { get; set; }
        public string ActivityName { get; set; }
        public Nullable<int> SendNum { get; set; }
        public Nullable<bool> IsValid { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Commons { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string Identifier { get; set; }
        public Nullable<short> Importance { get; set; }
        public string Content { get; set; }
        public Nullable<long> TemplateId { get; set; }
        public long ID { get; set; }
        public string SmsId { get; set; }
        public Nullable<long> SmsConfigId { get; set; }
    }
}