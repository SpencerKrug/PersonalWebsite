using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsite.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult About()
        {
            if (Request.Browser.IsMobileDevice == true)
            {
                return View("AboutMobile");
            }
            else
            {
                return View();
            }
        }
    }
}