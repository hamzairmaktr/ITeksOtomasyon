using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeslimVeren",
                table: "FaturaBilgiler");

            migrationBuilder.AddColumn<decimal>(
                name: "Tutar",
                table: "FaturaBilgiler",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tutar",
                table: "FaturaBilgiler");

            migrationBuilder.AddColumn<string>(
                name: "TeslimVeren",
                table: "FaturaBilgiler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
