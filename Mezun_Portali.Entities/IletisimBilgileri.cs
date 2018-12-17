namespace Mezun_Portali.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IletisimBilgileri")]
    public partial class IletisimBilgileri
    {
        public int Id { get; set; }

        public int KullaniciId { get; set; }

        [Required]
        [StringLength(50)]
        public string E_Mail { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Telefon { get; set; }

        [StringLength(250)]
        public string Adres { get; set; }

        public virtual MezunTablo MezunTablo { get; set; }
    }
}
