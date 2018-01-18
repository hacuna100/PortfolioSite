using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioSite.WebUI.Controllers
{
    public class SharedController : Controller
    {
        public PartialViewResult NavBar()
        {
            return PartialView();
        }

        public PartialViewResult Footer()
        {
            return PartialView();
        }
    }
}