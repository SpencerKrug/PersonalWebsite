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

        public ActionResult Download()
        {
            //First parameter is the path to the file.
            //Second parameter is the type of file.
            //Third parameter is the name of the file.
            //https://www.wiley.com/legacy/compbooks/graham/html4ed/appb/mimetype.html
            return File(Server.MapPath("~/Content/(Resume)SpencerKrug10-02-2019 .pdf"), "application/pdf", "(Resume)SpencerKrug10-02-2019 .pdf");
        }
    }
}