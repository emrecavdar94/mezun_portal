namespace Mezun_Portali.Ent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bildirimler")]
    public partial class Bildirimler
    {
        public int Id { get; set; }

        public int MezunId { get; set; }

        [Required]
        [StringLength(250)]
        public string Bildirim { get; set; }

        public virtual MezunTablo MezunTablo { get; set; }
    }
}
