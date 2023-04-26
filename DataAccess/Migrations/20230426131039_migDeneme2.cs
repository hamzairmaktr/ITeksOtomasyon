using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class migDeneme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FaturaDetaylar_Urunler_UrunId",
                table: "FaturaDetaylar");

            migrationBuilder.AddForeignKey(
                name: "FK_FaturaDetaylar_Urunler_UrunId",
                table: "FaturaDetaylar",
                column: "UrunId",
                principalTable: "Urunler",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FaturaDetaylar_Urunler_UrunId",
                table: "FaturaDetaylar");

            migrationBuilder.AddForeignKey(
                name: "FK_FaturaDetaylar_Urunler_UrunId",
                table: "FaturaDetaylar",
                column: "UrunId",
                principalTable: "Urunler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
