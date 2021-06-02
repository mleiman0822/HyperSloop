using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyperSloopApp.Migrations
{
    public partial class initalmigrate : Migration
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
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
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
                    HexColor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LengthInFeet = table.Column<double>(type: "double", nullable: false),
                    HeightInFeet = table.Column<double>(type: "double", nullable: false),
                    StartingFloor = table.Column<int>(type: "int", nullable: false),
                    EndingFloor = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
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
                name: "ScanEvents",
                columns: table => new
                {
                    ScanEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    SlideId = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScanEvents", x => x.ScanEventId);
                    table.ForeignKey(
                        name: "FK_ScanEvents_Slides_SlideId",
                        column: x => x.SlideId,
                        principalTable: "Slides",
                        principalColumn: "SlideId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScanEvents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Senors",
                columns: table => new
                {
                    SensorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SlideId = table.Column<int>(type: "int", nullable: false),
                    PercentageOfSlide = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Senors", x => x.SensorId);
                    table.ForeignKey(
                        name: "FK_Senors_Slides_SlideId",
                        column: x => x.SlideId,
                        principalTable: "Slides",
                        principalColumn: "SlideId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SensorEvents",
                columns: table => new
                {
                    SensorEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SensorId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorEvents", x => x.SensorEventId);
                    table.ForeignKey(
                        name: "FK_SensorEvents_Senors_SensorId",
                        column: x => x.SensorId,
                        principalTable: "Senors",
                        principalColumn: "SensorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SlideEvents",
                columns: table => new
                {
                    SlideEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SlideId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ScanEventId = table.Column<int>(type: "int", nullable: false),
                    StartingSensorEventId = table.Column<int>(type: "int", nullable: false),
                    EndingSensorEventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlideEvents", x => x.SlideEventId);
                    table.ForeignKey(
                        name: "FK_SlideEvents_ScanEvents_ScanEventId",
                        column: x => x.ScanEventId,
                        principalTable: "ScanEvents",
                        principalColumn: "ScanEventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlideEvents_SensorEvents_EndingSensorEventId",
                        column: x => x.EndingSensorEventId,
                        principalTable: "SensorEvents",
                        principalColumn: "SensorEventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlideEvents_SensorEvents_StartingSensorEventId",
                        column: x => x.StartingSensorEventId,
                        principalTable: "SensorEvents",
                        principalColumn: "SensorEventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlideEvents_Slides_SlideId",
                        column: x => x.SlideId,
                        principalTable: "Slides",
                        principalColumn: "SlideId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlideEvents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ScanEvents_SlideId",
                table: "ScanEvents",
                column: "SlideId");

            migrationBuilder.CreateIndex(
                name: "IX_ScanEvents_UserId",
                table: "ScanEvents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Senors_SlideId",
                table: "Senors",
                column: "SlideId");

            migrationBuilder.CreateIndex(
                name: "IX_SensorEvents_SensorId",
                table: "SensorEvents",
                column: "SensorId");

            migrationBuilder.CreateIndex(
                name: "IX_SlideEvents_EndingSensorEventId",
                table: "SlideEvents",
                column: "EndingSensorEventId");

            migrationBuilder.CreateIndex(
                name: "IX_SlideEvents_ScanEventId",
                table: "SlideEvents",
                column: "ScanEventId");

            migrationBuilder.CreateIndex(
                name: "IX_SlideEvents_SlideId",
                table: "SlideEvents",
                column: "SlideId");

            migrationBuilder.CreateIndex(
                name: "IX_SlideEvents_StartingSensorEventId",
                table: "SlideEvents",
                column: "StartingSensorEventId");

            migrationBuilder.CreateIndex(
                name: "IX_SlideEvents_UserId",
                table: "SlideEvents",
                column: "UserId");

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
                name: "ScanEvents");

            migrationBuilder.DropTable(
                name: "SensorEvents");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Senors");

            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
