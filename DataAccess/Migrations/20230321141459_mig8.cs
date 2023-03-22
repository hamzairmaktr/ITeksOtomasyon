using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CariTurler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Borc",
                table: "Borc");

            migrationBuilder.DropColumn(
                name: "TurId",
                table: "Borc");

            migrationBuilder.RenameTable(
                name: "Borc",
                newName: "Borclar");

            migrationBuilder.AlterColumn<string>(
                name: "CariTur",
                table: "Cariler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Tur",
                table: "Borclar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Borclar",
                table: "Borclar",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Borclar",
                table: "Borclar");

            migrationBuilder.DropColumn(
                name: "Tur",
                table: "Borclar");

            migrationBuilder.RenameTable(
                name: "Borclar",
                newName: "Borc");

            migrationBuilder.AlterColumn<int>(
                name: "CariTur",
                table: "Cariler",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "TurId",
                table: "Borc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Borc",
                table: "Borc",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CariTurler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CariTurler", x => x.Id);
                });
        }
    }
}
