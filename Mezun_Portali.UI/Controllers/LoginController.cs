using Mezun_Portali.BusinessLayer;
using Mezun_Portali.BusinessLayer.Results;
using Mezun_Portali.Ent;
using Mezun_Portali.Ent.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mezun_Portali.UI.Controllers
{
    public class LoginController : Controller
    {
        private BusinessLayerResult<MezunTablo> mezunResult = new BusinessLayerResult<MezunTablo>();
        private MezunManager mezunManager = new MezunManager();
        private MezunTablo mezun = new MezunTablo();
        private RegisterViewModel registerViewModel = new RegisterViewModel();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            
            return View();
        }
        public  ActionResult Register()
        {
            return View();
        }
    }
}