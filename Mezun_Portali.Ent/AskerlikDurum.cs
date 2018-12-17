namespace Mezun_Portali.Ent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AskerlikDurum")]
    public partial class AskerlikDurum
    {
        public int Id { get; set; }

        public int IlanId { get; set; }

        [Required]
        [StringLength(250)]
        public string Durum { get; set; }

        public virtual Ilan Ilan { get; set; }
    }
}
