using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class RelacionDepartamentoProyectoresFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaDeAlta",
                table: "Proyectores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartamentoId",
                table: "Proyectores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Proyectores_DepartamentoId",
                table: "Proyectores",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectores_Departamento_DepartamentoId",
                table: "Proyectores",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proyectores_Departamento_DepartamentoId",
                table: "Proyectores");

            migrationBuilder.DropIndex(
                name: "IX_Proyectores_DepartamentoId",
                table: "Proyectores");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Proyectores");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaDeAlta",
                table: "Proyectores",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
