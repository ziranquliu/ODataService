using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.OData;

namespace ODataService.Controllers
{
    //http://localhost/odata/Customers?$expand=Orders&$deltatoken=abc
    public class CustomersController : ODataController
    {
        public IHttpActionResult Get()
        {
            //EdmChangedObjectCollection changedCollection = new EdmChangedObjectCollection(CustomerType);
            //EdmDeltaEntityObject Customer = new EdmDeltaEntityObject(CustomerType);
            //Customer.Id = 123;
            //Customer.Name = "Added Customer";
            //changedCollection.Add(Customer);

            //EdmDeltaDeletedEntityObject Customer = new EdmDeltaDeletedEntityObject(CustomerType);
            //Customer.Id = 124;
            //Customer.Reason = DeltaDeletedEntryReason.Deleted;
            //changedCollection.Add(Customer);

            //EdmDeltaLink CustomerOrderLink = new EdmDeltaLink(CustomerType);
            //CustomerOrderLink.Relationship = "Orders";
            //CustomerOrderLink.Source = new Uri(ServiceBaseUri, "Customers(123)");
            //CustomerOrderLink.Target = new Uri(ServiceBaseUri, "Orders(10)");
            //changedCollection.Add(CustomerOrderLink);

            //EdmDeltaDeletedLink CustomerOrderDeletedLink = new EdmDeltaDeletedLink(CustomerType);
            //CustomerOrderDeletedLink.Relationship = "Orders";
            //CustomerOrderDeletedLink.Source = new Uri(ServiceBaseUri, "Customers(123)");
            //CustomerOrderDeletedLink.Target = new Uri(ServiceBaseUri, "Orders(11)");
            //changedCollection.Add(CustomerOrderDeletedLink);
            //return Ok(changedCollection);
            return null;
        }
    }
}