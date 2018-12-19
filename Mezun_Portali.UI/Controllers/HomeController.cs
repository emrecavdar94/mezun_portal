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
            //AnaSyafa
            return View();
        }
        public ActionResult Announcement()
        {
            //Duyurular
            return View();
        }
        public ActionResult AnnouncementText( int? idd)
        {
            //Duyurular Metin
            return View();
        }

    }
}