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
    
    public partial class ClmCampaignVINView
    {
        public long Id { get; set; }
        public string VIN { get; set; }
        public string UserName { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public long CampaignId { get; set; }
        public string IsCompletion { get; set; }
        public string IsCompletionName { get; set; }
        public Nullable<System.DateTime> CompletionTtime { get; set; }
        public string VehicleTypeName { get; set; }
        public Nullable<int> Carproperty { get; set; }
        public string UseType { get; set; }
        public Nullable<long> DistributeDealerId { get; set; }
        public string DealerName { get; set; }
        public string AttachUploadId { get; set; }
        public string Comments { get; set; }
        public string Licenseno { get; set; }
        public string OwnerName { get; set; }
        public string Name { get; set; }
        public string OwnerContact { get; set; }
        public string Culture { get; set; }
        public string CampaignCode { get; set; }
        public string DisplayName { get; set; }
    }
}
