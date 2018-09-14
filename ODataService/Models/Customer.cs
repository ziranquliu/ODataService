using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataService.Models
{
    public class Customer
    {
        public int CustomerId { get; set; } // structural property, primitive type, key
        public Address Location { get; set; } // structural property, complex type
        public IList<Order> Orders { get; set; } // navigation property, entity type
        public IDictionary<string, object> Dynamics { get; set; }

        public int Id { get; set; }

        public DateTimeOffset Birthday { get; set; }

        public Date Publish { get; set; }

        public TimeOfDay CheckTime { get; set; }
    }
}