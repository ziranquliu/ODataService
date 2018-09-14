//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Http;
//using System.Web.OData;
//using System.Web.OData.Routing;

//namespace ODataService.Controllers
//{
//    /*********************************************************
//                    3
//    *********************************************************/

//    [ODataRoutePrefix("Customers({key})")]
//    [ODataRoutePrefix("VipCustomer")]
//    public class ODataControllerWithMultiplePrefixes : ODataController
//    {
//    }

//    /*********************************************************
//                    2
//    *********************************************************/

//    //[ODataRoutePrefix("Customers({id})")]

//    /*********************************************************
//                    3
//    *********************************************************/

//    [ODataRoutePrefix("Customers")]
//    public class MyController : ODataController
//    {
//        [ODataRoute("({id})/Address")]
//        [ODataRoute("Clients({clientId})/MyOrders({orderId})/OrderLines")]
//        [ODataRoute("Customers({id})/NS.MyFunction(city={city})")]
//        [ODataRoute("Customers/Default.BoundFunction(SimpleEnum={p1})")]
//        public IHttpActionResult GetAddress(int id)
//        {
//            return null;
//        }

//        /*********************************************************
//                        2
//        *********************************************************/
//        //[ODataRoute("Address")]
//        //public IHttpActionResult GetAddress(int id)
//        //{
//        //    return null;
//        //}

//        //[ODataRoute("Address/City")]
//        //public IHttpActionResult GetCity(int id)
//        //{
//        //    return null;
//        //}

//        //[ODataRoute("/Order")]
//        //public IHttpActionResult GetOrder(int id)
//        //{
//        //    return null;
//    }

//    /*********************************************************
//                    1
//    *********************************************************/
//    //[HttpGet]
//    //[ODataRoute("Customers({id})/Address/City")]
//    //[ODataRoute("Products({id})/Address/City")]
//    ////~/odata/Customers(1)/Address/City
//    ////~/odata/Customers(2)/Address/City
//    ////~/odata/Customers(301)/Address/City
//    //public string GetCityOfACustomer([FromODataUri]int id)
//    //{
//    //    return "";
//    //}

//    //[ODataRoute("Customers({id})/Address")]
//    //public IHttpActionResult GetAddress(int id)
//    //{
//    //    return null;
//    //}

//    //[ODataRoute("Customers({id})/Address/City")]
//    //public IHttpActionResult GetCity(int id)
//    //{
//    //    return null;
//    //}

//    //[ODataRoute("Customers({id})/Order")]
//    //public IHttpActionResult GetOrder(int id)
//    //{
//    //    return null;
//    //}
//    //}
//}