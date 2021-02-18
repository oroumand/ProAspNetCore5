using Microsoft.EntityFrameworkCore.Migrations;

namespace Session04.ConfigDb.Migrations
{
    public partial class columnname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDate",
                schema: "config",
                table: "FluentPerson",
                newName: "DateOfBirth");

            migrationBuilder.RenameIndex(
                name: "IX_FluentPerson_Age_BirthDate",
                schema: "config",
                table: "FluentPerson",
                newName: "IX_FluentPerson_Age_DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                schema: "config",
                table: "AttributePerson",
                newName: "MyBirthDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                schema: "config",
                table: "FluentPerson",
                newName: "BirthDate");

            migrationBuilder.RenameIndex(
                name: "IX_FluentPerson_Age_DateOfBirth",
                schema: "config",
                table: "FluentPerson",
                newName: "IX_FluentPerson_Age_BirthDate");

            migrationBuilder.RenameColumn(
                name: "MyBirthDate",
                schema: "config",
                table: "AttributePerson",
                newName: "BirthDate");
        }
    }
}
