using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;
using ODataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using System.Web.OData.Routing.Conventions;

namespace ODataService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            #region Batch

            //var odataBatchHandler = new DefaultODataBatchHandler(GlobalConfiguration.DefaultServer);
            //odataBatchHandler.MessageQuotas.MaxPartsPerBatch = 8;
            //odataBatchHandler.MessageQuotas.MaxOperationsPerChangeset = 5;
            //config.MapODataServiceRoute("odata", "odata", GetModel(), odataBatchHandler);

            #endregion Batch

            //var builder = new ODataConventionModelBuilder();

            //builder.EntitySet<Product>("Products");

            //config.MapODataServiceRoute("ODataRoute", null, builder.GetEdmModel());

            //config.MapODataServiceRoute("r1", "api/r1", CLR.GetEdmModel1());
            //config.MapODataServiceRoute("r2", "api/r2", CLR.GetEdmModel2());
            //config.MapODataServiceRoute("r3", "api/r3", CLR.GetConventionModel());
            config.MapODataServiceRoute("r4", "api/r4", CLR3.GetUntypedEdmModel());
            //ODataRoutingConventions

            //自定义属性路由约定
            //HttpConfiguration configuration = ......
            //IEdmModel model = GetEdmModel();
            //IList<IODataRoutingConvention> conventions = ODataRoutingConventions.CreateDefaultWithAttributeRouting(configuration, model);
            //conventions.Insert(0, new CustomPropertyRoutingConvention());
            //configuration.MapODataServiceRoute("odata", "odata", model, new DefaultODataPathHandler(), conventions);

            //HttpConfiguration configuration = ...
            //TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"); // -8:00
            //configuration.SetTimeZoneInfo(timeZoneInfo);

            //config.MapODataServiceRoute("OData1", "odata/non-cap", GetExplicitEdmModel());
            //config.MapODataServiceRoute("OData2", "odata/cap", GetEdmModel());
        }

        //private static IEdmModel GetExplicitEdmModel()
        //{
        //    var builder = new ODataModelBuilder();

        //    // enum type "Color"
        //    var color = builder.EnumType<Color>();
        //    color.Member(Color.Red);
        //    color.Member(Color.Green);
        //    color.Member(Color.Blue);
        //    color.Member(Color.Yellow);
        //    color.Member(Color.Pink);
        //    color.Member(Color.Purple);

        //    // complex type "Address"
        //    var address = builder.ComplexType<Address>();
        //    address.Property(a => a.City);
        //    address.Property(a => a.Street);

        //    // entity type "Customer"
        //    var customer = builder.EntityType<Customer>().HasKey(c => c.CustomerId);
        //    customer.Property(c => c.Name);
        //    customer.Property(c => c.Token);
        //    // customer.Property(c => c.Email).IsNotNavigable(); // you can call Fluent API
        //    customer.Property(c => c.Email);
        //    customer.CollectionProperty(c => c.Addresses);
        //    customer.CollectionProperty(c => c.FavoriateColors);
        //    customer.HasMany(c => c.Orders);

        //    // entity type "Order"
        //    var order = builder.EntityType<Order>().HasKey(o => o.OrderId);
        //    order.Property(o => o.Price);

        //    // entity sets
        //    builder.EntitySet<Customer>("Customers").HasManyBinding(c => c.Orders, "Orders");
        //    builder.EntitySet<Order>("Orders");

        //    return builder.GetEdmModel();
        //}

        //// Builds the EDM model
        //private static IEdmModel GetEdmModel()
        //{
        //    var builder = new ODataConventionModelBuilder();
        //    builder.EntitySet<Customer>("Customers");
        //    builder.EntitySet<Order>("Orders");
        //    return builder.GetEdmModel();
        //}

        //public IEdmModel GetEdmModel()
        //{
        //    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
        //    builder.EntitySet<Customer>("Customers");
        //    builder.EntitySet<Order>("Orders");
        //    return builder.GetEdmModel();
        //}
    }
}