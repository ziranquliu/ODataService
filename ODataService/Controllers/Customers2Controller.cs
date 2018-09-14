using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.OData;

namespace ODataService.Controllers
{
    //~odata/Customers(1)/NS.EntityFunction(customer=@x,customerList=@y)? @x ={\"@odata.type\":\"%23NS.Customer\",\"Id\":1,\"Name\":\"John\"}&@y={\"value\":[{\"@odata.type\":\"%23NS.Customer\",\"Id\":2, \"Name\":\"Mike\"},{\"@odata.type\":\"%23NS.SubCustomer\",\"Id\":3,\"Name\":\"Tony\", \"Price\":9.9}]}"

    public class Customers2Controller : ODataController
    {
        [HttpGet]
        public IHttpActionResult PrimitiveFunction(int key, int? param, [FromODataUri]IList<int?> paramList)
        {
            return null;
        }

        [HttpPost]
        public IHttpActionResult PrimitiveAction(int key, ODataActionParameters parameters)
        {
            return null;
        }

        /* // will support in V5.5 RTM
        [HttpGet]
        public IHttpActionResult EnumFunction(int key, [FromODataUri]EdmEnumObject color, [FromODataUri]EdmEnumObjectCollection colorList)
        {
            return null;
        }

        [HttpPost]
        public IHttpActionResult EnumAction(int key, ODataActionParameters parameters)
        {
            return null;
        }
        */

        [HttpGet]
        public IHttpActionResult ComplexFunction(int key, [FromODataUri]EdmComplexObject address, [FromODataUri]EdmComplexObjectCollection addressList)
        {
            return null;
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult ComplexAction(int key, ODataActionParameters parameters)
        {
            return null;
        }

        [HttpGet]
        public IHttpActionResult EntityFunction(int key, [FromODataUri]EdmEntityObject customer, [FromODataUri]EdmEntityObjectCollection customerList)
        {
            return null;
        }

        [HttpPost]
        public IHttpActionResult EntityAction(int key, ODataActionParameters parameters)
        {
            return null;
        }
    }
}