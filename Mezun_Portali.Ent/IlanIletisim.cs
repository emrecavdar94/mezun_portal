namespace Mezun_Portali.Ent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IlanIletisim")]
    public partial class IlanIletisim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IlanIletisim()
        {
            Ilan = new HashSet<Ilan>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        [StringLength(50)]
        public string Eposta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ilan> Ilan { get; set; }
    }
}
