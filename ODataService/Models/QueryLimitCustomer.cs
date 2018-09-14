using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.OData.Query;

namespace ODataService.Models
{
    public class QueryLimitCustomer
    {
        public int Id { get; set; }

        [NonFilterable]
        [NotFilterable]
        [NotSortable]
        [Unsortable]
        public string Title { get; set; }

        [NotNavigable]
        public Address address { get; set; }

        [NotExpandable]
        public ICollection<QueryLimitOrder> Orders { get; set; }

        [NotCountable]
        public ICollection<Address> Addresses { get; set; }
    }
}