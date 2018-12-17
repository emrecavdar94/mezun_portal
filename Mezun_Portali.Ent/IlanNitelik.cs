namespace Mezun_Portali.Ent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IlanNitelik")]
    public partial class IlanNitelik
    {
        public int Id { get; set; }

        public int IlanId { get; set; }

        [Required]
        [StringLength(250)]
        public string Aciklama { get; set; }

        public virtual Ilan Ilan { get; set; }
    }
}
