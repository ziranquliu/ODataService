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
    
    public partial class TsConsultationQuestionOrAnswerView
    {
        public long id { get; set; }
        public string question { get; set; }
        public Nullable<long> createdBy { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> AskNum { get; set; }
        public Nullable<long> orderId { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public string answer { get; set; }
        public string comments { get; set; }
        public string diagnosis { get; set; }
        public string faultDescription { get; set; }
        public string measure { get; set; }
        public string name { get; set; }
        public string job { get; set; }
        public string POSITION { get; set; }
    }
}
