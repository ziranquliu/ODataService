using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.OData.Builder;

namespace ODataService.Models
{
    public class SimpleOpenCustomer
    {
        [Key]
        public int CustomerId { get; set; }

        public string Name { get; set; }
        public string Website { get; set; }
        public IDictionary<string, object> CustomerProperties { get; set; }

        public static IEdmModel GetEdmModel()
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<SimpleOpenCustomer>("SimpleOpenCustomers");
            return builder.GetEdmModel();
        }
    }
}