using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class FaturaTur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FaturaDetaylar_Urunler_UrunId",
                table: "FaturaDetaylar");

            migrationBuilder.DropIndex(
                name: "IX_FaturaDetaylar_UrunId",
                table: "FaturaDetaylar");

            migrationBuilder.AddColumn<string>(
                name: "FaturaTuru",
                table: "FaturaBilgiler",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FaturaTuru",
                table: "FaturaBilgiler");

            migrationBuilder.CreateIndex(
                name: "IX_FaturaDetaylar_UrunId",
                table: "FaturaDetaylar",
                column: "UrunId");

            migrationBuilder.AddForeignKey(
                name: "FK_FaturaDetaylar_Urunler_UrunId",
                table: "FaturaDetaylar",
                column: "UrunId",
                principalTable: "Urunler",
                principalColumn: "Id");
        }
    }
}
