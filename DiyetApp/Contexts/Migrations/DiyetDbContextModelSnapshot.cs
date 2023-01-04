﻿// <auto-generated />
using DiyetApp.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiyetApp.Contexts.Migrations
{
    [DbContext(typeof(DiyetDbContext))]
    partial class DiyetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DiyetApp.Besinler.CerezBaklagilGram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gram")
                        .HasColumnType("int");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("CerezBaklagilGramlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.CerezBaklagilPorsiyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("Porsiyon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("CerezBaklagilPorsiyonlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.DigerGram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gram")
                        .HasColumnType("int");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("DigerGramlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.DigerPorsiyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("Porsiyon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("DigerPorsiyonlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.EtGram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gram")
                        .HasColumnType("int");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("EtGramlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.EtPorsiyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("Porsiyon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("EtPorsiyonlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.FastFoodGram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gram")
                        .HasColumnType("int");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("FastFoodGramlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.FastFoodPorsiyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("Porsiyon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("FastFoodPorsiyonlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.IcecekMl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("Ml")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("IcecekMler");
                });

            modelBuilder.Entity("DiyetApp.Besinler.IcecekPorsiyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("Porsiyon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("IcecekPorsiyonlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("DiyetApp.Besinler.MeyveGram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gram")
                        .HasColumnType("int");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("MeyveGramlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.MeyvePorsiyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("Porsiyon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("MeyvePorsiyonlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.SebzeGram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gram")
                        .HasColumnType("int");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("SebzeGramlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.SebzePorsiyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("Porsiyon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("SebzePorsiyonlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.SutGram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gram")
                        .HasColumnType("int");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("SutGramlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.SutPorsiyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("Porsiyon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("SutPorsiyons");
                });

            modelBuilder.Entity("DiyetApp.Besinler.TahilGram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gram")
                        .HasColumnType("int");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("TahilGramlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.TahilPorsiyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("Porsiyon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("TahilPorsiyonlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.YagGram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gram")
                        .HasColumnType("int");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("YagGramlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.YagPorsiyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("Porsiyon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("YagPorsiyonlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.YemekGram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gram")
                        .HasColumnType("int");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("YemekGramlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.YemekPorsiyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kalori")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("Porsiyon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("YemekPorsiyonlar");
                });

            modelBuilder.Entity("DiyetApp.Kullanici.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdminAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Adminler");
                });

            modelBuilder.Entity("DiyetApp.Kullanici.Uye", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Boy")
                        .HasColumnType("int");

                    b.Property<bool>("Cinsiyet")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GizliYanit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HedefKalori")
                        .HasColumnType("float");

                    b.Property<int>("Kilo")
                        .HasColumnType("int");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Yas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Uyeler");
                });

            modelBuilder.Entity("DiyetApp.Besinler.CerezBaklagilGram", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("CerezBaklagilGramlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.CerezBaklagilPorsiyon", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("CerezBaklagilPorsiyonlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.DigerGram", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("DigerGramlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.DigerPorsiyon", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("DigerPorsiyonlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.EtGram", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("EtGramlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.EtPorsiyon", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("EtPorsiyonlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.FastFoodGram", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("FastFoodGramlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.FastFoodPorsiyon", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("FastFoodPorsiyonlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.IcecekMl", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("IcecekMler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.IcecekPorsiyon", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("IcecekPorsiyonlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.MeyveGram", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("MeyveGramlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.MeyvePorsiyon", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("MeyvePorsiyonlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.SebzeGram", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("SebzeGramlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.SebzePorsiyon", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("SebzePorsiyonlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.SutGram", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("SutGramlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.SutPorsiyon", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("SutPorsiyons")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.TahilGram", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("TahilGramlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.TahilPorsiyon", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("TahilPorsiyonlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.YagGram", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("YagGramlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.YagPorsiyon", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("YagPorsiyonlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.YemekGram", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("YemekGramlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.YemekPorsiyon", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("YemekPorsiyonlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Besinler.Kategori", b =>
                {
                    b.Navigation("CerezBaklagilGramlar");

                    b.Navigation("CerezBaklagilPorsiyonlar");

                    b.Navigation("DigerGramlar");

                    b.Navigation("DigerPorsiyonlar");

                    b.Navigation("EtGramlar");

                    b.Navigation("EtPorsiyonlar");

                    b.Navigation("FastFoodGramlar");

                    b.Navigation("FastFoodPorsiyonlar");

                    b.Navigation("IcecekMler");

                    b.Navigation("IcecekPorsiyonlar");

                    b.Navigation("MeyveGramlar");

                    b.Navigation("MeyvePorsiyonlar");

                    b.Navigation("SebzeGramlar");

                    b.Navigation("SebzePorsiyonlar");

                    b.Navigation("SutGramlar");

                    b.Navigation("SutPorsiyons");

                    b.Navigation("TahilGramlar");

                    b.Navigation("TahilPorsiyonlar");

                    b.Navigation("YagGramlar");

                    b.Navigation("YagPorsiyonlar");

                    b.Navigation("YemekGramlar");

                    b.Navigation("YemekPorsiyonlar");
                });
#pragma warning restore 612, 618
        }
    }
}