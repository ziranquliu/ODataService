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
    
    public partial class SpmPurchaseOrder
    {
        public long Id { get; set; }
        public string CompanyNo { get; set; }
        public string WmNo { get; set; }
        public string PurchaseCode { get; set; }
        public string OrderNum { get; set; }
        public string SupplierCode { get; set; }
        public string PurchaseType { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public int HasApiRecived { get; set; }
        public Nullable<System.DateTime> ApiRecivedOn { get; set; }
        public Nullable<System.DateTime> ETAOn { get; set; }
        public bool SAPCreated { get; set; }
        public bool HasSRMConfirm { get; set; }
        public Nullable<System.DateTime> SRMConfirmDate { get; set; }
        public string ApiType { get; set; }
        public bool IsEmergency { get; set; }
    }
}
