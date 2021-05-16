using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class alteracao_anuncio7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "QuantidadeDias",
                table: "Anuncio",
                type: "int",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time(6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "QuantidadeDias",
                table: "Anuncio",
                type: "time(6)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Anuncio",
                columns: new[] { "Id", "ClienteId", "DataInicio", "DataTermino", "InvestimentoDiario", "Nome", "QuantidadeDias" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 5, 15, 14, 45, 24, 971, DateTimeKind.Local).AddTicks(1897), new DateTime(2021, 6, 14, 14, 45, 24, 972, DateTimeKind.Local).AddTicks(774), 1.0, "", new TimeSpan(0, 12, 0, 0, 0) },
                    { 2, 2, new DateTime(2021, 5, 16, 14, 45, 24, 972, DateTimeKind.Local).AddTicks(4064), new DateTime(2021, 6, 14, 14, 45, 24, 972, DateTimeKind.Local).AddTicks(4079), 2.0, "", new TimeSpan(0, 12, 0, 0, 0) },
                    { 3, 3, new DateTime(2021, 5, 17, 14, 45, 24, 972, DateTimeKind.Local).AddTicks(4083), new DateTime(2021, 6, 14, 14, 45, 24, 972, DateTimeKind.Local).AddTicks(4085), 3.0, "", new TimeSpan(0, 12, 0, 0, 0) },
                    { 4, 1, new DateTime(2021, 5, 18, 14, 45, 24, 972, DateTimeKind.Local).AddTicks(4087), new DateTime(2021, 6, 14, 14, 45, 24, 972, DateTimeKind.Local).AddTicks(4088), 4.0, "", new TimeSpan(0, 12, 0, 0, 0) }
                });
        }
    }
}
