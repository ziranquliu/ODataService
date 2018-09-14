using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiOData.Models;
using System.Web.Http.OData.Query;

namespace WebApiOData.Controllers
{
    public class ProcController : ApiController
    {
        private Lazy<CEPOne_ReportEntities> context = new Lazy<CEPOne_ReportEntities>(
            () =>
        {
            return new CEPOne_ReportEntities();
        });

        public ProcController()
        {
        }

        // GET api/MdmDealer
        [Queryable(AllowedQueryOptions = AllowedQueryOptions.All)]
        public IQueryable Get()
        {
            CEPOne_ReportEntities c = context.Value;
            var data = c.Database.SqlQueryForDynamic("exec ProcQueryServiceProxyCTI");
            return data.AsQueryable();
        }
    }
}