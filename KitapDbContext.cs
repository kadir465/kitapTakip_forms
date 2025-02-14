using BtkKitapTakip.Modeller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkKitapTakip.Db
{
    public class KitapDbContext : DbContext
    {
        public DbSet<DbKategori> Kategoriler { get; set; }
        public DbSet<DbKitap> Kitaplar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Properties.BtkKitapTakip.LocalSqlServerConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbKategori>()
                .HasMany(x => x.Kitaplar)
                .WithOne(x => x.Kategori)
                .HasPrincipalKey(x=>x.Id)
                .HasForeignKey(x=>x.KategoriId);

            modelBuilder.Entity<DbKategori>()
                 .HasData(new DbKategori() { Id = 1, KategoriAdi = "Roman" },
                 new DbKategori() { Id = 2, KategoriAdi = "Şiir" });

        }
    }
}
