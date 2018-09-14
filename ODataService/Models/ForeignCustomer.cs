using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataService.Models
{
    public class ForeignCustomer
    {
        public int ForeignCustomerId { get; set; }
        public int OtherCustomerKey { get; set; }
        public IList<ForeignOrder> Orders { get; set; }
    }
}