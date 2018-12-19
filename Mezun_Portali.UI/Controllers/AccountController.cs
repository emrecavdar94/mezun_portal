using Mezun_Portali.BusinessLayer;
using Mezun_Portali.BusinessLayer.Results;
using Mezun_Portali.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mezun_Portali.UI.Controllers
{
    public class AccountController : Controller
    {
        private KariyerBilgileriManager kariyerManager = new KariyerBilgileriManager();
        private BusinessLayerResult<KariyerBilgileri> kariyerResult = new BusinessLayerResult<KariyerBilgileri>();
        private KariyerBilgileri kariyer = new KariyerBilgileri();
        private MezunManager mezunManager = new MezunManager();
        private BusinessLayerResult<MezunTablo> mezunResult = new BusinessLayerResult<MezunTablo>();
        private MezunTablo mezun = new MezunTablo();


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
<<<<<<< HEAD

            return View();
        }
        [HttpPost]
        public ActionResult KariyerEkle(DateTime kariyeayrilmatarihi, string kariyerfirmaadi,string  kariyerpozisyon,DateTime kariyergiristarihi)
        {
=======
            //Eğitim-Proje-Kariyer-Sertifika Bilgi Sayfası
>>>>>>> 19ea0aa13230bdea7bda23b81a2189f62776bceb
            return View();
        }
        public ActionResult AccountDetails()
        {
            //Profil Bilgilerini Güncelleme
            return View();
        }
    }
}