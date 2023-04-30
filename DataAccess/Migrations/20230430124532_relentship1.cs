using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class relentship1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borclar_Cariler_CariId1",
                table: "Borclar");

            migrationBuilder.DropIndex(
                name: "IX_Borclar_CariId1",
                table: "Borclar");

            migrationBuilder.DropColumn(
                name: "CariId1",
                table: "Borclar");

            migrationBuilder.CreateIndex(
                name: "IX_FaturaBilgiler_CariId",
                table: "FaturaBilgiler",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_FaturaBilgiler_PersonelId",
                table: "FaturaBilgiler",
                column: "PersonelId");

            migrationBuilder.AddForeignKey(
                name: "FK_FaturaBilgiler_Cariler_CariId",
                table: "FaturaBilgiler",
                column: "CariId",
                principalTable: "Cariler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FaturaBilgiler_Personeller_PersonelId",
                table: "FaturaBilgiler",
                column: "PersonelId",
                principalTable: "Personeller",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FaturaBilgiler_Cariler_CariId",
                table: "FaturaBilgiler");

            migrationBuilder.DropForeignKey(
                name: "FK_FaturaBilgiler_Personeller_PersonelId",
                table: "FaturaBilgiler");

            migrationBuilder.DropIndex(
                name: "IX_FaturaBilgiler_CariId",
                table: "FaturaBilgiler");

            migrationBuilder.DropIndex(
                name: "IX_FaturaBilgiler_PersonelId",
                table: "FaturaBilgiler");

            migrationBuilder.AddColumn<int>(
                name: "CariId1",
                table: "Borclar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Borclar_CariId1",
                table: "Borclar",
                column: "CariId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Borclar_Cariler_CariId1",
                table: "Borclar",
                column: "CariId1",
                principalTable: "Cariler",
                principalColumn: "Id");
        }
    }
}
