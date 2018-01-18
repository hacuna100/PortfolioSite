using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioSite.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Resume()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult ErrorPage()
        {
            return View();
        }
    }
}