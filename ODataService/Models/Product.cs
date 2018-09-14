using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.OData.Builder;

namespace ODataService.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [AutoExpand]
        public Category Category { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }

        [AutoExpand]
        public Customer Customer { get; set; }
    }
}