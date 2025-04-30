using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectPractica.Migrations
{
    /// <inheritdoc />
    public partial class AddNumeCompletToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NumeComplet",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Proiecte",
                columns: table => new
                {
                    ProiectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeClient = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Domeniul = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ObiectulContractului = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DataSemnareContract = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataIncheiereContract = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    ExistaAmendamente = table.Column<bool>(type: "bit", nullable: false),
                    NumarAmendamente = table.Column<int>(type: "int", nullable: false),
                    EsteClientPublic = table.Column<bool>(type: "bit", nullable: false),
                    AreSubcontractor = table.Column<bool>(type: "bit", nullable: false),
                    Numarubcontaractori = table.Column<int>(type: "int", nullable: false),
                    ValoareContract = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proiecte", x => x.ProiectId);
                });

            migrationBuilder.CreateTable(
                name: "ActeAditionale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataAct = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProiectId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    DescriereSchimbare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EsteAdaugare = table.Column<bool>(type: "bit", nullable: true),
                    ValoareNoua = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Motiv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NouaDataIncheiere = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Observatii = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActeAditionale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActeAditionale_Proiecte_ProiectId",
                        column: x => x.ProiectId,
                        principalTable: "Proiecte",
                        principalColumn: "ProiectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Livrabil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descriere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEstimata = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstePredat = table.Column<bool>(type: "bit", nullable: false),
                    ProiectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livrabil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livrabil_Proiecte_ProiectId",
                        column: x => x.ProiectId,
                        principalTable: "Proiecte",
                        principalColumn: "ProiectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResponsabiliProiecte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProiectId = table.Column<int>(type: "int", nullable: false),
                    DataAtribuire = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsabiliProiecte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponsabiliProiecte_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResponsabiliProiecte_Proiecte_ProiectId",
                        column: x => x.ProiectId,
                        principalTable: "Proiecte",
                        principalColumn: "ProiectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subcontractori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Domeniu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProiectId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcontractori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subcontractori_Proiecte_ProiectId",
                        column: x => x.ProiectId,
                        principalTable: "Proiecte",
                        principalColumn: "ProiectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Taskuri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descriere = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Responsabil = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EsteNotificare = table.Column<bool>(type: "bit", nullable: false),
                    ProiectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taskuri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Taskuri_Proiecte_ProiectId",
                        column: x => x.ProiectId,
                        principalTable: "Proiecte",
                        principalColumn: "ProiectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActeAditionale_ProiectId",
                table: "ActeAditionale",
                column: "ProiectId");

            migrationBuilder.CreateIndex(
                name: "IX_Livrabil_ProiectId",
                table: "Livrabil",
                column: "ProiectId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsabiliProiecte_AppUserId",
                table: "ResponsabiliProiecte",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsabiliProiecte_ProiectId",
                table: "ResponsabiliProiecte",
                column: "ProiectId");

            migrationBuilder.CreateIndex(
                name: "IX_Subcontractori_ProiectId",
                table: "Subcontractori",
                column: "ProiectId");

            migrationBuilder.CreateIndex(
                name: "IX_Taskuri_ProiectId",
                table: "Taskuri",
                column: "ProiectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActeAditionale");

            migrationBuilder.DropTable(
                name: "Livrabil");

            migrationBuilder.DropTable(
                name: "ResponsabiliProiecte");

            migrationBuilder.DropTable(
                name: "Subcontractori");

            migrationBuilder.DropTable(
                name: "Taskuri");

            migrationBuilder.DropTable(
                name: "Proiecte");

            migrationBuilder.DropColumn(
                name: "NumeComplet",
                table: "AspNetUsers");
        }
    }
}
