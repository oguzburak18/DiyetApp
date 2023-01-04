using DiyetApp.Besinler;
using DiyetApp.Kullanici;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetApp.Contexts
{
    public class DiyetDbContext : DbContext
    {
        public DbSet<Admin> Adminler { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<CerezBaklagilGram> CerezBaklagilGramlar { get; set; }
        public DbSet<CerezBaklagilPorsiyon> CerezBaklagilPorsiyonlar { get; set; }
        public DbSet<DigerGram> DigerGramlar { get; set; }
        public DbSet<DigerPorsiyon> DigerPorsiyonlar { get; set; }
        public DbSet<EtGram> EtGramlar { get; set; }
        public DbSet<EtPorsiyon> EtPorsiyonlar { get; set; }
        public DbSet<FastFoodGram> FastFoodGramlar { get; set; }
        public DbSet<FastFoodPorsiyon> FastFoodPorsiyonlar { get; set; }
        public DbSet<IcecekMl> IcecekMler { get; set; }
        public DbSet<IcecekPorsiyon> IcecekPorsiyonlar { get; set; }
        public DbSet<MeyveGram> MeyveGramlar { get; set; }
        public DbSet<MeyvePorsiyon> MeyvePorsiyonlar { get; set; }
        public DbSet<SebzeGram> SebzeGramlar { get; set; }
        public DbSet<SebzePorsiyon> SebzePorsiyonlar { get; set; }
        public DbSet<SutGram> SutGramlar { get; set; }
        public DbSet<SutPorsiyon> SutPorsiyons { get; set; }
        public DbSet<TahilGram> TahilGramlar { get; set; }
        public DbSet<TahilPorsiyon> TahilPorsiyonlar { get; set; }
        public DbSet<YagGram> YagGramlar { get; set; }
        public DbSet<YagPorsiyon> YagPorsiyonlar { get; set; }
        public DbSet<YemekGram> YemekGramlar { get; set; }
        public DbSet<YemekPorsiyon> YemekPorsiyonlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MONSTER\\MSSQLSERVER2022; database=DiyetAppDb; Trusted_Connection=True;");
        }
    }
}
