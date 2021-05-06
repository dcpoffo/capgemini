using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class _4_migracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Anuncio",
                columns: new[] { "Id", "ClienteId", "DataInicio", "DataTermino", "InvestimentoDiario", "Nome" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 5, 5, 20, 34, 45, 453, DateTimeKind.Local).AddTicks(4342), new DateTime(2021, 6, 4, 20, 34, 45, 455, DateTimeKind.Local).AddTicks(2365), 1.0, "Anuncio1" },
                    { 2, 1, new DateTime(2021, 5, 6, 20, 34, 45, 455, DateTimeKind.Local).AddTicks(8264), new DateTime(2021, 6, 4, 20, 34, 45, 455, DateTimeKind.Local).AddTicks(8291), 2.0, "Anuncio 2" },
                    { 3, 1, new DateTime(2021, 5, 7, 20, 34, 45, 455, DateTimeKind.Local).AddTicks(8301), new DateTime(2021, 6, 4, 20, 34, 45, 455, DateTimeKind.Local).AddTicks(8304), 3.0, "Anuncio 3" },
                    { 4, 1, new DateTime(2021, 5, 8, 20, 34, 45, 455, DateTimeKind.Local).AddTicks(8308), new DateTime(2021, 6, 4, 20, 34, 45, 455, DateTimeKind.Local).AddTicks(8310), 1.0, "Anuncio 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
