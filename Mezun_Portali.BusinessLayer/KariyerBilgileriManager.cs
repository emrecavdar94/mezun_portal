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
    public class KariyerBilgileriManager:ManagerBase<KariyerBilgileri>
    {
        private MezunManager mezunManager = new MezunManager();
        private BusinessLayerResult<MezunTablo> mezunResult = new BusinessLayerResult<MezunTablo>();
        public BusinessLayerResult<KariyerBilgileri> KariyerBilgiEkle(KariyerBilgileri data)
        {
            bool kariyerDurum;
            mezunResult= mezunManager.Bul(data.KullaniciId);
            MezunTablo mezun = mezunResult.Result;

            BusinessLayerResult<KariyerBilgileri> res = new BusinessLayerResult<KariyerBilgileri>();
            if (mezun == null)
            {
                res.AddError(ErrorMessageCode.UserCouldNotFind, "Mezun bulunamadı");
            }
            else
            {
                if (data.Giris_Tarihi != null)
                {
                    kariyerDurum = false;
                }
                else
                {
                    kariyerDurum = true;
                }
                int dbResult = base.Insert(new KariyerBilgileri()
                {
                    KullaniciId = mezun.Id,
                    Ayrilma_Tarihi = data.Ayrilma_Tarihi,
                    Durum=kariyerDurum,
                    Firma_Adi = data.Firma_Adi,
                    Giris_Tarihi = data.Giris_Tarihi,
                    Pozisyon = data.Pozisyon



                });
                

            }
            return res;
        }
    }
}
