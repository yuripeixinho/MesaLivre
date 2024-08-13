using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MesaLivre.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelUmParaUmResturante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Restaurantes_EnderecoID",
                table: "Restaurantes");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurantes_EnderecoID",
                table: "Restaurantes",
                column: "EnderecoID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Restaurantes_EnderecoID",
                table: "Restaurantes");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurantes_EnderecoID",
                table: "Restaurantes",
                column: "EnderecoID");
        }
    }
}
