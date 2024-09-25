using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppVendas.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensDaVenda_Produtos_ProdutoId",
                table: "ItensDaVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensDaVenda_Vendas_VendaID",
                table: "ItensDaVenda");

            migrationBuilder.DropColumn(
                name: "PublicId",
                table: "ItensDaVenda");

            migrationBuilder.RenameColumn(
                name: "VendaID",
                table: "ItensDaVenda",
                newName: "VendaId");

            migrationBuilder.RenameIndex(
                name: "IX_ItensDaVenda_VendaID",
                table: "ItensDaVenda",
                newName: "IX_ItensDaVenda_VendaId");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProdutoId",
                table: "ItensDaVenda",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensDaVenda_Produtos_ProdutoId",
                table: "ItensDaVenda",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensDaVenda_Vendas_VendaId",
                table: "ItensDaVenda",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "VendaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensDaVenda_Produtos_ProdutoId",
                table: "ItensDaVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensDaVenda_Vendas_VendaId",
                table: "ItensDaVenda");

            migrationBuilder.RenameColumn(
                name: "VendaId",
                table: "ItensDaVenda",
                newName: "VendaID");

            migrationBuilder.RenameIndex(
                name: "IX_ItensDaVenda_VendaId",
                table: "ItensDaVenda",
                newName: "IX_ItensDaVenda_VendaID");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProdutoId",
                table: "ItensDaVenda",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "PublicId",
                table: "ItensDaVenda",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_ItensDaVenda_Produtos_ProdutoId",
                table: "ItensDaVenda",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensDaVenda_Vendas_VendaID",
                table: "ItensDaVenda",
                column: "VendaID",
                principalTable: "Vendas",
                principalColumn: "VendaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
