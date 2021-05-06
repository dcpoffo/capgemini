using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class second_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anuncio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ValorInvestido = table.Column<double>(type: "double", nullable: false),
                    QuantidadeMaximaAvaliacoes = table.Column<int>(type: "int", nullable: false),
                    QuantidadeMaximaCliques = table.Column<int>(type: "int", nullable: false),
                    QuantidadeMaximaCompartilhamentos = table.Column<int>(type: "int", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anuncio_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anuncio");
        }
    }
}
