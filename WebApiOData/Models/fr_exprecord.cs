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
    
    public partial class fr_exprecord
    {
        public int ID { get; set; }
        public string tname { get; set; }
        public Nullable<short> type { get; set; }
        public string param { get; set; }
        public string ip { get; set; }
        public string username { get; set; }
        public string userrole { get; set; }
        public Nullable<int> time { get; set; }
        public Nullable<System.DateTime> logtime { get; set; }
        public string sql { get; set; }
        public string browser { get; set; }
        public Nullable<decimal> memory { get; set; }
    }
}
