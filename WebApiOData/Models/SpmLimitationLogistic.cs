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
    
    public partial class SpmLimitationLogistic
    {
        public long Id { get; set; }
        public string DealerNum { get; set; }
        public string DealerName { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public int ArrivalDays { get; set; }
        public string Contact { get; set; }
        public string ContactNum { get; set; }
        public Nullable<int> Logistics { get; set; }
        public Nullable<int> OrderType { get; set; }
        public Nullable<bool> IsDefaultWarehouse { get; set; }
        public string DeliveryAddress { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<int> OrdinaryOrderArrivalDays { get; set; }
        public Nullable<int> EmergencyOrderArrivalDays { get; set; }
        public Nullable<int> GreenPathOrderArrivalDays { get; set; }
    }
}
