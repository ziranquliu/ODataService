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
    
    public partial class TsDearlerView
    {
        public long id { get; set; }
        public string dealercode { get; set; }
        public string shortname { get; set; }
        public string fullname { get; set; }
        public Nullable<long> continentcode { get; set; }
        public string continent { get; set; }
        public Nullable<long> countrycode { get; set; }
        public string country { get; set; }
        public Nullable<long> regioncode { get; set; }
        public string region { get; set; }
        public Nullable<int> LEVEL { get; set; }
        public Nullable<long> provincecode { get; set; }
        public string province { get; set; }
        public Nullable<long> citycode { get; set; }
        public string city { get; set; }
        public Nullable<long> districtid { get; set; }
        public string name { get; set; }
    }
}