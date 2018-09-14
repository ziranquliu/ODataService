//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Http.Controllers;
//using System.Web.OData.Routing;
//using System.Web.OData.Routing.Conventions;

//自定义属性路由约定
//namespace ODataService.Conventions
//{
//    //~/entityset/key/property
//    //~/entityset/key/cast/property
//    //~/singleton/property
//    //~/singleton/cast/property
//    public class CustomPropertyRoutingConvention : NavigationSourceRoutingConvention
//    {
//        private const string ActionName = "GetProperty";

//        public override string SelectAction(ODataPath odataPath, HttpControllerContext controllerContext, ILookup<string, HttpActionDescriptor> actionMap)
//        {
//            if (odataPath == null || controllerContext == null || actionMap == null)
//            {
//                return null;
//            }

//            if (odataPath.PathTemplate == "~/entityset/key/property" ||
//                odataPath.PathTemplate == "~/entityset/key/cast/property" ||
//                odataPath.PathTemplate == "~/singleton/property" ||
//                odataPath.PathTemplate == "~/singleton/cast/property")
//            {
//                var segment = odataPath.Segments[odataPath.Segments.Count - 1] as PropertyAccessPathSegment;

//                if (segment != null)
//                {
//                    string actionName = FindMatchingAction(actionMap, ActionName);

//                    if (actionName != null)
//                    {
//                        if (odataPath.PathTemplate.StartsWith("~/entityset/key", StringComparison.Ordinal))
//                        {
//                            KeyValuePathSegment keyValueSegment = odataPath.Segments[1] as KeyValuePathSegment;
//                            controllerContext.RouteData.Values[ODataRouteConstants.Key] = keyValueSegment.Value;
//                        }

//                        controllerContext.RouteData.Values["propertyName"] = segment.PropertyName;

//                        return actionName;
//                    }
//                }
//            }

//            return null;
//        }

//        public static string FindMatchingAction(ILookup<string, HttpActionDescriptor> actionMap, params string[] targetActionNames)
//        {
//            foreach (string targetActionName in targetActionNames)
//            {
//                if (actionMap.Contains(targetActionName))
//                {
//                    return targetActionName;
//                }
//            }

//            return null;
//        }
//    }
//}

////Abstract entity types
//public abstract class Animal
//{
//}

//public class Dog : Animal
//{
//    public int DogId { get; set; }
//}

//public class Pig : Animal
//{
//    public int PigId { get; set; }
//}
//var builder = new ODataConventionModelBuilder();
//builder.EntityType<Animal>();
//  builder.EntitySet<Dog>("Dogs");
//  builder.EntitySet<Pig>("Pigs");
//  IEdmModel model = builder.GetEdmModel()

////Complex type example
//public abstract class Graph
//{ }

//public class Point : Graph
//{
//    public int X { get; set; }
//    public int Y { get; set; }
//}

//public class Line : Graph
//{
//    public IList<Point> Vertexes { get; set; }
//}

//var builder = new ODataConventionModelBuilder();
//builder.ComplexType<Graph>();
//  IEdmModel model = builder.GetEdmModel()