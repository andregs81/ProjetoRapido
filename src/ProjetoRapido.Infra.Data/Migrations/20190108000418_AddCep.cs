using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoRapido.Infra.Data.Migrations
{
    public partial class AddCep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Endereco",
                maxLength: 8,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Endereco");
        }
    }
}
