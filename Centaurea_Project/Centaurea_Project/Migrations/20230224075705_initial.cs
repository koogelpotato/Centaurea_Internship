using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Centaurea_Project.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concert",
                columns: table => new
                {
                    ConcertId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerformerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketsCount = table.Column<int>(type: "int", nullable: false),
                    PerformanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concert", x => x.ConcertId);
                });

            migrationBuilder.CreateTable(
                name: "ClassicalConcerts",
                columns: table => new
                {
                    ConcertId = table.Column<int>(type: "int", nullable: false),
                    VoiceType = table.Column<int>(type: "int", nullable: false),
                    ConcertName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComposersName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassicalConcerts", x => x.ConcertId);
                    table.ForeignKey(
                        name: "FK_ClassicalConcerts_Concert_ConcertId",
                        column: x => x.ConcertId,
                        principalTable: "Concert",
                        principalColumn: "ConcertId");
                });

            migrationBuilder.CreateTable(
                name: "Parties",
                columns: table => new
                {
                    ConcertId = table.Column<int>(type: "int", nullable: false),
                    AgeLimit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parties", x => x.ConcertId);
                    table.ForeignKey(
                        name: "FK_Parties_Concert_ConcertId",
                        column: x => x.ConcertId,
                        principalTable: "Concert",
                        principalColumn: "ConcertId");
                });

            migrationBuilder.CreateTable(
                name: "RegularConcerts",
                columns: table => new
                {
                    ConcertId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegularConcerts", x => x.ConcertId);
                    table.ForeignKey(
                        name: "FK_RegularConcerts_Concert_ConcertId",
                        column: x => x.ConcertId,
                        principalTable: "Concert",
                        principalColumn: "ConcertId");
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ConcertId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Concert_ConcertId",
                        column: x => x.ConcertId,
                        principalTable: "Concert",
                        principalColumn: "ConcertId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ConcertId",
                table: "Tickets",
                column: "ConcertId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassicalConcerts");

            migrationBuilder.DropTable(
                name: "Parties");

            migrationBuilder.DropTable(
                name: "RegularConcerts");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Concert");
        }
    }
}
