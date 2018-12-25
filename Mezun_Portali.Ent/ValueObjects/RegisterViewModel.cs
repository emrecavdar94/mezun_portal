using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mezun_Portali.Ent.ValueObjects
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="{0} alanı boş geçilemez."),DisplayName("Ad")]
        [StringLength(50,ErrorMessage ="{0} max. {1} karakter olmalıdır.")]
        public string Ad { get; set; }

       
        public string Soyad { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez."), DisplayName("Tc Kimlik No")]
        [StringLength(11, ErrorMessage = "{0} max. {1} karakter olmalıdır.")]
        public string TcKimlik { get; set; }
        [DisplayName("Tc Kimlik No")]
        public string DogumYeri { get; set; }

        public decimal Fakulte_No { get; set; }

        [Required(ErrorMessage ="{0} alanı boş geçilemez."),DisplayName("Kullanıcı Adı")]
        [StringLength(50,ErrorMessage ="{0} alanı max. {1} uzunluğunda olmalıdır.")]
        public string Kullanici_Adi { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez."),DataType(DataType.Password),DisplayName("Şifre")]
        [StringLength(50,ErrorMessage =("{0} max. {1} karakter olmalı."))]
        public string Sifre { get; set; }
        [DataType(DataType.Date),DisplayName("Şifre")]
        public DateTime DogumTarihi { get; set; }

        [DisplayName("Şifre Tekrar"),Required(ErrorMessage ="{0} alanı boş geçilemez."),DataType(DataType.Password), StringLength(50, ErrorMessage = ("{0} max. {1} karakter olmalı.")),Compare("Sifre",ErrorMessage ="{0} ile {1} uyuşmamaktadır.")]
        public string SifreTekrar { get; set; }
        public bool Onaylandi { get; set; }


        [DisplayName("E-posta"),
            Required(ErrorMessage = "{0} alanı boş geçilemez."),
            StringLength(50, ErrorMessage = "{0} max. {1} karakter olmalı."),
            EmailAddress(ErrorMessage = "{0} alanı için geçerli bir e-posta adresi giriniz.")]
        public string Mail { get; set; }

        
    }
}
