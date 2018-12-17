namespace Mezun_Portali.Ent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SertifikaBilgileri")]
    public partial class SertifikaBilgileri
    {
        public int Id { get; set; }

        public int KullaniciId { get; set; }

        [Required]
        [StringLength(250)]
        public string Aciklama { get; set; }

        [StringLength(150)]
        public string Alinan_Kurum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Tarih { get; set; }

        public virtual MezunTablo MezunTablo { get; set; }
    }
}
