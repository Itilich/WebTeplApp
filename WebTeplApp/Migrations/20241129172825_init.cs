using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebTeplApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Variants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Num1 = table.Column<double>(type: "REAL", nullable: false),
                    Num2 = table.Column<double>(type: "REAL", nullable: false),
                    Num3 = table.Column<double>(type: "REAL", nullable: false),
                    Num4 = table.Column<double>(type: "REAL", nullable: false),
                    Num5 = table.Column<double>(type: "REAL", nullable: false),
                    Num6 = table.Column<double>(type: "REAL", nullable: false),
                    Num7 = table.Column<double>(type: "REAL", nullable: false),
                    Num8 = table.Column<double>(type: "REAL", nullable: false),
                    Num9 = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variants", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Variants");
        }
    }
}
