namespace Mezun_Portali.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KullaniciAyarlari")]
    public partial class KullaniciAyarlari
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string KullaniciId { get; set; }

        public bool? Telefon_Bilgi { get; set; }

        public bool? Mesaj_Alma { get; set; }
    }
}
