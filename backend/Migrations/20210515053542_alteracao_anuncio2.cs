using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class alteracao_anuncio2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ValorTotalInvestido",
                table: "Anuncio",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 15, 2, 35, 41, 833, DateTimeKind.Local).AddTicks(4879), new DateTime(2021, 6, 14, 2, 35, 41, 834, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 16, 2, 35, 41, 834, DateTimeKind.Local).AddTicks(6771), new DateTime(2021, 6, 14, 2, 35, 41, 834, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 17, 2, 35, 41, 834, DateTimeKind.Local).AddTicks(6787), new DateTime(2021, 6, 14, 2, 35, 41, 834, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 18, 2, 35, 41, 834, DateTimeKind.Local).AddTicks(6790), new DateTime(2021, 6, 14, 2, 35, 41, 834, DateTimeKind.Local).AddTicks(6791) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorTotalInvestido",
                table: "Anuncio");

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 14, 23, 43, 35, 359, DateTimeKind.Local).AddTicks(1151), new DateTime(2021, 6, 13, 23, 43, 35, 359, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 15, 23, 43, 35, 360, DateTimeKind.Local).AddTicks(2910), new DateTime(2021, 6, 13, 23, 43, 35, 360, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 16, 23, 43, 35, 360, DateTimeKind.Local).AddTicks(2927), new DateTime(2021, 6, 13, 23, 43, 35, 360, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 17, 23, 43, 35, 360, DateTimeKind.Local).AddTicks(2930), new DateTime(2021, 6, 13, 23, 43, 35, 360, DateTimeKind.Local).AddTicks(2931) });
        }
    }
}
