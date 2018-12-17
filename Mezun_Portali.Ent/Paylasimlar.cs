namespace Mezun_Portali.Ent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Paylasimlar")]
    public partial class Paylasimlar
    {
        public int Id { get; set; }

        public int KullaniciId { get; set; }

        [StringLength(500)]
        public string Paylasim { get; set; }

        [Column(TypeName = "date")]
        public DateTime Paylasim_Tarihi { get; set; }

        [StringLength(250)]
        public string Medya { get; set; }

        public virtual MezunTablo MezunTablo { get; set; }
    }
}
