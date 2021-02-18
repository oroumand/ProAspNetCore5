using Microsoft.EntityFrameworkCore.Migrations;

namespace Session04.ConfigDb.Migrations
{
    public partial class addindex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PersonFluents_Age_BirthDate",
                table: "PersonFluents",
                columns: new[] { "Age", "BirthDate" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PersonFluents_Age_BirthDate",
                table: "PersonFluents");
        }
    }
}
