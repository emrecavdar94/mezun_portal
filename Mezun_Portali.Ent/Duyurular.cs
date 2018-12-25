namespace Mezun_Portali.Ent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Duyurular")]
    public partial class Duyurular
    {
        public int Id { get; set; }

        public int AdminId { get; set; }

        [Required]
        [StringLength(500)]
        public string Duyuru { get; set; }

        [Required]
        [StringLength(100)]
        public string DuyuruBaslik { get; set; }

        [Column(TypeName = "date")]
        public DateTime Duyuru_Tarihi { get; set; }
    }
}
