using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JenkinsDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page. -BREAKERROR1"; //nice place to put a test error    -BREAKERROR

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. -BREAKERROR2";

            return View();
        }
    }
}