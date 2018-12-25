namespace Mezun_Portali.Ent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MezunTablo")]
    public partial class MezunTablo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MezunTablo()
        {
            ArkadaslikBilgileri = new HashSet<ArkadaslikBilgileri>();
            ArkadaslikBilgileri1 = new HashSet<ArkadaslikBilgileri>();
            Bildirimler = new HashSet<Bildirimler>();
            EgitimBilgileri = new HashSet<EgitimBilgileri>();
            HobiBilgileri = new HashSet<HobiBilgileri>();
            IletisimBilgileri = new HashSet<IletisimBilgileri>();
            KariyerBilgileri = new HashSet<KariyerBilgileri>();
           
            KullaniciAyarlari = new HashSet<KullaniciAyarlari>();
            Mesajlar = new HashSet<Mesajlar>();
            Mesajlar1 = new HashSet<Mesajlar>();
            Paylasimlar = new HashSet<Paylasimlar>();
            ProjeBilgileri = new HashSet<ProjeBilgileri>();
            SertifikaBilgileri = new HashSet<SertifikaBilgileri>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }

        [Required]
        [StringLength(50)]
        public string Soyad { get; set; }
        

        [StringLength(250)]
        public string Fotograf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Telefon { get; set; }

        [Required]
        [StringLength(50)]
        public string Kullanici_Adi { get; set; }

        [Required]
        [StringLength(50)]
        public string Sifre { get; set; }

        [StringLength(11)]
        public string Tc_No { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }

        [StringLength(50)]
        public string DogumYeri { get; set; }

        public bool Onaylandi { get; set; }

        [Required]
        [StringLength(50)]
        public string Mail { get; set; }

        [StringLength(50)]
        public string Facebook { get; set; }

        [StringLength(50)]
        public string Twitter { get; set; }

        [StringLength(50)]
        public string Instagram { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArkadaslikBilgileri> ArkadaslikBilgileri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArkadaslikBilgileri> ArkadaslikBilgileri1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bildirimler> Bildirimler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EgitimBilgileri> EgitimBilgileri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HobiBilgileri> HobiBilgileri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IletisimBilgileri> IletisimBilgileri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KariyerBilgileri> KariyerBilgileri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciAyarlari> KullaniciAyarlari { get; set; }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mesajlar> Mesajlar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mesajlar> Mesajlar1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paylasimlar> Paylasimlar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjeBilgileri> ProjeBilgileri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SertifikaBilgileri> SertifikaBilgileri { get; set; }
    }
}
