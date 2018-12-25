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
        private LoginViewModel loginViewModel;
        // GET: Login
        public ActionResult Login()
        {
            if (TempData["result"] != null)
            {
                mezunResult = TempData["result"] as BusinessLayerResult<MezunTablo>;
            }
            
            return View(mezunResult);
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {

            loginViewModel = new LoginViewModel(username, password, username);
            mezunResult = mezunManager.Giris(loginViewModel);
            if (mezunResult.Errors.Count>0)
            {
                TempData["result"] = mezunResult;
                return RedirectToAction("Login");
            }
            else
            {
                Session["kullanici"] = (mezunResult.Result);
                
                return RedirectToAction("Index", "Home");
            }
           
           
        }
        public  ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (model!=null)
            {
                mezunManager.Kayit(model);
            }
            return RedirectToAction("Login");
        }
    }
}