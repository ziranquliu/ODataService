using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataService.Models
{
    public class VipCustomer : Customer
    {
        public Color FavoriteColor { get; set; } // structural property, primitive type
    }
}