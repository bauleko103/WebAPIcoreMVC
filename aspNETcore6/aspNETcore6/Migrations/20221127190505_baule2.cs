using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspNETcore6.Migrations
{
    /// <inheritdoc />
    public partial class baule2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Standard_StandardId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Standard");

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Standards",
                columns: table => new
                {
                    StandardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standards", x => x.StandardId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Standards_StandardId",
                table: "Student",
                column: "StandardId",
                principalTable: "Standards",
                principalColumn: "StandardId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Standards_StandardId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Standards");

            migrationBuilder.CreateTable(
                name: "Standard",
                columns: table => new
                {
                    StandardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standard", x => x.StandardId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Standard_StandardId",
                table: "Student",
                column: "StandardId",
                principalTable: "Standard",
                principalColumn: "StandardId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
