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
    
    public partial class fr_smsrecord
    {
        public int ID { get; set; }
        public string receiver { get; set; }
        public string mobile { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> logtime { get; set; }
        public Nullable<bool> result { get; set; }
        public string detail { get; set; }
        public string sender { get; set; }
    }
}
