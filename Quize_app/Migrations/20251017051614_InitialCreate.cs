using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quize_app.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    questionTest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    optionA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    optionB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    optionC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    optionD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correctAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
