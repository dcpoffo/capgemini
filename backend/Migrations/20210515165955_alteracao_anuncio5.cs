using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class alteracao_anuncio5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantidadeDias",
                table: "Anuncio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 15, 13, 59, 55, 393, DateTimeKind.Local).AddTicks(5090), new DateTime(2021, 6, 14, 13, 59, 55, 394, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 16, 13, 59, 55, 394, DateTimeKind.Local).AddTicks(7362), new DateTime(2021, 6, 14, 13, 59, 55, 394, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 17, 13, 59, 55, 394, DateTimeKind.Local).AddTicks(7382), new DateTime(2021, 6, 14, 13, 59, 55, 394, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 18, 13, 59, 55, 394, DateTimeKind.Local).AddTicks(7385), new DateTime(2021, 6, 14, 13, 59, 55, 394, DateTimeKind.Local).AddTicks(7386) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantidadeDias",
                table: "Anuncio");

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 15, 13, 47, 17, 919, DateTimeKind.Local).AddTicks(9617), new DateTime(2021, 6, 14, 13, 47, 17, 920, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 16, 13, 47, 17, 921, DateTimeKind.Local).AddTicks(2998), new DateTime(2021, 6, 14, 13, 47, 17, 921, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 17, 13, 47, 17, 921, DateTimeKind.Local).AddTicks(3018), new DateTime(2021, 6, 14, 13, 47, 17, 921, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 18, 13, 47, 17, 921, DateTimeKind.Local).AddTicks(3022), new DateTime(2021, 6, 14, 13, 47, 17, 921, DateTimeKind.Local).AddTicks(3023) });
        }
    }
}
