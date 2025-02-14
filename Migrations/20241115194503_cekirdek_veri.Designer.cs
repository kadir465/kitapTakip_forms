﻿// <auto-generated />
using System;
using BtkKitapTakip.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BtkKitapTakip.Migrations
{
    [DbContext(typeof(KitapDbContext))]
    [Migration("20241115194503_cekirdek_veri")]
    partial class cekirdek_veri
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BtkKitapTakip.Modeller.DbKategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            KategoriAdi = "Roman"
                        },
                        new
                        {
                            Id = 2,
                            KategoriAdi = "Şiir"
                        });
                });

            modelBuilder.Entity("BtkKitapTakip.Modeller.DbKitap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("Yazar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("BtkKitapTakip.Modeller.DbKitap", b =>
                {
                    b.HasOne("BtkKitapTakip.Modeller.DbKategori", "Kategori")
                        .WithMany("Kitaplar")
                        .HasForeignKey("KategoriId");

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("BtkKitapTakip.Modeller.DbKategori", b =>
                {
                    b.Navigation("Kitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
