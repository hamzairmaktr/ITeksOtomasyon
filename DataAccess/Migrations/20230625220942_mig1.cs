using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bankalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BankaAd = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Sube = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Iban = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    HesapNo = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Yetkili = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false),
                    Tarih = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HesapTuru = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bankalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cariler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ismi = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    CariTur = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    YetkiliAdSoyad = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false),
                    YetkiliStatu = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Telefon1 = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Telefon2 = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Mail = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Fax = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Il = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Ilce = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    VergiDaire = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Adres = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cariler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FaturaDetaylar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FaturaId = table.Column<int>(type: "INTEGER", nullable: false),
                    UrunId = table.Column<int>(type: "INTEGER", nullable: false),
                    TopSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    Kg = table.Column<decimal>(type: "TEXT", nullable: false),
                    KdvOran = table.Column<byte>(type: "INTEGER", nullable: false),
                    Kdv = table.Column<decimal>(type: "TEXT", nullable: false),
                    Fiyat = table.Column<decimal>(type: "TEXT", nullable: false),
                    KdvFiyat = table.Column<decimal>(type: "TEXT", nullable: false),
                    Tutar = table.Column<decimal>(type: "TEXT", nullable: false),
                    KdvTutar = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaturaDetaylar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Giderler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Tur = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    PersonelId = table.Column<int>(type: "INTEGER", nullable: false),
                    Not = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Tutar = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giderler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Haraketler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CariId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonelId = table.Column<int>(type: "INTEGER", nullable: false),
                    HaraketTur = table.Column<int>(type: "INTEGER", nullable: false),
                    Detay = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Tutar = table.Column<decimal>(type: "TEXT", nullable: false),
                    Tarih = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haraketler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HaraketTurler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HaraketTurler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kasalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KasaTur = table.Column<int>(type: "INTEGER", nullable: false),
                    Bakiye = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kasalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KasalarTurler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    BankaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KasalarTurler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Onem = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Baslik = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Detay = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    PersonelID = table.Column<int>(type: "INTEGER", nullable: false),
                    Yapildimi = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdSoyad = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Maas = table.Column<decimal>(type: "TEXT", nullable: false),
                    Telefon = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Mail = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Il = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Ilce = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    Adres = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Gorev = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stoklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tur = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    TopAdet = table.Column<int>(type: "INTEGER", nullable: false),
                    Kilogram = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stoklar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LotNo = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    KumasTur = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    KumasAd = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Renk = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Kg = table.Column<decimal>(type: "TEXT", nullable: false),
                    TopAdet = table.Column<int>(type: "INTEGER", nullable: false),
                    Detay = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AlisFiyat = table.Column<decimal>(type: "TEXT", nullable: false),
                    SatisFiyat = table.Column<decimal>(type: "TEXT", nullable: false),
                    Finish = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Borclar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CariId = table.Column<int>(type: "INTEGER", nullable: false),
                    Tur = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Tutar = table.Column<decimal>(type: "TEXT", nullable: false),
                    KacOdendi = table.Column<decimal>(type: "TEXT", nullable: false),
                    KacOdenecek = table.Column<decimal>(type: "TEXT", nullable: false),
                    VerilisTarih = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TeslimTarih = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Geciktimi = table.Column<bool>(type: "INTEGER", nullable: false),
                    Odendimi = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borclar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Borclar_Cariler_CariId",
                        column: x => x.CariId,
                        principalTable: "Cariler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FaturaBilgiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FaturaTuru = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    SeriNo = table.Column<string>(type: "TEXT", maxLength: 6, nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CariId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonelId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeslimAlan = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false),
                    KacOdendi = table.Column<decimal>(type: "TEXT", nullable: false),
                    KacOdenecek = table.Column<decimal>(type: "TEXT", nullable: false),
                    Tutar = table.Column<decimal>(type: "TEXT", nullable: false),
                    Odendimi = table.Column<bool>(type: "INTEGER", nullable: false),
                    FaturaKesildimi = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaturaBilgiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FaturaBilgiler_Cariler_CariId",
                        column: x => x.CariId,
                        principalTable: "Cariler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FaturaBilgiler_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Borclar_CariId",
                table: "Borclar",
                column: "CariId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FaturaBilgiler_CariId",
                table: "FaturaBilgiler",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_FaturaBilgiler_PersonelId",
                table: "FaturaBilgiler",
                column: "PersonelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bankalar");

            migrationBuilder.DropTable(
                name: "Borclar");

            migrationBuilder.DropTable(
                name: "FaturaBilgiler");

            migrationBuilder.DropTable(
                name: "FaturaDetaylar");

            migrationBuilder.DropTable(
                name: "Giderler");

            migrationBuilder.DropTable(
                name: "Haraketler");

            migrationBuilder.DropTable(
                name: "HaraketTurler");

            migrationBuilder.DropTable(
                name: "Kasalar");

            migrationBuilder.DropTable(
                name: "KasalarTurler");

            migrationBuilder.DropTable(
                name: "Notlar");

            migrationBuilder.DropTable(
                name: "Stoklar");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Cariler");

            migrationBuilder.DropTable(
                name: "Personeller");
        }
    }
}
