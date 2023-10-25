using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carcollection.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "varchar(200)", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    Engine = table.Column<string>(type: "varchar(200)", nullable: false),
                    RegNo = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    TotalRunning = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
