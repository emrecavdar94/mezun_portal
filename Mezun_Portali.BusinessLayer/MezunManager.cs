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
            BusinessLayerResult<MezunTablo> res = new BusinessLayerResult<MezunTablo>();
            MezunTablo mezun = Find(x => x.Kullanici_Adi == data.Kullanici_Adi || x.Mail == data.Mail);



            if (mezun != null)
            {
                if (mezun.Kullanici_Adi == data.Kullanici_Adi)
                {
                    res.AddError(ErrorMessageCode.UsernameAlreadyExists, "Kullanıcı adı kayıtlı");
                    return res;
                }

                else if (mezun.Mail == data.Mail)
                {
                    res.AddError(ErrorMessageCode.EmailAlreadyExists, "E-Posta adresi kayıtlı.");
                    return res;
                }
            } 
                
                    
                    
                   
                    MezunTablo mezunTablo = new MezunTablo();
                    mezunTablo.Ad = data.Ad;
                     mezunTablo.Soyad = data.Soyad;       
                    mezunTablo.Kullanici_Adi = data.Kullanici_Adi;
                    mezunTablo.Sifre = data.Sifre;
                    mezunTablo.Onaylandi = false;
                    mezunTablo.Mail = data.Mail;
                    mezunTablo.DogumYeri = data.DogumYeri;
                    mezunTablo.Tc_No = data.TcKimlik;
                    mezunTablo.DogumTarihi = data.DogumTarihi;
                    Insert(mezunTablo);
                    
                
            
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
        public BusinessLayerResult<MezunTablo> Giris(LoginViewModel data)
        {
            BusinessLayerResult<MezunTablo> res = new BusinessLayerResult<MezunTablo>();
            MezunTablo mezun = Find(x => x.Kullanici_Adi == data.username || x.Mail == data.email && x.Sifre==data.password);
            res.Result = mezun;
            if (mezun==null)
            {
                res.AddError(ErrorMessageCode.UserCouldNotFind, "Hatalı Giriş");
            }
            
            return res;
        }
    }
}
