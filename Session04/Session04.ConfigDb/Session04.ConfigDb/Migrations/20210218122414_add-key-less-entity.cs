using Microsoft.EntityFrameworkCore.Migrations;

namespace Session04.ConfigDb.Migrations
{
    public partial class addkeylessentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KeylessEntities",
                columns: table => new
                {
                    FristName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KeylessEntities");
        }
    }
}
