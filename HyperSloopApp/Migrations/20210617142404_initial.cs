using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyperSloopApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    SlideId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    HexColor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LengthInFeet = table.Column<double>(type: "double", nullable: false),
                    HeightInFeet = table.Column<double>(type: "double", nullable: false),
                    StartingFloor = table.Column<int>(type: "int", nullable: false),
                    EndingFloor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.SlideId);
                    table.ForeignKey(
                        name: "FK_Slides_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EventType = table.Column<int>(type: "int", nullable: false),
                    SlideId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Slides_SlideId",
                        column: x => x.SlideId,
                        principalTable: "Slides",
                        principalColumn: "SlideId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SlideId",
                table: "Events",
                column: "SlideId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Slides_LocationId",
                table: "Slides",
                column: "LocationId");

            migrationBuilder.Sql(@"CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `hypersloop`.`slideevents` AS
    SELECT 
        CONCAT(`userstart`.`EventId`,
                '_',
                `slidestart`.`EventId`,
                '_',
                `slideend`.`EventId`) AS `SlideEventid`,
        `userstart`.`UserId` AS `UserId`,
        `userstart`.`SlideId` AS `SlideId`,
        `userstart`.`DateTime` AS `ScanTime`,
        `slidestart`.`DateTime` AS `StartTime`,
        `slideend`.`DateTime` AS `EndTime`,
        (TIMESTAMPDIFF(MICROSECOND,
            `userstart`.`DateTime`,
            `slidestart`.`DateTime`) / 1000000) AS `Scan Duration`,
        (TIMESTAMPDIFF(MICROSECOND,
            `slidestart`.`DateTime`,
            `slideend`.`DateTime`) / 1000000) AS `Slide Duration`
    FROM
        ((`hypersloop`.`events` `userstart`
        JOIN `hypersloop`.`events` `slidestart` ON (((`userstart`.`SlideId` = `slidestart`.`SlideId`)
            AND (`slidestart`.`DateTime` > `userstart`.`DateTime`)
            AND (TIMESTAMPDIFF(SECOND, `userstart`.`DateTime`, `slidestart`.`DateTime`) < 10)
            AND (`slidestart`.`EventType` = 2)
            AND (`userstart`.`EventType` = 1))))
        JOIN `hypersloop`.`events` `slideend` ON (((`slidestart`.`SlideId` = `slideend`.`SlideId`)
            AND (`slideend`.`DateTime` > `slidestart`.`DateTime`)
            AND (TIMESTAMPDIFF(SECOND, `slidestart`.`DateTime`, `slideend`.`DateTime`) < 10)
            AND (`slideend`.`EventType` = 3))))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(@"DROP VIEW IF EXISTS hypersloop.slideevent;");
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
