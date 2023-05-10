using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class FaturaDetayDuzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiraNo",
                table: "FaturaBilgiler");

            migrationBuilder.AddColumn<decimal>(
                name: "Kdv",
                table: "FaturaDetaylar",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "KdvFiyat",
                table: "FaturaDetaylar",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<byte>(
                name: "KdvOran",
                table: "FaturaDetaylar",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<decimal>(
                name: "KdvTutar",
                table: "FaturaDetaylar",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "FaturaKesildimi",
                table: "FaturaBilgiler",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Odendimi",
                table: "FaturaBilgiler",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kdv",
                table: "FaturaDetaylar");

            migrationBuilder.DropColumn(
                name: "KdvFiyat",
                table: "FaturaDetaylar");

            migrationBuilder.DropColumn(
                name: "KdvOran",
                table: "FaturaDetaylar");

            migrationBuilder.DropColumn(
                name: "KdvTutar",
                table: "FaturaDetaylar");

            migrationBuilder.DropColumn(
                name: "FaturaKesildimi",
                table: "FaturaBilgiler");

            migrationBuilder.DropColumn(
                name: "Odendimi",
                table: "FaturaBilgiler");

            migrationBuilder.AddColumn<string>(
                name: "SiraNo",
                table: "FaturaBilgiler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
