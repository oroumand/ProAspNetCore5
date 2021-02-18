using Microsoft.EntityFrameworkCore.Migrations;

namespace Session04.ConfigDb.Migrations
{
    public partial class changetablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonFluents",
                table: "PersonFluents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonAttrs",
                table: "PersonAttrs");

            migrationBuilder.RenameTable(
                name: "PersonFluents",
                newName: "FluentPerson");

            migrationBuilder.RenameTable(
                name: "PersonAttrs",
                newName: "AttributePerson");

            migrationBuilder.RenameIndex(
                name: "IX_PersonFluents_Age_BirthDate",
                table: "FluentPerson",
                newName: "IX_FluentPerson_Age_BirthDate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FluentPerson",
                table: "FluentPerson",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttributePerson",
                table: "AttributePerson",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FluentPerson",
                table: "FluentPerson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttributePerson",
                table: "AttributePerson");

            migrationBuilder.RenameTable(
                name: "FluentPerson",
                newName: "PersonFluents");

            migrationBuilder.RenameTable(
                name: "AttributePerson",
                newName: "PersonAttrs");

            migrationBuilder.RenameIndex(
                name: "IX_FluentPerson_Age_BirthDate",
                table: "PersonFluents",
                newName: "IX_PersonFluents_Age_BirthDate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonFluents",
                table: "PersonFluents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonAttrs",
                table: "PersonAttrs",
                column: "Id");
        }
    }
}
