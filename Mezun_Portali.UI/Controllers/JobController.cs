using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mezun_Portali.UI.Controllers
{
    public class JobController : Controller
    {
        // GET: Job
        public ActionResult Index()
        {
            //İş İlanlarının Listelendiği Sayfa
            return View();
        }
        public ActionResult NewJob()
        {
            //İş İlanı Yayınlama
            return View();
        }
    }
}