using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Storage.Areas.Admin.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Admin/Default
        public ActionResult Index()
        {
            ViewBag.url = "fuck";
            return View();
        }
        public ActionResult Pro()
        {
            return View();
        }
    }
}