using Microsoft.EntityFrameworkCore.Migrations;

namespace Session04.ConfigDb.Migrations
{
    public partial class setdefaultschema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "config");

            migrationBuilder.RenameTable(
                name: "PersonFluentPk",
                newName: "PersonFluentPk",
                newSchema: "config");

            migrationBuilder.RenameTable(
                name: "PersonConvs",
                newName: "PersonConvs",
                newSchema: "config");

            migrationBuilder.RenameTable(
                name: "PersonAttrPks",
                newName: "PersonAttrPks",
                newSchema: "config");

            migrationBuilder.RenameTable(
                name: "NoDbSet",
                newName: "NoDbSet",
                newSchema: "config");

            migrationBuilder.RenameTable(
                name: "KeylessEntities",
                newName: "KeylessEntities",
                newSchema: "config");

            migrationBuilder.RenameTable(
                name: "FluentPerson",
                newName: "FluentPerson",
                newSchema: "config");

            migrationBuilder.RenameTable(
                name: "AttributePerson",
                newName: "AttributePerson",
                newSchema: "config");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "PersonFluentPk",
                schema: "config",
                newName: "PersonFluentPk");

            migrationBuilder.RenameTable(
                name: "PersonConvs",
                schema: "config",
                newName: "PersonConvs");

            migrationBuilder.RenameTable(
                name: "PersonAttrPks",
                schema: "config",
                newName: "PersonAttrPks");

            migrationBuilder.RenameTable(
                name: "NoDbSet",
                schema: "config",
                newName: "NoDbSet");

            migrationBuilder.RenameTable(
                name: "KeylessEntities",
                schema: "config",
                newName: "KeylessEntities");

            migrationBuilder.RenameTable(
                name: "FluentPerson",
                schema: "config",
                newName: "FluentPerson");

            migrationBuilder.RenameTable(
                name: "AttributePerson",
                schema: "config",
                newName: "AttributePerson");
        }
    }
}
