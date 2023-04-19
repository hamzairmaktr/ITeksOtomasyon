using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DogalGaz",
                table: "Giderler");

            migrationBuilder.DropColumn(
                name: "Ekstra",
                table: "Giderler");

            migrationBuilder.DropColumn(
                name: "Elektrik",
                table: "Giderler");

            migrationBuilder.DropColumn(
                name: "Internet",
                table: "Giderler");

            migrationBuilder.DropColumn(
                name: "Maaslar",
                table: "Giderler");

            migrationBuilder.DropColumn(
                name: "Su",
                table: "Giderler");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DogalGaz",
                table: "Giderler",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Ekstra",
                table: "Giderler",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Elektrik",
                table: "Giderler",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Internet",
                table: "Giderler",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Maaslar",
                table: "Giderler",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Su",
                table: "Giderler",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
