using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.OData.Builder;

namespace ODataService.Models
{
    public class ForeignOrder
    {
        public int ForeignOrderId { get; set; }
        public int CustomerId { get; set; }

        //[ForeignKey("CustomerId")]
        //public ForeignCustomer Customer { get; set; }

        //[ForeignKey("Customer")]
        //public int CustomerId { get; set; }
        //public ForeignCustomer Customer { get; set; }

        [ForeignKey("CustomerId")]
        [ActionOnDelete(EdmOnDeleteAction.Cascade)]
        public ForeignCustomer Customer { get; set; }
    }
}