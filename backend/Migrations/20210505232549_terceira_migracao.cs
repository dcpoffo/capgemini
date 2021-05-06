using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class terceira_migracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anuncio_Pessoa_PessoaId",
                table: "Anuncio");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Anuncio_PessoaId",
                table: "Anuncio");

            migrationBuilder.DeleteData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Anuncio",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Anuncio");

            migrationBuilder.DropColumn(
                name: "QuantidadeMaximaAvaliacoes",
                table: "Anuncio");

            migrationBuilder.DropColumn(
                name: "QuantidadeMaximaCliques",
                table: "Anuncio");

            migrationBuilder.RenameColumn(
                name: "ValorInvestido",
                table: "Anuncio",
                newName: "InvestimentoDiario");

            migrationBuilder.RenameColumn(
                name: "QuantidadeMaximaCompartilhamentos",
                table: "Anuncio",
                newName: "ClienteId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "Anuncio",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataTermino",
                table: "Anuncio",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Anuncio",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Anuncio_ClienteId",
                table: "Anuncio",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anuncio_Cliente_ClienteId",
                table: "Anuncio",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anuncio_Cliente_ClienteId",
                table: "Anuncio");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Anuncio_ClienteId",
                table: "Anuncio");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "Anuncio");

            migrationBuilder.DropColumn(
                name: "DataTermino",
                table: "Anuncio");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Anuncio");

            migrationBuilder.RenameColumn(
                name: "InvestimentoDiario",
                table: "Anuncio",
                newName: "ValorInvestido");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Anuncio",
                newName: "QuantidadeMaximaCompartilhamentos");

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Anuncio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeMaximaAvaliacoes",
                table: "Anuncio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeMaximaCliques",
                table: "Anuncio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Sobrenome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "Id", "Nome", "Sobrenome" },
                values: new object[,]
                {
                    { 1, "Darlan", "Poffo" },
                    { 2, "Vanessa", "Tanaka" },
                    { 3, "Nicolas", "Poffo" },
                    { 4, "Gabriel", "Poffo" },
                    { 5, "Gengis", "khan" }
                });

            migrationBuilder.InsertData(
                table: "Anuncio",
                columns: new[] { "Id", "PessoaId", "QuantidadeMaximaAvaliacoes", "QuantidadeMaximaCliques", "QuantidadeMaximaCompartilhamentos", "ValorInvestido" },
                values: new object[] { 1, 1, 1, 1, 1, 1.0 });

            migrationBuilder.InsertData(
                table: "Anuncio",
                columns: new[] { "Id", "PessoaId", "QuantidadeMaximaAvaliacoes", "QuantidadeMaximaCliques", "QuantidadeMaximaCompartilhamentos", "ValorInvestido" },
                values: new object[] { 2, 2, 2, 2, 2, 2.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Anuncio_PessoaId",
                table: "Anuncio",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anuncio_Pessoa_PessoaId",
                table: "Anuncio",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
