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
            //Kişinin Anasayfası
            return View();
        }
        public ActionResult Friends()
        {
            //Kişinin Arkadaşları Görüntüleniyor
            return View();
        }
        public ActionResult EKSP()
        {
            //Eğitim-Proje-Kariyer-Sertifika Bilgi Sayfası
            return View();
        }
        public ActionResult AccountDetails()
        {
            //Profil Bilgilerini Güncelleme
            return View();
        }
    }
}