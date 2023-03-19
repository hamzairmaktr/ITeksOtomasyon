using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ITeksOtomasyon;Trusted_Connection=true");
        }
        public DbSet<Banka> Bankalar { get; set; }
        public DbSet<Borc> Borclar { get; set; }
        public DbSet<FaturaBilgi> FaturaBilgiler { get; set; }
        public DbSet<FaturaDetay> FaturaDetaylar { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Gider> Giderler { get; set; }
        public DbSet<Ip> Ipler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<MyBorc> MyBorclar { get; set; }
        public DbSet<Not> Notlar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}
