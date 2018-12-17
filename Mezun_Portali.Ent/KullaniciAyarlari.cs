namespace Mezun_Portali.Ent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KullaniciAyarlari")]
    public partial class KullaniciAyarlari
    {
        public int Id { get; set; }

        public int MezunId { get; set; }

        public bool? Telefon_Bilgi { get; set; }

        public bool? Mesaj_Alma { get; set; }

        public virtual MezunTablo MezunTablo { get; set; }
    }
}
