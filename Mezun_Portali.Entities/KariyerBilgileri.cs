namespace Mezun_Portali.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KariyerBilgileri")]
    public partial class KariyerBilgileri
    {
        public int Id { get; set; }

        public int KullaniciId { get; set; }

        [Required]
        [StringLength(100)]
        public string Firma_Adi { get; set; }

        [StringLength(50)]
        public string Pozisyon { get; set; }

        public bool Durum { get; set; }

        public int? Giris_Tarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ayrilma_Tarihi { get; set; }

        public virtual MezunTablo MezunTablo { get; set; }
    }
}
