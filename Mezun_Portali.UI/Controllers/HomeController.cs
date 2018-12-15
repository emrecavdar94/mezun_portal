using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mezun_Portali.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Announcement()
        {
            return View();
        }
        public ActionResult AnnouncementText(int? id)
        {
            return View();
        }
    }
}