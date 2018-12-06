using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Serilog;

namespace AzureWebAppMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Log.Error("Getting index page");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            Log.Information("Getting about page");
            return View();
        }

        public ActionResult Contact()
        {
            Log.Warning("Getting contacts page");
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}