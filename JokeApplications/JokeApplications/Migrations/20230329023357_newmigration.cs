using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JokeApplications.Migrations
{
    /// <inheritdoc />
    public partial class newmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auther",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auther", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jokes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SetUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PunchLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutherId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShareableLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    NSFW = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jokes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jokes_Auther_AutherId",
                        column: x => x.AutherId,
                        principalTable: "Auther",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Auther",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 350, "Ruchikesh" },
                    { 351, "Suresh" },
                    { 352, "Ramesh" }
                });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "Id", "Approved", "AutherId", "Date", "NSFW", "PunchLine", "SetUp", "ShareableLink", "Type" },
                values: new object[,]
                {
                    { 1, true, 350, new DateTime(2023, 3, 29, 8, 3, 57, 128, DateTimeKind.Local).AddTicks(7023), false, "What is often characterized as a very conservative organization has taken a stance against racism. I'm not surprised at all though. To anyone who's been paying attention, from its very beginnings, NASCAR has always been veering to the left.", "A lot of people are shocked by the recent events in NASCAR.", "https://dotnetmasterruch.blob.core.windows.net/mango/13.jpg", "Normal" },
                    { 2, true, 351, new DateTime(2023, 3, 29, 8, 3, 57, 128, DateTimeKind.Local).AddTicks(7065), true, "I was talking to my physics teacher...", "I was talking to my physics teacher...", "https://dadjokes.io/joke/60dd36169d829533ec301e49", "Normal" },
                    { 3, true, 352, new DateTime(2023, 3, 29, 8, 3, 57, 128, DateTimeKind.Local).AddTicks(7077), false, "You put a little boogie on it.", "How do you make a tissue dance?", "https://dadjokes.io/joke2322/60dd36169d8dfdf29533ec301e49", "High" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jokes_AutherId",
                table: "Jokes",
                column: "AutherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jokes");

            migrationBuilder.DropTable(
                name: "Auther");
        }
    }
}
