using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.OData.Builder;

namespace ODataService.Models
{
    public class CLR
    {
        //private static readonly List<IConvention> _conventions = new List<IConvention>
        //{
        //    // type and property conventions (ordering is important here).
        //    new AbstractTypeDiscoveryConvention(),
        //    new DataContractAttributeEdmTypeConvention(),
        //    new NotMappedAttributeConvention(), // NotMappedAttributeConvention has to run before EntityKeyConvention
        //    new DataMemberAttributeEdmPropertyConvention(),
        //    new RequiredAttributeEdmPropertyConvention(),
        //    new ConcurrencyCheckAttributeEdmPropertyConvention(),
        //    new TimestampAttributeEdmPropertyConvention(),
        //    new KeyAttributeEdmPropertyConvention(), // KeyAttributeEdmPropertyConvention has to run before EntityKeyConvention
        //    new EntityKeyConvention(),
        //    new ComplexTypeAttributeConvention(), // This has to run after Key conventions, basically overrules them if there is a ComplexTypeAttribute
        //    new IgnoreDataMemberAttributeEdmPropertyConvention(),
        //    new NotFilterableAttributeEdmPropertyConvention(),
        //    new NonFilterableAttributeEdmPropertyConvention(),
        //    new NotSortableAttributeEdmPropertyConvention(),
        //    new UnsortableAttributeEdmPropertyConvention(),
        //    new NotNavigableAttributeEdmPropertyConvention(),
        //    new NotExpandableAttributeEdmPropertyConvention(),
        //    new NotCountableAttributeEdmPropertyConvention(),

        //    // INavigationSourceConvention's
        //    new SelfLinksGenerationConvention(),
        //    new NavigationLinksGenerationConvention(),
        //    new AssociationSetDiscoveryConvention(),

        //    // IEdmFunctionImportConventions's
        //    new ActionLinkGenerationConvention(),
        //    new FunctionLinkGenerationConvention(),
        //};

        public static IEdmModel GetConventionModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Customer>("Customers");
            builder.EntitySet<Order>("Orders");

            return builder.GetEdmModel();
        }

        public static IEdmModel GetEdmModel2()
        {
            var builder = new ODataModelBuilder();

            // enum type
            var color = builder.EnumType<Color>();
            color.Member(Color.Red);
            color.Member(Color.Blue);
            color.Member(Color.Green);

            // complex type
            // var address = builder.ComplexType<Address>().Abstract();
            var address = builder.ComplexType<Address>();
            address.Property(a => a.Country);
            address.Property(a => a.City);
            // address.HasDynamicProperties(a => a.Dynamics);

            var subAddress = builder.ComplexType<SubAddress>().DerivesFrom<Address>();
            subAddress.Property(s => s.Street);

            // entity type
            // var customer = builder.EntityType<Customer>().Abstract();
            var customer = builder.EntityType<Customer>();
            customer.HasKey(c => c.CustomerId);
            customer.ComplexProperty(c => c.Location);
            customer.HasMany(c => c.Orders);
            // customer.HasDynamicProperties(c => c.Dynamics);

            var order = builder.EntityType<Order>();
            order.HasKey(o => o.OrderId);
            order.Property(o => o.Token);

            // entity set
            builder.EntitySet<Customer>("Customers");
            builder.EntitySet<Order>("Orders");

            // function
            var function = customer.Function("BoundFunction").Returns<string>();
            function.Parameter<int>("value");
            function.Parameter<Address>("address");

            function = builder.Function("UnBoundFunction").Returns<int>();
            function.Parameter<Color>("color");
            function.EntityParameter<Order>("order");

            // action
            var action = customer.Collection.Action("BoundAction");
            action.Parameter<int>("value");
            action.CollectionParameter<Address>("addresses");

            action = builder.Action("UnBoundAction").Returns<int>();
            action.Parameter<Color>("color");
            action.CollectionEntityParameter<Order>("orders");

            return builder.GetEdmModel();
        }

        public static IEdmModel GetEdmModel1()
        {
            EdmModel model = new EdmModel();

            // Complex Type
            EdmComplexType address = new EdmComplexType("WebApiDocNS", "Address");
            address.AddStructuralProperty("Country", EdmPrimitiveTypeKind.String);
            address.AddStructuralProperty("City", EdmPrimitiveTypeKind.String);
            model.AddElement(address);

            EdmComplexType subAddress = new EdmComplexType("WebApiDocNS", "SubAddress", address);
            subAddress.AddStructuralProperty("Street", EdmPrimitiveTypeKind.String);
            model.AddElement(subAddress);

            // Enum type
            EdmEnumType color = new EdmEnumType("WebApiDocNS", "Color");
            color.AddMember(new EdmEnumMember(color, "Red", new EdmEnumMemberValue(0)));
            color.AddMember(new EdmEnumMember(color, "Blue", new EdmEnumMemberValue(1)));
            color.AddMember(new EdmEnumMember(color, "Green", new EdmEnumMemberValue(2)));
            model.AddElement(color);

            // Entity type
            EdmEntityType customer = new EdmEntityType("WebApiDocNS", "Customer");
            customer.AddKeys(customer.AddStructuralProperty("CustomerId", EdmPrimitiveTypeKind.Int32));
            customer.AddStructuralProperty("Location", new EdmComplexTypeReference(address, isNullable: true));
            model.AddElement(customer);

            EdmEntityType vipCustomer = new EdmEntityType("WebApiDocNS", "VipCustomer", customer);
            vipCustomer.AddStructuralProperty("FavoriteColor", new EdmEnumTypeReference(color, isNullable: false));
            model.AddElement(vipCustomer);

            EdmEntityType order = new EdmEntityType("WebApiDocNS", "Order");
            order.AddKeys(order.AddStructuralProperty("OrderId", EdmPrimitiveTypeKind.Int32));
            order.AddStructuralProperty("Token", EdmPrimitiveTypeKind.Guid);
            model.AddElement(order);

            EdmEntityContainer container = new EdmEntityContainer("WebApiDocNS", "Container");
            EdmEntitySet customers = container.AddEntitySet("Customers", customer);
            EdmEntitySet orders = container.AddEntitySet("Orders", order);
            model.AddElement(container);

            // EdmSingleton mary = container.AddSingleton("Mary", customer);

            // navigation properties
            EdmNavigationProperty ordersNavProp = customer.AddUnidirectionalNavigation(
                new EdmNavigationPropertyInfo
                {
                    Name = "Orders",
                    TargetMultiplicity = EdmMultiplicity.Many,
                    Target = order
                });
            customers.AddNavigationTarget(ordersNavProp, orders);

            // function
            IEdmTypeReference stringType = EdmCoreModel.Instance.GetPrimitive(EdmPrimitiveTypeKind.String, isNullable: false);
            IEdmTypeReference intType = EdmCoreModel.Instance.GetPrimitive(EdmPrimitiveTypeKind.Int32, isNullable: false);

            EdmFunction getFirstName = new EdmFunction("WebApiDocNS", "GetFirstName", stringType, isBound: true, entitySetPathExpression: null, isComposable: false);
            getFirstName.AddParameter("entity", new EdmEntityTypeReference(customer, false));
            model.AddElement(getFirstName);

            EdmFunction getNumber = new EdmFunction("WebApiDocNS", "GetOrderCount", intType, isBound: false, entitySetPathExpression: null, isComposable: false);
            model.AddElement(getNumber);
            container.AddFunctionImport("GetOrderCount", getNumber);

            // action
            EdmAction calculate = new EdmAction("WebApiDocNS", "CalculateOrderPrice", returnType: null, isBound: true, entitySetPathExpression: null);
            calculate.AddParameter("entity", new EdmEntityTypeReference(customer, false));
            model.AddElement(calculate);

            EdmAction change = new EdmAction("WebApiDocNS", "ChangeCustomerById", returnType: null, isBound: false, entitySetPathExpression: null);
            change.AddParameter("Id", intType);
            model.AddElement(change);
            container.AddActionImport("ChangeCustomerById", change);

            return model;
        }

        private static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Customer>("Customers");
            builder.ComplexType<Address>();
            builder.EnumType<Color>();

            BuildFunction(builder);
            BuildAction(builder);
            return builder.GetEdmModel();
        }

        // 调用见CustomersController
        private static void BuildAction(ODataConventionModelBuilder builder)
        {
            //Primitive and Collection of Primitive parameter
            //var action = builder.EntityType<Customer>().Collection.Action("PrimtiveAction");
            //action.Parameter<int>("p1");
            //action.Parameter<int?>("p2");
            //action.CollectionParameter<int>("p3");

            ////Enum and Collection of Enum parameter

            //var action = builder.EntityType<Customer>().Collection.Action("EnumAction");
            //action.Parameter<Color>("e1");
            //action.Parameter<Color?>("e2"); // nullable
            //action.CollectionParameter<Color?>("e3"); // Collection of nullable

            ////Complex and Collection of Complex parameter
            //var action = builder.EntityType<Customer>().Collection.Action("ComplexAction").Returns<string>();
            //action.Parameter<Address>("address");
            //action.CollectionParameter<Address>("addresses");

            ////Entity and Collection of Entity parameter
            var action = builder.EntityType<Customer>().Collection.Action("EntityAction").Returns<string>();
            action.EntityParameter<Customer>("customer");
            action.CollectionEntityParameter<Customer>("customers");
        }

        // 调用见CustomersController
        private static void BuildFunction(ODataConventionModelBuilder builder)
        {
            ////Primitive and Collection of Primitive parameter
            //var function = builder.EntityType<Customer>().Collection.Function("PrimtiveFunction").Returns<string>();
            //function.Parameter<int>("p1");
            //function.Parameter<int?>("p2");
            //function.CollectionParameter<int>("p3");

            ////Enum and Collection of Enum parameter
            //var function = builder.EntityType<Customer>().Collection.Function("EnumFunction").Returns<string>();
            //function.Parameter<Color>("e1");
            //function.Parameter<Color?>("e2"); // nullable
            //function.CollectionParameter<Color?>("e3"); // Collection of nullable

            ////Complex and Collection of Complex parameter
            //var function = builder.EntityType<Customer>().Collection.Function("ComplexFunction").Returns<string>();
            //function.Parameter<Address>("c1");
            //function.CollectionParameter<Address>("c2");

            ////Entity and Collection of Entity parameter
            ////only parameter alias is supported for entity.
            var function = builder.EntityType<Customer>().Collection.Function("EntityFunction").Returns<string>();
            function.EntityParameter<Customer>("a1");
            function.CollectionEntityParameter<Customer>("a2");
        }
    }
}