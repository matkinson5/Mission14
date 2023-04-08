using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission14.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Director = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Edited = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Title);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
