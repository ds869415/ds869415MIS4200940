using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ds869415MIS4200940.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My MIS4200 Test message.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Info about me.";

            return View();
        }
    }
}