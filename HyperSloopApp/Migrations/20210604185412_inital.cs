using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyperSloopApp.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Email = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Email);
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
                        name: "FK_Slides_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SlideEvents",
                columns: table => new
                {
                    SlideEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserEmail = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SlideId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Duration = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlideEvents", x => x.SlideEventId);
                    table.ForeignKey(
                        name: "FK_SlideEvents_Users_UserEmail",
                        column: x => x.UserEmail,
                        principalTable: "Users",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "Name" },
                values: new object[,]
                {
                    { 1, "BNG" },
                    { 2, "BNG South" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Email", "Name" },
                values: new object[,]
                {
                    { "matthew.leiman@bngholdingsinc.com", "Matthew Leiman" },
                    { "JasonBourne@jb.com", "Jason Bourne" }
                });

            migrationBuilder.InsertData(
                table: "SlideEvents",
                columns: new[] { "SlideEventId", "Duration", "SlideId", "StartTime", "UserEmail" },
                values: new object[] { 1, 10.0, 1, new DateTime(2021, 6, 4, 13, 54, 12, 131, DateTimeKind.Local).AddTicks(1934), "matthew.leiman@bngholdingsinc.com" });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "SlideId", "EndingFloor", "HeightInFeet", "HexColor", "LengthInFeet", "LocationId", "StartingFloor" },
                values: new object[,]
                {
                    { 1, 1, 50.0, "#0000FF", 50.0, 1, 3 },
                    { 2, 1, 25.0, "#FF0000", 25.0, 1, 2 },
                    { 3, 2, 20.0, "#FFFF00", 20.0, 1, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SlideEvents_UserEmail",
                table: "SlideEvents",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Slides_LocationId",
                table: "Slides",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SlideEvents");

            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
