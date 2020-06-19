using Microsoft.EntityFrameworkCore.Migrations;

namespace tunisiaToday.DataAccess.Migrations
{
    public partial class ajout_restriction_Pour_Prev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Previsualisation",
                table: "Articles",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Previsualisation",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 300);
        }
    }
}
