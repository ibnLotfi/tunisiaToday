using Microsoft.EntityFrameworkCore.Migrations;

namespace tunisiaToday.DataAccess.Migrations
{
    public partial class ajout_ImageUrl_et_Previsualition_dansArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Articles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Previsualisation",
                table: "Articles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Previsualisation",
                table: "Articles");
        }
    }
}
