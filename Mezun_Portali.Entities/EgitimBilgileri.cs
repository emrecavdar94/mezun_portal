namespace Mezun_Portali.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EgitimBilgileri")]
    public partial class EgitimBilgileri
    {
        public int Id { get; set; }

        public int KullaniciId { get; set; }

        [Required]
        [StringLength(100)]
        public string Universite_Adi { get; set; }

        [Required]
        [StringLength(50)]
        public string Tur { get; set; }

        [Required]
        [StringLength(50)]
        public string Fakulte { get; set; }

        [Required]
        [StringLength(50)]
        public string Bolum { get; set; }

        public int Giris_Yili { get; set; }

        [Column(TypeName = "date")]
        public DateTime Mezuniyet_Tarihi { get; set; }

        public virtual MezunTablo MezunTablo { get; set; }
    }
}
