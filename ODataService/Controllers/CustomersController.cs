//using ODataService.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Web;
//using System.Web.Http;
//using System.Web.Http.Results;
//using System.Web.OData;

//namespace ODataService.Controllers
//{
//    //Property access routing convention
//    //~/odata/Customers(1)/Orders
//    //~/odata/Customers(1)/Address
//    //~/odata/Customers(1)/Name
//    public class CustomersController : ODataController
//    {
//        //    private Customer[] _customers =
//        //   {
//        //    new Customer
//        //    {
//        //        Id = 0,
//        //        Name = "abc",
//        //        Orders = new[]
//        //        {
//        //            new Order { Id = 10, Name = "xyz" },
//        //            new Order { Id = 11, Name = "def" },
//        //        }
//        //    }
//        //};

//        //    [EnableQuery]
//        //    public IHttpActionResult Get()
//        //    {
//        //        return Ok(_customers.AsQueryable());
//        //    }

//        public string GetOrders([FromODataUri]int key)
//        {
//            return null;
//        }

//        public string GetAddress([FromODataUri]int key)
//        {
//            return null;
//        }

//        public string GetName([FromODataUri]int key)
//        {
//            return null;
//        }

//        //~/odata/Customers/Default.PrimitiveFunction(p1=1,p2=9,p3=[1,3,5,7,9])
//        //~/odata/Customers/Default.PrimitiveFunction(p1=2,p2=null,p3=[1,3,5,7,9])
//        //~/odata/Customers/Default.PrimitiveFunction(p1=3,p2=null,p3=@p)?@p=[2,4,6,8]
//        [HttpGet]
//        public string PrimtiveFunction(int p1, int? p2, [FromODataUri]IEnumerable<int> p3)
//        {
//            return null;
//        }

//        //~/odata/Customers/Default.EnumFunction(e1=NS.Color'Red',e2=NS.Color'Green',e3=['Red', null, 'Blue'])
//        //~/odata/Customers/Default.EnumFunction(e1=NS.Color'Blue',e2=null,e3=['Red', null, 'Blue'])
//        //~/odata/Customers/Default.EnumFunction(e1=NS.Color'Blue',e2=null,e3=@p)?@p=['Red', null, 'Blue']
//        [HttpGet]
//        public string EnumFunction(Color e1, Color? e2, [FromODataUri]IEnumerable<Color?> e3)
//        {
//            return null;
//        }

//        //~/odata/Customers/Default.ComplexFunction(c1=@x,c2=@y)?@x={\"@odata.type\":\"%23NS.Address\",\"City\":\"Redmond\"}&@y=[{\"@odata.type\":\"%23NS.Address\",\"City\":\"Redmond\"},{\"@odata.type\":\"%23NS.SubAddress\",\"City\":\"Shanghai\", \"Street\":\"Zi Xing Rd\"}]
//        //~/odata/Customers/Default.ComplexFunction(c1={\"@odata.type\":\"%23NS.Address\",\"City\":\"Redmond\"},c2=[{\"@odata.type\":\"%23NS.Address\",\"City\":\"Redmond\"},{\"@odata.type\":\"%23NS.SubAddress\",\"City\":\"Shanghai\", \"Street\":\"Zi Xing Rd\"}])
//        //~/odata/Customers/Default.ComplexFunction(c1=null,c2=@p)?@p=[null,{\"@odata.type\":\"%23NS.SubAddress\",\"City\":\"Shanghai\", \"Street\":\"Zi Xing Rd\"}]
//        [HttpGet]
//        public string ComplexFunction([FromODataUri]Address c1, [FromODataUri]IEnumerable<Address> c2)
//        {
//            return null;
//        }

//        //~/odata/Customers/Default.EntityFunction(a1=@x,a2=@y)?@x={\"@odata.type\":\"%23NS.Customer\",\"Id\":1,\"Name\":\"John\"}&@y={\"value\":[{\"@odata.type\":\"%23NS.Customer\",\"Id\":2, \"Name\":\"Mike\"},{\"@odata.type\":\"%23NS.SubCustomer\",\"Id\":3,\"Name\":\"Tony\", \"Price\":9.9}]}
//        //~/odata/Customers/Default.EntityFunction(a1=@x,a2=@y)?@x=null&@y={\"value\":[]}
//        [HttpGet]
//        public string EntityFunction([FromODataUri]Customer a1, [FromODataUri]IEnumerable<Customer> a2)
//        {
//            return null;
//        }

//        //Entity Reference and collection of Entity Reference parameter
//        //~/odata/Customers/Default.EntityFunction(a1=@x,a2=@y)?@x={\"@odata.id\":\"http://localhost/odata/Customers(2)\"}&@y={\"value\":[{\"@odata.id\":\"http://localhost/odata/Customers(2)\"},{\"@odata.id\":\"http://localhost/odata/Customers(3)\"}]}

//        //~/odata/Customers/Default.PrimitiveAction
//        [HttpPost]
//        public IHttpActionResult PrimitiveAction(ODataActionParameters parameters)
//        {
//            return null;
//        }

//        //~/odata/Customers/Default.EnumAction
//        [HttpPost]
//        public IHttpActionResult EnumAction(ODataActionParameters parameters)
//        {
//            return null;
//        }

//        //~/odata/Customers/Default.ComplexAction
//        [HttpPost]
//        public IHttpActionResult ComplexAction(ODataActionParameters parameters)
//        {
//            return null;
//        }

//        //~/odata/Customers/Default.EntityAction
//        [HttpPost]
//        public IHttpActionResult EntityAction(ODataActionParameters parameters)
//        {
//            return null;
//        }

//        //自定义属性路由约定
//        //[HttpGet]
//        //public IHttpActionResult GetProperty(int key, string propertyName)
//        //{
//        //    Customer customer = _customers.FirstOrDefault(c => c.CustomerId == key);
//        //    if (customer == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    PropertyInfo info = typeof(Customer).GetProperty(propertyName);

//        //    object value = info.GetValue(customer);

//        //    return Ok(value, value.GetType());
//        //}

//        //private IHttpActionResult Ok(object content, Type type)
//        //{
//        //    var resultType = typeof(OkNegotiatedContentResult<>).MakeGenericType(type);
//        //    return Activator.CreateInstance(resultType, content, this) as IHttpActionResult;
//        //}
//    }
//}

//////$filter DateTime
////GET ~/Customers?$filter=Birthday lt cast(2015-04-01T04:11:31%2B08:00, Edm.DateTimeOffset)
////GET ~/Customers?$filter=year(Birthday) eq 2010

////$orderby DateTime
////GET ~/Customers?$orderby=Birthday
////GET ~/Customers?$orderby=Birthday desc