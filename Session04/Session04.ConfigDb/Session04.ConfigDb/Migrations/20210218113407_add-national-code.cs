using Microsoft.EntityFrameworkCore.Migrations;

namespace Session04.ConfigDb.Migrations
{
    public partial class addnationalcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NationalCode",
                table: "PersonFluents",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NationalCode",
                table: "PersonFluents");
        }
    }
}
