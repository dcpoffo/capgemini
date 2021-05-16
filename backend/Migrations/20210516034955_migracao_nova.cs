using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class migracao_nova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Anuncio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataTermino = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    InvestimentoDiario = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anuncio_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Darlan" },
                    { 2, "Vanessa" },
                    { 3, "Nicolas" },
                    { 4, "Gabriel" },
                    { 5, "Gengis" }
                });

            migrationBuilder.InsertData(
                table: "Anuncio",
                columns: new[] { "Id", "ClienteId", "DataInicio", "DataTermino", "InvestimentoDiario", "Nome" },
                values: new object[] { 1, 1, new DateTime(2021, 5, 16, 0, 49, 54, 730, DateTimeKind.Local).AddTicks(6816), new DateTime(2021, 5, 21, 0, 49, 54, 731, DateTimeKind.Local).AddTicks(9356), 5.0, "Anuncio 1" });

            migrationBuilder.CreateIndex(
                name: "IX_Anuncio_ClienteId",
                table: "Anuncio",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anuncio");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
