using ODataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.OData;

namespace ODataService.Controllers
{
    //~/odata/SimpleOpenCustomers?$orderby=Token desc&$filter=Token ne null
    //~/odata/SimpleOpenCustomers?$select=Token
    public class SimpleOpenCustomersController
    {
        [EnableQuery]
        public IQueryable<SimpleOpenCustomer> Get()
        {
            return null;
            //return CreateCustomers().AsQueryable();
        }
    }
}