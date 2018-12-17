namespace Mezun_Portali.Ent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KimlikBilgileri")]
    public partial class KimlikBilgileri
    {
        public int Id { get; set; }

        public int KullaniciId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Tc_No { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Dogum_Tarihi { get; set; }

        [StringLength(50)]
        public string Dogum_Yeri { get; set; }
    }
}
