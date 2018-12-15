using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mezun_Portali.UI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Friends()
        {
            return View();
        }
        public ActionResult EKSP()
        {
            return View();
        }
        public ActionResult AccountDetails()
        {
            return View();
        }
    }
}