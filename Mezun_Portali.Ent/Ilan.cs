namespace Mezun_Portali.Ent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ilan")]
    public partial class Ilan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ilan()
        {
            IlanNitelik = new HashSet<IlanNitelik>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string IlanBasligi { get; set; }

        [Required]
        [StringLength(100)]
        public string Sektor { get; set; }

        [StringLength(50)]
        public string Pozisyon { get; set; }

        [StringLength(250)]
        public string Adres { get; set; }

        [StringLength(50)]
        public string CalismaSekli { get; set; }

        [StringLength(250)]
        public string Egitim { get; set; }

        [StringLength(250)]
        public string Dil { get; set; }

        public int IletisimId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }

        public virtual AskerlikDurum AskerlikDurum { get; set; }

        public virtual IlanIletisim IlanIletisim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanNitelik> IlanNitelik { get; set; }
    }
}
