using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationExemplo1.Migrations
{
    /// <inheritdoc />
    public partial class v300 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeExtenso",
                table: "unidadeMedida",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Sigla",
                table: "unidadeMedida",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "produtoId",
                table: "unidadeMedida",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Estoque",
                table: "produto",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "produto",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PrecoUnitario",
                table: "produto",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_unidadeMedida_produtoId",
                table: "unidadeMedida",
                column: "produtoId");

            migrationBuilder.AddForeignKey(
                name: "FK_unidadeMedida_produto_produtoId",
                table: "unidadeMedida",
                column: "produtoId",
                principalTable: "produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_unidadeMedida_produto_produtoId",
                table: "unidadeMedida");

            migrationBuilder.DropIndex(
                name: "IX_unidadeMedida_produtoId",
                table: "unidadeMedida");

            migrationBuilder.DropColumn(
                name: "NomeExtenso",
                table: "unidadeMedida");

            migrationBuilder.DropColumn(
                name: "Sigla",
                table: "unidadeMedida");

            migrationBuilder.DropColumn(
                name: "produtoId",
                table: "unidadeMedida");

            migrationBuilder.DropColumn(
                name: "Estoque",
                table: "produto");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "produto");

            migrationBuilder.DropColumn(
                name: "PrecoUnitario",
                table: "produto");
        }
    }
}
