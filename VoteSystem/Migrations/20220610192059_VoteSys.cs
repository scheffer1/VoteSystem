using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoteSystem.Migrations
{
    /// <inheritdoc />
    public partial class VoteSys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Poll",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horafinal = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poll", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PollId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    voteCounter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.id);
                    table.ForeignKey(
                        name: "FK_Options_Poll_PollId",
                        column: x => x.PollId,
                        principalTable: "Poll",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Options_PollId",
                table: "Options",
                column: "PollId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Poll");
        }
    }
}
