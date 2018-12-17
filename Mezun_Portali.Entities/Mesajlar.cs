namespace Mezun_Portali.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mesajlar")]
    public partial class Mesajlar
    {
        public int Id { get; set; }

        public int KullaniciId { get; set; }

        public int AliciId { get; set; }

        [Required]
        [StringLength(500)]
        public string Mesaj { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }

        public bool Okundumu { get; set; }

        public virtual MezunTablo MezunTablo { get; set; }

        public virtual MezunTablo MezunTablo1 { get; set; }
    }
}
