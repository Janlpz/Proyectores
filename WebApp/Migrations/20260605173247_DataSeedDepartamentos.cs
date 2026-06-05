using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedDepartamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos");

            migrationBuilder.RenameTable(
                name: "Departamentos",
                newName: "Departamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Departamento",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { 1, "DEPARTAMENTO DE SISTEMAS Y COMPUTACION" },
                    { 2, "DEPARTAMENTO DE INGENIERIA INDUSTRIAL" },
                    { 3, "DEPARTAMENTO DE CIENCIAS DE LA TIERRA" },
                    { 4, "DEPARTAMENTO DE CIENCIAS ECONOMICO-ADMINISTRATIVAS" },
                    { 5, "DEPARTAMENTO DE INGENIERIA METAL-MECANICA" },
                    { 6, "DEPARTAMENTO DE INGENIERIA QUIMICA Y BIOQUIMICA" },
                    { 7, "DEPARTAMENTO DE CIENCIAS BASICAS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento");

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.RenameTable(
                name: "Departamento",
                newName: "Departamentos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos",
                column: "Id");
        }
    }
}
