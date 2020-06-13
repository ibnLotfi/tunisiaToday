using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tunisiaToday.DataAccess.Migrations
{
    public partial class ajoutBool_Ala_Une_DatePubliEtMaj_article : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatePublication",
                table: "Articles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Maj",
                table: "Articles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "estUne",
                table: "Articles",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatePublication",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Maj",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "estUne",
                table: "Articles");
        }
    }
}
