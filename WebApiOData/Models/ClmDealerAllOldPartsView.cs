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
    
    public partial class ClmDealerAllOldPartsView
    {
        public long PartId { get; set; }
        public long DealerId { get; set; }
        public string DealerCode { get; set; }
        public string Dealer { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> AreaId { get; set; }
        public string SupplierNo { get; set; }
        public string Supplier { get; set; }
        public string ESupplier { get; set; }
        public string WarrantyNo { get; set; }
        public int WarrantyType { get; set; }
        public int WarrantyCategory { get; set; }
        public long WarrantyId { get; set; }
        public int HasReturned { get; set; }
        public int ReturnNoticeStatus { get; set; }
        public string VIN { get; set; }
        public Nullable<System.DateTime> Manufacturingdate { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public string OldPartNo { get; set; }
        public string OldPartName { get; set; }
        public bool IsMain { get; set; }
        public Nullable<decimal> Quanlity { get; set; }
        public Nullable<System.DateTime> RepairEnd { get; set; }
        public int StockStatus { get; set; }
        public string StockStatusName { get; set; }
        public Nullable<int> Status { get; set; }
        public string CarModels { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public string CSC { get; set; }
        public string WorkOrderNo { get; set; }
        public Nullable<System.DateTime> SubmitOn { get; set; }
        public Nullable<System.DateTime> CloseJob { get; set; }
        public Nullable<System.DateTime> AuditOn { get; set; }
        public string Culture { get; set; }
    }
}