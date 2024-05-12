using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace educa_tube_code.Migrations
{
    /// <inheritdoc />
    public partial class M03UpdateRegisterUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "KeepLoggedIn",
                table: "Usuario",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeepLoggedIn",
                table: "Usuario");
        }
    }
}
