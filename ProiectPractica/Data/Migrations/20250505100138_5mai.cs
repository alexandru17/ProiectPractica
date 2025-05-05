using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectPractica.Migrations
{
    /// <inheritdoc />
    public partial class _5mai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Numarubcontaractori",
                table: "Proiecte",
                newName: "Numarubcontractori");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Numarubcontractori",
                table: "Proiecte",
                newName: "Numarubcontaractori");
        }
    }
}
