using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationExemplo1.Migrations
{
    /// <inheritdoc />
    public partial class v301 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_unidadeMedida_produto_produtoId",
                table: "unidadeMedida");

            migrationBuilder.DropIndex(
                name: "IX_unidadeMedida_produtoId",
                table: "unidadeMedida");

            migrationBuilder.DropColumn(
                name: "produtoId",
                table: "unidadeMedida");

            migrationBuilder.AddColumn<int>(
                name: "unidadeMedidaId",
                table: "produto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_produto_unidadeMedidaId",
                table: "produto",
                column: "unidadeMedidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_produto_unidadeMedida_unidadeMedidaId",
                table: "produto",
                column: "unidadeMedidaId",
                principalTable: "unidadeMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produto_unidadeMedida_unidadeMedidaId",
                table: "produto");

            migrationBuilder.DropIndex(
                name: "IX_produto_unidadeMedidaId",
                table: "produto");

            migrationBuilder.DropColumn(
                name: "unidadeMedidaId",
                table: "produto");

            migrationBuilder.AddColumn<int>(
                name: "produtoId",
                table: "unidadeMedida",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
