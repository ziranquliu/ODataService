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
    
    public partial class TsQualityCaseView
    {
        public long id { get; set; }
        public string orderId { get; set; }
        public string dealerId { get; set; }
        public string dealerName { get; set; }
        public string dealerShortName { get; set; }
        public string dealerFullName { get; set; }
        public string advTheme { get; set; }
        public string codeVIN { get; set; }
        public string dealerStatus { get; set; }
        public string customerServiceStatus { get; set; }
        public string threeLine { get; set; }
        public string carModel { get; set; }
        public string plateNumber { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public Nullable<long> createdBy { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public Nullable<long> modifiedBy { get; set; }
        public Nullable<int> orderStatus { get; set; }
        public Nullable<System.DateTime> happenTime { get; set; }
        public string canSeeRole { get; set; }
        public string label { get; set; }
    }
}
