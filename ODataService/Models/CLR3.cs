using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataService.Models
{
    public class CLR3
    {
        public static IEdmModel GetUntypedEdmModel()
        {
            var model = new EdmModel();
            // complex type address
            EdmComplexType address = new EdmComplexType("NS", "Address", null, false, true);
            address.AddStructuralProperty("Street", EdmPrimitiveTypeKind.String);
            model.AddElement(address);
            // enum type color
            EdmEnumType color = new EdmEnumType("NS", "Color");
            color.AddMember(new EdmEnumMember(color, "Red", new EdmEnumMemberValue(0)));
            model.AddElement(color);
            // entity type customer
            EdmEntityType customer = new EdmEntityType("NS", "UntypedSimpleOpenCustomer", null, false, true);
            customer.AddKeys(customer.AddStructuralProperty("CustomerId", EdmPrimitiveTypeKind.Int32));
            customer.AddStructuralProperty("Color", new EdmEnumTypeReference(color, isNullable: true));
            model.AddElement(customer);
            EdmEntityContainer container = new EdmEntityContainer("NS", "Container");
            container.AddEntitySet("UntypedSimpleOpenCustomers", customer);
            model.AddElement(container);
            return model;
        }
    }
}