using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirmaId",
                table: "Haraketler",
                newName: "CariId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Haraketler",
                newName: "Detay");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Haraketler",
                newName: "Tarih");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "FaturaDetaylar",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VergiDaire",
                table: "FaturaBilgiler",
                newName: "TeslimVeren");

            migrationBuilder.RenameColumn(
                name: "FirmaId",
                table: "FaturaBilgiler",
                newName: "CariId");

            migrationBuilder.AddColumn<string>(
                name: "SiraNo",
                table: "FaturaBilgiler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiraNo",
                table: "FaturaBilgiler");

            migrationBuilder.RenameColumn(
                name: "Tarih",
                table: "Haraketler",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "Detay",
                table: "Haraketler",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CariId",
                table: "Haraketler",
                newName: "FirmaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "FaturaDetaylar",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "TeslimVeren",
                table: "FaturaBilgiler",
                newName: "VergiDaire");

            migrationBuilder.RenameColumn(
                name: "CariId",
                table: "FaturaBilgiler",
                newName: "FirmaId");
        }
    }
}
