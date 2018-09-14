using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.OData;

namespace ODataService.Controllers
{
    //~/odata/UntypedSimpleOpenCustomers(1)
    //~/odata/UntypedSimpleOpenCustomers
    public class UntypedSimpleOpenCustomersController : ODataController
    {
        private const string Payload = "{" +
                 "\"@odata.context\":\"http://localhost/odata/$metadata#UntypedSimpleOpenCustomer/$entity\"," +
                 "\"CustomerId\":6,\"Name\":\"FirstName 6\"," +
                 "\"Address\":{" +
                   "\"@odata.type\":\"#NS.Address\",\"Street\":\"Street 6\",\"City\":\"City 6\"" +
                 "}," +
                 "\"Addresses@odata.type\":\"#Collection(NS.Address)\"," +
                 "\"Addresses\":[{" +
                   "\"@odata.type\":\"#NS.Address\",\"Street\":\"Street 7\",\"City\":\"City 7\"" +
                 "}]," +
                 "\"DoubleList@odata.type\":\"#Collection(Double)\"," +
                 "\"DoubleList\":[5.5, 4.4, 3.3]," +
                 "\"FavoriteColor@odata.type\":\"#NS.Color\"," +
                 "\"FavoriteColor\":\"Red\"," +
                 "\"Color\":\"Red\"," +
                 "\"FavoriteColors@odata.type\":\"#Collection(NS.Color)\"," +
                 "\"FavoriteColors\":[\"0\", \"1\"]" +
               "}";

        [HttpGet]
        public IHttpActionResult Get(int key)
        {
            return null;
        }

        [HttpPost]
        public IHttpActionResult PostUntypedSimpleOpenCustomer(EdmEntityObject customer)
        {
            object nameValue;
            customer.TryGetPropertyValue("Name", out nameValue);
            Type nameType;
            customer.TryGetPropertyType("Name", out nameType);
            return null;
        }
    }
}