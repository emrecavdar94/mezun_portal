namespace Mezun_Portali.Ent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArkadaslikBilgileri")]
    public partial class ArkadaslikBilgileri
    {
        public int Id { get; set; }

        public int KullaniciId { get; set; }

        public int ArkadasId { get; set; }

        public virtual MezunTablo MezunTablo { get; set; }

        public virtual MezunTablo MezunTablo1 { get; set; }
    }
}
