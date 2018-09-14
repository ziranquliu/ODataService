using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataService.Models
{
    public class Order
    {
        public int OrderId { get; set; } // structural property, primitive type, key
        public Guid Token { get; set; } // structural property, primitive type
    }
}