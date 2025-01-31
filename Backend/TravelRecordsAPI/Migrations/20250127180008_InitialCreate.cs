using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelRecordsAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attraction",
                columns: table => new
                {
                    AttractionID = table.Column<int>(type: "int", nullable: false),
                    AttractionName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AttractionDesc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Score = table.Column<int>(type: "int", nullable: true),
                    Popularity = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attraction", x => x.AttractionID);
                });

            migrationBuilder.CreateTable(
                name: "HasAttraction",
                columns: table => new
                {
                    AttractionID = table.Column<int>(type: "int", nullable: false),
                    StageID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_has_attraction", x => new { x.AttractionID, x.StageID });
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    StageId = table.Column<int>(type: "int", nullable: false),
                    ImageId = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Story = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostId);
                });

            migrationBuilder.CreateTable(
                name: "Stage",
                columns: table => new
                {
                    StageId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    TripId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    StageDesc = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "date", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage", x => x.StageId);
                });

            migrationBuilder.CreateTable(
                name: "Trip",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false),
                    ImageId = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TripDesc = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trip", x => x.TripId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ImageId = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Username = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Bio = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attraction");

            migrationBuilder.DropTable(
                name: "HasAttraction");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Stage");

            migrationBuilder.DropTable(
                name: "Trip");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
