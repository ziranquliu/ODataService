using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataService.Models
{
    public class CLR2
    {
        public static IEdmModel GetEdmModel()
        {
            EdmModel model = new EdmModel();

            // Enum type "Color"
            EdmEnumType colorEnum = new EdmEnumType("NS", "Color");
            colorEnum.AddMember(new EdmEnumMember(colorEnum, "Red", new EdmEnumMemberValue(0)));
            colorEnum.AddMember(new EdmEnumMember(colorEnum, "Blue", new EdmEnumMemberValue(1)));
            colorEnum.AddMember(new EdmEnumMember(colorEnum, "Green", new EdmEnumMemberValue(2)));
            model.AddElement(colorEnum);

            // complex type "Address"
            EdmComplexType address = new EdmComplexType("NS", "Address");
            address.AddStructuralProperty("Street", EdmPrimitiveTypeKind.String);
            address.AddStructuralProperty("City", EdmPrimitiveTypeKind.String);
            model.AddElement(address);

            // derived complex type "SubAddress"
            EdmComplexType subAddress = new EdmComplexType("NS", "SubAddress", address);
            subAddress.AddStructuralProperty("Code", EdmPrimitiveTypeKind.Double);
            model.AddElement(subAddress);

            // entity type "Customer"
            EdmEntityType customer = new EdmEntityType("NS", "Customer");
            customer.AddKeys(customer.AddStructuralProperty("Id", EdmPrimitiveTypeKind.Int32));
            customer.AddStructuralProperty("Name", EdmPrimitiveTypeKind.String);
            model.AddElement(customer);

            // derived entity type special customer
            EdmEntityType subCustomer = new EdmEntityType("NS", "SubCustomer", customer);
            subCustomer.AddStructuralProperty("Price", EdmPrimitiveTypeKind.Double);
            model.AddElement(subCustomer);

            // entity sets
            EdmEntityContainer container = new EdmEntityContainer("NS", "Default");
            model.AddElement(container);
            container.AddEntitySet("Customers", customer);

            IEdmTypeReference intType = EdmCoreModel.Instance.GetPrimitive(EdmPrimitiveTypeKind.Int32, isNullable: true);
            EdmEnumTypeReference enumType = new EdmEnumTypeReference(colorEnum, isNullable: true);
            EdmComplexTypeReference complexType = new EdmComplexTypeReference(address, isNullable: true);
            EdmEntityTypeReference entityType = new EdmEntityTypeReference(customer, isNullable: true);

            // functions
            BuildFunction(model, "PrimitiveFunction", entityType, "param", intType);
            BuildFunction(model, "EnumFunction", entityType, "color", enumType);
            BuildFunction(model, "ComplexFunction", entityType, "address", complexType);
            BuildFunction(model, "EntityFunction", entityType, "customer", entityType);

            // actions
            BuildAction(model, "PrimitiveAction", entityType, "param", intType);
            BuildAction(model, "EnumAction", entityType, "color", enumType);
            BuildAction(model, "ComplexAction", entityType, "address", complexType);
            BuildAction(model, "EntityAction", entityType, "customer", entityType);
            return model;
        }

        private static void BuildFunction(EdmModel model, string funcName, IEdmEntityTypeReference bindingType, string paramName, IEdmTypeReference edmType)
        {
            IEdmTypeReference returnType = EdmCoreModel.Instance.GetPrimitive(EdmPrimitiveTypeKind.Boolean, isNullable: false);

            EdmFunction boundFunction = new EdmFunction("NS", funcName, returnType, isBound: true, entitySetPathExpression: null, isComposable: false);
            boundFunction.AddParameter("entity", bindingType);
            boundFunction.AddParameter(paramName, edmType);
            boundFunction.AddParameter(paramName + "List", new EdmCollectionTypeReference(new EdmCollectionType(edmType)));
            model.AddElement(boundFunction);
        }

        private static void BuildAction(EdmModel model, string actName, IEdmEntityTypeReference bindingType, string paramName, IEdmTypeReference edmType)
        {
            IEdmTypeReference returnType = EdmCoreModel.Instance.GetPrimitive(EdmPrimitiveTypeKind.Boolean, isNullable: false);

            EdmAction boundAction = new EdmAction("NS", actName, returnType, isBound: true, entitySetPathExpression: null);
            boundAction.AddParameter("entity", bindingType);
            boundAction.AddParameter(paramName, edmType);
            boundAction.AddParameter(paramName + "List", new EdmCollectionTypeReference(new EdmCollectionType(edmType)));
            model.AddElement(boundAction);
        }
    }
}