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
    
    public partial class MdmSupplierInfo
    {
        public long Id { get; set; }
        public string SupplierNo { get; set; }
        public string Duns { get; set; }
        public string SupplierName { get; set; }
        public string SupplierSName { get; set; }
        public string SupplierEngName { get; set; }
        public string SupplierEngSName { get; set; }
        public string SupplierAddr { get; set; }
        public string SupplierType { get; set; }
        public string ContactName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactTel { get; set; }
        public string ContactFax { get; set; }
        public string ContactMobile { get; set; }
        public string ContactEmail { get; set; }
        public string NightContactName { get; set; }
        public string NightContactTel { get; set; }
        public string NightContactFax { get; set; }
        public string NightContactMobile { get; set; }
        public string NightContactEmail { get; set; }
        public string DayContactName { get; set; }
        public string DayContactTel { get; set; }
        public string DayContactFax { get; set; }
        public string DayContactMobile { get; set; }
        public string DayContactEmail { get; set; }
        public string Country { get; set; }
        public string Area { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public Nullable<long> SupplierGroup { get; set; }
        public string AccountGroup { get; set; }
        public string CustomerCode { get; set; }
        public string Postcode { get; set; }
        public int Type { get; set; }
        public string BankCountryCode { get; set; }
        public string SWIFTCode { get; set; }
        public string BankAccount { get; set; }
        public string BankAccountOwnerName { get; set; }
        public string BankName { get; set; }
        public string PurchaseOrderCurrency { get; set; }
        public string PaymentConditionCode { get; set; }
        public string LanguageCode { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Comments { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public string Bukrs { get; set; }
        public string Werks { get; set; }
        public string Action { get; set; }
        public string STCD5 { get; set; }
        public int Source { get; set; }
        public bool SAPCreated { get; set; }
        public string HeadquartersAccount { get; set; }
        public string LNRZE { get; set; }
    }
}
