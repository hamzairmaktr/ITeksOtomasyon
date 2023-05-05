using Core.DataAccess.EntityFramework.Context;
using Core.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class Context : DbContext, IContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ITeksOtomasyon;Trusted_Connection=true;");
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<FaturaDetay>()
            //    .HasMany<FaturaDetay>(u => u.UrunId)
            //    .WithMany()
            //    .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Borc>()
                .HasOne<Cari>()
                .WithOne()
                .HasForeignKey<Borc>(b => b.CariId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<FaturaBilgi>()
                .HasOne<Personel>()
                .WithMany()
                .HasForeignKey(f => f.PersonelId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<FaturaBilgi>()
                .HasOne<Cari>()
                .WithMany()
                .HasForeignKey(f => f.CariId)
                .OnDelete(DeleteBehavior.NoAction);
        }



        public DbSet<Banka> Bankalar { get; set; }
        public DbSet<Borc> Borclar { get; set; }
        public DbSet<FaturaBilgi> FaturaBilgiler { get; set; }
        public DbSet<FaturaDetay> FaturaDetaylar { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Gider> Giderler { get; set; }
        public DbSet<Not> Notlar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Haraket> Haraketler { get; set; }
        public DbSet<HaraketTur> HaraketTurler { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<KasaTur> KasalarTurler { get; set; }
    }
}
