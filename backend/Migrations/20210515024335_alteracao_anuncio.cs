using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class alteracao_anuncio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantidadeMaximaCompartilhamento",
                table: "Anuncio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataInicio", "DataTermino", "Nome" },
                values: new object[] { new DateTime(2021, 5, 14, 23, 43, 35, 359, DateTimeKind.Local).AddTicks(1151), new DateTime(2021, 6, 13, 23, 43, 35, 359, DateTimeKind.Local).AddTicks(9670), "" });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClienteId", "DataInicio", "DataTermino", "Nome" },
                values: new object[] { 2, new DateTime(2021, 5, 15, 23, 43, 35, 360, DateTimeKind.Local).AddTicks(2910), new DateTime(2021, 6, 13, 23, 43, 35, 360, DateTimeKind.Local).AddTicks(2923), "" });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClienteId", "DataInicio", "DataTermino", "Nome" },
                values: new object[] { 3, new DateTime(2021, 5, 16, 23, 43, 35, 360, DateTimeKind.Local).AddTicks(2927), new DateTime(2021, 6, 13, 23, 43, 35, 360, DateTimeKind.Local).AddTicks(2928), "" });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataInicio", "DataTermino", "InvestimentoDiario", "Nome" },
                values: new object[] { new DateTime(2021, 5, 17, 23, 43, 35, 360, DateTimeKind.Local).AddTicks(2930), new DateTime(2021, 6, 13, 23, 43, 35, 360, DateTimeKind.Local).AddTicks(2931), 4.0, "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantidadeMaximaCompartilhamento",
                table: "Anuncio");

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataInicio", "DataTermino", "Nome" },
                values: new object[] { new DateTime(2021, 5, 5, 20, 34, 45, 453, DateTimeKind.Local).AddTicks(4342), new DateTime(2021, 6, 4, 20, 34, 45, 455, DateTimeKind.Local).AddTicks(2365), "Anuncio1" });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClienteId", "DataInicio", "DataTermino", "Nome" },
                values: new object[] { 1, new DateTime(2021, 5, 6, 20, 34, 45, 455, DateTimeKind.Local).AddTicks(8264), new DateTime(2021, 6, 4, 20, 34, 45, 455, DateTimeKind.Local).AddTicks(8291), "Anuncio 2" });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClienteId", "DataInicio", "DataTermino", "Nome" },
                values: new object[] { 1, new DateTime(2021, 5, 7, 20, 34, 45, 455, DateTimeKind.Local).AddTicks(8301), new DateTime(2021, 6, 4, 20, 34, 45, 455, DateTimeKind.Local).AddTicks(8304), "Anuncio 3" });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataInicio", "DataTermino", "InvestimentoDiario", "Nome" },
                values: new object[] { new DateTime(2021, 5, 8, 20, 34, 45, 455, DateTimeKind.Local).AddTicks(8308), new DateTime(2021, 6, 4, 20, 34, 45, 455, DateTimeKind.Local).AddTicks(8310), 1.0, "Anuncio 2" });
        }
    }
}
