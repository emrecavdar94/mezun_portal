namespace Mezun_Portali.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProjeBilgileri")]
    public partial class ProjeBilgileri
    {
        public int Id { get; set; }

        public int KullaniciId { get; set; }

        [Required]
        [StringLength(50)]
        public string Proje_Adi { get; set; }

        [StringLength(50)]
        public string Gorev { get; set; }

        [StringLength(250)]
        public string Aciklama { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Tarih { get; set; }

        public virtual MezunTablo MezunTablo { get; set; }
    }
}
