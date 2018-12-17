namespace Mezun_Portali.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HobiBilgileri")]
    public partial class HobiBilgileri
    {
        public int Id { get; set; }

        public int? KullaniciId { get; set; }

        [StringLength(150)]
        public string Hobi_Adi { get; set; }

        public virtual MezunTablo MezunTablo { get; set; }
    }
}
