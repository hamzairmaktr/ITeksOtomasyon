using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirmaId",
                table: "Borclar",
                newName: "CariId");

            migrationBuilder.AddColumn<string>(
                name: "KimAldı",
                table: "Borclar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KimAldı",
                table: "Borclar");

            migrationBuilder.RenameColumn(
                name: "CariId",
                table: "Borclar",
                newName: "FirmaId");
        }
    }
}
