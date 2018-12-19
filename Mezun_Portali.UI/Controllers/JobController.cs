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
    public class JobController : Controller
    {
        private BusinessLayerResult<Ilan> jobResult = new BusinessLayerResult<Ilan>();
        private JobManager jobManager = new JobManager();
        private List<Ilan> ilanList = new List<Ilan>();
        // GET: Job
        public ActionResult Index()
        {
            //İş İlanlarının Listelendiği Sayfa
            jobResult = jobManager.Listele();
            ilanList = jobResult.ResultList;
            

            return View(ilanList);
        }
        public ActionResult NewJob()
        {
            //İş İlanı Yayınlama
            return View();
        }

        [HttpPost]
        public ActionResult NewJob(string jobIlanbasligi,string jobSektor,string jobPozisyon,string jobAdres, string jobCalismasekli,string jobEgitim,string jobDil,string jobAciklama,string jobTelefon, string jobEposta)
        {
            Ilan ilan = new Ilan();
            IlanIletisim ilanIletisim = new IlanIletisim();
            IlanNitelik ilanNitelik = new IlanNitelik();
            ilan.IlanBasligi = jobIlanbasligi;
            ilan.CalismaSekli = jobCalismasekli;
            ilan.Sektor = jobSektor;
            ilan.Egitim = jobEgitim;
            ilan.Pozisyon = jobPozisyon;
            ilan.Dil = jobDil;
            ilanNitelik.Aciklama = jobAciklama;
            ilanIletisim.Tel = jobTelefon;
            ilanIletisim.Eposta = jobEposta;
            ilan.Adres = jobAdres;
            ilan.Tarih = DateTime.Now;
            jobResult = jobManager.Kayit(ilan);
            
            return View(jobResult);
        }
        [HttpPost]
        public ActionResult Emre()
        {
            return View();
        }
        
    }
}