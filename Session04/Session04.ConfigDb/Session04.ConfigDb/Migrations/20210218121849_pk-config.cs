using Microsoft.EntityFrameworkCore.Migrations;

namespace Session04.ConfigDb.Migrations
{
    public partial class pkconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonFluentPk",
                columns: table => new
                {
                    MyPrimaryKey01 = table.Column<int>(type: "int", nullable: false),
                    MyPrimaryKey02 = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonFluentPk", x => new { x.MyPrimaryKey01, x.MyPrimaryKey02 });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonFluentPk");
        }
    }
}
