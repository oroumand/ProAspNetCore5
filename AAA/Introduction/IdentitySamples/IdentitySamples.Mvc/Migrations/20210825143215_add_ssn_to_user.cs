using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentitySamples.Mvc.Migrations
{
    public partial class add_ssn_to_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ssn",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ssn",
                table: "AspNetUsers");
        }
    }
}
