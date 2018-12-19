using Mezun_Portali.BusinessLayer.Abstract;
using Mezun_Portali.BusinessLayer.Results;
using Mezun_Portali.Ent;
using Mezun_Portali.Ent.Messages;
using Mezun_Portali.Ent.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mezun_Portali.BusinessLayer
{
    public class MezunManager:ManagerBase<MezunTablo>
    {
        public BusinessLayerResult<MezunTablo> Kayit(RegisterViewModel data)
        {
            MezunTablo mezun = Find(x => x.Kullanici_Adi == data.Kullanici_Adi || x.Mail == data.Mail);
            BusinessLayerResult<MezunTablo> res = new BusinessLayerResult<MezunTablo>();
            if (mezun != null)
            {
                if (mezun.Kullanici_Adi==data.Kullanici_Adi)
                {
                    res.AddError(ErrorMessageCode.UsernameAlreadyExists, "Kullanıcı adı kayıtlı");
                }

                if (mezun.Kullanici_Adi==data.Kullanici_Adi)
                {
                    res.AddError(ErrorMessageCode.EmailAlreadyExists, "E-Posta adresi kayıtlı.");
                }
                else
                {
                    int dbResult = base.Insert(new MezunTablo()
                    {
                        Ad = data.Ad,
                        Kullanici_Adi = data.Kullanici_Adi,
                        Sifre=data.Sifre,
                        Onaylandi=false,
                        Mail=data.Mail
                        

                    });
                }
            }
            return res;

        }
      public  BusinessLayerResult<MezunTablo> Bul (int id)
        {
            BusinessLayerResult<MezunTablo> res = new BusinessLayerResult<MezunTablo>();
            MezunTablo mezun = Find(x => x.Id == id);
            res.Result = mezun;
            if (res==null)
            {
                res.AddError(ErrorMessageCode.UserCouldNotFind, "Mezun Bulunamadı.");

            }

            return res;
        }
    }
}
