using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Location.Migrations
{
    public partial class LocationFilms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblFilm",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFilm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblLocations",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IdUsers = table.Column<string>(nullable: true),
                    IdFilm = table.Column<string>(nullable: true),
                    DataLocations = table.Column<DateTime>(nullable: false),
                    DataDevolution = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblFilm");

            migrationBuilder.DropTable(
                name: "tblLocations");

            migrationBuilder.DropTable(
                name: "tblUsers");
        }
    }
}
