using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.Browser.IsMobileDevice == true)
            {
                return View("IndexMobile");
            }
            else
            {
                return View();
            }
        }
    }
}