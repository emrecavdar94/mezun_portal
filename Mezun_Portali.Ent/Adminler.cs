namespace Mezun_Portali.Ent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Adminler")]
    public partial class Adminler
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }

        [Required]
        [StringLength(50)]
        public string Soyad { get; set; }

        [Required]
        [StringLength(50)]
        public string Kullanici_Adi { get; set; }

        [Required]
        [StringLength(50)]
        public string Sifre { get; set; }
    }
}
