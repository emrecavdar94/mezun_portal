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
    public class AnnouncementManager:ManagerBase<Duyurular>
    {
        public BusinessLayerResult<Duyurular> Listele()
        {
            BusinessLayerResult<Duyurular> res = new BusinessLayerResult<Duyurular>();
            List<Duyurular> duyuruList = new List<Duyurular>();
            duyuruList = List();
            res.ResultList = duyuruList;
            if (res.ResultList == null)
            {
                res.AddError(ErrorMessageCode.UserCouldNotFind, "Hiç Bir Duyuru bulunmamaktadır.");
            }
            return res;
        }
        public BusinessLayerResult<Duyurular> Bul(int id)
        {
            
            BusinessLayerResult<Duyurular> res = new BusinessLayerResult<Duyurular>();
            res.Result = Find(x => x.Id == id);
            if (res.Result==null)
            {
                res.AddError(ErrorMessageCode.AnnouncementCouldNotFind, "Duyuru bulunamadı.");

            }
            return res;

        }
    }
}
