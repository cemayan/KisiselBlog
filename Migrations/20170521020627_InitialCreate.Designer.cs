using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using KisiselBlog.Models;

namespace KisiselBlog.Migrations
{
    [DbContext(typeof(KisiselBlogContext))]
    [Migration("20170521020627_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("KisiselBlog.Models.AltKategoriler", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AltKategoriAdi");

                    b.Property<int>("Kategori_ID");

                    b.HasKey("ID");

                    b.HasIndex("Kategori_ID");

                    b.ToTable("AltKategoriler");
                });

            modelBuilder.Entity("KisiselBlog.Models.Kategoriler", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("KategoriAdi");

                    b.HasKey("ID");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("KisiselBlog.Models.Paylasimlar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AltKategori_ID");

                    b.Property<int>("Kategori_ID");

                    b.Property<string>("PaylasimBaslik");

                    b.Property<int?>("PaylasimBegenmeSayisi");

                    b.Property<int?>("PaylasimGorulmeSayisi");

                    b.Property<string>("PaylasimHTML");

                    b.Property<string>("PaylasimOzet");

                    b.Property<string>("PaylasimResim");

                    b.Property<bool>("PaylasimResimGorunur");

                    b.Property<DateTime?>("PaylasimTarih");

                    b.HasKey("ID");

                    b.HasIndex("AltKategori_ID");

                    b.HasIndex("Kategori_ID");

                    b.ToTable("Paylasimlar");
                });

            modelBuilder.Entity("KisiselBlog.Models.AltKategoriler", b =>
                {
                    b.HasOne("KisiselBlog.Models.Kategoriler", "Kategoriler")
                        .WithMany("AltKategoriler")
                        .HasForeignKey("Kategori_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KisiselBlog.Models.Paylasimlar", b =>
                {
                    b.HasOne("KisiselBlog.Models.AltKategoriler", "AltKategoriler")
                        .WithMany()
                        .HasForeignKey("AltKategori_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KisiselBlog.Models.Kategoriler", "Kategoriler")
                        .WithMany()
                        .HasForeignKey("Kategori_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
