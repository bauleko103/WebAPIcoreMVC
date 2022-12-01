using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspNETcore6.Migrations
{
    /// <inheritdoc />
    public partial class baulemoi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Standards_StandardId",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Standards",
                table: "Standards");

            migrationBuilder.AlterColumn<int>(
                name: "StandardId",
                table: "Standards",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Standards",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "StandardBId",
                table: "Standards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Standards",
                table: "Standards",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Boss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    DiemSo = table.Column<int>(type: "int", nullable: false),
                    StandardBId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boss_Standards_StandardBId",
                        column: x => x.StandardBId,
                        principalTable: "Standards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boss_StandardBId",
                table: "Boss",
                column: "StandardBId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Standards_StandardId",
                table: "Student",
                column: "StandardId",
                principalTable: "Standards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Standards_StandardId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Boss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Standards",
                table: "Standards");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Standards");

            migrationBuilder.DropColumn(
                name: "StandardBId",
                table: "Standards");

            migrationBuilder.AlterColumn<int>(
                name: "StandardId",
                table: "Standards",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Standards",
                table: "Standards",
                column: "StandardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Standards_StandardId",
                table: "Student",
                column: "StandardId",
                principalTable: "Standards",
                principalColumn: "StandardId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
