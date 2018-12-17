using Mezun_Portali.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mezun_Portali.DataAccessLAyer
{
   public class DatabaseContext:DbContext
    {
        public DatabaseContext()
            : base("name=dbMezunPortali")
        {
        }

        public virtual DbSet<Adminler> Adminler { get; set; }
        public virtual DbSet<ArkadaslikBilgileri> ArkadaslikBilgileri { get; set; }
        public virtual DbSet<Bildirimler> Bildirimler { get; set; }
        public virtual DbSet<Duyurular> Duyurular { get; set; }
        public virtual DbSet<EgitimBilgileri> EgitimBilgileri { get; set; }
        public virtual DbSet<HobiBilgileri> HobiBilgileri { get; set; }
        public virtual DbSet<IletisimBilgileri> IletisimBilgileri { get; set; }
        public virtual DbSet<KariyerBilgileri> KariyerBilgileri { get; set; }
        public virtual DbSet<KimlikBilgileri> KimlikBilgileri { get; set; }
        public virtual DbSet<Mesajlar> Mesajlar { get; set; }
        public virtual DbSet<MezunTablo> MezunTablo { get; set; }
        public virtual DbSet<Paylasimlar> Paylasimlar { get; set; }
        public virtual DbSet<ProjeBilgileri> ProjeBilgileri { get; set; }
        public virtual DbSet<SertifikaBilgileri> SertifikaBilgileri { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<KullaniciAyarlari> KullaniciAyarlari { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IletisimBilgileri>()
                .Property(e => e.Telefon)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KimlikBilgileri>()
                .Property(e => e.Tc_No)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MezunTablo>()
                .Property(e => e.Fakulte_No)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MezunTablo>()
                .Property(e => e.Telefon)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MezunTablo>()
                .HasMany(e => e.ArkadaslikBilgileri)
                .WithRequired(e => e.MezunTablo)
                .HasForeignKey(e => e.KullaniciId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MezunTablo>()
                .HasMany(e => e.ArkadaslikBilgileri1)
                .WithRequired(e => e.MezunTablo1)
                .HasForeignKey(e => e.ArkadasId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MezunTablo>()
                .HasMany(e => e.Bildirimler)
                .WithRequired(e => e.MezunTablo)
                .HasForeignKey(e => e.MezunId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MezunTablo>()
                .HasMany(e => e.EgitimBilgileri)
                .WithRequired(e => e.MezunTablo)
                .HasForeignKey(e => e.KullaniciId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MezunTablo>()
                .HasMany(e => e.HobiBilgileri)
                .WithOptional(e => e.MezunTablo)
                .HasForeignKey(e => e.KullaniciId);

            modelBuilder.Entity<MezunTablo>()
                .HasMany(e => e.IletisimBilgileri)
                .WithRequired(e => e.MezunTablo)
                .HasForeignKey(e => e.KullaniciId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MezunTablo>()
                .HasMany(e => e.KariyerBilgileri)
                .WithRequired(e => e.MezunTablo)
                .HasForeignKey(e => e.KullaniciId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MezunTablo>()
                .HasMany(e => e.Mesajlar)
                .WithRequired(e => e.MezunTablo)
                .HasForeignKey(e => e.KullaniciId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MezunTablo>()
                .HasMany(e => e.Mesajlar1)
                .WithRequired(e => e.MezunTablo1)
                .HasForeignKey(e => e.AliciId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MezunTablo>()
                .HasMany(e => e.Paylasimlar)
                .WithRequired(e => e.MezunTablo)
                .HasForeignKey(e => e.KullaniciId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MezunTablo>()
                .HasMany(e => e.ProjeBilgileri)
                .WithRequired(e => e.MezunTablo)
                .HasForeignKey(e => e.KullaniciId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MezunTablo>()
                .HasMany(e => e.SertifikaBilgileri)
                .WithRequired(e => e.MezunTablo)
                .HasForeignKey(e => e.KullaniciId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KullaniciAyarlari>()
                .Property(e => e.Id)
                .IsFixedLength();

            modelBuilder.Entity<KullaniciAyarlari>()
                .Property(e => e.KullaniciId)
                .IsFixedLength();
        }
    }
}
