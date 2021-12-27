using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroeAcesso.WebAPI.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Cadastros",
                newName: "Number");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Cadastros",
                newName: "PhoneNumber");
        }
    }
}
