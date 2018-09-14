using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using WebApiOData.Models;

namespace WebApiOData.Controllers
{
    public class Person
    {
        public TimeSpan BirthTime { get; set; }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var client = new HttpClient())
            {
                var requestUri = "http://localhost:4595/api/Proc";
                var result = client.GetAsync(requestUri).Result;
                var content = result.Content.ReadAsStringAsync().Result;
                IQueryable list = JsonConvert.DeserializeObject<IQueryable>(content);
                return View(list);
            }
        }
    }
}