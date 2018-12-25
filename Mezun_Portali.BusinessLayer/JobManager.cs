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
            if (res.ResultList == null)
            {
                res.AddError(ErrorMessageCode.UserCouldNotFind, "Ilan bulunmamaktadır.");
            }
            return res ;
        }
       
        public BusinessLayerResult<Ilan> Kayit(Ilan data)
        {
         
            BusinessLayerResult<Ilan> res = new BusinessLayerResult<Ilan>();

            
            ICollection<IlanNitelik> listNitelik = new List<IlanNitelik>();
            listNitelik = data.IlanNitelik;
            Ilan ilan = new Ilan();
            IlanIletisim ilaniletisim = new IlanIletisim();
            ilaniletisim.Eposta = data.IlanIletisim.Eposta;
            ilaniletisim.Tel = data.IlanIletisim.Tel;
            ilan.IlanIletisim = ilaniletisim;
            ilan.IlanBasligi = data.IlanBasligi;
               ilan.Sektor = data.Sektor;
               ilan.Pozisyon = data.Pozisyon;
               ilan.Adres = data.Adres;
               ilan.CalismaSekli = data.CalismaSekli;
               ilan.Egitim = data.Egitim;
               ilan.IlanNitelik = listNitelik;
               ilan.Dil = data.Dil;
               ilan.IletisimId = data.IlanIletisim.Id;
            ilan.Tarih = data.Tarih;
              
            Insert(ilan);
           

            
            return res;

        }
    }
}
