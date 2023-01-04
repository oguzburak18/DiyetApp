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
        public DbSet<BesinPorsiyon> BesinPorsiyonlar { get; set; }
        public DbSet<IcecekMl> IcecekMler { get; set; }
        public DbSet<IcecekPorsiyon> IcecekPorsiyonlar { get; set; }
        public DbSet<BesinGram> BesinGramlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MONSTER\\MSSQLSERVER2022; database=DiyetAppDb; Trusted_Connection=True;");
        }
    }
}
