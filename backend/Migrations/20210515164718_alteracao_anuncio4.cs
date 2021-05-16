using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class alteracao_anuncio4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorTotalInvestido",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
