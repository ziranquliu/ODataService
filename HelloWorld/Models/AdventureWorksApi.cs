using Microsoft.Restier.Providers.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class AdventureWorksApi : EntityFrameworkApi<AdventureWorksLT>
    {
        public AdventureWorksApi(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        protected IQueryable<Product> OnFilterProduct(IQueryable<Product> entitySet)
        {
            return entitySet.Where(s => s.ProductID % 3 == 0).AsQueryable();
        }
    }
}