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
        public ActionResult AnaSayfa()
        {
            return View();
        }
        public ActionResult Duyurular()
        {
            return View();
        }
        public ActionResult DuyuruMetini()
        {
            return View();
        }

    }
}