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
    
    public partial class VehRO
    {
        public Nullable<long> Bankid { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public long Id { get; set; }
        public long DealerId { get; set; }
        public Nullable<decimal> Earnest { get; set; }
        public Nullable<decimal> Totalamount { get; set; }
        public Nullable<long> Carmaterialid { get; set; }
        public Nullable<System.DateTime> Orderdate { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<decimal> Price { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Remark { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] DateTimeStamp { get; set; }
        public Nullable<long> Customer { get; set; }
        public Nullable<long> Contactid { get; set; }
        public Nullable<int> Retailordertype { get; set; }
        public Nullable<decimal> Stdprice { get; set; }
        public Nullable<System.DateTime> Paydeposit_time { get; set; }
        public Nullable<long> Insurancecompanyid { get; set; }
        public string InvoiceName { get; set; }
        public Nullable<long> Ownerid { get; set; }
        public Nullable<int> Retaillocktype { get; set; }
        public Nullable<System.DateTime> Createdonmall { get; set; }
        public string Createdbymall { get; set; }
        public Nullable<int> Dataplatform { get; set; }
        public Nullable<long> Wsorderid { get; set; }
        public string Deliverytime { get; set; }
        public string Deliveryweek { get; set; }
        public string Name { get; set; }
        public string Lineid { get; set; }
        public Nullable<int> Lineorder2 { get; set; }
        public Nullable<int> Lineorder1 { get; set; }
        public Nullable<long> Transactioncurrencyid { get; set; }
        public Nullable<int> Orderstatus { get; set; }
        public string Vin { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public Nullable<bool> UseInsurance { get; set; }
        public Nullable<bool> UseFinance { get; set; }
        public Nullable<long> MatchVinCode { get; set; }
        public Nullable<int> CarReservationStatus { get; set; }
    }
}