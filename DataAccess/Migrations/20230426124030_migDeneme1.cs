using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class migDeneme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_FaturaDetaylar_UrunId",
                table: "FaturaDetaylar",
                column: "UrunId");

            migrationBuilder.AddForeignKey(
                name: "FK_FaturaDetaylar_Urunler_UrunId",
                table: "FaturaDetaylar",
                column: "UrunId",
                principalTable: "Urunler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FaturaDetaylar_Urunler_UrunId",
                table: "FaturaDetaylar");

            migrationBuilder.DropIndex(
                name: "IX_FaturaDetaylar_UrunId",
                table: "FaturaDetaylar");
        }
    }
}
