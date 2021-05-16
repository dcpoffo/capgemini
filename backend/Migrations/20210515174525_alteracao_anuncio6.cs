using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class alteracao_anuncio6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "QuantidadeDias",
                table: "Anuncio",
                type: "time(6)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataInicio", "DataTermino", "QuantidadeDias" },
                values: new object[] { new DateTime(2021, 5, 15, 14, 45, 24, 971, DateTimeKind.Local).AddTicks(1897), new DateTime(2021, 6, 14, 14, 45, 24, 972, DateTimeKind.Local).AddTicks(774), new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataInicio", "DataTermino", "QuantidadeDias" },
                values: new object[] { new DateTime(2021, 5, 16, 14, 45, 24, 972, DateTimeKind.Local).AddTicks(4064), new DateTime(2021, 6, 14, 14, 45, 24, 972, DateTimeKind.Local).AddTicks(4079), new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataInicio", "DataTermino", "QuantidadeDias" },
                values: new object[] { new DateTime(2021, 5, 17, 14, 45, 24, 972, DateTimeKind.Local).AddTicks(4083), new DateTime(2021, 6, 14, 14, 45, 24, 972, DateTimeKind.Local).AddTicks(4085), new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataInicio", "DataTermino", "QuantidadeDias" },
                values: new object[] { new DateTime(2021, 5, 18, 14, 45, 24, 972, DateTimeKind.Local).AddTicks(4087), new DateTime(2021, 6, 14, 14, 45, 24, 972, DateTimeKind.Local).AddTicks(4088), new TimeSpan(0, 12, 0, 0, 0) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "QuantidadeDias",
                table: "Anuncio",
                type: "int",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time(6)");

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataInicio", "DataTermino", "QuantidadeDias" },
                values: new object[] { new DateTime(2021, 5, 15, 13, 59, 55, 393, DateTimeKind.Local).AddTicks(5090), new DateTime(2021, 6, 14, 13, 59, 55, 394, DateTimeKind.Local).AddTicks(4091), 0 });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataInicio", "DataTermino", "QuantidadeDias" },
                values: new object[] { new DateTime(2021, 5, 16, 13, 59, 55, 394, DateTimeKind.Local).AddTicks(7362), new DateTime(2021, 6, 14, 13, 59, 55, 394, DateTimeKind.Local).AddTicks(7378), 0 });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataInicio", "DataTermino", "QuantidadeDias" },
                values: new object[] { new DateTime(2021, 5, 17, 13, 59, 55, 394, DateTimeKind.Local).AddTicks(7382), new DateTime(2021, 6, 14, 13, 59, 55, 394, DateTimeKind.Local).AddTicks(7383), 0 });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataInicio", "DataTermino", "QuantidadeDias" },
                values: new object[] { new DateTime(2021, 5, 18, 13, 59, 55, 394, DateTimeKind.Local).AddTicks(7385), new DateTime(2021, 6, 14, 13, 59, 55, 394, DateTimeKind.Local).AddTicks(7386), 0 });
        }
    }
}
