using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class RelentshipStart2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borclar_Cariler_CariId",
                table: "Borclar");

            migrationBuilder.DropIndex(
                name: "IX_Borclar_CariId",
                table: "Borclar");

            migrationBuilder.AddColumn<int>(
                name: "CariId1",
                table: "Borclar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Borclar_CariId",
                table: "Borclar",
                column: "CariId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Borclar_CariId1",
                table: "Borclar",
                column: "CariId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Borclar_Cariler_CariId",
                table: "Borclar",
                column: "CariId",
                principalTable: "Cariler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Borclar_Cariler_CariId1",
                table: "Borclar",
                column: "CariId1",
                principalTable: "Cariler",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borclar_Cariler_CariId",
                table: "Borclar");

            migrationBuilder.DropForeignKey(
                name: "FK_Borclar_Cariler_CariId1",
                table: "Borclar");

            migrationBuilder.DropIndex(
                name: "IX_Borclar_CariId",
                table: "Borclar");

            migrationBuilder.DropIndex(
                name: "IX_Borclar_CariId1",
                table: "Borclar");

            migrationBuilder.DropColumn(
                name: "CariId1",
                table: "Borclar");

            migrationBuilder.CreateIndex(
                name: "IX_Borclar_CariId",
                table: "Borclar",
                column: "CariId");

            migrationBuilder.AddForeignKey(
                name: "FK_Borclar_Cariler_CariId",
                table: "Borclar",
                column: "CariId",
                principalTable: "Cariler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
