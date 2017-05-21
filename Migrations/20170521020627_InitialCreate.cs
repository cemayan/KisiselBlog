using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KisiselBlog.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KategoriAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AltKategoriler",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AltKategoriAdi = table.Column<string>(nullable: true),
                    Kategori_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltKategoriler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AltKategoriler_Kategoriler_Kategori_ID",
                        column: x => x.Kategori_ID,
                        principalTable: "Kategoriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paylasimlar",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AltKategori_ID = table.Column<int>(nullable: false),
                    Kategori_ID = table.Column<int>(nullable: false),
                    PaylasimBaslik = table.Column<string>(nullable: true),
                    PaylasimBegenmeSayisi = table.Column<int>(nullable: true),
                    PaylasimGorulmeSayisi = table.Column<int>(nullable: true),
                    PaylasimHTML = table.Column<string>(nullable: true),
                    PaylasimOzet = table.Column<string>(nullable: true),
                    PaylasimResim = table.Column<string>(nullable: true),
                    PaylasimResimGorunur = table.Column<bool>(nullable: false),
                    PaylasimTarih = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paylasimlar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Paylasimlar_AltKategoriler_AltKategori_ID",
                        column: x => x.AltKategori_ID,
                        principalTable: "AltKategoriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paylasimlar_Kategoriler_Kategori_ID",
                        column: x => x.Kategori_ID,
                        principalTable: "Kategoriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AltKategoriler_Kategori_ID",
                table: "AltKategoriler",
                column: "Kategori_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Paylasimlar_AltKategori_ID",
                table: "Paylasimlar",
                column: "AltKategori_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Paylasimlar_Kategori_ID",
                table: "Paylasimlar",
                column: "Kategori_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paylasimlar");

            migrationBuilder.DropTable(
                name: "AltKategoriler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
