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
        private JobManager jobManager = new JobManager();
        public BusinessLayerResult<Ilan> ilanResult = new BusinessLayerResult<Ilan>();
        // GET: Job
        public ActionResult Index()
        {
            ilanResult = jobManager.Listele();
            return View(ilanResult);
        }
        public ActionResult NewJob()
        {
            return View();
        }
    }
}