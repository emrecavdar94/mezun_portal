using Mezun_Portali.BusinessLayer.Abstract;
using Mezun_Portali.BusinessLayer.Results;
using Mezun_Portali.Ent;
using Mezun_Portali.Ent.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mezun_Portali.BusinessLayer
{
    public class JobManager : ManagerBase<Ilan>
    {

        public  BusinessLayerResult<Ilan> Listele()
        {
            BusinessLayerResult<Ilan> res = new BusinessLayerResult<Ilan>();
            List<Ilan> ilanList = new List<Ilan>();
            ilanList = List();
            res.ResultList =ilanList  ;
            if (res.Result == null)
            {
                res.AddError(ErrorMessageCode.UserCouldNotFind, "Ilan bulunmamaktadır.");
            }
            return res ;
        }

    }
}
