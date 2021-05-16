using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class alteracao_anuncio3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantidadeMaximaCompartilhamento",
                table: "Anuncio");

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 15, 13, 45, 36, 339, DateTimeKind.Local).AddTicks(5169), new DateTime(2021, 6, 14, 13, 45, 36, 340, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 16, 13, 45, 36, 340, DateTimeKind.Local).AddTicks(7925), new DateTime(2021, 6, 14, 13, 45, 36, 340, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 17, 13, 45, 36, 340, DateTimeKind.Local).AddTicks(7947), new DateTime(2021, 6, 14, 13, 45, 36, 340, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataInicio", "DataTermino" },
                values: new object[] { new DateTime(2021, 5, 18, 13, 45, 36, 340, DateTimeKind.Local).AddTicks(7950), new DateTime(2021, 6, 14, 13, 45, 36, 340, DateTimeKind.Local).AddTicks(7951) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
