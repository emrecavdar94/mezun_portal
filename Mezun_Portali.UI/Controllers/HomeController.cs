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
    public class HomeController : Controller
    {
        private BusinessLayerResult<Duyurular> duyuruResult = new BusinessLayerResult<Duyurular>();
        private AnnouncementManager duyuruManager = new AnnouncementManager();
        private List<Duyurular> duyuruList = new List<Duyurular>();
        public ActionResult Index()
        {
            //AnaSyafa
            return View();
        }
        public ActionResult Announcement()
        {
            duyuruResult = duyuruManager.Listele();
            duyuruList = duyuruResult.ResultList;
            List <Duyurular> SortedList = duyuruList.OrderBy(o => o.Duyuru_Tarihi).ToList();
            return View(SortedList);
        }
        public ActionResult AnnouncementText( int id)
        {
            
            if (id <=0)
            {
                id = 1;
            }
            duyuruResult = duyuruManager.Bul(id);
            

            return View(duyuruResult);

        }

    }
}